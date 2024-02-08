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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.dollarcoin = New System.Windows.Forms.PictureBox()
        Me.quartercoin = New System.Windows.Forms.PictureBox()
        Me.dimecoin = New System.Windows.Forms.PictureBox()
        Me.nickelcoin = New System.Windows.Forms.PictureBox()
        CType(Me.dollarcoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quartercoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimecoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelcoin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(128, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 93)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(237, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 93)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(348, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 90)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(457, 5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(103, 92)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(275, 260)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(119, 94)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dollarcoin
        '
        Me.dollarcoin.Image = CType(resources.GetObject("dollarcoin.Image"), System.Drawing.Image)
        Me.dollarcoin.Location = New System.Drawing.Point(675, 33)
        Me.dollarcoin.Name = "dollarcoin"
        Me.dollarcoin.Size = New System.Drawing.Size(94, 91)
        Me.dollarcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarcoin.TabIndex = 6
        Me.dollarcoin.TabStop = False
        Me.dollarcoin.Visible = False
        '
        'quartercoin
        '
        Me.quartercoin.Image = CType(resources.GetObject("quartercoin.Image"), System.Drawing.Image)
        Me.quartercoin.Location = New System.Drawing.Point(675, 130)
        Me.quartercoin.Name = "quartercoin"
        Me.quartercoin.Size = New System.Drawing.Size(94, 91)
        Me.quartercoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quartercoin.TabIndex = 7
        Me.quartercoin.TabStop = False
        Me.quartercoin.Visible = False
        '
        'dimecoin
        '
        Me.dimecoin.Image = CType(resources.GetObject("dimecoin.Image"), System.Drawing.Image)
        Me.dimecoin.Location = New System.Drawing.Point(675, 227)
        Me.dimecoin.Name = "dimecoin"
        Me.dimecoin.Size = New System.Drawing.Size(94, 91)
        Me.dimecoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dimecoin.TabIndex = 8
        Me.dimecoin.TabStop = False
        Me.dimecoin.Visible = False
        '
        'nickelcoin
        '
        Me.nickelcoin.Image = CType(resources.GetObject("nickelcoin.Image"), System.Drawing.Image)
        Me.nickelcoin.Location = New System.Drawing.Point(675, 324)
        Me.nickelcoin.Name = "nickelcoin"
        Me.nickelcoin.Size = New System.Drawing.Size(94, 91)
        Me.nickelcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nickelcoin.TabIndex = 9
        Me.nickelcoin.TabStop = False
        Me.nickelcoin.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.nickelcoin)
        Me.Controls.Add(Me.dimecoin)
        Me.Controls.Add(Me.quartercoin)
        Me.Controls.Add(Me.dollarcoin)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dollarcoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quartercoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dimecoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nickelcoin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents dollarcoin As PictureBox
    Friend WithEvents quartercoin As PictureBox
    Friend WithEvents dimecoin As PictureBox
    Friend WithEvents nickelcoin As PictureBox
End Class
