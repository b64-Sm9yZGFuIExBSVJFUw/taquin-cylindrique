<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Taquin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Taquin))
        Me.Piece_1 = New System.Windows.Forms.Button()
        Me.Piece_2 = New System.Windows.Forms.Button()
        Me.Piece_3 = New System.Windows.Forms.Button()
        Me.Piece_4 = New System.Windows.Forms.Button()
        Me.Piece_8 = New System.Windows.Forms.Button()
        Me.Piece_7 = New System.Windows.Forms.Button()
        Me.Piece_6 = New System.Windows.Forms.Button()
        Me.Piece_5 = New System.Windows.Forms.Button()
        Me.Piece_16 = New System.Windows.Forms.Button()
        Me.Piece_15 = New System.Windows.Forms.Button()
        Me.Piece_14 = New System.Windows.Forms.Button()
        Me.Piece_13 = New System.Windows.Forms.Button()
        Me.Piece_12 = New System.Windows.Forms.Button()
        Me.Piece_10 = New System.Windows.Forms.Button()
        Me.Piece_9 = New System.Windows.Forms.Button()
        Me.Piece_11 = New System.Windows.Forms.Button()
        Me.PanelPieces = New System.Windows.Forms.Panel()
        Me.ButtonAbandonner = New System.Windows.Forms.Button()
        Me.Label_Joueur = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Temps = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CheckBox_Pause = New System.Windows.Forms.CheckBox()
        Me.Bouton_ProchainCoup = New System.Windows.Forms.Button()
        Me.Bouton_TouteSolution = New System.Windows.Forms.Button()
        Me.Timer_Random = New System.Windows.Forms.Timer(Me.components)
        Me.PanelPieces.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Piece_1
        '
        Me.Piece_1.BackgroundImage = CType(resources.GetObject("Piece_1.BackgroundImage"), System.Drawing.Image)
        Me.Piece_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_1.ForeColor = System.Drawing.Color.Blue
        Me.Piece_1.Location = New System.Drawing.Point(10, 15)
        Me.Piece_1.Name = "Piece_1"
        Me.Piece_1.Size = New System.Drawing.Size(93, 85)
        Me.Piece_1.TabIndex = 1
        Me.Piece_1.Tag = "1"
        Me.Piece_1.Text = "1"
        Me.Piece_1.UseVisualStyleBackColor = True
        '
        'Piece_2
        '
        Me.Piece_2.BackgroundImage = CType(resources.GetObject("Piece_2.BackgroundImage"), System.Drawing.Image)
        Me.Piece_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_2.ForeColor = System.Drawing.Color.Blue
        Me.Piece_2.Location = New System.Drawing.Point(109, 15)
        Me.Piece_2.Name = "Piece_2"
        Me.Piece_2.Size = New System.Drawing.Size(93, 85)
        Me.Piece_2.TabIndex = 2
        Me.Piece_2.Tag = "2"
        Me.Piece_2.Text = "2"
        Me.Piece_2.UseVisualStyleBackColor = True
        '
        'Piece_3
        '
        Me.Piece_3.BackgroundImage = CType(resources.GetObject("Piece_3.BackgroundImage"), System.Drawing.Image)
        Me.Piece_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_3.ForeColor = System.Drawing.Color.Blue
        Me.Piece_3.Location = New System.Drawing.Point(208, 15)
        Me.Piece_3.Name = "Piece_3"
        Me.Piece_3.Size = New System.Drawing.Size(93, 85)
        Me.Piece_3.TabIndex = 3
        Me.Piece_3.Tag = "3"
        Me.Piece_3.Text = "3"
        Me.Piece_3.UseVisualStyleBackColor = True
        '
        'Piece_4
        '
        Me.Piece_4.BackgroundImage = CType(resources.GetObject("Piece_4.BackgroundImage"), System.Drawing.Image)
        Me.Piece_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_4.ForeColor = System.Drawing.Color.Blue
        Me.Piece_4.Location = New System.Drawing.Point(307, 15)
        Me.Piece_4.Name = "Piece_4"
        Me.Piece_4.Size = New System.Drawing.Size(93, 85)
        Me.Piece_4.TabIndex = 4
        Me.Piece_4.Tag = "4"
        Me.Piece_4.Text = "4"
        Me.Piece_4.UseVisualStyleBackColor = True
        '
        'Piece_8
        '
        Me.Piece_8.BackgroundImage = CType(resources.GetObject("Piece_8.BackgroundImage"), System.Drawing.Image)
        Me.Piece_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_8.ForeColor = System.Drawing.Color.Blue
        Me.Piece_8.Location = New System.Drawing.Point(307, 106)
        Me.Piece_8.Name = "Piece_8"
        Me.Piece_8.Size = New System.Drawing.Size(93, 85)
        Me.Piece_8.TabIndex = 8
        Me.Piece_8.Tag = "8"
        Me.Piece_8.Text = "8"
        Me.Piece_8.UseVisualStyleBackColor = True
        '
        'Piece_7
        '
        Me.Piece_7.BackgroundImage = CType(resources.GetObject("Piece_7.BackgroundImage"), System.Drawing.Image)
        Me.Piece_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_7.ForeColor = System.Drawing.Color.Blue
        Me.Piece_7.Location = New System.Drawing.Point(208, 106)
        Me.Piece_7.Name = "Piece_7"
        Me.Piece_7.Size = New System.Drawing.Size(93, 85)
        Me.Piece_7.TabIndex = 7
        Me.Piece_7.Tag = "7"
        Me.Piece_7.Text = "7"
        Me.Piece_7.UseVisualStyleBackColor = True
        '
        'Piece_6
        '
        Me.Piece_6.BackgroundImage = CType(resources.GetObject("Piece_6.BackgroundImage"), System.Drawing.Image)
        Me.Piece_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_6.ForeColor = System.Drawing.Color.Blue
        Me.Piece_6.Location = New System.Drawing.Point(109, 106)
        Me.Piece_6.Name = "Piece_6"
        Me.Piece_6.Size = New System.Drawing.Size(93, 85)
        Me.Piece_6.TabIndex = 6
        Me.Piece_6.Tag = "6"
        Me.Piece_6.Text = "6"
        Me.Piece_6.UseVisualStyleBackColor = True
        '
        'Piece_5
        '
        Me.Piece_5.BackgroundImage = CType(resources.GetObject("Piece_5.BackgroundImage"), System.Drawing.Image)
        Me.Piece_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_5.ForeColor = System.Drawing.Color.Blue
        Me.Piece_5.Location = New System.Drawing.Point(10, 106)
        Me.Piece_5.Name = "Piece_5"
        Me.Piece_5.Size = New System.Drawing.Size(93, 85)
        Me.Piece_5.TabIndex = 5
        Me.Piece_5.Tag = "5"
        Me.Piece_5.Text = "5"
        Me.Piece_5.UseVisualStyleBackColor = True
        '
        'Piece_16
        '
        Me.Piece_16.BackgroundImage = CType(resources.GetObject("Piece_16.BackgroundImage"), System.Drawing.Image)
        Me.Piece_16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_16.ForeColor = System.Drawing.Color.Blue
        Me.Piece_16.Location = New System.Drawing.Point(307, 288)
        Me.Piece_16.Name = "Piece_16"
        Me.Piece_16.Size = New System.Drawing.Size(93, 85)
        Me.Piece_16.TabIndex = 16
        Me.Piece_16.Tag = "16"
        Me.Piece_16.Text = "16"
        Me.Piece_16.UseVisualStyleBackColor = True
        Me.Piece_16.Visible = False
        '
        'Piece_15
        '
        Me.Piece_15.BackgroundImage = CType(resources.GetObject("Piece_15.BackgroundImage"), System.Drawing.Image)
        Me.Piece_15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_15.ForeColor = System.Drawing.Color.Blue
        Me.Piece_15.Location = New System.Drawing.Point(208, 288)
        Me.Piece_15.Name = "Piece_15"
        Me.Piece_15.Size = New System.Drawing.Size(93, 85)
        Me.Piece_15.TabIndex = 15
        Me.Piece_15.Tag = "15"
        Me.Piece_15.Text = "15"
        Me.Piece_15.UseVisualStyleBackColor = True
        '
        'Piece_14
        '
        Me.Piece_14.BackgroundImage = CType(resources.GetObject("Piece_14.BackgroundImage"), System.Drawing.Image)
        Me.Piece_14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_14.ForeColor = System.Drawing.Color.Blue
        Me.Piece_14.Location = New System.Drawing.Point(109, 288)
        Me.Piece_14.Name = "Piece_14"
        Me.Piece_14.Size = New System.Drawing.Size(93, 85)
        Me.Piece_14.TabIndex = 14
        Me.Piece_14.Tag = "14"
        Me.Piece_14.Text = "14"
        Me.Piece_14.UseVisualStyleBackColor = True
        '
        'Piece_13
        '
        Me.Piece_13.BackgroundImage = CType(resources.GetObject("Piece_13.BackgroundImage"), System.Drawing.Image)
        Me.Piece_13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_13.ForeColor = System.Drawing.Color.Blue
        Me.Piece_13.Location = New System.Drawing.Point(10, 288)
        Me.Piece_13.Name = "Piece_13"
        Me.Piece_13.Size = New System.Drawing.Size(93, 85)
        Me.Piece_13.TabIndex = 13
        Me.Piece_13.Tag = "13"
        Me.Piece_13.Text = "13"
        Me.Piece_13.UseVisualStyleBackColor = True
        '
        'Piece_12
        '
        Me.Piece_12.BackgroundImage = CType(resources.GetObject("Piece_12.BackgroundImage"), System.Drawing.Image)
        Me.Piece_12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_12.ForeColor = System.Drawing.Color.Blue
        Me.Piece_12.Location = New System.Drawing.Point(307, 197)
        Me.Piece_12.Name = "Piece_12"
        Me.Piece_12.Size = New System.Drawing.Size(93, 85)
        Me.Piece_12.TabIndex = 12
        Me.Piece_12.Tag = "12"
        Me.Piece_12.Text = "12"
        Me.Piece_12.UseVisualStyleBackColor = True
        '
        'Piece_10
        '
        Me.Piece_10.BackgroundImage = CType(resources.GetObject("Piece_10.BackgroundImage"), System.Drawing.Image)
        Me.Piece_10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_10.ForeColor = System.Drawing.Color.Blue
        Me.Piece_10.Location = New System.Drawing.Point(109, 197)
        Me.Piece_10.Name = "Piece_10"
        Me.Piece_10.Size = New System.Drawing.Size(93, 85)
        Me.Piece_10.TabIndex = 10
        Me.Piece_10.Tag = "10"
        Me.Piece_10.Text = "10"
        Me.Piece_10.UseVisualStyleBackColor = True
        '
        'Piece_9
        '
        Me.Piece_9.BackgroundImage = CType(resources.GetObject("Piece_9.BackgroundImage"), System.Drawing.Image)
        Me.Piece_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_9.ForeColor = System.Drawing.Color.Blue
        Me.Piece_9.Location = New System.Drawing.Point(10, 197)
        Me.Piece_9.Name = "Piece_9"
        Me.Piece_9.Size = New System.Drawing.Size(93, 85)
        Me.Piece_9.TabIndex = 9
        Me.Piece_9.Tag = "9"
        Me.Piece_9.Text = "9"
        Me.Piece_9.UseVisualStyleBackColor = True
        '
        'Piece_11
        '
        Me.Piece_11.BackgroundImage = CType(resources.GetObject("Piece_11.BackgroundImage"), System.Drawing.Image)
        Me.Piece_11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Piece_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Piece_11.ForeColor = System.Drawing.Color.Blue
        Me.Piece_11.Location = New System.Drawing.Point(208, 197)
        Me.Piece_11.Name = "Piece_11"
        Me.Piece_11.Size = New System.Drawing.Size(93, 85)
        Me.Piece_11.TabIndex = 11
        Me.Piece_11.Tag = "11"
        Me.Piece_11.Text = "11"
        Me.Piece_11.UseVisualStyleBackColor = True
        '
        'PanelPieces
        '
        Me.PanelPieces.BackgroundImage = CType(resources.GetObject("PanelPieces.BackgroundImage"), System.Drawing.Image)
        Me.PanelPieces.Controls.Add(Me.Piece_16)
        Me.PanelPieces.Controls.Add(Me.Piece_11)
        Me.PanelPieces.Controls.Add(Me.Piece_1)
        Me.PanelPieces.Controls.Add(Me.Piece_2)
        Me.PanelPieces.Controls.Add(Me.Piece_15)
        Me.PanelPieces.Controls.Add(Me.Piece_3)
        Me.PanelPieces.Controls.Add(Me.Piece_14)
        Me.PanelPieces.Controls.Add(Me.Piece_4)
        Me.PanelPieces.Controls.Add(Me.Piece_13)
        Me.PanelPieces.Controls.Add(Me.Piece_5)
        Me.PanelPieces.Controls.Add(Me.Piece_12)
        Me.PanelPieces.Controls.Add(Me.Piece_6)
        Me.PanelPieces.Controls.Add(Me.Piece_10)
        Me.PanelPieces.Controls.Add(Me.Piece_7)
        Me.PanelPieces.Controls.Add(Me.Piece_9)
        Me.PanelPieces.Controls.Add(Me.Piece_8)
        Me.PanelPieces.Location = New System.Drawing.Point(26, 36)
        Me.PanelPieces.Name = "PanelPieces"
        Me.PanelPieces.Size = New System.Drawing.Size(412, 388)
        Me.PanelPieces.TabIndex = 17
        '
        'ButtonAbandonner
        '
        Me.ButtonAbandonner.BackgroundImage = CType(resources.GetObject("ButtonAbandonner.BackgroundImage"), System.Drawing.Image)
        Me.ButtonAbandonner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonAbandonner.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonAbandonner.Location = New System.Drawing.Point(463, 362)
        Me.ButtonAbandonner.Name = "ButtonAbandonner"
        Me.ButtonAbandonner.Size = New System.Drawing.Size(316, 76)
        Me.ButtonAbandonner.TabIndex = 18
        Me.ButtonAbandonner.Text = "ABANDONNER"
        Me.ButtonAbandonner.UseVisualStyleBackColor = True
        '
        'Label_Joueur
        '
        Me.Label_Joueur.AutoSize = True
        Me.Label_Joueur.BackColor = System.Drawing.Color.Transparent
        Me.Label_Joueur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Joueur.Location = New System.Drawing.Point(477, 9)
        Me.Label_Joueur.Name = "Label_Joueur"
        Me.Label_Joueur.Size = New System.Drawing.Size(74, 24)
        Me.Label_Joueur.TabIndex = 19
        Me.Label_Joueur.Text = "Joueur:"
        '
        'Timer
        '
        Me.Timer.Interval = 1000
        '
        'Temps
        '
        Me.Temps.AutoSize = True
        Me.Temps.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Temps.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Temps.ForeColor = System.Drawing.Color.Red
        Me.Temps.Image = CType(resources.GetObject("Temps.Image"), System.Drawing.Image)
        Me.Temps.Location = New System.Drawing.Point(37, 50)
        Me.Temps.Name = "Temps"
        Me.Temps.Size = New System.Drawing.Size(123, 42)
        Me.Temps.TabIndex = 20
        Me.Temps.Text = "99999"
        Me.Temps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Temps)
        Me.Panel1.Location = New System.Drawing.Point(511, 92)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(216, 154)
        Me.Panel1.TabIndex = 21
        '
        'CheckBox_Pause
        '
        Me.CheckBox_Pause.AutoSize = True
        Me.CheckBox_Pause.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox_Pause.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox_Pause.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CheckBox_Pause.Location = New System.Drawing.Point(541, 51)
        Me.CheckBox_Pause.Name = "CheckBox_Pause"
        Me.CheckBox_Pause.Size = New System.Drawing.Size(130, 35)
        Me.CheckBox_Pause.TabIndex = 22
        Me.CheckBox_Pause.Text = "PAUSE"
        Me.CheckBox_Pause.UseVisualStyleBackColor = False
        '
        'Bouton_ProchainCoup
        '
        Me.Bouton_ProchainCoup.Location = New System.Drawing.Point(463, 295)
        Me.Bouton_ProchainCoup.Name = "Bouton_ProchainCoup"
        Me.Bouton_ProchainCoup.Size = New System.Drawing.Size(136, 23)
        Me.Bouton_ProchainCoup.TabIndex = 23
        Me.Bouton_ProchainCoup.Text = "Voir prochain coup"
        Me.Bouton_ProchainCoup.UseVisualStyleBackColor = True
        '
        'Bouton_TouteSolution
        '
        Me.Bouton_TouteSolution.Location = New System.Drawing.Point(643, 295)
        Me.Bouton_TouteSolution.Name = "Bouton_TouteSolution"
        Me.Bouton_TouteSolution.Size = New System.Drawing.Size(136, 23)
        Me.Bouton_TouteSolution.TabIndex = 24
        Me.Bouton_TouteSolution.Text = "Voir solution complète"
        Me.Bouton_TouteSolution.UseVisualStyleBackColor = True
        '
        'Timer_Random
        '
        Me.Timer_Random.Interval = 10
        '
        'Taquin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Bouton_TouteSolution)
        Me.Controls.Add(Me.Bouton_ProchainCoup)
        Me.Controls.Add(Me.CheckBox_Pause)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label_Joueur)
        Me.Controls.Add(Me.ButtonAbandonner)
        Me.Controls.Add(Me.PanelPieces)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Taquin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taquin"
        Me.PanelPieces.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Piece_1 As Button
    Friend WithEvents Piece_2 As Button
    Friend WithEvents Piece_3 As Button
    Friend WithEvents Piece_4 As Button
    Friend WithEvents Piece_8 As Button
    Friend WithEvents Piece_7 As Button
    Friend WithEvents Piece_6 As Button
    Friend WithEvents Piece_5 As Button
    Friend WithEvents Piece_16 As Button
    Friend WithEvents Piece_15 As Button
    Friend WithEvents Piece_14 As Button
    Friend WithEvents Piece_13 As Button
    Friend WithEvents Piece_12 As Button
    Friend WithEvents Piece_10 As Button
    Friend WithEvents Piece_9 As Button
    Friend WithEvents Piece_11 As Button
    Friend WithEvents PanelPieces As Panel
    Friend WithEvents ButtonAbandonner As Button
    Friend WithEvents Label_Joueur As Label
    Friend WithEvents Timer As Timer
    Friend WithEvents Temps As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CheckBox_Pause As CheckBox
    Friend WithEvents Bouton_ProchainCoup As Button
    Friend WithEvents Bouton_TouteSolution As Button
    Friend WithEvents Timer_Random As Timer
End Class
