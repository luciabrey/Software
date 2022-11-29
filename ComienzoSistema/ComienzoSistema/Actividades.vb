Public Class Actividades
    Dim contraseña As String

    Private Sub inicial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles inicial.Click
        futsal.Visible = False
        gbdefault.Visible = True
        voley.Visible = False
        handball.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttHandball.Click
        futsal.Visible = False
        gbdefault.Visible = False
        voley.Visible = False
        handball.Visible = True
    End Sub

    Private Sub Actividades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        handball.Visible = False
        futsal.Visible = False
        voley.Visible = False
    End Sub

    Private Sub bttFutsal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttFutsal.Click
        gbdefault.Visible = False
        futsal.Visible = True
        handball.Visible = False
        voley.Visible = False
    End Sub

    Private Sub bttVoley_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttVoley.Click
        voley.Visible = True
        handball.Visible = False
        gbdefault.Visible = False
        futsal.Visible = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub bttModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar.Click


        contraseña = InputBox("Ingrese la contraseña")
        If contraseña = "benavidez" Then
            box1.Enabled = True
            box2.Enabled = True
            box3.Enabled = True
            box4.Enabled = True
            box5.Enabled = True
            box6.Enabled = True
            box7.Enabled = True
            box8.Enabled = True
            box9.Enabled = True
            box10.Enabled = True
            box11.Enabled = True
            box12.Enabled = True

            bttAceptar.Visible = True

        Else : MsgBox("Contraseña Incorrecta!")
        End If
    End Sub

    Private Sub bttAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar.Click
        box1.Enabled = False
        box2.Enabled = False
        box3.Enabled = False
        box4.Enabled = False
        box5.Enabled = False
        box6.Enabled = False
        box7.Enabled = False
        box8.Enabled = False
        box9.Enabled = False
        box10.Enabled = False
        box11.Enabled = False
        box12.Enabled = False
    End Sub


    Private Sub bttModificar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar2.Click
        contraseña = InputBox("Ingrese la contraseña")
        If contraseña = "benavidez" Then
            bttAceptar2.Visible = True
            boxFutsal.Enabled = True

        Else : MsgBox("Contraseña Incorrecta!")
        End If

    End Sub

    Private Sub bttAceptar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar2.Click
        boxFutsal.Enabled = False
        bttAceptar2.Visible = True
    End Sub

    Private Sub bttModificar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar4.Click
        contraseña = InputBox("Ingrese la contraseña")
        If contraseña = "benavidez" Then
            bttAceptar4.Visible = True
            boxHandBall.Enabled = True

        Else : MsgBox("Contraseña Incorrecta!")
        End If
    End Sub

    Private Sub bttAceptar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar4.Click
        bttAceptar4.Visible = False
    End Sub

    Private Sub bttModificar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttModificar3.Click
        contraseña = InputBox("Ingrese la contraseña")
        If contraseña = "benavidez" Then
            bttAceptar3.Visible = True
            boxVoley.Enabled = True

        Else : MsgBox("Contraseña Incorrecta!")
        End If
    End Sub

    Private Sub bttAceptar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bttAceptar3.Click
        bttAceptar3.Visible = True
    End Sub

End Class