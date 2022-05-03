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
        Me.Main = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.showButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.backgroundButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Main.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main
        '
        Me.Main.ColumnCount = 2
        Me.Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.Main.Controls.Add(Me.PictureBox1, 0, 0)
        Me.Main.Controls.Add(Me.CheckBox1, 0, 1)
        Me.Main.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Main.Location = New System.Drawing.Point(0, 0)
        Me.Main.Name = "Main"
        Me.Main.RowCount = 2
        Me.Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.Main.Size = New System.Drawing.Size(706, 402)
        Me.Main.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Main.SetColumnSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(700, 355)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 364)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Stretch"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.showButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.clearButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.backgroundButton)
        Me.FlowLayoutPanel1.Controls.Add(Me.closeButton)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(108, 364)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(595, 35)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'showButton
        '
        Me.showButton.AutoSize = True
        Me.showButton.Location = New System.Drawing.Point(503, 3)
        Me.showButton.Name = "showButton"
        Me.showButton.Size = New System.Drawing.Size(89, 23)
        Me.showButton.TabIndex = 0
        Me.showButton.Text = "Show a Picture"
        Me.showButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.AutoSize = True
        Me.clearButton.Location = New System.Drawing.Point(402, 3)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(95, 23)
        Me.clearButton.TabIndex = 1
        Me.clearButton.Text = "Clear the Picture"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'backgroundButton
        '
        Me.backgroundButton.AutoSize = True
        Me.backgroundButton.Location = New System.Drawing.Point(285, 3)
        Me.backgroundButton.Name = "backgroundButton"
        Me.backgroundButton.Size = New System.Drawing.Size(111, 23)
        Me.backgroundButton.TabIndex = 2
        Me.backgroundButton.Text = "Set the background"
        Me.backgroundButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.AutoSize = True
        Me.closeButton.Location = New System.Drawing.Point(204, 3)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(75, 23)
        Me.closeButton.TabIndex = 3
        Me.closeButton.Text = "Close"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" &
    "s (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Select a picture file"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 402)
        Me.Controls.Add(Me.Main)
        Me.Name = "Form1"
        Me.Text = "Picture Selector"
        Me.Main.ResumeLayout(False)
        Me.Main.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Main As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents showButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents backgroundButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
