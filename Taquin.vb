Imports System.ComponentModel 'Pour le sub "Closing"
Imports System.IO

Public Class Taquin
    Private parisDescartes As Boolean = False 'Le secret
    Private tempsInitial As Integer = 120 'Par défaut
    Private tempsRestant As Integer
    Private mouvements As Integer 'Nb de mouvements
    Private pause As Boolean = False 'Le jeu est-t-il en pause ?
    Private joueur As Joueur 'Le joueur qui joue actuellement
    Private malFermé As Boolean = True 'Le jeu a-t-il été mal fermé ?
    Private commencé As Boolean = False 'La partie a-t-elle commencée ?
    'Le joueur a-t-il cliqué sur "Voir la solution" ?
    Private solutionDonnée As Boolean = False
    'Le joueur a-t-il cliqué sur "Voir prochain mouvement" ?
    Private mouvementDonné As Boolean = False

    'Compteur de mouvements effectués lors de la randomization 
    '(Evite les "nombres magiques")
    Private nbMouvementsRandom As Integer = 0

    'Quand on appelle le sub "Attendre", combien de ms
    Private msAttente As Integer = 0

    Public Sub setTemps(ByVal tps As Integer)
        tempsInitial = tps
    End Sub

    Public Function getTemps() As Integer
        Return tempsInitial
    End Function

    'Met à jour le joueur actuel
    Public Sub setJoueur(ByVal j As Joueur)
        joueur = j
    End Sub

    '
    Public Sub setParisDescartes(ByVal val As Boolean)
        parisDescartes = val
    End Sub

    'Quand on lance le formulaire
    Private Sub Taquin_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Si c'est pas les graphismes par défaut, il faut les charger
        If getGraphismes() <> "Metallique" Then loadGraphismes()

        'On initialise les labels
        Label_Joueur.Text &= " " & joueur.getNom
        Temps.Text = tempsInitial

        If getTimerActif() Then 'Si le timer est activé
            tempsRestant = tempsInitial
        Else 'Sinon, le temps restant sera le temps du joueur
            tempsRestant = 0
        End If

        'On commence la randomization du taquin
        Timer_Random.Start()

        '100 mouvements à faire
        While nbMouvementsRandom < 100
            Application.DoEvents()
        End While

        'Fin de la randomization
        Timer_Random.Stop()

        'Si c'est le secret ParisDescartes
        If parisDescartes Then
            For Each pièce As Button In PanelPieces.Controls
                'Alors les boutons ont le logo en image
                pièce.BackgroundImage = System.Drawing.Image.FromFile(
                    "Images\ParisDescartes\" & pièce.Text & ".png")
            Next pièce

            'S'il n'avait pas déjà la prouesse, il l'obtient
            If Not détective Then estDétective()
        End If

        'La partie commence !
        Timer.Enabled = True
        commencé = True
        Timer.Start()

        If getMusiqueFond() <> "Pas de musique" Then
            'On joue la musique en boucle
            MenuPrincipal.Musique.URL = getMusiqueFond()
            MenuPrincipal.Musique.settings.setMode("loop", True)
        End If
    End Sub

    'Pour au début de la partie, randomizer le taquin à partir du résolu
    Private Sub Timer_Random_Tick(sender As Object, e As EventArgs) Handles _
                                                               Timer_Random.Tick
        'S'il est utilisé pour randomizer le taquin (Donc la partie pas commencée)
        '(Car il est aussi utilisé pour le sub "Attendre")
        If Not commencé Then
            nbMouvementsRandom += 1
            Dim r As Random = New Random()
            Dim mouvement As Integer = r.Next(4)

            If mouvement = 0 Then 'Haut
                If pièceVide.Tag > 4 Then
                    Piece_Click(getButtonAtTag(pièceVide.Tag - 4), e)
                End If
            ElseIf mouvement = 1 Then 'Gauche
                If pièceVide.Tag <> 1 And pièceVide.Tag <> 5 And pièceVide.Tag <> 9 And
                                                            pièceVide.Tag <> 13 Then
                    Piece_Click(getButtonAtTag(pièceVide.Tag - 1), e)
                End If
            ElseIf mouvement = 2 Then 'Bas
                If pièceVide.Tag < 13 Then
                    Piece_Click(getButtonAtTag(pièceVide.Tag + 4), e)
                End If
            Else 'Droite
                If pièceVide.Tag <> 4 And pièceVide.Tag <> 8 And pièceVide.Tag <> 12 And
                                                            pièceVide.Tag <> 16 Then
                    Piece_Click(getButtonAtTag(pièceVide.Tag + 1), e)
                End If
            End If
        Else 'S'il est utilisé pour attendre
            msAttente -= 1
        End If
    End Sub

    'Utilisée uniquement dans la randomization: Sert à récupérer la case vide
    Private Function pièceVide() As Button
        For Each pièce As Button In PanelPieces.Controls
            If Not pièce.Visible Then Return pièce
        Next pièce

        Return Nothing
    End Function

    'Renvoie le bouton qui a comme tag le nombre en paramètre
    Private Function getButtonAtTag(ByVal tag As Integer) As Button
        For Each pièce As Button In PanelPieces.Controls
            If pièce.Tag = tag Then Return pièce
        Next pièce

        Return Nothing
    End Function

    'Quand on clique sur le bouton "Abandonner"
    Private Sub ButtonAbandonner_Click(sender As Object, e As EventArgs) Handles _
                                                            ButtonAbandonner.Click
        My.Computer.Audio.Play("Sons\Abandonner.wav")
        Dim réponse As String = MsgBox("Êtes-vous sûr de vouloir abandonner?",
                                        vbCritical + vbYesNo, "Confirmation")

        If réponse = MsgBoxResult.Yes Then
            MenuPrincipal.Musique.Ctlcontrols.stop() 'Fin de la musique

            'On met donc à jour les statistiques du joueur
            joueur.additionneCumulTemps(tempsInitial - tempsRestant)
            joueur.additionneCumulMouvements(mouvements)
            If getSauvAuto() Then sauvegarderJoueurs()

            'A-t-il réussi des prouesses ?
            If Not habile Then estHabile()
            If Not sans_vie Then estSansVie()

            'La fênetre n'a pas été fermée par le joueur, mais par le bouton
            malFermé = False
            Close()
            MenuPrincipal.Show()
        End If
    End Sub

    'Quand la souris est sur le bouton "Abandonner"
    Private Sub Souris_Sur_Abandonner(sender As Object, e As EventArgs) _
                                       Handles ButtonAbandonner.MouseHover
        Me.Cursor = Cursors.No
        sender.foreColor = Color.Red

        'Le texte "ABANDONNER" passe en gras
        sender.Font = New Font(ButtonAbandonner.Font, FontStyle.Bold)
    End Sub

    'Quand la souris n'est plus sur le bouton "Abandonner"
    Private Sub Souris_Plus_Sur_Abandonner(sender As Object, e As EventArgs) _
                                          Handles ButtonAbandonner.MouseLeave
        Me.Cursor = Cursors.Cross
        sender.foreColor = Color.Black

        'Le texte "ABANDONNER" revient à la normale
        sender.Font = New Font(ButtonAbandonner.Font, FontStyle.Regular)
    End Sub

    'Quand on clique sur une pièce du Taquin
    Private Sub Piece_Click(sender As Object, e As EventArgs) Handles _
        Piece_1.Click, Piece_2.Click, Piece_3.Click, Piece_4.Click,
        Piece_5.Click, Piece_6.Click, Piece_7.Click, Piece_8.Click,
        Piece_9.Click, Piece_10.Click, Piece_11.Click, Piece_12.Click,
        Piece_13.Click, Piece_14.Click, Piece_15.Click, Piece_16.Click

        If Not pause Then
            'S'il peut bouger
            If peutBouger(sender) Then
                ' =============== ON ECHANGE LES VALEURS DES PIECES =============
                Dim tmp As Integer = pièceVide().Text
                pièceVide().Text = sender.Text
                sender.Text = tmp

                If parisDescartes Then 'Si c'est le secret ParisDescartes
                    'On échange donc les images des pièces
                    pièceVide().BackgroundImage =
                        System.Drawing.Image.FromFile(
                         "Images\ParisDescartes\" & pièceVide().Text & ".png")

                    sender.Text = tmp

                    sender.BackgroundImage = System.Drawing.Image.FromFile(
                                        "Images\ParisDescartes\" & tmp & ".png")
                End If

                'La case cliquée devient vide dans le taquin et la vide visible
                pièceVide().Visible = True
                sender.visible = False

                My.Computer.Audio.Play("Sons\Bougé.wav")

                'Les mouvements dûs à la randomization et ceux faits par le solveur 
                'ne comptent pas
                If commencé And Not solutionDonnée AndAlso Not mouvementDonné Then
                    mouvements += 1
                End If

                'S'il a gagné 
                If partie_gagnée() And commencé Then
                    Timer.Stop()
                    MenuPrincipal.Musique.Ctlcontrols.stop() 'Fin de la musique
                    My.Computer.Audio.Play("Sons\Gagné.wav")

                    If Not solutionDonnée And Not mouvementDonné Then
                        'On met à jour les statistiques
                        If getTimerActif() Then
                            joueur.ajouterRecord(tempsInitial - tempsRestant)
                        Else
                            'Le temps joué
                            joueur.ajouterRecord(tempsRestant)
                        End If

                        joueur.additionneCumulMouvements(mouvements)

                        If getTimerActif() Then
                            MsgBox("Vous avez résolu le taquin en " & tempsInitial -
                           tempsRestant & " secondes et en " & mouvements &
                           " mouvements! Bravo!!", vbInformation, "Bravo!")
                        Else
                            MsgBox("Vous avez résolu le taquin en " & tempsRestant &
                               " secondes et en " & mouvements &
                           " mouvements! Bravo!!", vbInformation, "Bravo!")
                        End If


                        If getSauvAuto() Then sauvegarderJoueurs()

                        'A-t-il réussi des prouesses ?
                        If Not habile Then estHabile()
                        If Not sans_vie Then estSansVie()
                        If Not invincible Then estInvincible()
                        If Not champion Then estChampion()

                        'A-t-il réussi la prouesse "Einstein"?
                        If mouvements < 50 And Not einstein Then
                            einstein = True
                            My.Computer.Audio.Play("Sons\Prouesse.wav")
                            MsgBox("Vous avez réussi en moins de 50 mouvements !",
                               vbInformation, "PROUESSE EINSTEIN REUSSIE!")

                            'S'il a toutes les prouesses
                            If champion AndAlso habile AndAlso invincible AndAlso
                            einstein AndAlso détective AndAlso sans_vie Then
                                aToutRéussi()
                            End If
                        End If

                        malFermé = False
                        Close()
                        MenuPrincipal.Show()
                    Else 'Si la solution a été donnée (Cliqué sur "Voir solution")
                        'Mais si la partie finit avec un mouvement donné
                        If mouvementDonné Then

                            joueur.additionneCumulMouvements(mouvements)
                            If getTimerActif() Then
                                joueur.ajouterRecord(tempsInitial - tempsRestant)
                            Else
                                'Le temps joué
                                joueur.ajouterRecord(tempsRestant)
                            End If

                        End If
                        MsgBox("Et voilà ! La prochaine fois, tentez seul !",
                               vbInformation, "Fini!")

                        malFermé = False
                        Close()
                        MenuPrincipal.Show()
                    End If
                End If
            End If
        Else 'Si le jeu est en pause
            MsgBox("Le jeu est en pause !", vbInformation, "En pause")
        End If
    End Sub

    'C'est l'évènement Tick du timer du jeu.
    Private Sub Seconde_En_Moins(sender As Object, e As EventArgs) Handles _
                                                                Timer.Tick
        If getTimerActif() Then
            'Si temps écoulé et que ce n'est pas en même temps que le solveur joue
            If tempsRestant <= 0 And Not solutionDonnée Then
                Timer.Stop()
                joueur.additionneCumulMouvements(mouvements)
                joueur.additionneCumulTemps(tempsInitial)
                MenuPrincipal.Musique.Ctlcontrols.stop() 'Fin de la musique
                My.Computer.Audio.Play("Sons\Perdu.wav")

                MsgBox("Temps écoulé, vous avez perdu !", vbInformation,
                                                         "Perdu...")
                malFermé = False
                Close()
                MenuPrincipal.Show()
                Exit Sub
            End If

            'Quand la solution est montrée, le temps s'arrête
            If Not solutionDonnée Then tempsRestant -= 1

            Temps.Text = tempsRestant

            If tempsRestant <= 10 Then 'S'il reste moins de 10 secondes
                MenuPrincipal.Musique.Ctlcontrols.fastForward() 'La musique accélère
            End If
        Else 'Si le timer est désactivé
            Temps.Text = tempsRestant
            tempsRestant += 1 'On affiche donc le temps écoulé
        End If
    End Sub

    'Renvoie si oui ou non, la pièce peut bouger
    'J'ai du tout faire à la main...
    Public Function peutBouger(ByVal pièce As Button) As Boolean
        If estAuMilieuEnHaut(pièce) Or estAuMilieuEnBas(pièce) Then
            If Not getButtonAtTag(pièce.Tag + 1).Visible Then Return True
            If Not getButtonAtTag(pièce.Tag - 1).Visible Then Return True
        End If

        If estEnHautAGauche(pièce) Or estEnBasAGauche(pièce) Then
            If Not getButtonAtTag(pièce.Tag + 1).Visible Then Return True
            If estCylindrique() Then
                If Not getButtonAtTag(pièce.Tag + 3).Visible Then Return True
            End If
        End If

        If estEnHautADroite(pièce) Or estEnBasADroite(pièce) Then
            If Not getButtonAtTag(pièce.Tag - 1).Visible Then Return True
            If estCylindrique() Then
                If Not getButtonAtTag(pièce.Tag - 3).Visible Then Return True
            End If
        End If

        If estEnHaut(pièce) Then
            If Not getButtonAtTag(pièce.Tag + 4).Visible Then Return True
        End If

        If estEnBas(pièce) Then
            If Not getButtonAtTag(pièce.Tag - 4).Visible Then Return True
        End If

        If estAuMilieuDuTaquin(pièce) Then
            If Not getButtonAtTag(pièce.Tag + 1).Visible Then Return True
            If Not getButtonAtTag(pièce.Tag - 1).Visible Then Return True
            If Not getButtonAtTag(pièce.Tag + 4).Visible Then Return True
            If Not getButtonAtTag(pièce.Tag - 4).Visible Then Return True
        End If

        If estAuMilieuEnBas(pièce) Then
            If Not getButtonAtTag(pièce.Tag - 4).Visible Then Return True
        End If

        If estAuMilieuEnHaut(pièce) Then
            If Not getButtonAtTag(pièce.Tag + 4).Visible Then Return True
        End If

        If estAuMilieuAGauche(pièce) Then
            If Not getButtonAtTag(pièce.Tag + 1).Visible Then Return True
            If Not getButtonAtTag(pièce.Tag + 4).Visible Then Return True
            If Not getButtonAtTag(pièce.Tag - 4).Visible Then Return True
            If estCylindrique() Then
                If Not getButtonAtTag(pièce.Tag + 3).Visible Then Return True
            End If
        End If

        If estAuMilieuADroite(pièce) Then
            If Not getButtonAtTag(pièce.Tag - 1).Visible Then Return True
            If Not getButtonAtTag(pièce.Tag + 4).Visible Then Return True
            If Not getButtonAtTag(pièce.Tag - 4).Visible Then Return True
            If estCylindrique() Then
                If Not getButtonAtTag(pièce.Tag - 3).Visible Then Return True
            End If
        End If

        Return False
    End Function
    '========================POUR LES POSITIONS UTILISEES CI-DESSUS================
    '==================== PARTIE HAUTE =====================
    Public Function estEnHaut(ByVal pièce As Button) As Boolean
        Return pièce.Tag > 0 And pièce.Tag < 5
    End Function

    Public Function estAuMilieuEnHaut(ByVal pièce As Button) As Boolean
        Return pièce.Tag = 2 Or pièce.Tag = 3
    End Function

    Public Function estEnHautAGauche(ByVal pièce As Button) As Boolean
        Return pièce.Tag = 1
    End Function

    Public Function estEnHautADroite(ByVal pièce As Button) As Boolean
        Return pièce.Tag = 4
    End Function

    '==================== PARTIE MILIEU =====================
    Public Function estAuMilieuDuTaquin(ByVal pièce As Button) As Boolean
        Return pièce.Tag > 5 And pièce.Tag <> 8 AndAlso pièce.Tag <> 9 AndAlso
                                            pièce.Tag < 12
    End Function

    Public Function estAuMilieuAGauche(ByVal pièce As Button) As Boolean
        Return pièce.Tag = 5 Or pièce.Tag = 9
    End Function

    Public Function estAuMilieuADroite(ByVal pièce As Button) As Boolean
        Return pièce.Tag = 8 Or pièce.Tag = 12
    End Function

    '==================== PARTIE BASSE =====================
    Public Function estEnBas(ByVal pièce As Button) As Boolean
        Return pièce.Tag > 12 And pièce.Tag < 17
    End Function

    Public Function estAuMilieuEnBas(ByVal pièce As Button) As Boolean
        Return pièce.Tag = 14 Or pièce.Tag = 15
    End Function

    Public Function estEnBasAGauche(ByVal pièce As Button) As Boolean
        Return pièce.Tag = 13
    End Function

    Public Function estEnBasADroite(ByVal pièce As Button) As Boolean
        Return pièce.Tag = 16
    End Function


    'Renvoie si le joueur a gagné la partie (Appellée à chaque mouvements)
    Private Function partie_gagnée() As Boolean
        For Each piece As Button In PanelPieces.Controls
            'Le tag contient ce que la pièce est sensée avoir
            If piece.Text <> piece.Tag Then Return False
        Next piece

        'Si toutes les pièces sont au bon endroit (Text = Tag)
        Return True
    End Function

    'Charge les graphismes quand ce n'est pas ceux par défaut (<> Métallique)
    Private Sub loadGraphismes()
        'Donc ici, on va récupérer dans le dossier "Images" les graphismes
        If getGraphismes() = "Metallique" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Taquin_Bg.png")
            PanelPieces.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\PanelPieces_bg.png")
            ButtonAbandonner.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\ABANDONNER_bg.jpg")

            For Each piece As Button In PanelPieces.Controls
                piece.BackgroundImage = System.Drawing.Image.FromFile(
                    "Images\Taquin_Piece.png")
                piece.ForeColor = Color.Blue
            Next piece

        ElseIf getGraphismes() = "Aquatique" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Aquatique\Taquin_Bg.jpg")
            PanelPieces.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Aquatique\PanelPieces_bg.jpg")
            ButtonAbandonner.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Aquatique\ABANDONNER_bg.jpg")

            For Each piece As Button In PanelPieces.Controls
                piece.BackgroundImage = System.Drawing.Image.FromFile(
                    "Images\Graphismes_Aquatique\Taquin_Piece.jpg")
                If Not parisDescartes Then piece.ForeColor = Color.Cyan
            Next piece
        ElseIf getGraphismes() = "Feu" Then
            Me.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Feu\Taquin_Bg.jpg")
            PanelPieces.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Feu\PanelPieces_bg.jpg")
            ButtonAbandonner.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Feu\ABANDONNER_bg.jpg")

            For Each piece As Button In PanelPieces.Controls
                piece.BackgroundImage = System.Drawing.Image.FromFile(
                    "Images\Graphismes_Feu\Taquin_Piece.jpg")
                If Not parisDescartes Then piece.ForeColor = Color.Orange
            Next piece

            Label_Joueur.ForeColor = Color.White
        Else 'Si c'est espace
            Me.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Espace\Taquin_Bg.jpg")
            PanelPieces.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Espace\PanelPieces_bg.jpg")
            ButtonAbandonner.BackgroundImage = System.Drawing.Image.FromFile(
                "Images\Graphismes_Espace\ABANDONNER_bg.jpg")
            Label_Joueur.ForeColor = Color.White

            For Each piece As Button In PanelPieces.Controls
                piece.BackgroundImage = System.Drawing.Image.FromFile(
                    "Images\Graphismes_Espace\Taquin_Piece.jpg")
                If Not parisDescartes Then piece.ForeColor = Color.White
            Next piece
        End If

    End Sub

    'Quand l'état de la checkbox "Pause" a changée
    Private Sub CheckBox_Pause_CheckedChanged(sender As Object, e As EventArgs) _
                                             Handles CheckBox_Pause.CheckedChanged
        My.Computer.Audio.Play("Sons\Pause.wav")

        If sender.checked Then 'Si c'est en pause
            MenuPrincipal.Musique.Ctlcontrols.pause() 'Musique en pause
            Timer.Stop()
        Else
            MenuPrincipal.Musique.Ctlcontrols.play()
            Timer.Start()
        End If

        pause = Not pause
    End Sub

    'Quand le formulaire se ferme
    Private Sub Taquin_Closing(sender As Object, e As CancelEventArgs) Handles _
                                                                    Me.Closing
        'La musique s'arrête (Dans le cas où il le ferme de lui même)
        MenuPrincipal.Musique.Ctlcontrols.stop()
        If malFermé Then End
    End Sub

    'Indique le prochain coup au joueur. Le joueur perdera 10 secondes de jeu
    Private Sub Bouton_ProchainCoup_Click(sender As Object, e As EventArgs) Handles _
                                                        Bouton_ProchainCoup.Click
        If Not estCylindrique() Then
            MsgBox("Cette fonctionalitée n'est pas disponible " &
            "lorsque le taquin n'est pas cylindrique.", vbInformation, "Impossible.")
            Exit Sub
        End If

        If getTimerActif() Then
            Dim rep As String = MsgBox("Attention, demander le prochain mouvement " &
                "vous retire 10 secondes !", vbQuestion + vbYesNo, "Confirmation")

            If rep = MsgBoxResult.No Then Exit Sub

            tempsRestant -= 10 'On lui inflige le malus
            If tempsRestant < 0 Then tempsRestant = 0
        End If
        mouvementDonné = True

        'Ecriture...
        écrireFichier()

        Dim lecteur As New StreamReader("TexteRepondu.txt") 'Pour la lecture
        lecteur.ReadLine() 'La taille du taquin ne nous intéresse pas
        lecteur.ReadLine() 'Le nombre de solutions non plus
        lecteur.ReadLine() 'L'état du taquin non plus
        lecteur.ReadLine()
        lecteur.ReadLine()
        lecteur.ReadLine()

        'A cette ligne, il y a le mouvement effectué.
        Dim mouvement As String = lecteur.ReadLine()

        If mouvement = "SUD" Then
            Piece_Click(getButtonAtTag(pièceVide.Tag + 4), e)

        ElseIf mouvement = "EST" Then
            'Sans ce if, il aurait planté car il est cylindrique
            If pièceVide.Tag <> 4 And pièceVide.Tag <> 8 And pièceVide.Tag <> 12 And
                    pièceVide.Tag <> 16 Then

                Piece_Click(getButtonAtTag(pièceVide.Tag + 1), e)
            Else 'Si on utilise la "cylindricité"
                Piece_Click(getButtonAtTag(pièceVide.Tag - 3), e)
            End If

        ElseIf mouvement = "OUEST" Then
            If pièceVide.Tag <> 1 And pièceVide.Tag <> 5 And pièceVide.Tag <> 9 And
                    pièceVide.Tag <> 13 Then

                Piece_Click(getButtonAtTag(pièceVide.Tag - 1), e)
            Else
                Piece_Click(getButtonAtTag(pièceVide.Tag + 3), e)
            End If

        ElseIf mouvement = "NORD" Then
            Piece_Click(getButtonAtTag(pièceVide.Tag - 4), e)
        End If

        lecteur.Close()

        'On supprime les fichiers
        My.Computer.FileSystem.DeleteFile("TexteSaisi.txt")
        My.Computer.FileSystem.DeleteFile("TexteRepondu.txt")
        mouvementDonné = False
    End Sub

    'Indique au joueur la solution complète du taquin
    Private Sub Bouton_TouteSolution_Click(sender As Object, e As EventArgs) Handles _
                                                    Bouton_TouteSolution.Click

        If Not estCylindrique() Then
            MsgBox("Cette fonctionalitée n'est pas disponible " &
            "lorsque le taquin n'est pas cylindrique.", vbInformation, "Impossible.")
            Exit Sub
        End If

        Timer.Stop()
        solutionDonnée = True

        'On enregistre ce que le joueur a fait avant la solution
        joueur.additionneCumulMouvements(mouvements)
        If getTimerActif() Then
            joueur.additionneCumulTemps(tempsInitial - tempsRestant)
        Else
            joueur.additionneCumulTemps(tempsRestant)
        End If


        écrireFichier()

        Dim lecteur As New StreamReader("TexteRepondu.txt") 'Pour la lecture
        lecteur.ReadLine() 'La taille du taquin ne nous intéresse pas
        lecteur.ReadLine() 'Le nombre de solutions non plus
        lecteur.ReadLine() 'L'état du taquin non plus
        lecteur.ReadLine()
        lecteur.ReadLine()
        lecteur.ReadLine()


        While Not partie_gagnée()
            'Le joueur DOIT regarder la solution et pas la "déranger"
            Bouton_ProchainCoup.Enabled = False
            Bouton_TouteSolution.Enabled = False
            ButtonAbandonner.Enabled = False
            CheckBox_Pause.Enabled = False

            'A cette ligne, il y a le mouvement effectué.
            Dim mouvement As String = lecteur.ReadLine()

            If mouvement = "SUD" Then
                Piece_Click(getButtonAtTag(pièceVide.Tag + 4), e)

            ElseIf mouvement = "EST" Then
                'Sans ce if, il aurait planté car il est cylindrique
                If pièceVide.Tag <> 4 And pièceVide.Tag <> 8 And pièceVide.Tag <> 12 And
                    pièceVide.Tag <> 16 Then

                    Piece_Click(getButtonAtTag(pièceVide.Tag + 1), e)
                Else 'Si on utilise la "cylindricité"
                    Piece_Click(getButtonAtTag(pièceVide.Tag - 3), e)
                End If

            ElseIf mouvement = "OUEST" Then
                If pièceVide.Tag <> 1 And pièceVide.Tag <> 5 And pièceVide.Tag <> 9 And
                    pièceVide.Tag <> 13 Then

                    Piece_Click(getButtonAtTag(pièceVide.Tag - 1), e)
                Else
                    Piece_Click(getButtonAtTag(pièceVide.Tag + 3), e)
                End If

            ElseIf mouvement = "NORD" Then
                Piece_Click(getButtonAtTag(pièceVide.Tag - 4), e)
            End If

            'Comme on veut que le joueur voit bien les mouvements à faire, 
            'il attend 300 millisecondes avant de voir le prochain)
            attendre(30) '(30 * Timer_Random.Interval)

            'L'état du taquin après le mouvement ne nous intéresse pas, 
            'on a bien évidemment confiance au solveur
            lecteur.ReadLine()
            lecteur.ReadLine()
            lecteur.ReadLine()
            lecteur.ReadLine()
        End While

        Bouton_ProchainCoup.Enabled = True
        Bouton_TouteSolution.Enabled = True
        ButtonAbandonner.Enabled = True
        CheckBox_Pause.Enabled = True

        lecteur.Close()

        'On supprime les fichiers
        My.Computer.FileSystem.DeleteFile("TexteSaisi.txt")
        My.Computer.FileSystem.DeleteFile("TexteRepondu.txt")
    End Sub

    'Appelé pour le solveur de taquin, il écrit dans le fichier l'état du taquin
    Private Sub écrireFichier()
        'Ecrit dans le fichier
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("TexteSaisi.txt",
                                       False, New System.Text.UTF8Encoding(False))

        'Les dimensions
        file.WriteLine("4 4")

        'Ecrit l'état du taquin
        For i As Integer = 1 To 16
            If getButtonAtTag(i).Visible Then
                file.Write(getButtonAtTag(i).Text & " ")
            Else
                file.Write("# ")
            End If
        Next i

        file.Close()

        Dim commande As String =
            "Solveur.exe < TexteSaisi.txt > TexteRepondu.txt"

        Dim p As New Process
        Dim psi As New ProcessStartInfo(
            "cmd.exe",
            "/c " & commande
        )
        p.StartInfo = psi
        p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden

        p.Start()
        Dim tmp As String = tempsRestant 'On stocke le temps restant 
        Temps.Text = ChrW(8987) 'On affiche un sablier


        'Jeu en pause
        MenuPrincipal.Musique.Ctlcontrols.pause()
        Timer.Stop()
        pause = True

        'On attend que le solveur résout le taquin
        p.WaitForExit()

        MsgBox("Chargement terminé !")
        Temps.Text = tmp 'On récupère le temps restant

        'Le jeu reprend
        pause = False
        Timer.Start()
        MenuPrincipal.Musique.Ctlcontrols.play()
    End Sub

    'Met le jeu en "attente" durant ms*timer_random.Interval (ms*10)
    '(Utilisé seulement lorsqu'on montre la solution complète
    Private Sub attendre(ByVal ms As Integer)
        msAttente = ms
        Timer_Random.Start()

        While msAttente > 0
            Application.DoEvents() 'Pour que l'élément tick puisse se déclencher
        End While

        Timer_Random.Stop()
    End Sub
End Class