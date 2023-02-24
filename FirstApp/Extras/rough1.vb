Imports System.Data.OleDb
Imports System.IO

Public Class rough1
    Private Sub rough1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "UPDATE INTO SET files=? WHERE id=1"
        Dim attachmentValue As Byte() = File.ReadAllBytes("C:\Users\hp\Desktop\New folder\Rick\17084888_rick_and_morty_hugging_each_other.png")
        Using connection As New OleDbConnection(Variables.ConnectionString)
            connection.Open()
            Using command As New OleDbCommand(sql, connection)
                command.Parameters.AddWithValue("@files", attachmentValue)
                command.ExecuteNonQuery()
            End Using
        End Using


    End Sub
End Class