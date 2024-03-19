<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class productcontrol
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IDlabel = New System.Windows.Forms.Label()
        Me.Pricelabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'IDlabel
        '
        Me.IDlabel.AutoSize = True
        Me.IDlabel.Location = New System.Drawing.Point(17, 95)
        Me.IDlabel.Name = "IDlabel"
        Me.IDlabel.Size = New System.Drawing.Size(48, 16)
        Me.IDlabel.TabIndex = 1
        Me.IDlabel.Text = "Label1"
        '
        'Pricelabel
        '
        Me.Pricelabel.AutoSize = True
        Me.Pricelabel.Location = New System.Drawing.Point(84, 95)
        Me.Pricelabel.Name = "Pricelabel"
        Me.Pricelabel.Size = New System.Drawing.Size(48, 16)
        Me.Pricelabel.TabIndex = 2
        Me.Pricelabel.Text = "Label2"
        '
        'productcontrol
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Pricelabel)
        Me.Controls.Add(Me.IDlabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "productcontrol"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IDlabel As Label
    Friend WithEvents Pricelabel As Label
End Class
