Imports System.IO

Public Class Form1
    Dim SW As StreamWriter

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        SFDWriter.ShowDialog()
    End Sub

    Private Sub SFDWriter_FileOk(
            sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SFDWriter.FileOk
        If SFDWriter.FileName <> "" Then

        End If
        SW = New StreamWriter(SFDWriter.FileName, False)

        For Each line As String In Split(TextBox1.Text, Chr(13))
            SW.WriteLine(line)

        Next
        SW.Close()


    End Sub
End Class
