Imports System.ComponentModel

Public Class Scores
    Private malFermé As Boolean = True

    'Lorsqu'on clique sur le bouton "Retour"
    Private Sub Bouton_Retour_Click(sender As Object, e As EventArgs) Handles _
                                                        Bouton_Retour.Click
        My.Computer.Audio.Play("Sons\Quitter.wav")
        Dim réponse As String = MsgBox("Souhaitez-vous retourner au menu principal ?",
                                       vbYesNo + vbQuestion, "Confirmation")

        If réponse = MsgBoxResult.Yes Then
            malFermé = False
            Close()
            MenuPrincipal.Show()
        End If

    End Sub

    'Lorsqu'on ouvre le formulaire
    Private Sub Scores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initListBox_Nom()
        initListBox_Tps()
    End Sub

    'Lorsque la souris n'est plus sur le bouton "Retour"
    Private Sub Bouton_Retour_MouseLeave(sender As Object, e As EventArgs) Handles _
                                                        Bouton_Retour.MouseLeave
        sender.backcolor = Color.White
        Me.Cursor = Cursors.Arrow
    End Sub

    'Lorsque la souris est sur le bouton "Retour"
    Private Sub Bouton_Retour_MouseHover(sender As Object, e As EventArgs) Handles _
                                                    Bouton_Retour.MouseHover
        sender.backcolor = Color.Red
        Me.Cursor = Cursors.No
    End Sub

    'Lorsque le joueur clique sur un nom dans la listbox
    Private Sub ListBox_Nom_Cliqué(sender As Object, e As EventArgs) Handles _
                ListBox_Nom.SelectedIndexChanged, ListBox_Tps.SelectedIndexChanged

        Dim sélectionné As Integer = sender.selectedindex

        'La synchronisation
        ListBox_Nom.SelectedIndex = sélectionné
        ListBox_Tps.SelectedIndex = sélectionné

    End Sub

    'Lorsque le joueur clique sur "Tirer par ordre alphabétique"
    Private Sub Bouton_Trier_Alpha_Click(sender As Object, e As EventArgs) Handles _
                                                            Bouton_Trier_Alpha.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        ListBox_Nom.Sorted = True
        initListBox_Tps()
    End Sub

    'Lorsque le joueur clique sur "Tirer par meilleur temps"
    Private Sub Bouton_Trier_Tps_Click(sender As Object, e As EventArgs) Handles _
                                                         Bouton_Trier_Tps.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        ListBox_Nom.Sorted = False

        'On utilise le tri à bulle
        Dim swap As Boolean
        Do
            swap = False
            For i As Integer = 0 To ListBox_Nom.Items.Count - 2
                If getJoueur(ListBox_Nom.Items(i + 1)).getRecord <
                    getJoueur(ListBox_Nom.Items(i)).getRecord Then

                    Dim tmp As String = ListBox_Nom.Items(i)
                    Dim tmp2 As Integer = ListBox_Tps.Items(i)
                    ListBox_Nom.Items.RemoveAt(i)
                    ListBox_Tps.Items.RemoveAt(i)
                    ListBox_Nom.Items.Insert(i + 1, tmp)
                    ListBox_Tps.Items.Insert(i + 1, tmp2)
                    swap = True
                End If
            Next i
        Loop While swap 'Tant qu'on a échangé des valeurs
    End Sub

    'Lorsque le joueur clique sur "Voir statistiques"
    Private Sub Bouton_Stats_Click(sender As Object, e As EventArgs) Handles _
                                                         Bouton_Stats.Click
        If ListBox_Nom.SelectedItem = "" Then
            MsgBox("Aucun joueur n'a été sélectionné!", vbCritical, "Erreur")
            Exit Sub
        End If
        My.Computer.Audio.Play("Sons\Bouton.wav")

        '==== CONSTRUCTION DE LA CHAINE DE CARACTERES ====
        MsgBox(toStringStats(ListBox_Nom.SelectedItem), vbInformation + vbOKOnly,
               "Statistiques du joueur " & ListBox_Nom.SelectedItem)
    End Sub

    Private Sub Bouton_Charger_Click(sender As Object, e As EventArgs) Handles _
                                                            Bouton_Charger.Click
        chargerJoueurs()
    End Sub

    Private Sub Bouton_Sauvegarder_Click(sender As Object, e As EventArgs) Handles _
                                                        Bouton_Sauvegarder.Click
        sauvegarderJoueurs()
    End Sub

    Private Sub Scores_Closing(sender As Object, e As CancelEventArgs) Handles _
                                                            Me.Closing
        If malFermé Then End
    End Sub
End Class