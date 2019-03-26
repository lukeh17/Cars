<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.RoadMove = New System.Windows.Forms.Timer(Me.components)
        Me.MoveUp = New System.Windows.Forms.Timer(Me.components)
        Me.MoveDown = New System.Windows.Forms.Timer(Me.components)
        Me.ECar1 = New System.Windows.Forms.Timer(Me.components)
        Me.ECar2 = New System.Windows.Forms.Timer(Me.components)
        Me.ECar3 = New System.Windows.Forms.Timer(Me.components)
        Me.ECar4 = New System.Windows.Forms.Timer(Me.components)
        Me.GameOverText = New System.Windows.Forms.Label()
        Me.RestartButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ScoreText = New System.Windows.Forms.Label()
        Me.SpeedUp = New System.Windows.Forms.Timer(Me.components)
        Me.SpeedIncText = New System.Windows.Forms.Label()
        Me.MainMenuButton = New System.Windows.Forms.Button()
        Me.EnemyCar4 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar3 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar2 = New System.Windows.Forms.PictureBox()
        Me.EnemyCar1 = New System.Windows.Forms.PictureBox()
        Me.Lambo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RoadPicture = New System.Windows.Forms.PictureBox()
        CType(Me.EnemyCar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lambo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoadPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoadMove
        '
        Me.RoadMove.Enabled = True
        Me.RoadMove.Interval = 10
        '
        'MoveUp
        '
        Me.MoveUp.Enabled = True
        '
        'MoveDown
        '
        Me.MoveDown.Enabled = True
        '
        'ECar1
        '
        Me.ECar1.Enabled = True
        Me.ECar1.Interval = 10
        '
        'ECar2
        '
        Me.ECar2.Enabled = True
        Me.ECar2.Interval = 10
        '
        'ECar3
        '
        Me.ECar3.Enabled = True
        Me.ECar3.Interval = 10
        '
        'ECar4
        '
        Me.ECar4.Enabled = True
        Me.ECar4.Interval = 10
        '
        'GameOverText
        '
        Me.GameOverText.AutoSize = True
        Me.GameOverText.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GameOverText.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 40.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GameOverText.Location = New System.Drawing.Point(207, 205)
        Me.GameOverText.Name = "GameOverText"
        Me.GameOverText.Size = New System.Drawing.Size(784, 150)
        Me.GameOverText.TabIndex = 7
        Me.GameOverText.Text = "Game Over"
        Me.GameOverText.Visible = False
        '
        'RestartButton
        '
        Me.RestartButton.Font = New System.Drawing.Font("Broadway", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestartButton.Location = New System.Drawing.Point(202, 358)
        Me.RestartButton.Name = "RestartButton"
        Me.RestartButton.Size = New System.Drawing.Size(267, 80)
        Me.RestartButton.TabIndex = 1
        Me.RestartButton.Text = "Restart"
        Me.RestartButton.UseVisualStyleBackColor = True
        Me.RestartButton.Visible = False
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Broadway", 19.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(800, 358)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(267, 80)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        Me.ExitButton.Visible = False
        '
        'ScoreText
        '
        Me.ScoreText.AutoSize = True
        Me.ScoreText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ScoreText.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreText.ForeColor = System.Drawing.Color.White
        Me.ScoreText.Location = New System.Drawing.Point(21, 18)
        Me.ScoreText.Name = "ScoreText"
        Me.ScoreText.Size = New System.Drawing.Size(133, 40)
        Me.ScoreText.TabIndex = 10
        Me.ScoreText.Text = "Score: 0"
        '
        'SpeedUp
        '
        Me.SpeedUp.Enabled = True
        Me.SpeedUp.Interval = 10
        '
        'SpeedIncText
        '
        Me.SpeedIncText.AutoSize = True
        Me.SpeedIncText.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.SpeedIncText.Font = New System.Drawing.Font("Trebuchet MS", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpeedIncText.Location = New System.Drawing.Point(492, 83)
        Me.SpeedIncText.Name = "SpeedIncText"
        Me.SpeedIncText.Size = New System.Drawing.Size(335, 54)
        Me.SpeedIncText.TabIndex = 11
        Me.SpeedIncText.Text = "Speed Increased"
        Me.SpeedIncText.Visible = False
        '
        'MainMenuButton
        '
        Me.MainMenuButton.Font = New System.Drawing.Font("Broadway", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuButton.Location = New System.Drawing.Point(501, 358)
        Me.MainMenuButton.Name = "MainMenuButton"
        Me.MainMenuButton.Size = New System.Drawing.Size(267, 80)
        Me.MainMenuButton.TabIndex = 2
        Me.MainMenuButton.Text = "Main Menu"
        Me.MainMenuButton.UseVisualStyleBackColor = True
        Me.MainMenuButton.Visible = False
        '
        'EnemyCar4
        '
        Me.EnemyCar4.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.EnemyCar4.Image = Global.Cars.My.Resources.Resources.EnemyCar2
        Me.EnemyCar4.Location = New System.Drawing.Point(916, 635)
        Me.EnemyCar4.Name = "EnemyCar4"
        Me.EnemyCar4.Size = New System.Drawing.Size(214, 106)
        Me.EnemyCar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar4.TabIndex = 6
        Me.EnemyCar4.TabStop = False
        '
        'EnemyCar3
        '
        Me.EnemyCar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.EnemyCar3.Image = Global.Cars.My.Resources.Resources.EnemyCar
        Me.EnemyCar3.Location = New System.Drawing.Point(1771, 52)
        Me.EnemyCar3.Name = "EnemyCar3"
        Me.EnemyCar3.Size = New System.Drawing.Size(214, 106)
        Me.EnemyCar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar3.TabIndex = 5
        Me.EnemyCar3.TabStop = False
        '
        'EnemyCar2
        '
        Me.EnemyCar2.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.EnemyCar2.Image = Global.Cars.My.Resources.Resources.EnemyCar
        Me.EnemyCar2.Location = New System.Drawing.Point(2514, 231)
        Me.EnemyCar2.Name = "EnemyCar2"
        Me.EnemyCar2.Size = New System.Drawing.Size(214, 106)
        Me.EnemyCar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar2.TabIndex = 4
        Me.EnemyCar2.TabStop = False
        '
        'EnemyCar1
        '
        Me.EnemyCar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.EnemyCar1.Image = Global.Cars.My.Resources.Resources.EnemyCar2
        Me.EnemyCar1.Location = New System.Drawing.Point(2309, 445)
        Me.EnemyCar1.Name = "EnemyCar1"
        Me.EnemyCar1.Size = New System.Drawing.Size(214, 106)
        Me.EnemyCar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EnemyCar1.TabIndex = 3
        Me.EnemyCar1.TabStop = False
        '
        'Lambo
        '
        Me.Lambo.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Lambo.Image = Global.Cars.My.Resources.Resources.Lambo
        Me.Lambo.Location = New System.Drawing.Point(12, 445)
        Me.Lambo.Name = "Lambo"
        Me.Lambo.Size = New System.Drawing.Size(232, 106)
        Me.Lambo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Lambo.TabIndex = 2
        Me.Lambo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.PictureBox1.Image = Global.Cars.My.Resources.Resources.Road
        Me.PictureBox1.Location = New System.Drawing.Point(1396, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1440, 742)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'RoadPicture
        '
        Me.RoadPicture.BackColor = System.Drawing.Color.Black
        Me.RoadPicture.Image = Global.Cars.My.Resources.Resources.Road
        Me.RoadPicture.Location = New System.Drawing.Point(-14, 28)
        Me.RoadPicture.Name = "RoadPicture"
        Me.RoadPicture.Size = New System.Drawing.Size(1440, 742)
        Me.RoadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RoadPicture.TabIndex = 0
        Me.RoadPicture.TabStop = False
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LawnGreen
        Me.ClientSize = New System.Drawing.Size(1250, 812)
        Me.Controls.Add(Me.MainMenuButton)
        Me.Controls.Add(Me.SpeedIncText)
        Me.Controls.Add(Me.ScoreText)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RestartButton)
        Me.Controls.Add(Me.GameOverText)
        Me.Controls.Add(Me.EnemyCar4)
        Me.Controls.Add(Me.EnemyCar3)
        Me.Controls.Add(Me.EnemyCar2)
        Me.Controls.Add(Me.EnemyCar1)
        Me.Controls.Add(Me.Lambo)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RoadPicture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cars"
        CType(Me.EnemyCar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EnemyCar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lambo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoadPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RoadPicture As PictureBox
    Friend WithEvents RoadMove As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Lambo As PictureBox
    Friend WithEvents MoveUp As Timer
    Friend WithEvents MoveDown As Timer
    Friend WithEvents EnemyCar1 As PictureBox
    Friend WithEvents EnemyCar2 As PictureBox
    Friend WithEvents EnemyCar3 As PictureBox
    Friend WithEvents EnemyCar4 As PictureBox
    Friend WithEvents ECar1 As Timer
    Friend WithEvents ECar2 As Timer
    Friend WithEvents ECar3 As Timer
    Friend WithEvents ECar4 As Timer
    Friend WithEvents GameOverText As Label
    Friend WithEvents RestartButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ScoreText As Label
    Friend WithEvents SpeedUp As Timer
    Friend WithEvents SpeedIncText As Label
    Friend WithEvents MainMenuButton As Button
End Class
