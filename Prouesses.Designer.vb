<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prouesses
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prouesses))
        Me.Label_Titre = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Bouton_Champion = New System.Windows.Forms.Button()
        Me.Bouton_Invincible = New System.Windows.Forms.Button()
        Me.Bouton_Habile = New System.Windows.Forms.Button()
        Me.Bouton_Detective = New System.Windows.Forms.Button()
        Me.Bouton_Einstein = New System.Windows.Forms.Button()
        Me.Bouton_Sansvie = New System.Windows.Forms.Button()
        Me.Bouton_Retour = New System.Windows.Forms.Button()
        Me.Timer_Fin = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label_Titre
        '
        Me.Label_Titre.AutoSize = True
        Me.Label_Titre.BackColor = System.Drawing.Color.Transparent
        Me.Label_Titre.Font = New System.Drawing.Font("Ink Free", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Titre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_Titre.Location = New System.Drawing.Point(54, 22)
        Me.Label_Titre.Name = "Label_Titre"
        Me.Label_Titre.Size = New System.Drawing.Size(290, 60)
        Me.Label_Titre.TabIndex = 0
        Me.Label_Titre.Text = "PROUESSES"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1565, -143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 81)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Bouton_Champion
        '
        Me.Bouton_Champion.BackgroundImage = CType(resources.GetObject("Bouton_Champion.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Champion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bouton_Champion.Location = New System.Drawing.Point(12, 131)
        Me.Bouton_Champion.Name = "Bouton_Champion"
        Me.Bouton_Champion.Size = New System.Drawing.Size(109, 86)
        Me.Bouton_Champion.TabIndex = 2
        Me.Bouton_Champion.UseVisualStyleBackColor = True
        '
        'Bouton_Invincible
        '
        Me.Bouton_Invincible.BackgroundImage = CType(resources.GetObject("Bouton_Invincible.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Invincible.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bouton_Invincible.Location = New System.Drawing.Point(139, 131)
        Me.Bouton_Invincible.Name = "Bouton_Invincible"
        Me.Bouton_Invincible.Size = New System.Drawing.Size(109, 86)
        Me.Bouton_Invincible.TabIndex = 3
        Me.Bouton_Invincible.UseVisualStyleBackColor = True
        '
        'Bouton_Habile
        '
        Me.Bouton_Habile.BackgroundImage = CType(resources.GetObject("Bouton_Habile.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Habile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bouton_Habile.Location = New System.Drawing.Point(268, 131)
        Me.Bouton_Habile.Name = "Bouton_Habile"
        Me.Bouton_Habile.Size = New System.Drawing.Size(109, 86)
        Me.Bouton_Habile.TabIndex = 4
        Me.Bouton_Habile.UseVisualStyleBackColor = True
        '
        'Bouton_Detective
        '
        Me.Bouton_Detective.BackgroundImage = CType(resources.GetObject("Bouton_Detective.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Detective.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bouton_Detective.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bouton_Detective.Location = New System.Drawing.Point(268, 241)
        Me.Bouton_Detective.Name = "Bouton_Detective"
        Me.Bouton_Detective.Size = New System.Drawing.Size(109, 86)
        Me.Bouton_Detective.TabIndex = 7
        Me.Bouton_Detective.UseVisualStyleBackColor = True
        '
        'Bouton_Einstein
        '
        Me.Bouton_Einstein.BackgroundImage = CType(resources.GetObject("Bouton_Einstein.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Einstein.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bouton_Einstein.Location = New System.Drawing.Point(139, 241)
        Me.Bouton_Einstein.Name = "Bouton_Einstein"
        Me.Bouton_Einstein.Size = New System.Drawing.Size(109, 86)
        Me.Bouton_Einstein.TabIndex = 6
        Me.Bouton_Einstein.UseVisualStyleBackColor = True
        '
        'Bouton_Sansvie
        '
        Me.Bouton_Sansvie.BackgroundImage = CType(resources.GetObject("Bouton_Sansvie.BackgroundImage"), System.Drawing.Image)
        Me.Bouton_Sansvie.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Bouton_Sansvie.Location = New System.Drawing.Point(12, 241)
        Me.Bouton_Sansvie.Name = "Bouton_Sansvie"
        Me.Bouton_Sansvie.Size = New System.Drawing.Size(109, 86)
        Me.Bouton_Sansvie.TabIndex = 5
        Me.Bouton_Sansvie.UseVisualStyleBackColor = True
        '
        'Bouton_Retour
        '
        Me.Bouton_Retour.BackColor = System.Drawing.Color.LightGray
        Me.Bouton_Retour.Location = New System.Drawing.Point(156, 362)
        Me.Bouton_Retour.Name = "Bouton_Retour"
        Me.Bouton_Retour.Size = New System.Drawing.Size(75, 23)
        Me.Bouton_Retour.TabIndex = 8
        Me.Bouton_Retour.Text = "Retour"
        Me.Bouton_Retour.UseVisualStyleBackColor = False
        '
        'Timer_Fin
        '
        Me.Timer_Fin.Interval = 1000
        '
        'Prouesses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(394, 424)
        Me.Controls.Add(Me.Bouton_Retour)
        Me.Controls.Add(Me.Bouton_Detective)
        Me.Controls.Add(Me.Bouton_Einstein)
        Me.Controls.Add(Me.Bouton_Sansvie)
        Me.Controls.Add(Me.Bouton_Habile)
        Me.Controls.Add(Me.Bouton_Invincible)
        Me.Controls.Add(Me.Bouton_Champion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label_Titre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Prouesses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Succès"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label_Titre As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Bouton_Champion As Button
    Friend WithEvents Bouton_Invincible As Button
    Friend WithEvents Bouton_Habile As Button
    Friend WithEvents Bouton_Detective As Button
    Friend WithEvents Bouton_Einstein As Button
    Friend WithEvents Bouton_Sansvie As Button
    Friend WithEvents Bouton_Retour As Button
    Friend WithEvents Timer_Fin As Timer
End Class
