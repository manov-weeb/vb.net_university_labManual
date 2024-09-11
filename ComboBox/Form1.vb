
Public Class Form1
    Dim DD, YYYY As Integer
    Dim MM As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DD = dd_box.Text
        MM = mm_box.Text
        YYYY = yyyy_box.Text

        MsgBox(DD & " " & MM & " " & YYYY)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 30
            dd_box.Items.Add(i)
        Next

        Dim months() As String = {"Janurary", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"}

        mm_box.Items.AddRange(months)


        For i As Integer = 1990 To 2025
            yyyy_box.Items.Add(i)
        Next
    End Sub
End Class
