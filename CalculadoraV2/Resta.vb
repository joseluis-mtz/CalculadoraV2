Public Class Resta
    Dim respuesta As MsgBoxResult
    Private Sub Resta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtResultado.Enabled = False
    End Sub

    Private Sub txtNum1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNum1.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            eRP.SetError(txtNum1, "ERROR AL INGRESAR DATO.")
            MsgBox("Upps!, Te recuerdo que solo puedes introducir valores númericos", vbCritical, "Error!!!")
            txtNum1.Text = vbNullChar
        Else
            eRP.SetError(txtNum1, Nothing)
        End If
    End Sub

    Private Sub txtNum1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txtNum2.Focus()
        End If
    End Sub

    Private Sub txtNum2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNum2.KeyDown
        If Not ((e.KeyValue >= 48 And e.KeyValue <= 57) OrElse (e.KeyValue = 8) OrElse (e.KeyValue = 13)) Then
            e.Handled = True
            eRP.SetError(txtNum2, "ERROR AL INGRESAR DATO.")
            MsgBox("Upps!, Te recuerdo que solo puedes introducir valores númericos", vbCritical, "Error!!!")
            txtNum2.Text = vbNullChar
        Else
            eRP.SetError(txtNum2, Nothing)
        End If
    End Sub

    Private Sub txtNum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum2.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnEjecuta.PerformClick()
        End If
    End Sub

    Private Sub btnEjecuta_Click(sender As Object, e As EventArgs) Handles btnEjecuta.Click
        Dim numero1 = txtNum1.Text
        Dim numero2 = txtNum2.Text
        If numero1 >= numero2 Then
            txtResultado.Text = Val(txtNum1.Text) - Val(txtNum2.Text)
        Else
            MsgBox("La resta arroja un resultado negativo.", MsgBoxStyle.Critical, "Lo sentimos")
            txtResultado.Text = "ERROR"
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        respuesta = MsgBox("¿Deseas salir de la aplicación?", vbYesNo, "Salir de la aplicación.")
        If respuesta = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class