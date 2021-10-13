Imports System.Runtime.CompilerServices

Module CustomerExtensions

    <Extension()>
    Public Sub PrintAndPunctuate(aString As String, punc As String)
        Console.WriteLine(aString & punc)
    End Sub

    <Extension>
    Public Function Asd(Obj As String) As String
        Return Obj
    End Function

End Module
