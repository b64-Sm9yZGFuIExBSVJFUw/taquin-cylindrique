Imports System.ComponentModel

Public Class Options
    Private malFermé As Boolean = True

    'Quand la souris est sur un bouton
    Private Sub Souris_Sur_Bouton(sender As Object, e As EventArgs) Handles _
                            Bouton_Enrg.MouseHover, Bouton_Annuler.MouseHover

        If sender Is Bouton_Annuler Then
            sender.backcolor = Color.Red
            Me.Cursor = Cursors.No
        Else
            sender.backcolor = Color.Green
        End If
    End Sub

    'Quand la souris n'est plus sur le bouton
    Private Sub Souris_Plus_Sur_Bouton(sender As Object, e As EventArgs) _
                Handles Bouton_Annuler.MouseLeave, Bouton_Enrg.MouseLeave

        sender.backcolor = Color.White
        Me.Cursor = Cursors.Arrow
    End Sub

    'Quand on clique sur le bouton "Annuler"
    Private Sub Bouton_Annuler_Click(sender As Object, e As EventArgs) _
                                            Handles Bouton_Annuler.Click

        My.Computer.Audio.Play("Sons\Quitter.wav")
        Dim réponse As String = MsgBox(
            "Voulez-vous quitter sans enregistrer ?", vbQuestion +
            vbYesNo, "Confirmation")

        If réponse = MsgBoxResult.Yes Then
            malfermé = False
            Close()
            SaisieNom.Show()
        End If
    End Sub

    'Quand on clique sur "Enregistrer"
    Private Sub Bouton_Enrg_Click(sender As Object, e As EventArgs) Handles _
                                                            Bouton_Enrg.Click

        If getTimerActif() And (TextBox_Timer.Text = "" Or TextBox_Timer.Text = "0") Then
            MsgBox("Le timer entré est incorrect!", vbCritical + vbOKOnly, "Erreur")
            Exit Sub
        End If

        My.Computer.Audio.Play("Sons\Bouton.wav")
        Dim réponse As String = MsgBox("Voulez-vous enregistrer les options ?",
                                       vbQuestion + vbYesNo, "Confirmation")

        If réponse = MsgBoxResult.Yes Then
            'On modifie donc les options du jeu présents dans le module JEU
            Taquin.setTemps(TextBox_Timer.Text)
            If RadioButton_Metallique.Checked Then setGraphismes("Metallique")
            If RadioButton_Aquatique.Checked Then setGraphismes("Aquatique")
            If RadioButton_Feu.Checked Then setGraphismes("Feu")
            If RadioButton_Espace.Checked Then setGraphismes("Espace")

            If RadioButton_MuteCity.Checked Then setMusiqueFond("
                                             Sons\Partie_MuteCity.wav")

            If RadioButton_N.Checked Then setMusiqueFond("Sons\Partie_N.wav")

            If RadioButton_Mario.Checked Then setMusiqueFond("
                                             Sons\Partie_Mario.wav")

            If RadioButton_noMusic.Checked Then setMusiqueFond("Pas de musique")

            If CheckBox_désacTimer.Checked Then
                setTimerActif(False)
            Else
                setTimerActif(True)
            End If

            If CheckBox_SauvAuto.Checked Then
                setSauvAuto(True)
            Else
                setSauvAuto(False)
            End If

            If CheckBox_NonCylindrique.Checked Then
                setCylindrique(False)
            Else
                setCylindrique(True)
            End If
            My.Computer.Audio.Play("Sons\Sauvegardé.wav")
            malFermé = False
            Close()
            SaisieNom.Show()
        End If
    End Sub

    'Quand on tape quelque chose dans la textbox (Vérification si on entre un chiffre)
    Private Sub TextBox_Timer_KeyPress(sender As Object,
                         e As KeyPressEventArgs) Handles TextBox_Timer.KeyPress

        If e.KeyChar = vbBack Then
            Exit Sub
        End If

        If e.KeyChar >= "A" Or e.KeyChar <= "z" Then
            e.Handled = True
        End If

        If e.KeyChar < "0" And e.KeyChar > "9" Then
            e.Handled = True
        End If

        If e.KeyChar >= "0" And e.KeyChar <= "9" Then
            e.Handled = False
        End If
    End Sub

    'Si on a modifié le texte d'une manière spéciale (Copié, surligné, etc.)
    Private Sub TextBox_Timer_TextChanged(sender As Object, e As EventArgs) _
                                          Handles TextBox_Timer.TextChanged

        'Si on colle autre chose que des chiffres, il ne fait rien
        If Char.IsLetter(TextBox_Timer.Text) Then TextBox_Timer.Text = ""
    End Sub

    'Quand le formulaire se lance
    Private Sub Options_Load(sender As Object, e As EventArgs) Handles _
                                                             MyBase.Load
        'On met les valeurs 
        Select Case getMusiqueFond()
            Case "Sons\Partie_MuteCity.wav"
                RadioButton_MuteCity.Checked = True
            Case "Sons\Partie_N.wav"
                RadioButton_N.Checked = True
            Case "Sons\Partie_Mario.wav"
                RadioButton_Mario.Checked = True
            Case "Pas de musique"
                RadioButton_noMusic.Checked = True
        End Select

        Select Case getGraphismes()
            Case "Metallique"
                RadioButton_Metallique.Checked = True
            Case "Aquatique"
                RadioButton_Aquatique.Checked = True
            Case "Feu"
                RadioButton_Feu.Checked = True
            Case "Espace"
                RadioButton_Espace.Checked = True
        End Select

        TextBox_Timer.Text = Taquin.getTemps

        CheckBox_SauvAuto.Checked = getSauvAuto()
        CheckBox_NonCylindrique.Checked = Not estCylindrique() 'L'inverse

        CheckBox_désacTimer.Checked = Not getTimerActif()

    End Sub

    'Quand l'état de la checkbox "Sauvegarde automatique" change
    Private Sub CheckBox_SauvAuto_CheckedChanged(sender As Object, e As EventArgs) _
                                             Handles CheckBox_SauvAuto.CheckedChanged

        'Si on viens d'activer la sauvegarde automatique
        If sender.checked And Not getSauvAuto() Then
            Dim r As String = MsgBox("Attention, à chaque abandon ou après une partie" _
                           & " gagnée, la sauvegarde précédente sera toujours écrasée.",
                                               vbCritical + vbYesNo, "Êtes-vous sûr ?")

            If r = MsgBoxResult.Yes Then
                sender.checked = True
            Else
                sender.checked = False
            End If
        End If
    End Sub

    'Quand le formulaire se ferme
    Private Sub Options_Closing(sender As Object, e As CancelEventArgs) Handles _
                                                                    Me.Closing
        If malFermé Then End 'Si le joueur a fermé de lui-même le formulaire
    End Sub

    'Quand l'état de la checkbox "Désactiver le timer" change
    Private Sub CheckBox_désacTimer_CheckedChanged(sender As Object, e As EventArgs) _
                                         Handles CheckBox_désacTimer.CheckedChanged

        'Si on viens de désactiver le timer
        If sender.checked And getTimerActif() Then
            Dim rep As String = MsgBox("Le timer sera maintenant votre temps de jeu " &
                                       "durant la partie. ", vbQuestion + vbYesNo,
                                                             "Voulez-vous continuer?")

            If rep = MsgBoxResult.Yes Then
                TextBox_Timer.Enabled = False
            Else
                TextBox_Timer.Enabled = True
                sender.checked = False
                Exit Sub
            End If

            'Si on réactive le timer
        ElseIf Not sender.checked Then
            TextBox_Timer.Enabled = True
            'Si le timer était déjà désactivé et qu'on le re-désactive
        ElseIf sender.checked Then
            TextBox_Timer.Enabled = False
        End If
    End Sub

    'Quand on clique sur "Sauvegarder"
    Private Sub Bouton_Sauvegarder_Click(sender As Object, e As EventArgs) Handles _
                                                            Bouton_Sauvegarder.Click
        sauvegarderOptions()
    End Sub

    'Quand on clique sur "Charger"
    Private Sub Bouton_Charger_Click(sender As Object, e As EventArgs) Handles _
                                                        Bouton_Charger.Click
        chargerOptions()
    End Sub
End Class