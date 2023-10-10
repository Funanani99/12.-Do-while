Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        num = 1

        Do While num <= 5

            MsgBox(num)
            num += 1

        Loop

        MsgBox("Out of the loop")

    End Sub
End Class
