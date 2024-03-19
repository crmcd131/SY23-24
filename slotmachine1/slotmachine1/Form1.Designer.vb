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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelMoney = New System.Windows.Forms.Label()
        Me.ButtonAddMoney = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Reelcontrol3 = New slotmachine1.reelcontrol1()
        Me.Reelcontrol2 = New slotmachine1.reelcontrol1()
        Me.Reelcontrol1 = New slotmachine1.reelcontrol1()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Spin"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 287)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(430, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(584, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'LabelMoney
        '
        Me.LabelMoney.AutoSize = True
        Me.LabelMoney.Location = New System.Drawing.Point(90, 224)
        Me.LabelMoney.Name = "LabelMoney"
        Me.LabelMoney.Size = New System.Drawing.Size(48, 16)
        Me.LabelMoney.TabIndex = 7
        Me.LabelMoney.Text = "Money"
        '
        'ButtonAddMoney
        '
        Me.ButtonAddMoney.Location = New System.Drawing.Point(90, 70)
        Me.ButtonAddMoney.Name = "ButtonAddMoney"
        Me.ButtonAddMoney.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddMoney.TabIndex = 8
        Me.ButtonAddMoney.Text = "ADD MONEY"
        Me.ButtonAddMoney.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(87, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "COST = 50$"
        '
        'Reelcontrol3
        '
        Me.Reelcontrol3.ItemValue = 0
        Me.Reelcontrol3.Location = New System.Drawing.Point(534, 134)
        Me.Reelcontrol3.Name = "Reelcontrol3"
        Me.Reelcontrol3.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol3.SpinTime = 2000
        Me.Reelcontrol3.TabIndex = 4
        '
        'Reelcontrol2
        '
        Me.Reelcontrol2.ItemValue = 0
        Me.Reelcontrol2.Location = New System.Drawing.Point(378, 134)
        Me.Reelcontrol2.Name = "Reelcontrol2"
        Me.Reelcontrol2.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol2.SpinTime = 2000
        Me.Reelcontrol2.TabIndex = 3
        '
        'Reelcontrol1
        '
        Me.Reelcontrol1.ItemValue = 0
        Me.Reelcontrol1.Location = New System.Drawing.Point(222, 134)
        Me.Reelcontrol1.Name = "Reelcontrol1"
        Me.Reelcontrol1.Size = New System.Drawing.Size(150, 150)
        Me.Reelcontrol1.SpinTime = 2000
        Me.Reelcontrol1.TabIndex = 2
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(443, 104)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(48, 16)
        Me.LabelResult.TabIndex = 10
        Me.LabelResult.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ButtonAddMoney)
        Me.Controls.Add(Me.LabelMoney)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Reelcontrol3)
        Me.Controls.Add(Me.Reelcontrol2)
        Me.Controls.Add(Me.Reelcontrol1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Reelcontrol1 As reelcontrol1
    Friend WithEvents Reelcontrol2 As reelcontrol1
    Friend WithEvents Reelcontrol3 As reelcontrol1
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelMoney As Label
    Friend WithEvents ButtonAddMoney As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelResult As Label
End Class
