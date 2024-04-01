Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim message As String = "Terms and Conditions:" & vbCrLf & vbCrLf &
                                "1: By accessing or using this website, you agree to be bound by these terms and conditions of use. If you do not agree with any of these terms, you are prohibited from using or accessing this site." & vbCrLf &
                                "2: The content of this website is for general information purposes only and is subject to change without notice." & vbCrLf &
                                "3: We do not guarantee the accuracy, completeness, or timeliness of the information and materials found on this website." & vbCrLf &
                                "4: Your use of any information or materials on this website is entirely at your own risk, for which we shall not be liable. It shall be your own responsibility to ensure that any products, services, or information available through this website meet your specific requirements." & vbCrLf &
                                "5: This website contains material which is owned by or licensed to us. This material includes, but is not limited to, the design, layout, look, appearance, and graphics. Reproduction is prohibited other than in accordance with the copyright notice, which forms part of these terms and conditions." & vbCrLf &
                                "6: Unauthorized use of this website may give rise to a claim for damages and/or be a criminal offense." & vbCrLf &
                                "7: From time to time, this website may also include links to other websites. These links are provided for your convenience to provide further information. They do not signify that we endorse the website(s). We have no responsibility for the content of the linked website(s)." & vbCrLf &
                                "8: Your use of this website and any dispute arising out of such use of the website is subject to the laws of [eee]." & vbCrLf &
                                "9: By agreeing to the terms and conditions, you understand that you'll be shipped by a soverign nation which abides all child labor laws(none)." & vbCrLf &
                                "10: All trademarks reproduced in this website, which are not the property of, or licensed to the operator, are acknowledged on the website." & vbCrLf &
                                "11: We reserve the right to modify these terms and conditions at any time without prior notice. It is your responsibility to review these terms and conditions periodically." & vbCrLf & vbCrLf & vbCrLf &
        "- By clicking 'Yes', you confirm that you have read and accept the terms and conditions."

        Dim title As String = "Terms and Conditions"

        Dim result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If result = DialogResult.Yes Then
            MessageBox.Show("You have agreed to the terms and conditions.", "Agreement Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf result = DialogResult.No Then
            MessageBox.Show("You have declined the terms and conditions.", "Agreement Declined", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub



    Private ShoppingCart As New List(Of CartItem)



    Public Class CartItem
        Public Property Name As String
        Public Property Price As Decimal

        Public Sub New(itemName As String, itemPrice As Decimal)
            Name = itemName
            Price = itemPrice
        End Sub

        Public Overrides Function ToString() As String
            Return $"{Name} - ${Price}"
        End Function
    End Class




    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        Dim newItem As New CartItem("Sunglasses Holders", 2.87D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub

    Private Sub btnAddTalkiShirt_Click(sender As Object, e As EventArgs) Handles btnAddTalkiShirt.Click
        Dim newItem As New CartItem("Talki Shirt", 9.53D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub

    Private Sub btnAddWTFHat_Click(sender As Object, e As EventArgs) Handles btnAddWTFHat.Click
        Dim newItem As New CartItem("WTF Hat", 4.04D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub

    Private Sub btnAddBabyToy_Click(sender As Object, e As EventArgs) Handles btnAddBabyToy.Click
        Dim newItem As New CartItem("Baby Water Toy", 1.69D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub
    Private Sub btnAddEarbuds_Click(sender As Object, e As EventArgs) Handles btnAddEarbuds.Click
        Dim newItem As New CartItem("Wireless Buds", 10.48D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub





    Private Sub btnViewCart_Click(sender As Object, e As EventArgs) Handles btnViewCart.Click
        lstCartItems.Visible = Not lstCartItems.Visible

        If lstCartItems.Visible Then
            lstCartItems.Items.Clear()

            Dim totalAmount As Decimal = 0

            For Each item As CartItem In ShoppingCart
                lstCartItems.Items.Add(item.ToString())
                totalAmount += item.Price
            Next

            lstCartItems.Items.Add("")

            lstCartItems.Items.Add($"Total: ${totalAmount}")
            lstCartItems.Items.Add("Buy")
        End If

        Dim showItems As Boolean = Not lstCartItems.Visible

        PBRegular1.Visible = showItems
        PBRegular2.Visible = showItems
        PBRegular3.Visible = showItems
        PBRegular4.Visible = showItems
        PBRegular5.Visible = showItems

        btnBuyBest1.Visible = showItems
        btnBuyBest2.Visible = showItems
        btnBuyBest3.Visible = showItems
        btnbuybest4.Visible = showItems
        btnBuyBest5.Visible = showItems

        pictureBoxBest1.Visible = showItems
        pictureBoxBest2.Visible = showItems
        pictureBoxBest3.Visible = showItems
        pictureBoxBest4.Visible = showItems
        pictureBoxBest5.Visible = showItems

        btnBuyBest1.Visible = showItems
        btnBuyBest2.Visible = showItems
        btnBuyBest3.Visible = showItems
        btnbuybest4.Visible = showItems
        btnBuyBest5.Visible = showItems

        If lstCartItems.Visible Then
            lstCartItems.Items.Clear()

            For Each item As CartItem In ShoppingCart
                lstCartItems.Items.Add(item.ToString())
            Next
        End If
    End Sub

    Private Sub lstCartItems_Click(sender As Object, e As EventArgs) Handles lstCartItems.Click
        If lstCartItems.SelectedItem IsNot Nothing AndAlso lstCartItems.SelectedItem.ToString() = "Buy" Then
            lstCartItems.Items.Clear()
            ShoppingCart.Clear()
        End If
    End Sub





    Private Sub btnBestSellers_Click(sender As Object, e As EventArgs) Handles btnBestSellers.Click
        PBRegular1.Visible = False
        PBRegular2.Visible = False
        PBRegular3.Visible = False
        PBRegular4.Visible = False
        PBRegular5.Visible = False

        btnAddToCart.Visible = False
        btnAddTalkiShirt.Visible = False
        btnAddBabyToy.Visible = False
        btnAddEarbuds.Visible = False
        btnAddWTFHat.Visible = False



        pictureBoxBest1.Visible = True
        pictureBoxBest2.Visible = True
        pictureBoxBest3.Visible = True
        pictureBoxBest4.Visible = True
        pictureBoxBest5.Visible = True

        btnBuyBest1.Visible = True
        btnBuyBest2.Visible = True
        btnBuyBest3.Visible = True
        btnbuybest4.Visible = True
        btnBuyBest5.Visible = True
    End Sub

    Private Sub btnOriginalView_Click(sender As Object, e As EventArgs) Handles btnOriginalView.Click
        PBRegular1.Visible = True
        PBRegular2.Visible = True
        PBRegular3.Visible = True
        PBRegular4.Visible = True
        PBRegular5.Visible = True

        btnBuyBest1.Visible = True
        btnBuyBest2.Visible = True
        btnBuyBest3.Visible = True
        btnbuybest4.Visible = True
        btnBuyBest5.Visible = True

        pictureBoxBest1.Visible = False
        pictureBoxBest2.Visible = False
        pictureBoxBest3.Visible = False
        pictureBoxBest4.Visible = False
        pictureBoxBest5.Visible = False

        btnBuyBest1.Visible = False
        btnBuyBest2.Visible = False
        btnBuyBest3.Visible = False
        btnbuybest4.Visible = False
        btnBuyBest5.Visible = False
    End Sub

    Private Sub btnBuyBest1_Click(sender As Object, e As EventArgs) Handles btnBuyBest1.Click
        Dim newItem As New CartItem("Quilted Waterproof Mattress", 9.88D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub

    Private Sub btnBuyBest2_Click(sender As Object, e As EventArgs) Handles btnBuyBest2.Click
        Dim newItem As New CartItem("Small Stroller Rack", 9.23D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub

    Private Sub btnBuyBest3_Click(sender As Object, e As EventArgs) Handles btnBuyBest3.Click
        Dim newItem As New CartItem("Air Compressor", 13.52D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub

    Private Sub btnbuybest4_Click(sender As Object, e As EventArgs) Handles btnbuybest4.Click
        Dim newItem As New CartItem("Binoculars", 36.53D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub

    Private Sub btnBuyBest5_Click(sender As Object, e As EventArgs) Handles btnBuyBest5.Click
        Dim newItem As New CartItem("Asuda Laptop", 186.98D)

        ShoppingCart.Add(newItem)

        MessageBox.Show(newItem.Name & " added to cart.")
    End Sub


End Class
