Imports System.Text.RegularExpressions
Imports Renci.SshNet
Imports Renci.SshNet.Common
Imports System.Runtime.CompilerServices


Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client = New Ssh()
        Dim output = client.Execute("ls")
    End Sub
End Class

Public Class Log
    Public Shared Sub Verbose(message As String)
        Console.WriteLine(message)
    End Sub

    Public Shared Sub [Error](message As String)
        Console.WriteLine(message)
    End Sub
End Class

Module StringExt
    <Extension()>
    Function StringBeforeLastRegEx(str As String, regex As Regex) As String
        Dim matches = regex.Matches(str)
        Return If(matches.Count > 0, str.Substring(0, matches.Item(matches.Count - 1).Index), str)
    End Function

    <Extension()>
    Function EndsWithRegEx(str As String, regex As Regex) As Boolean
        Dim matches = regex.Matches(str)
        Return matches.Count > 0 AndAlso str.Length = (matches.Count - 1 + matches.Item(matches.Count - 1).Length)
    End Function

    <Extension()>
    Function StringAfter(str As String, substring As String) As String
        Dim index = str.IndexOf(substring, StringComparison.Ordinal)
        Return If(index >= 0, str.Substring(index + substring.Length), "")
    End Function

    <Extension()>
    Function GetLines(str As String) As String()
        Return Regex.Split(str, vbCrLf & "|" & vbCr & "|" & vbLf)
    End Function
End Module

Module UtilExt
    <Extension()>
    Sub ForEach(Of T)(sequence As IEnumerable(Of T), func As Action(Of T))
        For Each item In sequence
            func(item)
        Next
    End Sub
End Module

Public Class Ssh
    Private sshClient As SshClient
    Private shell As ShellStream
    Private pwd As String = "tapus123"
    Private lastCommand As String = ""
    Shared prompt As Regex = New Regex("[a-zA-Z0-9_.-]*\@[a-zA-Z0-9_.-]*\:\~[#$] ", RegexOptions.Compiled)
    Shared pwdPrompt As Regex = New Regex("password for .*\:", RegexOptions.Compiled)
    Shared promptOrPwd As Regex = New Regex(Ssh.prompt.ToString + "|" + Ssh.pwdPrompt.ToString)

    Public Sub Connect()
        Dim host = "3.16.198.57"
        Dim username = "ec2-user"
        Dim password = "tapus123"

        sshClient = New SshClient(host, username, password)
        sshClient.Connect()
        Dim terminalMode = New Dictionary(Of TerminalModes, UInteger)()
        terminalMode.Add(TerminalModes.ECHO, 53)
        shell = sshClient.CreateShellStream("", 0, 0, 0, 0, 4096, terminalMode)

        Try
            Expect(Ssh.prompt)
        Catch ex As Exception
            Log.[Error]("Exception - " & ex.Message)
            Throw
        End Try
    End Sub

    Public Sub Disconnect()
        Log.Verbose($"Ssh Disconnect")
        sshClient?.Disconnect()
        sshClient = Nothing
    End Sub

    Private Sub Write(commandLine As String)
        Console.ForegroundColor = ConsoleColor.Green
        Log.Verbose("> " & commandLine)
        Console.ResetColor()
        lastCommand = commandLine
        shell.WriteLine(commandLine)
    End Sub

    Private Function Expect(_expect As Regex, Optional timeoutSeconds As Double = 60.0) As String
        Dim result = shell.Expect(_expect, TimeSpan.FromSeconds(timeoutSeconds))

        If result Is Nothing Then
            Throw New Exception($"Timeout {timeoutSeconds}s executing {lastCommand}")
        End If

        result = If(result.Contains(lastCommand), result.StringAfter(lastCommand), result)
        result = result.StringBeforeLastRegEx(Ssh.prompt)
        result = result.Trim()
        result.GetLines().ForEach(Sub(x) Log.Verbose(x))
        Return result
    End Function

    Public Function Execute(commandLine As String, Optional timeoutSeconds As Double = 30.0) As String
        Dim exception As Exception = Nothing
        Dim result = ""
        Dim errorMessage = "failed"
        Dim errorCode = "exception"

        Try
            Write(commandLine)
            result = Expect(Ssh.promptOrPwd)

            If result.EndsWithRegEx(pwdPrompt) Then
                Write(pwd)
                Expect(Ssh.prompt)
            End If

            Write("echo $?")
            errorCode = Expect(Ssh.prompt)

            If errorCode = "0" Then
                Return result
            ElseIf result.Length > 0 Then
                errorMessage = result
            End If

        Catch ex As Exception
            exception = ex
            errorMessage = ex.Message
        End Try

        Throw New Exception($"Ssh error: {errorMessage}, code: {errorCode}, command: {commandLine}", exception)
    End Function
End Class
