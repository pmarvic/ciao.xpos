Public Class frmPrimary
    Private Sub TimerPos_Tick(sender As Object, e As EventArgs) Handles TimerPos.Tick
        lblTime.Text = TimeOfDay
        lblDate.Text = DateAndTime.Now.ToLongDateString
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            Case Keys.F2
                MsgBox("Inserte Contraseña")
            Case Keys.F3
                MsgBox("g")
            Case Keys.F10
                End
            Case Keys.Return
                MsgBox("Enter")
        End Select
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub frmPrimary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Empresa = "01" Then
            ptbLogoSucasa.Visible = True
            ptbLogoSaidi.Visible = False

        Else
            ptbLogoSucasa.Visible = False
            ptbLogoSaidi.Visible = True
        End If


    End Sub
End Class
