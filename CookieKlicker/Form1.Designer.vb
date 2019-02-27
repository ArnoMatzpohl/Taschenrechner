<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Zählerbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.KostenChormeLabel = New System.Windows.Forms.Label()
        Me.KaufenChormeButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.KaufenCleanMasterButton = New System.Windows.Forms.Button()
        Me.CleanmasterPreisLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.ChromeLevelLabel = New System.Windows.Forms.Label()
        Me.CleanMasterLevelLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(127, 115)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(432, 426)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Zählerbox
        '
        Me.Zählerbox.Enabled = False
        Me.Zählerbox.Location = New System.Drawing.Point(225, 75)
        Me.Zählerbox.Name = "Zählerbox"
        Me.Zählerbox.Size = New System.Drawing.Size(311, 20)
        Me.Zählerbox.TabIndex = 1
        Me.Zählerbox.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(162, 66)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(41, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(859, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "- Generiertautomatisch Internet Explorer Money"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(790, 227)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(761, 88)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(87, 86)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'KostenChormeLabel
        '
        Me.KostenChormeLabel.AutoSize = True
        Me.KostenChormeLabel.Location = New System.Drawing.Point(860, 244)
        Me.KostenChormeLabel.Name = "KostenChormeLabel"
        Me.KostenChormeLabel.Size = New System.Drawing.Size(73, 13)
        Me.KostenChormeLabel.TabIndex = 7
        Me.KostenChormeLabel.Text = "- Kostet: 100$"
        '
        'KaufenChormeButton
        '
        Me.KaufenChormeButton.Enabled = False
        Me.KaufenChormeButton.ForeColor = System.Drawing.Color.Black
        Me.KaufenChormeButton.Location = New System.Drawing.Point(862, 260)
        Me.KaufenChormeButton.Name = "KaufenChormeButton"
        Me.KaufenChormeButton.Size = New System.Drawing.Size(75, 23)
        Me.KaufenChormeButton.TabIndex = 8
        Me.KaufenChormeButton.Text = "Kaufen"
        Me.KaufenChormeButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(655, -203)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(100, 1356)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 9
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(790, 297)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'KaufenCleanMasterButton
        '
        Me.KaufenCleanMasterButton.Location = New System.Drawing.Point(863, 330)
        Me.KaufenCleanMasterButton.Name = "KaufenCleanMasterButton"
        Me.KaufenCleanMasterButton.Size = New System.Drawing.Size(75, 23)
        Me.KaufenCleanMasterButton.TabIndex = 11
        Me.KaufenCleanMasterButton.Text = "Kaufen"
        Me.KaufenCleanMasterButton.UseVisualStyleBackColor = True
        '
        'CleanmasterPreisLabel
        '
        Me.CleanmasterPreisLabel.AutoSize = True
        Me.CleanmasterPreisLabel.Location = New System.Drawing.Point(856, 314)
        Me.CleanmasterPreisLabel.Name = "CleanmasterPreisLabel"
        Me.CleanmasterPreisLabel.Size = New System.Drawing.Size(88, 13)
        Me.CleanmasterPreisLabel.TabIndex = 15
        Me.CleanmasterPreisLabel.Text = "- Kostet: 10.000$"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(855, 297)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(170, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "- Schütz dich vor Hacker-Angriffen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(856, 386)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "- Kostet: 100.000$"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(855, 369)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "- "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(863, 402)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Kaufen"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(790, 369)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 16
        Me.PictureBox7.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(855, 457)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "- Kostet: 1.000.000$"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(854, 440)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "- Generiertautomatisch Internet Explorer Money"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(862, 473)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Kaufen"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(789, 440)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(48, 46)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 20
        Me.PictureBox8.TabStop = False
        '
        'ChromeLevelLabel
        '
        Me.ChromeLevelLabel.AutoSize = True
        Me.ChromeLevelLabel.Location = New System.Drawing.Point(787, 211)
        Me.ChromeLevelLabel.Name = "ChromeLevelLabel"
        Me.ChromeLevelLabel.Size = New System.Drawing.Size(45, 13)
        Me.ChromeLevelLabel.TabIndex = 24
        Me.ChromeLevelLabel.Text = "Level: 0"
        '
        'CleanMasterLevelLabel
        '
        Me.CleanMasterLevelLabel.AutoSize = True
        Me.CleanMasterLevelLabel.Location = New System.Drawing.Point(786, 281)
        Me.CleanMasterLevelLabel.Name = "CleanMasterLevelLabel"
        Me.CleanMasterLevelLabel.Size = New System.Drawing.Size(45, 13)
        Me.CleanMasterLevelLabel.TabIndex = 25
        Me.CleanMasterLevelLabel.Text = "Level: 0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1340, 675)
        Me.Controls.Add(Me.CleanMasterLevelLabel)
        Me.Controls.Add(Me.ChromeLevelLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.CleanmasterPreisLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.KaufenCleanMasterButton)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.KaufenChormeButton)
        Me.Controls.Add(Me.KostenChormeLabel)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Zählerbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Zählerbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents KostenChormeLabel As Label
    Friend WithEvents KaufenChormeButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents KaufenCleanMasterButton As Button
    Friend WithEvents CleanmasterPreisLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents ChromeLevelLabel As Label
    Friend WithEvents CleanMasterLevelLabel As Label
End Class
