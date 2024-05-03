Imports System.Reflection.Emit

Class MainWindow
    Private Sub Button1_Click(sender As Object, e As RoutedEventArgs) Handles Button1.Click
        Dim selectedDate As DateTime = Cal1.SelectedDate.Value
        Dim month As Integer = selectedDate.Month
        Dim day As Integer = selectedDate.Day

        Dim sign As String = ""
        HideAllImages()  ' Make sure all images are initially hidden.

        Select Case month
            Case 1
                If day >= 20 Then sign = "Aquarius" Else sign = "Capricorn"
            Case 2
                If day >= 19 Then sign = "Pisces" Else sign = "Aquarius"
            Case 3
                If day >= 21 Then sign = "Aries" Else sign = "Pisces"
            Case 4
                If day >= 20 Then sign = "Taurus" Else sign = "Aries"
            Case 5
                If day >= 21 Then sign = "Gemini" Else sign = "Taurus"
            Case 6
                If day >= 21 Then sign = "Cancer" Else sign = "Gemini"
            Case 7
                If day >= 23 Then sign = "Leo" Else sign = "Cancer"
            Case 8
                If day >= 23 Then sign = "Virgo" Else sign = "Leo"
            Case 9
                If day >= 23 Then sign = "Libra" Else sign = "Virgo"
            Case 10
                If day >= 23 Then sign = "Scorpio" Else sign = "Libra"
            Case 11
                If day >= 22 Then sign = "Sagittarius" Else sign = "Scorpio"
            Case 12
                If day >= 22 Then sign = "Capricorn" Else sign = "Sagittarius"
        End Select

        Label1.Content = "Your star sign is " & sign
        ShowSignImage(sign)
    End Sub

    Private Sub HideAllImages()
        aquarius.Visibility = Visibility.Collapsed
        pisces.Visibility = Visibility.Collapsed
        aries.Visibility = Visibility.Collapsed
        ' Collapse other images similarly
    End Sub

    Private Sub ShowSignImage(sign As String)
        Dim imageControl As Image = TryCast(Me.FindName(sign), Image)
        If imageControl IsNot Nothing Then
            imageControl.Visibility = Visibility.Visible
        Else
            MessageBox.Show("Image control not found for sign: " & sign)
        End If
    End Sub

End Class