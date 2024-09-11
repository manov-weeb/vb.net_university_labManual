Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim colorDialog As New ColorDialog


        If colorDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.ForeColor = colorDialog.Color
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fontDialog As New FontDialog

        If fontDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.Font = fontDialog.Font

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim colorDialog As New ColorDialog

        If colorDialog.ShowDialog() = DialogResult.OK Then
            TextBox1.BackColor = colorDialog.Color
        End If
    End Sub
End Class
