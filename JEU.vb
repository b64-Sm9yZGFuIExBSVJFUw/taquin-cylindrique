Imports System.IO

Module JEU

    Private joueurs() As Joueur 'La liste des joueurs
    Private nbAjoutés As Integer = 0 'Pointeur pour la liste
    Private sauvAuto As Boolean = False 'Par défaut

    Sub Main()
        'Si je ne fais pas ce Redim, et que je le fais "dynamiquement"
        'Le jeu plante
        ReDim joueurs(999)
        Application.Run(MenuPrincipal) 'On lance le formulaire principal
    End Sub

    'Si le joueur n'a jamais emporté une partie 
    Public Const pasDeMeilleurTemps As Integer = 999999

    'Crée une nouvelle partie et renvoie le joueur qui va jouer
    Public Function nouvellePartie(ByVal nom As String) As Joueur
        If Not déjàJoué(nom) Then 'Si le joueur n'est pas dans la ComboBox
            joueurs(nbAjoutés) = New Joueur(nom)
            nbAjoutés += 1 'On l'ajoute à la liste des joueurs
            Return joueurs(nbAjoutés - 1)
        Else
            getJoueur(nom).joueAUnePartie()
            Return getJoueur(nom)
        End If
    End Function

    'Renvoie le joueur à partir de son nom
    Public Function getJoueur(ByVal nom As String) As Joueur
        For i As Integer = 0 To nbAjoutés - 1
            If joueurs(i).getNom = nom Then Return joueurs(i)
        Next i
        Return Nothing
    End Function

    'Renvoie si oui ou non, le joueur est déjà présent dans la liste
    Private Function déjàJoué(ByVal nom As String) As Boolean
        If nbAjoutés = 0 Then Return False

        For i As Integer = 0 To nbAjoutés - 1
            If joueurs(i).getNom = nom Then Return True
        Next i
        Return False
    End Function

    'Pour initialiser la combobox dans la saisie du nom
    Public Sub initComboBox()
        SaisieNom.Saisie_Nom.Items.Clear()

        For i As Integer = 0 To nbAjoutés - 1
            SaisieNom.Saisie_Nom.Items.Add(joueurs(i).getNom)
        Next i
    End Sub

    'Pour initialiser la listbox des noms dans le tableau des scores
    Public Sub initListBox_Nom()
        For i As Integer = 0 To nbAjoutés - 1
            Scores.ListBox_Nom.Items.Add(joueurs(i).getNom)
        Next i
    End Sub

    'Initialise la ListBox avec les temps
    Public Sub initListBox_Tps()

        'Remet à zéro 
        Scores.ListBox_Tps.Items.Clear()

        For i As Integer = 0 To nbAjoutés - 1
            If getJoueur(Scores.ListBox_Nom.Items(i)).getRecord =
                                        pasDeMeilleurTemps Then
                Scores.ListBox_Tps.Items.Add("Pas de temps")
            Else
                Scores.ListBox_Tps.Items.Add(getJoueur(Scores.ListBox_Nom.Items(i)).
                                                                          getRecord)
            End If
        Next i
    End Sub

    'Affiche pour la MsgBox les statistiques détaillées du joueur 
    'où le nom est en paramètre
    Public Function toStringStats(ByVal nom As String) As String
        Dim joueur As Joueur = getJoueur(nom)

        Return joueur.getStats()
    End Function


    'Sauvegarde les joueurs
    Public Sub sauvegarderJoueurs()

        'Si le joueur n'a jamais joué
        If nbAjoutés = 0 Then
            MsgBox("Il n'y a aucune donnée dans le jeu actuellement!",
                   vbInformation, "Inutile..")
            Exit Sub
        End If

        'Si une sauvegarde existe déjà
        If sauvAuto = False Then
            Dim rep As String = MsgBox("Une sauvegarde a été détectée." &
                    Environment.NewLine & "Voulez-vous l'écraser ?", vbCritical +
                    vbYesNo, "Attention!")

            If rep = MsgBoxResult.No Then
                Exit Sub
            End If
        End If


        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("Taquin.sauvegarde", False)

        'Pour chaque joueur, on l'écrit
        For i As Integer = 0 To nbAjoutés - 1
            'Construction de la chaîne à travers une méthode
            file.WriteLine(joueurs(i).toStringSauvegarde)
        Next i

        'Pas la peine de marquer à chaque fin de parties cette MsgBox 
        'si la sauv. est auto.
        If sauvAuto = False Then
            My.Computer.Audio.Play("Sons\Sauvegardé.wav")
            MsgBox("Les joueurs ont bien été sauvegardés!", vbInformation, "Succès")
        End If

        file.Close()
    End Sub

    'Charge les données des joueurs de la sauvegarde 
    Public Sub chargerJoueurs()
        Dim corrompue As Boolean = False

        'Si aucune sauvegarde n'a été détectée
        If Not My.Computer.FileSystem.FileExists("Taquin.sauvegarde") Then
            MsgBox("Si vous avez précédemment sauvegardé, vérifiez bien que " &
                   "Taquin.sauvegarde soit bien présent au même endroit que " &
                   "l'éxécutable du jeu!", vbCritical, "Sauvegarde non trouvée")
            Exit Sub
        End If

        Dim joueursSauv(999) As Joueur 'Tableau qui va stocker les joueurs sauvegardés
        Dim nbAjoutésSauv As Integer = 0
        Dim lecteur As New StreamReader("Taquin.sauvegarde") 'Pour la lecture

        'Si la sauvegarde est vide
        If lecteur.EndOfStream Then
            MsgBox("La sauvegarde est vide!", vbCritical, "Erreur")
            lecteur.Close()
            Exit Sub
        End If

        While Not lecteur.EndOfStream 'Tant qu'on est pas à la fin du fichier

            'Statistiques obtenues
            Dim stats() As String = lecteur.ReadLine().Split(" ")
            Dim nomSauv As String = stats(0)
            Dim nbPartiesSauv As String = stats(1)
            Dim nbPartiesWonSauv As String = stats(2)
            Dim mouvementsSauv As String = stats(3)
            Dim tempsCumulSauv As String = stats(4)


            'Si les formats ne sont pas corrects 
            '(Surtout si un joueur a essayé de tricher mais a raté)  
            If stats.Length <> 5 Then corrompue = True
            If Not Char.IsLetter(nomSauv) Then corrompue = True
            If Not Char.IsDigit(nbPartiesSauv) Then corrompue = True
            If Not Char.IsDigit(nbPartiesWonSauv) Then corrompue = True
            If Not Char.IsDigit(mouvementsSauv) Then corrompue = True
            If Not Char.IsDigit(tempsCumulSauv) Then corrompue = True

            If Not corrompue Then
                joueursSauv(nbAjoutésSauv) = New Joueur(nomSauv)
                joueursSauv(nbAjoutésSauv).createJoueur(nbPartiesSauv,
                         nbPartiesWonSauv, mouvementsSauv, tempsCumulSauv)

                'S'il a un record (Donc si <> "#" et " ")
                If lecteur.Peek <> 35 And lecteur.Peek <> 32 Then
                    Dim record As Integer = lecteur.ReadLine()
                    joueursSauv(nbAjoutésSauv).setRecord(record)
                End If

                'Si nombre de parties gagnées > nombre de parties
                If joueursSauv(nbAjoutésSauv).nbPartiesWonCorrompue Then
                    corrompue = True
                End If

                nbAjoutésSauv += 1

                'Joueur suivant
                lecteur.ReadLine()
            End If
        End While

        If corrompue Then
            MsgBox("La sauvegarde est corrompue! Impossible de la charger.",
                   vbCritical, "Erreur")
            lecteur.Close()
            Exit Sub
        End If

        'Sauvegarde réussie!
        Array.Copy(joueursSauv, joueurs, 99)
        nbAjoutés = nbAjoutésSauv
        My.Computer.Audio.Play("Sons\Chargé.wav")
        MsgBox("Chargement réussi! Pour mettre à jour les scores, " &
                "retournez en arrière et revenez.", vbInformation, "Succès")

        lecteur.Close()

        '=== LES PROUESSES ===
        estChampion()
        estDétective()
        estHabile()
        estSansVie()
        estInvincible()
        'Pour Einstein, c'est forcément après qu'il ait gagné une partie
    End Sub


    '=============================== LES OPTIONS ============================
    Private graphismes As String = "Metallique" 'Par défaut
    'Musique de fond par défaut
    Private musiqueFond As String = "Sons\Partie_MuteCity.wav"
    Private cylindrique As Boolean = True 'Par défaut, évidemment à True
    Private timerActif As Boolean = True 'Le timer est-t-il activé ?

    Public Sub setSauvAuto(ByVal val As Boolean)
        sauvAuto = val
    End Sub

    Public Function getSauvAuto() As Boolean
        Return sauvAuto
    End Function

    'Modifie la musique de fond
    Public Sub setMusiqueFond(ByVal music As String)
        musiqueFond = music
    End Sub

    'Renvoie la musique de fond
    Public Function getMusiqueFond() As String
        Return musiqueFond
    End Function

    Public Sub setGraphismes(ByVal val As String)
        graphismes = val
    End Sub

    Public Function getGraphismes() As String
        Return graphismes
    End Function

    'Met à jour la variable "timerActif"
    Public Sub setTimerActif(ByVal val As Boolean)
        timerActif = val
    End Sub

    'Renvoie l'état de la variable "timerActif"
    Public Function getTimerActif() As Boolean
        Return timerActif
    End Function

    Public Sub setCylindrique(ByVal val As Boolean)
        cylindrique = val
    End Sub

    Public Function estCylindrique() As Boolean
        Return cylindrique
    End Function

    'Sauvegarde les options
    Public Sub sauvegarderOptions()

        'Si une sauvegarde existe déjà
        If My.Computer.FileSystem.FileExists("Options.sauvegarde") Then
            Dim rep As String = MsgBox("Une sauvegarde a été détectée." &
                    Environment.NewLine & "Voulez-vous l'écraser ?", vbCritical +
                    vbYesNo, "Attention!")

            If rep = MsgBoxResult.No Then
                Exit Sub
            End If
        End If


        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("Options.sauvegarde", False)

        'Le timer
        file.Write(Options.TextBox_Timer.Text & " ")

        'On va écrire la sauvegarde d'une manière incompréhensible pour éviter au
        'maximum que le joueur puisse y toucher
        If Options.CheckBox_désacTimer.Checked = True Then
            file.Write("0 ")
        Else
            file.Write("1 ")
        End If

        If Options.CheckBox_SauvAuto.Checked = True Then
            file.Write("1 ")
        Else
            file.Write("0 ")
        End If

        If Options.CheckBox_NonCylindrique.Checked = True Then
            file.Write("0")
        Else
            file.Write("1")
        End If

        file.Write(Environment.NewLine) 'Ligne suivante

        Select Case True
            Case Options.RadioButton_MuteCity.Checked
                file.Write("Mu")
            Case Options.RadioButton_N.Checked
                file.Write("N")
            Case Options.RadioButton_Mario.Checked
                file.Write("Ma")
            Case Else
                file.Write("Z")
        End Select

        file.Write(Environment.NewLine) 'Ligne suivante

        Select Case True
            Case Options.RadioButton_Metallique.Checked
                file.Write("M")
            Case Options.RadioButton_Aquatique.Checked
                file.Write("A")
            Case Options.RadioButton_Feu.Checked
                file.Write("F")
            Case Else 'Espace
                file.Write("E")
        End Select

        file.Close()

        My.Computer.Audio.Play("Sons\Sauvegardé.wav")
        MsgBox("Les options ont bien étés sauvegardées !", vbInformation, "Succès")
    End Sub

    Public Sub chargerOptions()
        Dim corrompue As Boolean = False

        'Si aucune sauvegarde n'a été détectée
        If Not My.Computer.FileSystem.FileExists("Options.sauvegarde") Then
            MsgBox("Si vous avez précédemment sauvegardé, vérifiez bien que " &
                   "Options.sauvegarde soit bien présent au même endroit que " &
                   "l'éxécutable du jeu!", vbCritical, "Sauvegarde non trouvée")
            Exit Sub
        End If

        Dim lecteur As New StreamReader("Options.sauvegarde") 'Pour la lecture

        'Si la sauvegarde est vide
        If lecteur.EndOfStream Then
            MsgBox("La sauvegarde est vide!", vbCritical, "Erreur")
            lecteur.Close()
            Exit Sub
        End If

        Dim optionsDeGauche() As String = lecteur.ReadLine().Split(" ")
        Dim timerSauv As String = optionsDeGauche(0)
        Dim timerActifSauv As String = optionsDeGauche(1)
        Dim sauvAutoSauv As String = optionsDeGauche(2)
        Dim cylindriqueSauv As String = optionsDeGauche(3)
        Dim musiqueSauv As String = lecteur.ReadLine()
        Dim graphismesSauv As String = lecteur.ReadLine()

        'S'il y a encore des données (Alors que normalement non)
        If Not lecteur.EndOfStream Then
            corrompue = True
        End If

        'Vérification des données
        If Not Char.IsDigit(timerSauv) Then corrompue = True
        If Not Char.IsDigit(timerActifSauv) Then corrompue = True
        If Not Char.IsDigit(sauvAutoSauv) Then corrompue = True
        If Not Char.IsDigit(cylindriqueSauv) Then corrompue = True
        If Not Char.IsLetter(musiqueSauv) Then corrompue = True
        If Not Char.IsLetter(graphismesSauv) Then corrompue = True
        If graphismesSauv.Length > 2 Then corrompue = True
        If musiqueSauv.Length > 2 Then corrompue = True
        If cylindriqueSauv > 1 Then corrompue = True
        If sauvAutoSauv > 1 Then corrompue = True
        If timerSauv < 0 Then corrompue = True
        If optionsDeGauche.Length <> 4 Then corrompue = True

        If corrompue Then
            MsgBox("La sauvegarde est corrompue! Impossible de la charger.",
                   vbCritical, "Erreur")
            lecteur.Close()
            Exit Sub
        End If

        'Si la sauvegarde est correcte
        Options.TextBox_Timer.Text = timerSauv

        If timerActifSauv = 0 Then
            Options.CheckBox_désacTimer.Checked = True
        Else
            Options.CheckBox_désacTimer.Checked = False
        End If

        If sauvAuto = 0 Then
            Options.CheckBox_SauvAuto.Checked = False
        Else
            Options.CheckBox_SauvAuto.Checked = True
        End If

        If cylindriqueSauv = 0 Then
            Options.CheckBox_NonCylindrique.Checked = True
        Else
            Options.CheckBox_NonCylindrique.Checked = False
        End If

        If musiqueSauv = "Mu" Then
            Options.RadioButton_MuteCity.Checked = True
        ElseIf musiqueSauv = "N" Then
            Options.RadioButton_N.Checked = True
        ElseIf musiqueSauv = "Ma" Then
            Options.RadioButton_Mario.Checked = True
        Else 'Si pas de musique (Z)
            Options.RadioButton_noMusic.Checked = True
        End If

        If graphismesSauv = "M" Then
            Options.RadioButton_Metallique.Checked = True
        ElseIf graphismesSauv = "A" Then
            Options.RadioButton_Aquatique.Checked = True
        ElseIf graphismesSauv = "F" Then
            Options.RadioButton_Feu.Checked = True
        Else 'Si espace (E)
            Options.RadioButton_Espace.Checked = True
        End If

        My.Computer.Audio.Play("Sons\Chargé.wav")
        MsgBox("Les options ont bien étés chargées !", vbInformation, "Succès")
        lecteur.Close()
    End Sub

    'LES PROUESSES 
    '(J'ai mis en public, on va pas faire des setteurs/getteurs pour chacun...)
    Public champion As Boolean = False
    Public invincible As Boolean = False
    Public sans_vie As Boolean = False
    Public habile As Boolean = False
    Public détective As Boolean = False
    Public einstein As Boolean = False
    Private toutesProuesses As Boolean = False

    'Teste si le joueur a réussi la prouesse "Détective"
    Public Sub estDétective()
        For i As Integer = 0 To nbAjoutés - 1
            'Si un des joueurs s'appelle ParisDescartes, alors oui
            If joueurs(i).getNom = "ParisDescartes" Then
                détective = True
                My.Computer.Audio.Play("Sons\Prouesse.wav")

                MsgBox("Vous avez découvert le secret!", vbInformation,
                       "PROUESSE DETECTIVE REUSSIE!")
            End If
        Next i

        'Puis on teste s'il a toutes les prouesses
        If champion AndAlso habile AndAlso invincible AndAlso einstein _
                                AndAlso détective AndAlso sans_vie Then
            aToutRéussi()
        End If
    End Sub

    'Teste si le joueur a réussi la prouesse "Champion"
    Public Sub estChampion()
        For i As Integer = 0 To nbAjoutés - 1
            'Si un des joueurs à un record inférieur à 16 secondes
            If joueurs(i).getRecord < 16 Then
                champion = True
                My.Computer.Audio.Play("Sons\Prouesse.wav")
                MsgBox("Vous avez battu le créateur!", vbInformation,
                       "PROUESSE CHAMPION REUSSIE!")
            End If
        Next i

        If champion AndAlso habile AndAlso invincible AndAlso einstein AndAlso
            détective AndAlso sans_vie Then
            aToutRéussi()
        End If
    End Sub

    'Teste si le joueur a réussi la prouesse "Invincible"
    Public Sub estInvincible()
        For i As Integer = 0 To nbAjoutés - 1
            'Délégation
            If joueurs(i).estInvincible Then
                invincible = True
                My.Computer.Audio.Play("Sons\Prouesse.wav")

                MsgBox("Vous avez gagné toutes vos parties pour plus de 2 parties " &
                        "jouées!", vbInformation, "PROUESSE INVINCIBLE REUSSIE!")
            End If
        Next i

        If champion AndAlso habile AndAlso invincible AndAlso einstein AndAlso
            détective AndAlso sans_vie Then
            aToutRéussi()
        End If
    End Sub

    'Teste si le joueur a réussi la prouesse "Sans vie"
    Public Sub estSansVie()
        For i As Integer = 0 To nbAjoutés - 1
            'Si un des joueurs à un temps de jeu supérieur à 2500 secondes
            If joueurs(i).getCumulTemps > 2500 Then
                sans_vie = True
                My.Computer.Audio.Play("Sons\Prouesse.wav")
                MsgBox("Vous avez plus de 2.500 secondes de jeu !", vbInformation,
                       "PROUESSE SANS VIE REUSSIE!")
            End If
        Next i

        If champion AndAlso habile AndAlso invincible AndAlso einstein AndAlso
            détective AndAlso sans_vie Then
            aToutRéussi()
        End If
    End Sub

    'Teste si le joueur a réussi la prouesse "Habile"
    Public Sub estHabile()
        For i As Integer = 0 To nbAjoutés - 1
            'Si un des joueurs à un total de mouvements supérieur à 5000
            If joueurs(i).getCumulMouvement > 5000 Then
                habile = True
                My.Computer.Audio.Play("Sons\Prouesse.wav")
                MsgBox("Vous avez plus de 5.000 mouvements au total", vbInformation,
                       "PROUESSE HABILE REUSSIE!")
            End If
        Next i

        If champion AndAlso habile AndAlso invincible AndAlso einstein AndAlso
            détective AndAlso sans_vie Then
            aToutRéussi()
        End If
    End Sub

    Public Function getToutesProuesses() As Boolean
        Return toutesProuesses
    End Function

    'S'il a toutes les prouesses on l'appelle
    Public Sub aToutRéussi()
        toutesProuesses = True
        My.Computer.Audio.Play("Sons\Gagné.wav")

        MsgBox("Vous avez réussi toutes les prouesses!! Allez voir un peu vos " &
                            "prouesses!", vbInformation, "Félicitations!")
    End Sub
End Module
