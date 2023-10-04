Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim YourMessage As String
        Dim BirthYear As Integer

        YourMessage = "Happy Birthday! How old are you now?"
        MsgBox(YourMessage)



        BirthYear = Val(InputBox("enter Year of Birth"))
        MsgBox("you are now" & 2023 - Birthyear & "years old")
    End Sub
End Class
