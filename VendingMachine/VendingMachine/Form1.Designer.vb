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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.idTB = New System.Windows.Forms.TextBox()
        Me.ProductPB = New System.Windows.Forms.PictureBox()
        Me.Productcontrol16 = New VendingMachine.productcontrol()
        Me.Productcontrol15 = New VendingMachine.productcontrol()
        Me.Productcontrol14 = New VendingMachine.productcontrol()
        Me.Productcontrol13 = New VendingMachine.productcontrol()
        Me.Productcontrol12 = New VendingMachine.productcontrol()
        Me.Productcontrol11 = New VendingMachine.productcontrol()
        Me.Productcontrol10 = New VendingMachine.productcontrol()
        Me.Productcontrol9 = New VendingMachine.productcontrol()
        Me.Productcontrol8 = New VendingMachine.productcontrol()
        Me.Productcontrol7 = New VendingMachine.productcontrol()
        Me.Productcontrol6 = New VendingMachine.productcontrol()
        Me.Productcontrol5 = New VendingMachine.productcontrol()
        Me.Productcontrol4 = New VendingMachine.productcontrol()
        Me.Productcontrol3 = New VendingMachine.productcontrol()
        Me.Productcontrol2 = New VendingMachine.productcontrol()
        Me.Productcontrol1 = New VendingMachine.productcontrol()
        CType(Me.dollarcoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quartercoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dimecoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nickelcoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(655, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(655, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.Location = New System.Drawing.Point(655, 78)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.Location = New System.Drawing.Point(655, 172)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 40)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(728, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 29)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(701, 261)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(143, 32)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Coin Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'dollarcoin
        '
        Me.dollarcoin.Image = CType(resources.GetObject("dollarcoin.Image"), System.Drawing.Image)
        Me.dollarcoin.Location = New System.Drawing.Point(822, 31)
        Me.dollarcoin.Name = "dollarcoin"
        Me.dollarcoin.Size = New System.Drawing.Size(75, 41)
        Me.dollarcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dollarcoin.TabIndex = 6
        Me.dollarcoin.TabStop = False
        Me.dollarcoin.Visible = False
        '
        'quartercoin
        '
        Me.quartercoin.Image = CType(resources.GetObject("quartercoin.Image"), System.Drawing.Image)
        Me.quartercoin.Location = New System.Drawing.Point(822, 78)
        Me.quartercoin.Name = "quartercoin"
        Me.quartercoin.Size = New System.Drawing.Size(75, 41)
        Me.quartercoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.quartercoin.TabIndex = 7
        Me.quartercoin.TabStop = False
        Me.quartercoin.Visible = False
        '
        'dimecoin
        '
        Me.dimecoin.Image = CType(resources.GetObject("dimecoin.Image"), System.Drawing.Image)
        Me.dimecoin.Location = New System.Drawing.Point(822, 125)
        Me.dimecoin.Name = "dimecoin"
        Me.dimecoin.Size = New System.Drawing.Size(75, 41)
        Me.dimecoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.dimecoin.TabIndex = 8
        Me.dimecoin.TabStop = False
        Me.dimecoin.Visible = False
        '
        'nickelcoin
        '
        Me.nickelcoin.Image = CType(resources.GetObject("nickelcoin.Image"), System.Drawing.Image)
        Me.nickelcoin.Location = New System.Drawing.Point(822, 171)
        Me.nickelcoin.Name = "nickelcoin"
        Me.nickelcoin.Size = New System.Drawing.Size(75, 41)
        Me.nickelcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nickelcoin.TabIndex = 9
        Me.nickelcoin.TabStop = False
        Me.nickelcoin.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(723, 358)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Buy"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'idTB
        '
        Me.idTB.Location = New System.Drawing.Point(720, 406)
        Me.idTB.Name = "idTB"
        Me.idTB.Size = New System.Drawing.Size(100, 22)
        Me.idTB.TabIndex = 27
        '
        'ProductPB
        '
        Me.ProductPB.Location = New System.Drawing.Point(701, 482)
        Me.ProductPB.Name = "ProductPB"
        Me.ProductPB.Size = New System.Drawing.Size(165, 129)
        Me.ProductPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ProductPB.TabIndex = 28
        Me.ProductPB.TabStop = False
        '
        'Productcontrol16
        '
        Me.Productcontrol16.Location = New System.Drawing.Point(480, 381)
        Me.Productcontrol16.Name = "Productcontrol16"
        Me.Productcontrol16.productcount = 5
        Me.Productcontrol16.productid = "D4"
        Me.Productcontrol16.productpicture = CType(resources.GetObject("Productcontrol16.productpicture"), System.Drawing.Image)
        Me.Productcontrol16.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol16.Size = New System.Drawing.Size(150, 120)
        Me.Productcontrol16.TabIndex = 25
        '
        'Productcontrol15
        '
        Me.Productcontrol15.Location = New System.Drawing.Point(324, 381)
        Me.Productcontrol15.Name = "Productcontrol15"
        Me.Productcontrol15.productcount = 5
        Me.Productcontrol15.productid = "D3"
        Me.Productcontrol15.productpicture = CType(resources.GetObject("Productcontrol15.productpicture"), System.Drawing.Image)
        Me.Productcontrol15.productprice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Productcontrol15.Size = New System.Drawing.Size(150, 113)
        Me.Productcontrol15.TabIndex = 24
        '
        'Productcontrol14
        '
        Me.Productcontrol14.Location = New System.Drawing.Point(168, 386)
        Me.Productcontrol14.Name = "Productcontrol14"
        Me.Productcontrol14.productcount = 5
        Me.Productcontrol14.productid = "D2"
        Me.Productcontrol14.productpicture = CType(resources.GetObject("Productcontrol14.productpicture"), System.Drawing.Image)
        Me.Productcontrol14.productprice = New Decimal(New Integer() {2, 0, 0, 0})
        Me.Productcontrol14.Size = New System.Drawing.Size(150, 113)
        Me.Productcontrol14.TabIndex = 23
        '
        'Productcontrol13
        '
        Me.Productcontrol13.Location = New System.Drawing.Point(12, 388)
        Me.Productcontrol13.Name = "Productcontrol13"
        Me.Productcontrol13.productcount = 5
        Me.Productcontrol13.productid = "D1"
        Me.Productcontrol13.productpicture = CType(resources.GetObject("Productcontrol13.productpicture"), System.Drawing.Image)
        Me.Productcontrol13.productprice = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Productcontrol13.Size = New System.Drawing.Size(150, 113)
        Me.Productcontrol13.TabIndex = 22
        '
        'Productcontrol12
        '
        Me.Productcontrol12.Location = New System.Drawing.Point(480, 262)
        Me.Productcontrol12.Name = "Productcontrol12"
        Me.Productcontrol12.productcount = 5
        Me.Productcontrol12.productid = "C4"
        Me.Productcontrol12.productpicture = CType(resources.GetObject("Productcontrol12.productpicture"), System.Drawing.Image)
        Me.Productcontrol12.productprice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Productcontrol12.Size = New System.Drawing.Size(150, 113)
        Me.Productcontrol12.TabIndex = 21
        '
        'Productcontrol11
        '
        Me.Productcontrol11.Location = New System.Drawing.Point(324, 262)
        Me.Productcontrol11.Name = "Productcontrol11"
        Me.Productcontrol11.productcount = 5
        Me.Productcontrol11.productid = "C3"
        Me.Productcontrol11.productpicture = CType(resources.GetObject("Productcontrol11.productpicture"), System.Drawing.Image)
        Me.Productcontrol11.productprice = New Decimal(New Integer() {25, 0, 0, 65536})
        Me.Productcontrol11.Size = New System.Drawing.Size(150, 113)
        Me.Productcontrol11.TabIndex = 20
        '
        'Productcontrol10
        '
        Me.Productcontrol10.Location = New System.Drawing.Point(168, 262)
        Me.Productcontrol10.Name = "Productcontrol10"
        Me.Productcontrol10.productcount = 5
        Me.Productcontrol10.productid = "C2"
        Me.Productcontrol10.productpicture = CType(resources.GetObject("Productcontrol10.productpicture"), System.Drawing.Image)
        Me.Productcontrol10.productprice = New Decimal(New Integer() {35, 0, 0, 65536})
        Me.Productcontrol10.Size = New System.Drawing.Size(150, 118)
        Me.Productcontrol10.TabIndex = 19
        '
        'Productcontrol9
        '
        Me.Productcontrol9.Location = New System.Drawing.Point(12, 264)
        Me.Productcontrol9.Name = "Productcontrol9"
        Me.Productcontrol9.productcount = 5
        Me.Productcontrol9.productid = "C1"
        Me.Productcontrol9.productpicture = CType(resources.GetObject("Productcontrol9.productpicture"), System.Drawing.Image)
        Me.Productcontrol9.productprice = New Decimal(New Integer() {6, 0, 0, 0})
        Me.Productcontrol9.Size = New System.Drawing.Size(150, 118)
        Me.Productcontrol9.TabIndex = 18
        '
        'Productcontrol8
        '
        Me.Productcontrol8.Location = New System.Drawing.Point(480, 138)
        Me.Productcontrol8.Name = "Productcontrol8"
        Me.Productcontrol8.productcount = 5
        Me.Productcontrol8.productid = "B4"
        Me.Productcontrol8.productpicture = CType(resources.GetObject("Productcontrol8.productpicture"), System.Drawing.Image)
        Me.Productcontrol8.productprice = New Decimal(New Integer() {125, 0, 0, 131072})
        Me.Productcontrol8.Size = New System.Drawing.Size(150, 118)
        Me.Productcontrol8.TabIndex = 17
        '
        'Productcontrol7
        '
        Me.Productcontrol7.Location = New System.Drawing.Point(324, 138)
        Me.Productcontrol7.Name = "Productcontrol7"
        Me.Productcontrol7.productcount = 5
        Me.Productcontrol7.productid = "B3"
        Me.Productcontrol7.productpicture = CType(resources.GetObject("Productcontrol7.productpicture"), System.Drawing.Image)
        Me.Productcontrol7.productprice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Productcontrol7.Size = New System.Drawing.Size(150, 118)
        Me.Productcontrol7.TabIndex = 16
        '
        'Productcontrol6
        '
        Me.Productcontrol6.Location = New System.Drawing.Point(168, 138)
        Me.Productcontrol6.Name = "Productcontrol6"
        Me.Productcontrol6.productcount = 5
        Me.Productcontrol6.productid = "B2"
        Me.Productcontrol6.productpicture = CType(resources.GetObject("Productcontrol6.productpicture"), System.Drawing.Image)
        Me.Productcontrol6.productprice = New Decimal(New Integer() {45, 0, 0, 65536})
        Me.Productcontrol6.Size = New System.Drawing.Size(150, 118)
        Me.Productcontrol6.TabIndex = 15
        '
        'Productcontrol5
        '
        Me.Productcontrol5.Location = New System.Drawing.Point(12, 138)
        Me.Productcontrol5.Name = "Productcontrol5"
        Me.Productcontrol5.productcount = 5
        Me.Productcontrol5.productid = "B1"
        Me.Productcontrol5.productpicture = CType(resources.GetObject("Productcontrol5.productpicture"), System.Drawing.Image)
        Me.Productcontrol5.productprice = New Decimal(New Integer() {5, 0, 0, 0})
        Me.Productcontrol5.Size = New System.Drawing.Size(150, 120)
        Me.Productcontrol5.TabIndex = 14
        '
        'Productcontrol4
        '
        Me.Productcontrol4.Location = New System.Drawing.Point(480, 12)
        Me.Productcontrol4.Name = "Productcontrol4"
        Me.Productcontrol4.productcount = 5
        Me.Productcontrol4.productid = "A4"
        Me.Productcontrol4.productpicture = CType(resources.GetObject("Productcontrol4.productpicture"), System.Drawing.Image)
        Me.Productcontrol4.productprice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Productcontrol4.Size = New System.Drawing.Size(150, 120)
        Me.Productcontrol4.TabIndex = 13
        '
        'Productcontrol3
        '
        Me.Productcontrol3.Location = New System.Drawing.Point(324, 12)
        Me.Productcontrol3.Name = "Productcontrol3"
        Me.Productcontrol3.productcount = 5
        Me.Productcontrol3.productid = "A3"
        Me.Productcontrol3.productpicture = CType(resources.GetObject("Productcontrol3.productpicture"), System.Drawing.Image)
        Me.Productcontrol3.productprice = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Productcontrol3.Size = New System.Drawing.Size(150, 120)
        Me.Productcontrol3.TabIndex = 12
        '
        'Productcontrol2
        '
        Me.Productcontrol2.Location = New System.Drawing.Point(168, 12)
        Me.Productcontrol2.Name = "Productcontrol2"
        Me.Productcontrol2.productcount = 5
        Me.Productcontrol2.productid = "A2"
        Me.Productcontrol2.productpicture = CType(resources.GetObject("Productcontrol2.productpicture"), System.Drawing.Image)
        Me.Productcontrol2.productprice = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Productcontrol2.Size = New System.Drawing.Size(150, 120)
        Me.Productcontrol2.TabIndex = 11
        '
        'Productcontrol1
        '
        Me.Productcontrol1.Location = New System.Drawing.Point(12, 12)
        Me.Productcontrol1.Name = "Productcontrol1"
        Me.Productcontrol1.productcount = 5
        Me.Productcontrol1.productid = "A1"
        Me.Productcontrol1.productpicture = CType(resources.GetObject("Productcontrol1.productpicture"), System.Drawing.Image)
        Me.Productcontrol1.productprice = New Decimal(New Integer() {15, 0, 0, 65536})
        Me.Productcontrol1.Size = New System.Drawing.Size(150, 120)
        Me.Productcontrol1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 634)
        Me.Controls.Add(Me.ProductPB)
        Me.Controls.Add(Me.idTB)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Productcontrol16)
        Me.Controls.Add(Me.Productcontrol15)
        Me.Controls.Add(Me.Productcontrol14)
        Me.Controls.Add(Me.Productcontrol13)
        Me.Controls.Add(Me.Productcontrol12)
        Me.Controls.Add(Me.Productcontrol11)
        Me.Controls.Add(Me.Productcontrol10)
        Me.Controls.Add(Me.Productcontrol9)
        Me.Controls.Add(Me.Productcontrol8)
        Me.Controls.Add(Me.Productcontrol7)
        Me.Controls.Add(Me.Productcontrol6)
        Me.Controls.Add(Me.Productcontrol5)
        Me.Controls.Add(Me.Productcontrol4)
        Me.Controls.Add(Me.Productcontrol3)
        Me.Controls.Add(Me.Productcontrol2)
        Me.Controls.Add(Me.Productcontrol1)
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
        CType(Me.ProductPB, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Productcontrol1 As productcontrol
    Friend WithEvents Productcontrol2 As productcontrol
    Friend WithEvents Productcontrol3 As productcontrol
    Friend WithEvents Productcontrol4 As productcontrol
    Friend WithEvents Productcontrol5 As productcontrol
    Friend WithEvents Productcontrol6 As productcontrol
    Friend WithEvents Productcontrol7 As productcontrol
    Friend WithEvents Productcontrol8 As productcontrol
    Friend WithEvents Productcontrol9 As productcontrol
    Friend WithEvents Productcontrol10 As productcontrol
    Friend WithEvents Productcontrol11 As productcontrol
    Friend WithEvents Productcontrol12 As productcontrol
    Friend WithEvents Productcontrol13 As productcontrol
    Friend WithEvents Productcontrol14 As productcontrol
    Friend WithEvents Productcontrol15 As productcontrol
    Friend WithEvents Productcontrol16 As productcontrol
    Friend WithEvents Button6 As Button
    Friend WithEvents idTB As TextBox
    Friend WithEvents ProductPB As PictureBox
End Class
