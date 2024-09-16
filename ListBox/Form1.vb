Public Class Form1
    Dim cities() As String = {"New York", "Tokyo", "Berlin", "Kathmandu", "Chennai"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(cities)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles count.Click
        MsgBox("Total cities: " & ListBox1.Items.Count)
    End Sub

    Private Sub sort_Click(sender As Object, e As EventArgs) Handles sort.Click
        ' Clear ListBox2 before adding sorted items
        ListBox2.Items.Clear()
        Array.Sort(cities)
        ListBox2.Items.AddRange(cities)
        MsgBox("Cities sorted and added to ListBox2.")
    End Sub

    Private Sub remove_Click(sender As Object, e As EventArgs) Handles remove.Click
        If ListBox1.SelectedItem IsNot Nothing Then
            Dim selectedItem As String = ListBox1.SelectedItem.ToString()
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to remove " & selectedItem & "?", "Confirm Removal", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                ListBox1.Items.Remove(ListBox1.SelectedItem)
                MsgBox(selectedItem & " has been removed.")
            End If
        Else
            MsgBox("Please select an item to remove.")
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        sort.Enabled = ListBox1.SelectedItem IsNot Nothing
        remove.Enabled = ListBox1.SelectedItem IsNot Nothing
    End Sub
End Class
