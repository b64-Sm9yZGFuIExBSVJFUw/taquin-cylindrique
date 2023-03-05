<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scores
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Scores))
        Me.Bouton_Retour = New System.Windows.Forms.Button()
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.ListBox_Nom = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox_Tps = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Bouton_Trier_Alpha = New System.Windows.Forms.Button()
        Me.Bouton_Trier_Tps = New System.Windows.Forms.Button()
        Me.Bouton_Stats = New System.Windows.Forms.Button()
        Me.Bouton_Sauvegarder = New System.Windows.Forms.Button()
        Me.Bouton_Charger = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Bouton_Retour
        '
        Me.Bouton_Retour.BackColor = System.Drawing.Color.DarkGray
        Me.Bouton_Retour.Location = New System.Drawing.Point(45, 350)
        Me.Bouton_Retour.Name = "Bouton_Retour"
        Me.Bouton_Retour.Size = New System.Drawing.Size(162, 59)
        Me.Bouton_Retour.TabIndex = 1
        Me.Bouton_Retour.Text = "Retour au menu"
        Me.Bouton_Retour.UseVisualStyleBackColor = False
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.Label_Titre.BackColor = System.Drawing.Color.Transparent
        Me.Label_Titre.Font = New System.Drawing.Font("Ink Free", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.Location = New System.Drawing.Point(163, 9)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(470, 65)
        Me.Label_Titre.TabIndex = 2
        Me.Label_Titre.Text = "Tableau des scores"
        '
        'ListBox_Nom
        '
        Me.ListBox_Nom.FormattingEnabled = True
        Me.ListBox_Nom.Location = New System.Drawing.Point(45, 131)
        Me.ListBox_Nom.Name = "ListBox_Nom"
        Me.ListBox_Nom.Size = New System.Drawing.Size(134, 186)
        Me.ListBox_Nom.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Joueurs:"
        '
        'ListBox_Tps
        '
        Me.ListBox_Tps.FormattingEnabled = True
        Me.ListBox_Tps.Location = New System.Drawing.Point(323, 132)
        Me.ListBox_Tps.Name = "ListBox_Tps"
        Me.ListBox_Tps.Size = New System.Drawing.Size(127, 186)
        Me.ListBox_Tps.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Temps (En secondes):"
        '
        'Bouton_Trier_Alpha
        '
        Me.Bouton_Trier_Alpha.BackgroundImage = CType(resources.GetObject("Bouton_Trier_Alpha.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Trier_Alpha.Location = New System.Drawing.Point(573, 131)
        Me.Bouton_Trier_Alpha.Name = "Bouton_Trier_Alpha"
        Me.Bouton_Trier_Alpha.Size = New System.Drawing.Size(162, 59)
        Me.Bouton_Trier_Alpha.TabIndex = 7
        Me.Bouton_Trier_Alpha.Text = "Trier par ordre alphabétique"
        Me.Bouton_Trier_Alpha.UseVisualStyleBackColor = True
        '
        'Bouton_Trier_Tps
        '
        Me.Bouton_Trier_Tps.BackgroundImage = CType(resources.GetObject("Bouton_Trier_Tps.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Trier_Tps.Location = New System.Drawing.Point(573, 196)
        Me.Bouton_Trier_Tps.Name = "Bouton_Trier_Tps"
        Me.Bouton_Trier_Tps.Size = New System.Drawing.Size(162, 59)
        Me.Bouton_Trier_Tps.TabIndex = 8
        Me.Bouton_Trier_Tps.Text = "Trier par meilleur temps"
        Me.Bouton_Trier_Tps.UseVisualStyleBackColor = True
        '
        'Bouton_Stats
        '
        Me.Bouton_Stats.BackgroundImage = CType(resources.GetObject("Bouton_Stats.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Stats.Location = New System.Drawing.Point(573, 261)
        Me.Bouton_Stats.Name = "Bouton_Stats"
        Me.Bouton_Stats.Size = New System.Drawing.Size(162, 59)
        Me.Bouton_Stats.TabIndex = 9
        Me.Bouton_Stats.Text = "Voir statistiques du joueur"
        Me.Bouton_Stats.UseVisualStyleBackColor = True
        '
        'Bouton_Sauvegarder
        '
        Me.Bouton_Sauvegarder.BackgroundImage = CType(resources.GetObject("Bouton_Sauvegarder.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Sauvegarder.Location = New System.Drawing.Point(310, 350)
        Me.Bouton_Sauvegarder.Name = "Bouton_Sauvegarder"
        Me.Bouton_Sauvegarder.Size = New System.Drawing.Size(162, 59)
        Me.Bouton_Sauvegarder.TabIndex = 10
        Me.Bouton_Sauvegarder.Text = "Sauvegarder"
        Me.Bouton_Sauvegarder.UseVisualStyleBackColor = True
        '
        'Bouton_Charger
        '
        Me.Bouton_Charger.BackgroundImage = CType(resources.GetObject("Bouton_Charger.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Charger.Location = New System.Drawing.Point(573, 350)
        Me.Bouton_Charger.Name = "Bouton_Charger"
        Me.Bouton_Charger.Size = New System.Drawing.Size(162, 59)
        Me.Bouton_Charger.TabIndex = 11
        Me.Bouton_Charger.Text = "Charger..."
        Me.Bouton_Charger.UseVisualStyleBackColor = True
        '
        'Scores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Bouton_Charger)
        Me.Controls.Add(Me.Bouton_Sauvegarder)
        Me.Controls.Add(Me.Bouton_Stats)
        Me.Controls.Add(Me.Bouton_Trier_Tps)
        Me.Controls.Add(Me.Bouton_Trier_Alpha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox_Tps)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox_Nom)
        Me.Controls.Add(Me.Label_Titre)
        Me.Controls.Add(Me.Bouton_Retour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Scores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bouton_Retour As Button
    Friend WithEvents Label_Titre As Label
    Friend WithEvents ListBox_Nom As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox_Tps As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Bouton_Trier_Alpha As Button
    Friend WithEvents Bouton_Trier_Tps As Button
    Friend WithEvents Bouton_Stats As Button
    Friend WithEvents Bouton_Sauvegarder As Button
    Friend WithEvents Bouton_Charger As Button
End Class
