<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.dtPicker = New System.Windows.Forms.DateTimePicker()
        Me.julianDate = New System.Windows.Forms.Label()
        Me.lblEnterDate = New System.Windows.Forms.Label()
        Me.gDateEnter = New System.Windows.Forms.TextBox()
        Me.gDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtPicker
        '
        Me.dtPicker.Location = New System.Drawing.Point(193, 41)
        Me.dtPicker.Name = "dtPicker"
        Me.dtPicker.Size = New System.Drawing.Size(138, 20)
        Me.dtPicker.TabIndex = 0
        '
        'julianDate
        '
        Me.julianDate.AutoSize = True
        Me.julianDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.julianDate.Location = New System.Drawing.Point(358, 41)
        Me.julianDate.Name = "julianDate"
        Me.julianDate.Size = New System.Drawing.Size(32, 17)
        Me.julianDate.TabIndex = 1
        Me.julianDate.Text = "<?>"
        '
        'lblEnterDate
        '
        Me.lblEnterDate.AutoSize = True
        Me.lblEnterDate.Enabled = False
        Me.lblEnterDate.Location = New System.Drawing.Point(43, 45)
        Me.lblEnterDate.Name = "lblEnterDate"
        Me.lblEnterDate.Size = New System.Drawing.Size(144, 13)
        Me.lblEnterDate.TabIndex = 2
        Me.lblEnterDate.Text = "Enter date to find Julian Date"
        Me.lblEnterDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gDateEnter
        '
        Me.gDateEnter.Location = New System.Drawing.Point(193, 83)
        Me.gDateEnter.Name = "gDateEnter"
        Me.gDateEnter.Size = New System.Drawing.Size(100, 20)
        Me.gDateEnter.TabIndex = 3
        '
        'gDate
        '
        Me.gDate.AutoSize = True
        Me.gDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gDate.Location = New System.Drawing.Point(358, 83)
        Me.gDate.Name = "gDate"
        Me.gDate.Size = New System.Drawing.Size(32, 17)
        Me.gDate.TabIndex = 4
        Me.gDate.Text = "<?>"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(43, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Enter Julian date to find Date"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(183, 130)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 178)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gDate)
        Me.Controls.Add(Me.gDateEnter)
        Me.Controls.Add(Me.lblEnterDate)
        Me.Controls.Add(Me.julianDate)
        Me.Controls.Add(Me.dtPicker)
        Me.Name = "Main"
        Me.Text = "Date Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtPicker As DateTimePicker
    Friend WithEvents julianDate As Label
    Friend WithEvents lblEnterDate As Label
    Friend WithEvents gDateEnter As TextBox
    Friend WithEvents gDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClose As Button
End Class
