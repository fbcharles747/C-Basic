Class MainWindow

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        MessageBox.Show("thanks for clicking me")

    End Sub

    Private Sub Button_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs)
        MessageBox.Show("left mouse is released")

    End Sub
End Class
