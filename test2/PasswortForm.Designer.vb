<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PasswortForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PasswortForm))
        Me.NeuesPasswortGenerierenButton = New System.Windows.Forms.Button()
        Me.PasswortBox = New System.Windows.Forms.TextBox()
        Me.GepeichertePasswörterBox = New System.Windows.Forms.TextBox()
        Me.SpeichernButton = New System.Windows.Forms.Button()
        Me.VerwendungsBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NeuesPasswortGenerierenButton
        '
        Me.NeuesPasswortGenerierenButton.Location = New System.Drawing.Point(323, 21)
        Me.NeuesPasswortGenerierenButton.Name = "NeuesPasswortGenerierenButton"
        Me.NeuesPasswortGenerierenButton.Size = New System.Drawing.Size(105, 23)
        Me.NeuesPasswortGenerierenButton.TabIndex = 1
        Me.NeuesPasswortGenerierenButton.Text = "Neues Paswort"
        Me.NeuesPasswortGenerierenButton.UseVisualStyleBackColor = True
        '
        'PasswortBox
        '
        Me.PasswortBox.Location = New System.Drawing.Point(12, 23)
        Me.PasswortBox.Name = "PasswortBox"
        Me.PasswortBox.ReadOnly = True
        Me.PasswortBox.Size = New System.Drawing.Size(305, 20)
        Me.PasswortBox.TabIndex = 3
        '
        'GepeichertePasswörterBox
        '
        Me.GepeichertePasswörterBox.AcceptsReturn = True
        Me.GepeichertePasswörterBox.Location = New System.Drawing.Point(12, 105)
        Me.GepeichertePasswörterBox.Multiline = True
        Me.GepeichertePasswörterBox.Name = "GepeichertePasswörterBox"
        Me.GepeichertePasswörterBox.ReadOnly = True
        Me.GepeichertePasswörterBox.Size = New System.Drawing.Size(305, 270)
        Me.GepeichertePasswörterBox.TabIndex = 4
        '
        'SpeichernButton
        '
        Me.SpeichernButton.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolTip
        Me.SpeichernButton.Location = New System.Drawing.Point(323, 60)
        Me.SpeichernButton.Name = "SpeichernButton"
        Me.SpeichernButton.Size = New System.Drawing.Size(105, 23)
        Me.SpeichernButton.TabIndex = 5
        Me.SpeichernButton.Text = "Speichern"
        Me.SpeichernButton.UseVisualStyleBackColor = True
        '
        'VerwendungsBox
        '
        Me.VerwendungsBox.Location = New System.Drawing.Point(12, 62)
        Me.VerwendungsBox.Name = "VerwendungsBox"
        Me.VerwendungsBox.Size = New System.Drawing.Size(305, 20)
        Me.VerwendungsBox.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Passwort:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label2.Location = New System.Drawing.Point(9, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Verwendungszweck:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label3.Location = New System.Drawing.Point(9, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gespeicherte Passwörter:"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(345, 134)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(68, 46)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 14
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(345, 186)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(345, 238)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(68, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 16
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(345, 277)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(68, 63)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 17
        Me.PictureBox4.TabStop = False
        '
        'PasswortForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(448, 398)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.VerwendungsBox)
        Me.Controls.Add(Me.SpeichernButton)
        Me.Controls.Add(Me.GepeichertePasswörterBox)
        Me.Controls.Add(Me.PasswortBox)
        Me.Controls.Add(Me.NeuesPasswortGenerierenButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "PasswortForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Passwort-Generator"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NeuesPasswortGenerierenButton As Button
    Friend WithEvents PasswortBox As TextBox
    Friend WithEvents GepeichertePasswörterBox As TextBox
    Friend WithEvents SpeichernButton As Button
    Friend WithEvents VerwendungsBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
