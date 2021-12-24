Public Class Form1
    '' Evento que se desencadena cuando el usuario pasa el CURSOR por encima del control btnSuma
    Private Sub btnSuma_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSuma.MouseMove
        '' Cuando se desencadena, el tamaño del control en ancho y alto es modificado para crecer un poco mientras el cursor se mantiene encima
        btnSuma.Width = 119
        btnSuma.Height = 104
    End Sub

    '' Evento que se desencadena cuando el usuario saca el CURSOR de encima del control btnSuma
    Private Sub btnSuma_MouseLeave(sender As Object, e As EventArgs) Handles btnSuma.MouseLeave
        '' Cuando se desencadena, el tamaño del control en ancho y alto es modificado para volver a su tamaño original
        btnSuma.Width = 114
        btnSuma.Height = 99
    End Sub

    Private Sub btnResta_MouseMove(sender As Object, e As MouseEventArgs) Handles btnResta.MouseMove
        btnResta.Width = 119
        btnResta.Height = 104
    End Sub

    Private Sub btnResta_MouseLeave(sender As Object, e As EventArgs) Handles btnResta.MouseLeave
        btnResta.Width = 114
        btnResta.Height = 99
    End Sub

    Private Sub btnMult_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMult.MouseMove
        btnMult.Width = 119
        btnMult.Height = 104
    End Sub

    Private Sub btnMult_MouseLeave(sender As Object, e As EventArgs) Handles btnMult.MouseLeave
        btnMult.Width = 114
        btnMult.Height = 99
    End Sub

    Private Sub btnDiv_MouseMove(sender As Object, e As MouseEventArgs) Handles btnDiv.MouseMove
        btnDiv.Width = 119
        btnDiv.Height = 104
    End Sub

    Private Sub btnDiv_MouseLeave(sender As Object, e As EventArgs) Handles btnDiv.MouseLeave
        btnDiv.Width = 114
        btnDiv.Height = 99
    End Sub

    ''Botón para Ir a suma
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        '' Ir a suma, se crea una instancia del formulario que se desea mostrar
        Dim frmCambia = New Suma()
        '' Se muestra el nuevo formulario como dependiente del formulario principal para funcionar
        frmCambia.ShowDialog()
    End Sub

    ''Botón para Ir a resta
    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        '' Ir a resta, se crea una instancia del formulario que se desea mostrar
        Dim frmCambia = New Resta()
        '' Se muestra el nuevo formulario como dependiente del formulario principal para funcionar
        frmCambia.ShowDialog()
    End Sub

    ''Botón para Ir a multiplicación
    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        '' Ir a multiplicación, se crea una instancia del formulario que se desea mostrar
        Dim frmCambia = New Multiplicacion()
        '' Se muestra el nuevo formulario como dependiente del formulario principal para funcionar
        frmCambia.ShowDialog()
    End Sub

    ''Botón para Ir a división
    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        '' Ir a división, se crea una instancia del formulario que se desea mostrar
        Dim frmCambia = New Division()
        '' Se muestra el nuevo formulario como dependiente del formulario principal para funcionar
        frmCambia.ShowDialog()
    End Sub
End Class
