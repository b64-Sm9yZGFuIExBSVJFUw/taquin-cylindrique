Public Class MenuPrincipal
    'Lorsqu'on clique sur le bouton "Quitter"
    Private Sub BoutonQuitter_Click(sender As Object, e As EventArgs) Handles _
                                                           Bouton_Quitter.Click
        My.Computer.Audio.Play("Sons\Quitter.wav")
        Dim réponse As String = MsgBox("Voulez-vous réellement quitter?",
                                       vbQuestion + vbYesNo, "Confirmation")

        If réponse = MsgBoxResult.Yes Then End
    End Sub

    'Lorsqu'on clique sur le bouton "Jouer"
    Private Sub BoutonJouer_Click(sender As Object, e As EventArgs) Handles _
                                                        Bouton_Jouer.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        Hide()
        SaisieNom.Show()
    End Sub

    'Si la souris passe sur un bouton
    Private Sub Souris_Sur_Bouton(sender As Object, e As EventArgs) Handles _
                         Bouton_Quitter.MouseHover, Bouton_Jouer.MouseHover,
                         Bouton_Tableau.MouseHover, Bouton_Prouesses.MouseHover

        If sender Is Bouton_Jouer Then
            sender.BackColor = Color.Green
            'Si l'un était focus, la priorité sur le mousehover
            Bouton_Quitter.BackColor = Color.White
            Bouton_Tableau.BackColor = Color.White
            Bouton_Prouesses.BackColor = Color.White
        ElseIf sender Is Bouton_Quitter Then
            sender.BackColor = Color.Red
            Bouton_Jouer.BackColor = Color.White
            Bouton_Tableau.BackColor = Color.White
            Bouton_Prouesses.BackColor = Color.White
            Me.Cursor = Cursors.No
        ElseIf sender Is Bouton_Tableau Then
            sender.backColor = Color.Yellow
            Bouton_Prouesses.BackColor = Color.White
            Bouton_Jouer.BackColor = Color.White
            Bouton_Quitter.BackColor = Color.White
        Else 'Si c'est le bouton "Prouesses"
            sender.backColor = Color.Yellow
            Bouton_Tableau.BackColor = Color.White
            Bouton_Jouer.BackColor = Color.White
            Bouton_Quitter.BackColor = Color.White
        End If
    End Sub

    'Si la souris n'est plus sur un bouton
    Private Sub Souris_Plus_Sur_Bouton(sender As Object, e As EventArgs) Handles _
                         Bouton_Quitter.MouseLeave, Bouton_Jouer.MouseLeave,
                         Bouton_Tableau.MouseLeave, Bouton_Prouesses.MouseLeave

        sender.BackColor = Color.White
        Me.Cursor = Cursors.Arrow
    End Sub

    'Quand le focus est sur un bouton
    Private Sub Focus_Bouton(sender As Object, e As EventArgs) Handles _
                   Bouton_Jouer.GotFocus, Bouton_Quitter.GotFocus,
                   Bouton_Tableau.GotFocus, Bouton_Prouesses.GotFocus

        If sender Is Bouton_Jouer Then
            sender.BackColor = Color.Green
        ElseIf sender Is Bouton_Quitter Then
            sender.BackColor = Color.Red
        Else
            sender.backcolor = Color.Yellow
        End If
    End Sub

    'Quand le focus n'est plus sur un bouton
    Private Sub Focus_Plus_Bouton(sender As Object, e As EventArgs) Handles _
                        Bouton_Quitter.LostFocus, Bouton_Jouer.LostFocus,
                        Bouton_Tableau.LostFocus, Bouton_Prouesses.LostFocus

        sender.BackColor = Color.White
    End Sub

    'Lorsqu'on clique sur le bouton "Afficher les scores"
    Private Sub Bouton_Tableau_Click(sender As Object, e As EventArgs) Handles _
                                                        Bouton_Tableau.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        Hide()
        Scores.Show()
    End Sub

    'Lorsqu'on clique sur le bouton "Prouesses"
    Private Sub Bouton_Prouesses_Click(sender As Object, e As EventArgs) Handles _
                                                        Bouton_Prouesses.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        Hide()
        Prouesses.Show()
    End Sub
End Class
