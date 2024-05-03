Imports System.Text.RegularExpressions

Class MainWindow
    Private Sub ClearButton_Click(sender As Object, e As RoutedEventArgs)
        ' Clear all textboxes
        CardNumberTextBox1.Text = ""
        NameTextBox1.Text = ""
        ExpireDateTextBox1.Text = ""
        EmailTextBox1.Text = ""
        SecurityCodeTextBox1.Text = ""
        PhoneTextBox1.Text = ""
        ' Disable the OK button
        OKButton1.IsEnabled = False
    End Sub

    Private Sub CheckFieldsAndEnableOKButton()
        ' Enable the OK button if all required fields have correct formats
        If IsCardNumberValid() AndAlso IsNameValid() AndAlso IsExpireDateValid() AndAlso IsEmailValid() AndAlso IsSecurityCodeValid() AndAlso IsPhoneNumberValid() Then
            OKButton1.IsEnabled = True
        Else
            OKButton1.IsEnabled = False
        End If
    End Sub

    Private Sub OKButton_Click(sender As Object, e As RoutedEventArgs)
        ' Perform actions when OK button is clicked
        MessageBox.Show("All fields are valid. Processing credit card...")
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)
        ' Call the function to check fields and enable OK button whenever any textbox content changes
        CheckFieldsAndEnableOKButton()
    End Sub

    Private Function IsCardNumberValid() As Boolean
        ' Check if card number has correct format (e.g., "4444 5464 4572 3456")
        Return Regex.IsMatch(CardNumberTextBox1.Text, "^\d{4} \d{4} \d{4} \d{4}$")
    End Function

    Private Function IsNameValid() As Boolean
        ' Check if name has correct format (e.g., "John Mcdan")
        Return Regex.IsMatch(NameTextBox1.Text, "^[a-zA-Z]+ [a-zA-Z]+$")
    End Function

    Private Function IsExpireDateValid() As Boolean
        ' Check if expiration date has correct format (e.g., "01/15")
        Return Regex.IsMatch(ExpireDateTextBox1.Text, "^\d{2}/\d{2}$")
    End Function

    Private Function IsEmailValid() As Boolean
        ' Check if email has correct format (e.g., "cade@gmail.com")
        Return Regex.IsMatch(EmailTextBox1.Text, "^\w+@\w+\.\w+$")
    End Function

    Private Function IsSecurityCodeValid() As Boolean
        ' Check if security code has correct format (e.g., "545")
        Return Regex.IsMatch(SecurityCodeTextBox1.Text, "^\d{3}$")
    End Function

    Private Function IsPhoneNumberValid() As Boolean
        ' Check if phone number has correct format (e.g., "702 643 4560")
        Return Regex.IsMatch(PhoneTextBox1.Text, "^\d{3} \d{3} \d{4}$")
    End Function
End Class