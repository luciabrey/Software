Public Class ClubBenavidez


    Private Sub ClubBenavidez_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Socios.Hide()
        Actividades.Hide()
    End Sub

    Private Sub bttActividad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttActividad.Click
        Actividades.Show()
    End Sub

    Private Sub bttCobranza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttCobranza.Click
        Cobranza.Show()
    End Sub
    Private Sub bttSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttSalir.Click
        End
    End Sub

    Private Sub BttSocios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BttSocios.Click
        Socios.Show()
    End Sub


    Private Sub bttInicio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttInicio.Click
        Dim inicio As String
        Dim aux As Integer

        inicio = InputBox("Ingrese la contraseña para acceder como Empleado:")
        If inicio = "Empleado" And aux = 0 Then
            BttSocios.Enabled = True
            bttActividad.Enabled = True
            bttCobranza.Enabled = True
            aux = 1
        Else
            BttSocios.Enabled = False
            bttActividad.Enabled = False
            bttCobranza.Enabled = False
            MsgBox("Contraseña Incorrecta!")
        End If

    End Sub
End Class
