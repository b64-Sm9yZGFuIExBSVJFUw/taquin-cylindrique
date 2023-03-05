<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options))
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.Label_Timer = New System.Windows.Forms.Label()
        Me.TextBox_Timer = New System.Windows.Forms.TextBox()
        Me.Bouton_Enrg = New System.Windows.Forms.Button()
        Me.Bouton_Annuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelGraphismes = New System.Windows.Forms.Panel()
        Me.RadioButton_Espace = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Feu = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Aquatique = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Metallique = New System.Windows.Forms.RadioButton()
        Me.CheckBox_SauvAuto = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMusique = New System.Windows.Forms.Panel()
        Me.RadioButton_noMusic = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Mario = New System.Windows.Forms.RadioButton()
        Me.RadioButton_N = New System.Windows.Forms.RadioButton()
        Me.RadioButton_MuteCity = New System.Windows.Forms.RadioButton()
        Me.CheckBox_NonCylindrique = New System.Windows.Forms.CheckBox()
        Me.CheckBox_désacTimer = New System.Windows.Forms.CheckBox()
        Me.Bouton_Charger = New System.Windows.Forms.Button()
        Me.Bouton_Sauvegarder = New System.Windows.Forms.Button()
        Me.PanelGraphismes.SuspendLayout()
        Me.PanelMusique.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.Label_Titre.BackColor = System.Drawing.Color.Transparent
        Me.Label_Titre.Font = New System.Drawing.Font("Ink Free", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.Location = New System.Drawing.Point(179, 9)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(172, 39)
        Me.Label_Titre.TabIndex = 0
        Me.Label_Titre.Text = "OPTIONS"
        '
        'Label_Timer
        '
        Me.Label_Timer.AutoSize = True
        Me.Label_Timer.BackColor = System.Drawing.Color.Transparent
        Me.Label_Timer.Location = New System.Drawing.Point(12, 91)
        Me.Label_Timer.Name = "Label_Timer"
        Me.Label_Timer.Size = New System.Drawing.Size(104, 13)
        Me.Label_Timer.TabIndex = 1
        Me.Label_Timer.Text = "Timer (En secondes)"
        '
        'TextBox_Timer
        '
        Me.TextBox_Timer.Location = New System.Drawing.Point(34, 107)
        Me.TextBox_Timer.MaxLength = 5
        Me.TextBox_Timer.Name = "TextBox_Timer"
        Me.TextBox_Timer.Size = New System.Drawing.Size(82, 20)
        Me.TextBox_Timer.TabIndex = 2
        '
        'Bouton_Enrg
        '
        Me.Bouton_Enrg.Location = New System.Drawing.Point(26, 321)
        Me.Bouton_Enrg.Name = "Bouton_Enrg"
        Me.Bouton_Enrg.Size = New System.Drawing.Size(102, 40)
        Me.Bouton_Enrg.TabIndex = 3
        Me.Bouton_Enrg.Text = "Enregistrer"
        Me.Bouton_Enrg.UseVisualStyleBackColor = True
        '
        'Bouton_Annuler
        '
        Me.Bouton_Annuler.Location = New System.Drawing.Point(153, 321)
        Me.Bouton_Annuler.Name = "Bouton_Annuler"
        Me.Bouton_Annuler.Size = New System.Drawing.Size(102, 40)
        Me.Bouton_Annuler.TabIndex = 4
        Me.Bouton_Annuler.Text = "Annuler"
        Me.Bouton_Annuler.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(382, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Graphismes du taquin:"
        '
        'PanelGraphismes
        '
        Me.PanelGraphismes.BackColor = System.Drawing.Color.Transparent
        Me.PanelGraphismes.Controls.Add(Me.RadioButton_Espace)
        Me.PanelGraphismes.Controls.Add(Me.RadioButton_Feu)
        Me.PanelGraphismes.Controls.Add(Me.RadioButton_Aquatique)
        Me.PanelGraphismes.Controls.Add(Me.RadioButton_Metallique)
        Me.PanelGraphismes.Location = New System.Drawing.Point(358, 105)
        Me.PanelGraphismes.Name = "PanelGraphismes"
        Me.PanelGraphismes.Size = New System.Drawing.Size(170, 183)
        Me.PanelGraphismes.TabIndex = 6
        '
        'RadioButton_Espace
        '
        Me.RadioButton_Espace.AutoSize = True
        Me.RadioButton_Espace.BackgroundImage = CType(resources.GetObject("RadioButton_Espace.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton_Espace.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Espace.ForeColor = System.Drawing.Color.Snow
        Me.RadioButton_Espace.Location = New System.Drawing.Point(3, 136)
        Me.RadioButton_Espace.Name = "RadioButton_Espace"
        Me.RadioButton_Espace.Size = New System.Drawing.Size(122, 34)
        Me.RadioButton_Espace.TabIndex = 3
        Me.RadioButton_Espace.TabStop = True
        Me.RadioButton_Espace.Text = "Espace"
        Me.RadioButton_Espace.UseVisualStyleBackColor = True
        '
        'RadioButton_Feu
        '
        Me.RadioButton_Feu.AutoSize = True
        Me.RadioButton_Feu.BackgroundImage = CType(resources.GetObject("RadioButton_Feu.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton_Feu.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Feu.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton_Feu.Location = New System.Drawing.Point(3, 96)
        Me.RadioButton_Feu.Name = "RadioButton_Feu"
        Me.RadioButton_Feu.Size = New System.Drawing.Size(78, 34)
        Me.RadioButton_Feu.TabIndex = 2
        Me.RadioButton_Feu.TabStop = True
        Me.RadioButton_Feu.Text = "Feu"
        Me.RadioButton_Feu.UseVisualStyleBackColor = True
        '
        'RadioButton_Aquatique
        '
        Me.RadioButton_Aquatique.AutoSize = True
        Me.RadioButton_Aquatique.BackgroundImage = CType(resources.GetObject("RadioButton_Aquatique.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton_Aquatique.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Aquatique.ForeColor = System.Drawing.SystemColors.Control
        Me.RadioButton_Aquatique.Location = New System.Drawing.Point(3, 53)
        Me.RadioButton_Aquatique.Name = "RadioButton_Aquatique"
        Me.RadioButton_Aquatique.Size = New System.Drawing.Size(154, 34)
        Me.RadioButton_Aquatique.TabIndex = 1
        Me.RadioButton_Aquatique.TabStop = True
        Me.RadioButton_Aquatique.Text = "Aquatique"
        Me.RadioButton_Aquatique.UseVisualStyleBackColor = True
        '
        'RadioButton_Metallique
        '
        Me.RadioButton_Metallique.AutoSize = True
        Me.RadioButton_Metallique.BackgroundImage = CType(resources.GetObject("RadioButton_Metallique.BackgroundImage"), System.Drawing.Image)
        Me.RadioButton_Metallique.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Metallique.ForeColor = System.Drawing.Color.FloralWhite
        Me.RadioButton_Metallique.Location = New System.Drawing.Point(3, 13)
        Me.RadioButton_Metallique.Name = "RadioButton_Metallique"
        Me.RadioButton_Metallique.Size = New System.Drawing.Size(158, 34)
        Me.RadioButton_Metallique.TabIndex = 0
        Me.RadioButton_Metallique.TabStop = True
        Me.RadioButton_Metallique.Text = "Métallique"
        Me.RadioButton_Metallique.UseVisualStyleBackColor = True
        '
        'CheckBox_SauvAuto
        '
        Me.CheckBox_SauvAuto.AutoSize = True
        Me.CheckBox_SauvAuto.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_SauvAuto.Location = New System.Drawing.Point(15, 191)
        Me.CheckBox_SauvAuto.Name = "CheckBox_SauvAuto"
        Me.CheckBox_SauvAuto.Size = New System.Drawing.Size(146, 17)
        Me.CheckBox_SauvAuto.TabIndex = 7
        Me.CheckBox_SauvAuto.Text = "Sauvegarde Automatique"
        Me.CheckBox_SauvAuto.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(199, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Musique de fond:"
        '
        'PanelMusique
        '
        Me.PanelMusique.BackColor = System.Drawing.Color.Transparent
        Me.PanelMusique.Controls.Add(Me.RadioButton_noMusic)
        Me.PanelMusique.Controls.Add(Me.RadioButton_Mario)
        Me.PanelMusique.Controls.Add(Me.RadioButton_N)
        Me.PanelMusique.Controls.Add(Me.RadioButton_MuteCity)
        Me.PanelMusique.Location = New System.Drawing.Point(167, 105)
        Me.PanelMusique.Name = "PanelMusique"
        Me.PanelMusique.Size = New System.Drawing.Size(166, 183)
        Me.PanelMusique.TabIndex = 7
        '
        'RadioButton_noMusic
        '
        Me.RadioButton_noMusic.AutoSize = True
        Me.RadioButton_noMusic.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_noMusic.Location = New System.Drawing.Point(6, 136)
        Me.RadioButton_noMusic.Name = "RadioButton_noMusic"
        Me.RadioButton_noMusic.Size = New System.Drawing.Size(139, 17)
        Me.RadioButton_noMusic.TabIndex = 3
        Me.RadioButton_noMusic.Text = "Pas de musique de fond"
        Me.RadioButton_noMusic.UseVisualStyleBackColor = False
        '
        'RadioButton_Mario
        '
        Me.RadioButton_Mario.AutoSize = True
        Me.RadioButton_Mario.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_Mario.Location = New System.Drawing.Point(6, 96)
        Me.RadioButton_Mario.Name = "RadioButton_Mario"
        Me.RadioButton_Mario.Size = New System.Drawing.Size(154, 17)
        Me.RadioButton_Mario.TabIndex = 2
        Me.RadioButton_Mario.Text = "Dernier Boss: Mario et Luigi"
        Me.RadioButton_Mario.UseVisualStyleBackColor = False
        '
        'RadioButton_N
        '
        Me.RadioButton_N.AutoSize = True
        Me.RadioButton_N.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_N.Location = New System.Drawing.Point(6, 53)
        Me.RadioButton_N.Name = "RadioButton_N"
        Me.RadioButton_N.Size = New System.Drawing.Size(150, 17)
        Me.RadioButton_N.TabIndex = 1
        Me.RadioButton_N.Text = "N de Pokémon Noir/Blanc"
        Me.RadioButton_N.UseVisualStyleBackColor = False
        '
        'RadioButton_MuteCity
        '
        Me.RadioButton_MuteCity.AutoSize = True
        Me.RadioButton_MuteCity.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton_MuteCity.Checked = True
        Me.RadioButton_MuteCity.Location = New System.Drawing.Point(6, 13)
        Me.RadioButton_MuteCity.Name = "RadioButton_MuteCity"
        Me.RadioButton_MuteCity.Size = New System.Drawing.Size(147, 17)
        Me.RadioButton_MuteCity.TabIndex = 0
        Me.RadioButton_MuteCity.TabStop = True
        Me.RadioButton_MuteCity.Text = "MuteCity de F-Zero SNES"
        Me.RadioButton_MuteCity.UseVisualStyleBackColor = False
        '
        'CheckBox_NonCylindrique
        '
        Me.CheckBox_NonCylindrique.AutoSize = True
        Me.CheckBox_NonCylindrique.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_NonCylindrique.Location = New System.Drawing.Point(15, 230)
        Me.CheckBox_NonCylindrique.Name = "CheckBox_NonCylindrique"
        Me.CheckBox_NonCylindrique.Size = New System.Drawing.Size(130, 17)
        Me.CheckBox_NonCylindrique.TabIndex = 9
        Me.CheckBox_NonCylindrique.Text = "Mode Non Cylindrique"
        Me.CheckBox_NonCylindrique.UseVisualStyleBackColor = False
        '
        'CheckBox_désacTimer
        '
        Me.CheckBox_désacTimer.AutoSize = True
        Me.CheckBox_désacTimer.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_désacTimer.Location = New System.Drawing.Point(15, 150)
        Me.CheckBox_désacTimer.Name = "CheckBox_désacTimer"
        Me.CheckBox_désacTimer.Size = New System.Drawing.Size(113, 17)
        Me.CheckBox_désacTimer.TabIndex = 10
        Me.CheckBox_désacTimer.Text = "Désactiver le timer"
        Me.CheckBox_désacTimer.UseVisualStyleBackColor = False
        '
        'Bouton_Charger
        '
        Me.Bouton_Charger.Location = New System.Drawing.Point(296, 321)
        Me.Bouton_Charger.Name = "Bouton_Charger"
        Me.Bouton_Charger.Size = New System.Drawing.Size(102, 40)
        Me.Bouton_Charger.TabIndex = 11
        Me.Bouton_Charger.Text = "Charger"
        Me.Bouton_Charger.UseVisualStyleBackColor = True
        '
        'Bouton_Sauvegarder
        '
        Me.Bouton_Sauvegarder.Location = New System.Drawing.Point(426, 321)
        Me.Bouton_Sauvegarder.Name = "Bouton_Sauvegarder"
        Me.Bouton_Sauvegarder.Size = New System.Drawing.Size(102, 40)
        Me.Bouton_Sauvegarder.TabIndex = 12
        Me.Bouton_Sauvegarder.Text = "Sauvegarder"
        Me.Bouton_Sauvegarder.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(547, 373)
        Me.Controls.Add(Me.Bouton_Sauvegarder)
        Me.Controls.Add(Me.Bouton_Charger)
        Me.Controls.Add(Me.CheckBox_désacTimer)
        Me.Controls.Add(Me.CheckBox_NonCylindrique)
        Me.Controls.Add(Me.PanelMusique)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox_SauvAuto)
        Me.Controls.Add(Me.PanelGraphismes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bouton_Annuler)
        Me.Controls.Add(Me.Bouton_Enrg)
        Me.Controls.Add(Me.TextBox_Timer)
        Me.Controls.Add(Me.Label_Timer)
        Me.Controls.Add(Me.Label_Titre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.PanelGraphismes.ResumeLayout(False)
        Me.PanelGraphismes.PerformLayout()
        Me.PanelMusique.ResumeLayout(False)
        Me.PanelMusique.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Titre As Label
    Friend WithEvents Label_Timer As Label
    Friend WithEvents TextBox_Timer As TextBox
    Friend WithEvents Bouton_Enrg As Button
    Friend WithEvents Bouton_Annuler As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelGraphismes As Panel
    Friend WithEvents RadioButton_Espace As RadioButton
    Friend WithEvents RadioButton_Feu As RadioButton
    Friend WithEvents RadioButton_Aquatique As RadioButton
    Friend WithEvents RadioButton_Metallique As RadioButton
    Friend WithEvents CheckBox_SauvAuto As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMusique As Panel
    Friend WithEvents RadioButton_noMusic As RadioButton
    Friend WithEvents RadioButton_Mario As RadioButton
    Friend WithEvents RadioButton_N As RadioButton
    Friend WithEvents RadioButton_MuteCity As RadioButton
    Friend WithEvents CheckBox_NonCylindrique As CheckBox
    Friend WithEvents CheckBox_désacTimer As CheckBox
    Friend WithEvents Bouton_Charger As Button
    Friend WithEvents Bouton_Sauvegarder As Button
End Class
