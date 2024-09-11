<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dd_box = New System.Windows.Forms.ComboBox()
        mm_box = New System.Windows.Forms.ComboBox()
        yyyy_box = New System.Windows.Forms.ComboBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' dd_box
        ' 
        dd_box.FormattingEnabled = True
        dd_box.Location = New Point(24, 22)
        dd_box.Name = "dd_box"
        dd_box.Size = New Size(77, 28)
        dd_box.TabIndex = 0
        ' 
        ' mm_box
        ' 
        mm_box.FormattingEnabled = True
        mm_box.Location = New Point(134, 22)
        mm_box.Name = "mm_box"
        mm_box.Size = New Size(100, 28)
        mm_box.TabIndex = 1
        ' 
        ' yyyy_box
        ' 
        yyyy_box.FormattingEnabled = True
        yyyy_box.Location = New Point(268, 22)
        yyyy_box.Name = "yyyy_box"
        yyyy_box.Size = New Size(112, 28)
        yyyy_box.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(134, 79)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "Show Date"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(392, 153)
        Controls.Add(Button1)
        Controls.Add(yyyy_box)
        Controls.Add(mm_box)
        Controls.Add(dd_box)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents dd_box As System.Windows.Forms.ComboBox
    Friend WithEvents mm_box As System.Windows.Forms.ComboBox
    Friend WithEvents yyyy_box As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As Button

End Class
