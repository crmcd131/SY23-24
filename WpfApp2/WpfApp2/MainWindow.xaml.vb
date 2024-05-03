Class MainWindow
    Private rateDict As Dictionary(Of String, Double) = New Dictionary(Of String, Double)() From {
        {"USD", 1.0},
        {"EUR", 0.87},
        {"GBP", 0.78},
        {"JPY", 110.47},
        {"CAD", 1.25},
        {"AUD", 1.31}
    }

    Private Sub Convert_Click(sender As Object, e As RoutedEventArgs)
        Dim dollars As Double
        If Double.TryParse(txtDollars.Text, dollars) Then
            Dim fromCurrency As String = DirectCast(cmbFromCurrency.SelectedItem, ComboBoxItem).Content.ToString().Substring(0, 3)
            Dim toCurrency As String = DirectCast(cmbToCurrency.SelectedItem, ComboBoxItem).Content.ToString().Substring(0, 3)

            Dim rate As Double = rateDict(fromCurrency)
            Dim convertedAmount As Double = dollars * (rateDict(toCurrency) / rate)

            lblConvertedAmount.Content = convertedAmount.ToString("C") ' Format as currency
        Else
            MessageBox.Show("Please enter a valid amount in dollars.")
        End If
    End Sub

    Private Sub Clear_Click(sender As Object, e As RoutedEventArgs)
        txtDollars.Clear()
        lblConvertedAmount.Content = ""
    End Sub

    Private Sub cmbFromCurrency_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        UpdateCurrencyImage(imgFromCurrency, cmbFromCurrency)
        UpdateRate()
    End Sub

    Private Sub cmbToCurrency_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        UpdateCurrencyImage(imgToCurrency, cmbToCurrency)
        UpdateRate()
    End Sub

    Private Sub UpdateCurrencyImage(image As Image, comboBox As ComboBox)
        Dim currency As String = DirectCast(comboBox.SelectedItem, ComboBoxItem).Content.ToString().Substring(0, 3)
        image.Source = New BitmapImage(New Uri($"Images/{currency}.png", UriKind.Relative))
    End Sub


    Private Sub UpdateRate()
        Dim fromCurrency As String = DirectCast(cmbFromCurrency.SelectedItem, ComboBoxItem).Content.ToString().Substring(0, 3)
        Dim toCurrency As String = DirectCast(cmbToCurrency.SelectedItem, ComboBoxItem).Content.ToString().Substring(0, 3)

        Dim rate As Double = rateDict(fromCurrency)
        txtRate.Text = $"1 {fromCurrency} = {rateDict(toCurrency) / rate} {toCurrency}"
    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        UpdateCurrencyImage(imgFromCurrency, cmbFromCurrency)
        UpdateCurrencyImage(imgToCurrency, cmbToCurrency)
        UpdateRate()
    End Sub
End Class
