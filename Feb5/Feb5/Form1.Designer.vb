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
        Me.Clickercontrol1 = New Feb5.clickercontrol()
        Me.Clickercontrol2 = New Feb5.clickercontrol()
        Me.Clickercontrol3 = New Feb5.clickercontrol()
        Me.SuspendLayout()
        '
        'Clickercontrol1
        '
        Me.Clickercontrol1.BackColor = System.Drawing.SystemColors.ControlText
        Me.Clickercontrol1.Location = New System.Drawing.Point(228, 12)
        Me.Clickercontrol1.Name = "Clickercontrol1"
        Me.Clickercontrol1.Size = New System.Drawing.Size(150, 150)
        Me.Clickercontrol1.TabIndex = 6
        '
        'Clickercontrol2
        '
        Me.Clickercontrol2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Clickercontrol2.Location = New System.Drawing.Point(47, 12)
        Me.Clickercontrol2.Name = "Clickercontrol2"
        Me.Clickercontrol2.Size = New System.Drawing.Size(150, 150)
        Me.Clickercontrol2.TabIndex = 7
        '
        'Clickercontrol3
        '
        Me.Clickercontrol3.BackColor = System.Drawing.Color.Coral
        Me.Clickercontrol3.Location = New System.Drawing.Point(394, 12)
        Me.Clickercontrol3.Name = "Clickercontrol3"
        Me.Clickercontrol3.Size = New System.Drawing.Size(150, 150)
        Me.Clickercontrol3.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Clickercontrol3)
        Me.Controls.Add(Me.Clickercontrol2)
        Me.Controls.Add(Me.Clickercontrol1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Clickercontrol1 As clickercontrol
    Friend WithEvents Clickercontrol2 As clickercontrol
    Friend WithEvents Clickercontrol3 As clickercontrol
End Class
