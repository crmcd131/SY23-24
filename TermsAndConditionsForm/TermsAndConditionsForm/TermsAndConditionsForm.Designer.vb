<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TermsAndConditionsForm
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
        Me.btnAgree = New System.Windows.Forms.Button()
        Me.btnDecline = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAgree
        '
        Me.btnAgree.Location = New System.Drawing.Point(163, 144)
        Me.btnAgree.Name = "btnAgree"
        Me.btnAgree.Size = New System.Drawing.Size(75, 23)
        Me.btnAgree.TabIndex = 0
        Me.btnAgree.Text = "Button1"
        Me.btnAgree.UseVisualStyleBackColor = True
        '
        'btnDecline
        '
        Me.btnDecline.Location = New System.Drawing.Point(354, 159)
        Me.btnDecline.Name = "btnDecline"
        Me.btnDecline.Size = New System.Drawing.Size(75, 23)
        Me.btnDecline.TabIndex = 1
        Me.btnDecline.Text = "Button2"
        Me.btnDecline.UseVisualStyleBackColor = True
        '
        'TermsAndConditionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDecline)
        Me.Controls.Add(Me.btnAgree)
        Me.Name = "TermsAndConditionsForm"
        Me.Text = "TermsAndConditionsForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAgree As Button
    Friend WithEvents btnDecline As Button
End Class
