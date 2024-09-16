Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim items() As String = {"C", "C++", "Java", "Python", "Rust", "Javascript",
           "Solidity", "MongoDB", "GoLang", "SQL"}

        ComboBox1.Items.AddRange(items)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Add(ComboBox1.SelectedItem)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim itemsArray(ListBox1.Items.Count - 1) As String
        ListBox1.Items.CopyTo(itemsArray, 0)
        ListBox1.Items.Clear()
        Array.Sort(itemsArray)
        ListBox1.Items.AddRange(itemsArray)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        ComboBox1.Items.Clear()
    End Sub
End Class
