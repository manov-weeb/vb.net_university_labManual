Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Validate If the input Is a number
        Dim fahrenheit As Double
        If Double.TryParse(fah.Text, fahrenheit) Then
            ' Convert Fahrenheit to Celsius
            Dim celsius As Double = (fahrenheit - 32) * 5 / 9

            ' Display the Celsius value in TextBox2
            cel.Text = celsius.ToString("F2") ' "F2" formats to 2 decimal places
        Else
            ' Show an error if the input is not a valid number
            MsgBox("Please enter a valid number for Fahrenheit.")
        End If
    End Sub

    Private Sub cel_TextChanged(sender As Object, e As EventArgs) Handles cel.TextChanged
        cel.ReadOnly = True

    End Sub
End Class
