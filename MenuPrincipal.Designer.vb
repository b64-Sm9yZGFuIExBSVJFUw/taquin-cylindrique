<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Bouton_Jouer = New System.Windows.Forms.Button()
        Me.Bouton_Quitter = New System.Windows.Forms.Button()
        Me.Bouton_Tableau = New System.Windows.Forms.Button()
        Me.Bouton_Prouesses = New System.Windows.Forms.Button()
        Me.Musique = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.Musique, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bouton_Jouer
        '
        Me.Bouton_Jouer.BackColor = System.Drawing.Color.White
        Me.Bouton_Jouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bouton_Jouer.Location = New System.Drawing.Point(24, 305)
        Me.Bouton_Jouer.Name = "Bouton_Jouer"
        Me.Bouton_Jouer.Size = New System.Drawing.Size(122, 63)
        Me.Bouton_Jouer.TabIndex = 0
        Me.Bouton_Jouer.Text = "Jouer!"
        Me.Bouton_Jouer.UseVisualStyleBackColor = False
        '
        'Bouton_Quitter
        '
        Me.Bouton_Quitter.BackColor = System.Drawing.Color.White
        Me.Bouton_Quitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bouton_Quitter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bouton_Quitter.Location = New System.Drawing.Point(465, 305)
        Me.Bouton_Quitter.Name = "Bouton_Quitter"
        Me.Bouton_Quitter.Size = New System.Drawing.Size(122, 63)
        Me.Bouton_Quitter.TabIndex = 1
        Me.Bouton_Quitter.Text = "Quitter..."
        Me.Bouton_Quitter.UseVisualStyleBackColor = False
        '
        'Bouton_Tableau
        '
        Me.Bouton_Tableau.BackColor = System.Drawing.Color.White
        Me.Bouton_Tableau.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bouton_Tableau.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bouton_Tableau.Location = New System.Drawing.Point(315, 305)
        Me.Bouton_Tableau.Name = "Bouton_Tableau"
        Me.Bouton_Tableau.Size = New System.Drawing.Size(122, 63)
        Me.Bouton_Tableau.TabIndex = 2
        Me.Bouton_Tableau.Text = "Afficher les scores"
        Me.Bouton_Tableau.UseVisualStyleBackColor = False
        '
        'Bouton_Prouesses
        '
        Me.Bouton_Prouesses.BackColor = System.Drawing.Color.White
        Me.Bouton_Prouesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bouton_Prouesses.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Bouton_Prouesses.Location = New System.Drawing.Point(169, 305)
        Me.Bouton_Prouesses.Name = "Bouton_Prouesses"
        Me.Bouton_Prouesses.Size = New System.Drawing.Size(122, 63)
        Me.Bouton_Prouesses.TabIndex = 3
        Me.Bouton_Prouesses.Text = "Prouesses"
        Me.Bouton_Prouesses.UseVisualStyleBackColor = False
        '
        'Musique
        '
        Me.Musique.Enabled = True
        Me.Musique.Location = New System.Drawing.Point(556, 107)
        Me.Musique.Name = "Musique"
        Me.Musique.OcxState = CType(resources.GetObject("Musique.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Musique.Size = New System.Drawing.Size(10, 10)
        Me.Musique.TabIndex = 7
        Me.Musique.Visible = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(611, 408)
        Me.Controls.Add(Me.Musique)
        Me.Controls.Add(Me.Bouton_Prouesses)
        Me.Controls.Add(Me.Bouton_Tableau)
        Me.Controls.Add(Me.Bouton_Quitter)
        Me.Controls.Add(Me.Bouton_Jouer)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le Taquin Cylindrique"
        CType(Me.Musique, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Bouton_Jouer As Button
    Friend WithEvents Bouton_Quitter As Button
    Friend WithEvents Bouton_Tableau As Button
    Friend WithEvents Bouton_Prouesses As Button
    Friend WithEvents Musique As AxWMPLib.AxWindowsMediaPlayer
End Class
