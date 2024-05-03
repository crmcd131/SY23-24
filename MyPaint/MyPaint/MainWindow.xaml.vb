Imports Microsoft.Win32
Imports System.IO

Class MainWindow
    Dim grab1 As Color
    Dim grab2 As Color
    Private Sub drawingcanvas_MouseMove(sender As Object, e As MouseEventArgs) Handles drawingcanvas.MouseMove
        If Shapelabel.Content = "Ellipse" Then
            Dim el As New Ellipse
            el.Width = widthslider.Value
            el.Height = heightslider.Value
            el.Fill = colorrectangle1.Fill
            Dim p As Point = Mouse.GetPosition(drawingcanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                drawingcanvas.Children.Add(el)
            End If
        End If

        If Shapelabel.Content = "Rectangle" Then
            Dim el As New Rectangle
            el.Width = widthslider.Value
            el.Height = heightslider.Value
            el.Fill = colorrectangle1.Fill
            Dim p As Point = Mouse.GetPosition(drawingcanvas)
            Canvas.SetLeft(el, p.X)
            Canvas.SetTop(el, p.Y)
            If e.LeftButton = MouseButtonState.Pressed Then
                drawingcanvas.Children.Add(el)
            End If
        End If
    End Sub

    Private Sub colorrectangle2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles colorrectangle2.MouseDown, colorrectangle3.MouseDown, colorrectangle4.MouseDown, colorrectangle5.MouseDown
        colorrectangle1.Fill = sender.fill
    End Sub

    Private Sub Button_Click_1(sender As Object, e As RoutedEventArgs)
        drawingcanvas.Children.RemoveRange(1, drawingcanvas.Children.Count)
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        drawingcanvas.Children.RemoveAt(drawingcanvas.Children.Count - 1)
    End Sub

    Private Sub Button_Click_2(sender As Object, e As RoutedEventArgs)
        Shapelabel.Content = sender.content
    End Sub

    Private Sub Ellipsebutton_Click(sender As Object, e As RoutedEventArgs) Handles Ellipsebutton.Click
        Shapelabel.Content = sender.content
    End Sub

    Private Sub Savebutton_Click(sender As Object, e As RoutedEventArgs) Handles Savebutton.Click
        ExportToPng(drawingcanvas)
    End Sub
    Public Sub ExportToPng(ByVal surface As Canvas)

        Dim sfd As New SaveFileDialog

        sfd.ShowDialog()

        If sfd.FileName Is Nothing Then Return

        Dim transform As Transform = surface.LayoutTransform

        surface.LayoutTransform = Nothing

        Dim size As Size = New Size(surface.Width, surface.Height)

        surface.Measure(size)

        surface.Arrange(New Rect(size))

        Dim renderBitmap As RenderTargetBitmap = New RenderTargetBitmap(CInt(size.Width), CInt(size.Height), 96.0R, 96.0R, PixelFormats.Pbgra32)

        renderBitmap.Render(surface)



        Using outStream As FileStream = New FileStream(sfd.FileName & ".png", FileMode.Create)

            Dim encoder As PngBitmapEncoder = New PngBitmapEncoder()

            encoder.Frames.Add(BitmapFrame.Create(renderBitmap))

            encoder.Save(outStream)

        End Using

        '

        surface.LayoutTransform = transform

        Canvas.SetLeft(drawingcanvas, 200)

        Canvas.SetTop(drawingcanvas, 10)

    End Sub

    Private Sub color1_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color1.MouseDown
        grab1 = Color.FromRgb(r.Value, g.Value, b.Value)
        sender.fill = New SolidColorBrush(grab1)
    End Sub

    Private Sub color2_MouseDown(sender As Object, e As MouseButtonEventArgs) Handles color2.MouseDown
        grab2 = Color.FromRgb(r.Value, g.Value, b.Value)
        sender.fill = New SolidColorBrush(grab2)
    End Sub

    Private Sub angleslider_ValueChanged(sender As Object, e As RoutedPropertyChangedEventArgs(Of Double)) Handles angleslider.ValueChanged
        colorrectangle1.Fill = New LinearGradientBrush(grab1, grab2, angleslider.Value)
    End Sub
End Class
