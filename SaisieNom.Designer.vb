<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SaisieNom
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaisieNom))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bouton_Confirmer = New System.Windows.Forms.Button()
        Me.Bouton_Annuler = New System.Windows.Forms.Button()
        Me.Saisie_Nom = New System.Windows.Forms.ComboBox()
        Me.Bouton_Options = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Votre nom ?"
        '
        'Bouton_Confirmer
        '
        Me.Bouton_Confirmer.Enabled = False
        Me.Bouton_Confirmer.Location = New System.Drawing.Point(140, 36)
        Me.Bouton_Confirmer.Name = "Bouton_Confirmer"
        Me.Bouton_Confirmer.Size = New System.Drawing.Size(105, 28)
        Me.Bouton_Confirmer.TabIndex = 2
        Me.Bouton_Confirmer.Text = "Confirmer"
        Me.Bouton_Confirmer.UseVisualStyleBackColor = True
        '
        'Bouton_Annuler
        '
        Me.Bouton_Annuler.Location = New System.Drawing.Point(12, 36)
        Me.Bouton_Annuler.Name = "Bouton_Annuler"
        Me.Bouton_Annuler.Size = New System.Drawing.Size(105, 28)
        Me.Bouton_Annuler.TabIndex = 3
        Me.Bouton_Annuler.Text = "Annuler"
        Me.Bouton_Annuler.UseVisualStyleBackColor = True
        '
        'Saisie_Nom
        '
        Me.Saisie_Nom.FormattingEnabled = True
        Me.Saisie_Nom.Location = New System.Drawing.Point(94, 6)
        Me.Saisie_Nom.MaxLength = 24
        Me.Saisie_Nom.Name = "Saisie_Nom"
        Me.Saisie_Nom.Size = New System.Drawing.Size(151, 21)
        Me.Saisie_Nom.TabIndex = 4
        '
        'Bouton_Options
        '
        Me.Bouton_Options.Location = New System.Drawing.Point(76, 70)
        Me.Bouton_Options.Name = "Bouton_Options"
        Me.Bouton_Options.Size = New System.Drawing.Size(105, 28)
        Me.Bouton_Options.TabIndex = 5
        Me.Bouton_Options.Text = "Options..."
        Me.Bouton_Options.UseVisualStyleBackColor = True
        '
        'SaisieNom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(257, 105)
        Me.Controls.Add(Me.Bouton_Options)
        Me.Controls.Add(Me.Saisie_Nom)
        Me.Controls.Add(Me.Bouton_Annuler)
        Me.Controls.Add(Me.Bouton_Confirmer)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SaisieNom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaisieNom"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Bouton_Confirmer As Button
    Friend WithEvents Bouton_Annuler As Button
    Friend WithEvents Saisie_Nom As ComboBox
    Friend WithEvents Bouton_Options As Button
End Class
