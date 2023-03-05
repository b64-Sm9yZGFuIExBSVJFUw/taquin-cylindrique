Imports System.ComponentModel

Public Class Prouesses
    Private temps As Integer = 0 'Pour le générique de fin
    Private malfermé As Boolean = True

    Public credits As Boolean = False 'Si le joueur s'est appelé "Credits"

    Private Sub Bouton_Champion_Click(sender As Object, e As EventArgs) Handles _
                                                            Bouton_Champion.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        If Not champion Then
            MsgBox("Battre le record du créateur (16 secondes)", vbInformation,
                   "Prouesse: CHAMPION")
        Else
            MsgBox("Vous avez réussi à battre le créateur! (Record de moins de 16 secondes)",
                   vbInformation, "Prouesse: CHAMPION")
        End If
    End Sub

    Private Sub Bouton_Invincible_Click(sender As Object, e As EventArgs) Handles _
                                                             Bouton_Invincible.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        If Not invincible Then
            MsgBox("Avoir un ratio de 1 pour plus de 2 parties jouées", vbInformation,
                   "Prouesse: INVINCIBLE")
        Else
            MsgBox("Vous avez réussi à gagner toutes les parties avec plus de 2 parties jouées!",
                   vbInformation, "Prouesse: INVINCIBLE")
        End If
    End Sub

    Private Sub Bouton_Habile_Click(sender As Object, e As EventArgs) Handles _
                                                          Bouton_Habile.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        If Not habile Then
            MsgBox("Avoir un total de 5.000 mouvements", vbInformation, "Prouesse: HABILE")
        Else
            MsgBox("Vous avez plus de 5.000 mouvements au total!", vbInformation,
                   "Prouesse: HABILE")
        End If
    End Sub

    Private Sub Bouton_Sansvie_Click(sender As Object, e As EventArgs) Handles _
                                                          Bouton_Sansvie.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        If Not sans_vie Then
            MsgBox("Avoir un total 2.500 secondes de jeu", vbInformation, "Prouesse: SANS VIE")
        Else
            MsgBox("Vous avez plus de 2.500 secondes de jeu! (Plus de 42 minutes de jeu)",
                   vbInformation, "Prouesse: SANS VIE")
        End If
    End Sub

    Private Sub Bouton_Einstein_Click(sender As Object, e As EventArgs) Handles _
                                                          Bouton_Einstein.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        If Not einstein Then
            MsgBox("Finir un taquin en moins de 50 mouvements", vbInformation,
                   "Prouesse: EINSTEIN")
        Else
            MsgBox("Vous avez fini un taquin en moins de 50 mouvements!", vbInformation,
                   "Prouesse: EINSTEIN")
        End If
    End Sub

    Private Sub Bouton_Detective_Click(sender As Object, e As EventArgs) Handles _
                                                          Bouton_Detective.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        If Not détective Then
            'La phrase est elle même l'indice
            MsgBox("Ptrouver Ale Rsecret Idu Sjeu ... ", vbInformation,
                   "(... et Descartes) Prouesse: DETECTIVE")
        Else
            MsgBox("Vous avez trouvé le secret du jeu!" & Environment.NewLine &
                   "(S'appeller -->ParisDescartes<--)", vbInformation, "Prouesse: DETECTIVE")
        End If
    End Sub

    Private Sub Bouton_Retour_Click(sender As Object, e As EventArgs) Handles _
        Bouton_Retour.Click
        My.Computer.Audio.Play("Sons\Bouton.wav")
        My.Computer.Audio.Play("Sons\Quitter.wav")
        Dim rep As String = MsgBox("Retourner au menu principal?", vbYesNo +
                                   vbQuestion, "Confirmation")

        If rep = MsgBoxResult.Yes Then
            malfermé = False
            Close()
            MenuPrincipal.Show()
        End If
    End Sub

    'Lorsqu'on ouvre le formulaire
    Private Sub Prouesses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If champion Then Bouton_Champion.BackgroundImage =
            System.Drawing.Image.FromFile("Images\Prouesses\Débloqué.png")

        If détective Then Bouton_Detective.BackgroundImage =
            System.Drawing.Image.FromFile("Images\Prouesses\Débloqué.png")

        If habile Then Bouton_Habile.BackgroundImage =
            System.Drawing.Image.FromFile("Images\Prouesses\Débloqué.png")

        If sans_vie Then Bouton_Sansvie.BackgroundImage =
            System.Drawing.Image.FromFile("Images\Prouesses\Débloqué.png")

        If invincible Then Bouton_Invincible.BackgroundImage =
            System.Drawing.Image.FromFile("Images\Prouesses\Débloqué.png")

        If einstein Then Bouton_Einstein.BackgroundImage =
            System.Drawing.Image.FromFile("Images\Prouesses\Débloqué.png")

        'S'il a toutes les prouesses
        If champion AndAlso habile AndAlso invincible AndAlso einstein AndAlso
            détective AndAlso sans_vie Then fin()

        'S'il s'est appelé credits
        If credits Then fin()

    End Sub

    'La fin du jeu.
    Private Sub fin()
        'Plus aucun contrôle
        Label_Titre.Visible = False
        Bouton_Champion.Visible = False
        Bouton_Habile.Visible = False
        Bouton_Sansvie.Visible = False
        Bouton_Invincible.Visible = False
        Bouton_Detective.Visible = False
        Bouton_Einstein.Visible = False
        Bouton_Retour.Visible = False

        Me.WindowState = FormWindowState.Maximized 'Plein écran

        'Ecran noir
        Me.BackgroundImage = Nothing
        Me.BackColor = Color.Black

        My.Computer.Audio.Play("Sons\Prouesse.wav")

        'Texte au milieu
        Label_Titre.Location = New Point((Size.Width / 2) - 500, Size.Height / 2)
        Label_Titre.BackColor = Color.Black
        Label_Titre.ForeColor = Color.White

        'Musique de fin
        MenuPrincipal.Musique.URL = "Sons\Ending.wav"
        MenuPrincipal.Musique.settings.setMode("loop", True)

        Label_Titre.Text = "Vous y êtes !"
        Label_Titre.Visible = True
        attendre(5)
        Label_Titre.Text = "Vous avez réussi !"
        attendre(4)
        Label_Titre.Text = "Tout n'était de base qu'un projet."
        attendre(4)
        Label_Titre.Text = "Mais j'y ai fait un jeu que j'ai adoré programmer."
        attendre(4)
        Label_Titre.Text = "Vous avez réussi..."
        attendre(3)
        My.Computer.Audio.Play("Sons\Gagné.wav")
        Label_Titre.Text = "Vous avez réussi à 100% ce jeu !!"
        attendre(6)
        Label_Titre.Text = "Credits:"
        attendre(2)
        Label_Titre.Text = "Jeu crée par: Jordan LAIRES"
        attendre(4)
        Label_Titre.Text = "Sons:"
        attendre(3)
        Label_Titre.Text = "Son <<Abandonner>>: Viens du jeu Metal Gear Solid" &
            Environment.NewLine & "(Nintendo)"
        attendre(2)
        Label_Titre.Text = "Son <<Bougé>>: Viens du jeu Minecraft" &
            Environment.NewLine & "(Mojang)"
        attendre(2)
        Label_Titre.Text = "Sons <<Bouton, Chargé, Partie, Pause, Perdu," &
            Environment.NewLine & "      Prouesse, Quitter, Gagné>>: Viens d'une" &
            Environment.NewLine & "banque gratuite de sons libres de droits (CCHub)"
        attendre(2)
        Label_Titre.Text = "Son <<Sauvegardé>>: Viens du jeu Pokémon" &
            Environment.NewLine & "(Nintendo)"
        attendre(2)
        Label_Titre.Text = "Musiques:"
        attendre(3)
        Label_Titre.Text = "Musique <<Mute City>>: Viens du jeu F-ZERO SNES" &
            Environment.NewLine & "(Nintendo)"
        attendre(2)
        Label_Titre.Text = "Musique <<N>>: Viens du jeu Pokémon Noire et Blanche" &
            Environment.NewLine & "(Nintendo)"
        attendre(2)
        Label_Titre.Text = "Musique <<Dernier Boss>>: Viens du jeu" &
            Environment.NewLine & "Mario & Luigi: Superstar Saga" &
            Environment.NewLine & "(Nintendo)"
        attendre(2)
        Label_Titre.Text = "Musique <<Ending>>: Viens du meme Internet 2204355" &
            Environment.NewLine & "(Zalza)"
        attendre(2)
        Label_Titre.Text = "Images:"
        attendre(3)
        Label_Titre.Text = "Backgrounds, boutons: Viens de banques d'images gratuites " &
            Environment.NewLine & "et libres de droits"
        attendre(2)
        Label_Titre.Text = "Secret <<ParisDescartes>>: Viens de l'université Paris Descartes" &
            Environment.NewLine & "(Son logo)"
        attendre(2)
        Label_Titre.Text = "Remerciements:"
        attendre(3)
        Label_Titre.Text = "Mes amis et ma copine pour avoir testés le jeu"
        attendre(2)
        Label_Titre.Text = "L'équipe Pédagogique de Paris Descartes pour leur " &
        Environment.NewLine & " enseignement"
        attendre(2)
        Label_Titre.Text = "Et..."
        attendre(5)
        My.Computer.Audio.Play("Sons\Sauvegardé.wav")
        Label_Titre.Text = "A vous pour avoir joué ce jeu jusqu'à la fin !"
        attendre(5)
        Label_Titre.Text = "Merci, " & Environment.MachineName & "."
        attendre(10)
        MenuPrincipal.Musique.Ctlcontrols.stop()
        malfermé = False
        Me.Close()

        MsgBox("Un gros merci à vous!", vbInformation,
               "Je vous remercie infiniment d'avoir joué.")

        sauvegarderJoueurs()
        MenuPrincipal.Close()
    End Sub

    'Pour le générique de fin
    Private Sub attendre(ByVal sec As Integer)
        temps = 0
        Timer_Fin.Start()
        While temps < sec
            'Si on ne met pas ça l'application ne fera rien
            System.Windows.Forms.Application.DoEvents()
        End While
        Timer_Fin.Stop()
    End Sub

    'Permet la fonction "Attendre"
    Private Sub Timer_Fin_Tick(sender As Object, e As EventArgs) Handles Timer_Fin.Tick
        temps += 1
    End Sub

    Private Sub Bouton_Retour_MouseHover(sender As Object, e As EventArgs) Handles _
                                                             Bouton_Retour.MouseHover
        sender.backcolor = Color.Red
        Me.Cursor = Cursors.No
    End Sub

    Private Sub Bouton_Retour_MouseLeave(sender As Object, e As EventArgs) Handles _
                                                            Bouton_Retour.MouseLeave
        sender.backcolor = Color.LightGray
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub Bouton_Retour_LostFocus(sender As Object, e As EventArgs) Handles _
        Bouton_Retour.LostFocus
        sender.backcolor = Color.LightGray
    End Sub

    Private Sub Bouton_Retour_GotFocus(sender As Object, e As EventArgs) Handles _
        Bouton_Retour.GotFocus
        sender.backcolor = Color.Red
    End Sub

    Private Sub Prouesses_Closing(sender As Object, e As CancelEventArgs) Handles _
                                                                    Me.Closing
        If malfermé Then End
    End Sub
End Class