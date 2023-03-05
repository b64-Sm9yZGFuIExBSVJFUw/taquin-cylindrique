Imports System.ComponentModel

Public Class SaisieNom
    Private malFermé As Boolean = True 'Le jeu a-t-il été mal fermé ?

    'Quand on clique sur "Annuler"
    Private Sub BoutonAnnuler_Click(sender As Object, e As EventArgs) Handles _
                                                        Bouton_Annuler.Click
        My.Computer.Audio.Play("Sons\Quitter.wav")
        Dim réponse As String = MsgBox("Voulez-vous annuler?", vbQuestion +
                                       vbYesNo, "Confirmation")

        If réponse = MsgBoxResult.Yes Then
            malFermé = False 'Ce n'est pas le joueur qui l'a fermé
            Close()
            MenuPrincipal.Show()
        End If
    End Sub

    'Quand on clique sur "Confirmer"
    Private Sub BoutonConfirmer_Click(sender As Object, e As EventArgs) _
                                        Handles Bouton_Confirmer.Click

        My.Computer.Audio.Play("Sons\Bouton.wav")
        Dim réponse As String = MsgBox(Saisie_Nom.Text &
            " est bien votre nom ?", vbInformation + vbYesNo,
            "Confirmation")

        If réponse = MsgBoxResult.Yes Then
            My.Computer.Audio.Play("Sons\Partie.wav")
            Taquin.setJoueur(nouvellePartie(Saisie_Nom.Text))

            'Le secret du jeu
            If Saisie_Nom.Text = "ParisDescartes" Then Taquin.setParisDescartes(True)

            'Un autre secret pour afficher le générique
            If Saisie_Nom.Text = "Credits" Then
                malFermé = False
                Close()
                Prouesses.credits = True
                Prouesses.Show()
            End If

            malFermé = False
            Close()
            Taquin.Show()
        End If
    End Sub

    'Quand on tape quelque chose dans la textbox (Vérification si on entre une lettre)
    Private Sub Saisie_Nom_KeyPress(sender As Object, e As KeyPressEventArgs) _
                                                Handles Saisie_Nom.KeyPress
        If e.KeyChar = vbBack Then
            'S'il restera 1 caractère ou moins
            If Saisie_Nom.Text.Length <= 2 Then Bouton_Confirmer.Enabled = False
            Exit Sub
        End If

        'Si c'est autre chose que des lettres
        If e.KeyChar < "A" Or e.KeyChar > "z" Then
            e.Handled = True
        End If

        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            e.Handled = True
        End If

        If Char.IsLetter(Saisie_Nom.Text) Then
            Bouton_Confirmer.Enabled = True
        Else
            Bouton_Confirmer.Enabled = False
        End If
    End Sub

    'Quand un bouton obtient le focus
    Private Sub Focus_Bouton(sender As Object, e As EventArgs) Handles _
                 Bouton_Annuler.GotFocus, Bouton_Confirmer.GotFocus,
                 Bouton_Options.GotFocus

        If sender Is Bouton_Confirmer Then
            sender.BackColor = Color.Green
        ElseIf sender Is Bouton_Annuler Then
            sender.BackColor = Color.Red
        Else 'Si c'est le bouton "Options..."
            sender.backcolor = Color.Yellow
        End If
    End Sub

    'Quand un bouton perd le focus
    Private Sub Focus_Plus_Bouton(sender As Object, e As EventArgs) Handles _
                     Bouton_Annuler.LostFocus, Bouton_Confirmer.LostFocus,
                     Bouton_Options.LostFocus

        sender.BackColor = Color.White
    End Sub

    'Quand la souris est sur un bouton
    Private Sub Souris_Sur_Bouton(sender As Object, e As EventArgs) Handles _
                     Bouton_Annuler.MouseHover, Bouton_Confirmer.MouseHover,
                     Bouton_Options.MouseHover

        If sender Is Bouton_Confirmer Then
            sender.BackColor = Color.Green
            'Si l'un était focus, la priorité sur le mousehover
            Bouton_Annuler.BackColor = Color.White
            Bouton_Options.BackColor = Color.White
        ElseIf sender Is Bouton_Annuler Then
            sender.BackColor = Color.Red
            Bouton_Confirmer.BackColor = Color.White
            Bouton_Options.BackColor = Color.White
            Me.Cursor = Cursors.No
        Else 'Si c'est le bouton "Options"
            sender.backcolor = Color.Yellow
            Bouton_Confirmer.BackColor = Color.White
            Bouton_Annuler.BackColor = Color.White
        End If

    End Sub

    'Quand la souris n'est plus sur le bouton
    Private Sub Souris_Plus_Sur_Bouton(sender As Object, e As EventArgs) _
        Handles Bouton_Annuler.MouseLeave, Bouton_Confirmer.MouseLeave,
        Bouton_Options.MouseLeave

        sender.BackColor = Color.White
        Me.Cursor = Cursors.Arrow
    End Sub

    'Si on a choisi un nom qui était dans la ComboBox
    Private Sub Saisie_Nom_SelectedIndexChanged(sender As Object,
                        e As EventArgs) Handles Saisie_Nom.SelectedIndexChanged

        Bouton_Confirmer.Enabled = True
    End Sub

    'Si on clique sur le bouton "Options"
    Private Sub Bouton_Options_Click(sender As Object, e As EventArgs) Handles _
                                                            Bouton_Options.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        malFermé = False
        Close()
        Options.Show()
    End Sub

    'Si on a modifié le texte d'une manière spéciale (Copié, surligné, etc.)
    Private Sub Saisie_Nom_TextChanged(sender As Object, e As EventArgs) _
                                          Handles Saisie_Nom.TextChanged

        If Saisie_Nom.Text.Length < 2 Then Bouton_Confirmer.Enabled = False

        If Char.IsLetter(Saisie_Nom.Text) And Saisie_Nom.Text.Length > 1 Then
            Bouton_Confirmer.Enabled = True
        End If
    End Sub

    'Quand le formulaire se ferme
    Private Sub SaisieNom_Closing(sender As Object, e As CancelEventArgs) Handles _
                                                                        Me.Closing

        'Si c'est le joueur qu'il l'a fermé de lui-même, le programme s'arrête
        If malFermé Then End
    End Sub

    'Quand le formulaire s'ouvre
    Private Sub SaisieNom_Load(sender As Object, e As EventArgs) Handles _
                                                                Me.Load
        initComboBox()
    End Sub
End Class