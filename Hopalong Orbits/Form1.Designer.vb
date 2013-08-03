<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me._size_upDown = New System.Windows.Forms.NumericUpDown()
        Me._itrations_updown = New System.Windows.Forms.NumericUpDown()
        Me._pointsize_updown = New System.Windows.Forms.NumericUpDown()
        CType(Me._size_upDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._itrations_updown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._pointsize_updown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(17, 70)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Black
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(17, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Black
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(17, 41)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        '_size_upDown
        '
        Me._size_upDown.Location = New System.Drawing.Point(17, 99)
        Me._size_upDown.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me._size_upDown.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me._size_upDown.Name = "_size_upDown"
        Me._size_upDown.Size = New System.Drawing.Size(75, 20)
        Me._size_upDown.TabIndex = 3
        Me._size_upDown.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        '_itrations_updown
        '
        Me._itrations_updown.Location = New System.Drawing.Point(17, 125)
        Me._itrations_updown.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me._itrations_updown.Minimum = New Decimal(New Integer() {20000, 0, 0, 0})
        Me._itrations_updown.Name = "_itrations_updown"
        Me._itrations_updown.Size = New System.Drawing.Size(75, 20)
        Me._itrations_updown.TabIndex = 3
        Me._itrations_updown.Value = New Decimal(New Integer() {20000, 0, 0, 0})
        '
        '_pointsize_updown
        '
        Me._pointsize_updown.Location = New System.Drawing.Point(17, 151)
        Me._pointsize_updown.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me._pointsize_updown.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me._pointsize_updown.Name = "_pointsize_updown"
        Me._pointsize_updown.Size = New System.Drawing.Size(75, 20)
        Me._pointsize_updown.TabIndex = 3
        Me._pointsize_updown.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Form1
        '
        Me.AcceptButton = Me.Button2
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(605, 388)
        Me.Controls.Add(Me._pointsize_updown)
        Me.Controls.Add(Me._itrations_updown)
        Me.Controls.Add(Me._size_upDown)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "MileuMaker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._size_upDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._itrations_updown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._pointsize_updown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents _size_upDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents _itrations_updown As System.Windows.Forms.NumericUpDown
    Friend WithEvents _pointsize_updown As System.Windows.Forms.NumericUpDown

End Class
