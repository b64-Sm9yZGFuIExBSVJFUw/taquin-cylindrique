Imports System.IO

Public Class Joueur
    Private nom As String
    Private record As Integer 'Meilleur temps
    Private nbParties As Integer
    Private nbPartiesWon As Integer 'nbPartiesGagnées
    Private cumulTemps As Long
    Private cumulMouvements As Long

    Public Sub New(ByVal leNom As String) 'Son constructeur
        nom = leNom
        nbParties = 1
        nbPartiesWon = 0
        cumulTemps = 0
        cumulMouvements = 0
        record = pasDeMeilleurTemps
    End Sub

    'Quand le joueur a gagné une partie, on ajoute son record
    Public Sub ajouterRecord(ByVal tps As Integer)
        'Si nouveau record
        If Me.record > tps Then Me.record = tps

        cumulTemps += tps
        nbPartiesWon += 1
    End Sub

    'Met à jour son temps de jeu
    Public Sub additionneCumulTemps(ByVal tps As Integer)
        cumulTemps += tps
    End Sub

    'Quand il lance une partie
    Public Sub joueAUnePartie()
        nbParties += 1
    End Sub

    'Met à jour ses mouvements totaux
    Public Sub additionneCumulMouvements(ByVal mouvements As Integer)
        cumulMouvements += mouvements
    End Sub

    Public Function getNom() As String
        Return nom
    End Function

    Public Function getCumulMouvement() As Long
        Return cumulMouvements
    End Function

    Public Function getCumulTemps() As Long
        Return cumulTemps
    End Function

    'Test si le joueur a réussi la prouesse "Invincible
    Public Function estInvincible() As Double
        'S'il a un ratio de 1...
        If nbPartiesWon = nbParties Then
            If nbPartiesWon > 2 And nbParties > 2 Then '...Pour plus de 2 parties
                Return True
            End If
            Return False
        End If
        Return False
    End Function


    'Renvoie le meilleur temps du joueur
    Public Function getRecord() As Integer
        Return record
    End Function

    'Renvoie la chaîne pour afficher ses statistiques détaillées
    Public Function getStats() As String
        Dim stats As String = ""

        stats &= "Nombre de parties jouées: " & nbParties &
                 Environment.NewLine & "Nombre de parties gagnées: " &
                 nbPartiesWon & Environment.NewLine &
                 "Ratio gagnées/perdues: "

        If nbPartiesWon = nbParties Then
            stats &= " Vous avez gagné toutes les parties!"
        Else
            stats &= nbPartiesWon / nbParties
        End If

        stats &= Environment.NewLine & "Nombre de mouvements total: " &
                 cumulMouvements & Environment.NewLine & "Temps de jeu: " &
                 cumulTemps & " secondes" & Environment.NewLine &
                 "Meilleur temps: "

        If getRecord() = pasDeMeilleurTemps Then
            stats &= "Pas de meilleur temps"
        Else
            stats &= getRecord() & " secondes"
        End If

        Return stats
    End Function

    'Renvoie la chaîne de caractère pour l'écriture dans la sauvegarde
    Public Function toStringSauvegarde() As String
        Dim sauv As String = ""

        sauv &= nom & " " & nbParties & " " & nbPartiesWon & " " &
            cumulMouvements & " " & cumulTemps

        'S'il a un record
        If record <> pasDeMeilleurTemps Then
            sauv &= Environment.NewLine & record
        End If

        'Marque la fin d'un joueur
        sauv &= Environment.NewLine & "#"
        Return sauv
    End Function

    'Crée un joueur à partir des attributs mis en paramètre (Pour la sauvegarde)
    Public Sub createJoueur(ByVal nbparties As String, nbpartieswon As String,
                            mouvements As String, cumultemps As String)

        Me.nbParties = nbparties
        Me.nbPartiesWon = nbpartieswon
        Me.cumulMouvements = mouvements
        Me.cumulTemps = cumultemps
    End Sub

    'Retourne si le joueur a gagné plus de parties qu'il en a joué (Ce qui est impossible)
    Public Function nbPartiesWonCorrompue() As Boolean
        Return nbPartiesWon > nbParties
    End Function

    'Utilisé dans la sauvegarde
    Public Sub setRecord(ByVal tps As Integer)
        record = tps
    End Sub
End Class
