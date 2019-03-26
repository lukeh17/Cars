Option Strict On
Option Explicit On
Option Infer Off

Public Class Form

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlaySound()
    End Sub

    'Speed Variables
    Private CarSpeed As Integer = 15
    Private ECarSpeed1 As Integer = 4
    Private ECarSpeed2 As Integer = 3
    Private RoadSpeed As Integer = 3
    'Score and time variables 
    Private GameScore As Integer = 0
    Private time As Integer = 0
    'Setting up random
    Private rand As Random = New Random

    Private Sub PlaySound()
        My.Computer.Audio.Play("C:\Users\lukeh\Desktop\Dmacc\VB\Projects\Cars\Cars\Resources\Driving.wav",
        AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub RoadMove_Tick(sender As Object, e As EventArgs) Handles RoadMove.Tick
        'Moves Picture Boxes in a loop to create a moving road
        RoadPicture.Left -= RoadSpeed
        PictureBox1.Left -= RoadSpeed

        'Resetting roads after passing left edge
        If PictureBox1.Right < -20 Then
            PictureBox1.Left = Me.ClientSize.Width - 16
        End If

        If RoadPicture.Right < -20 Then
            RoadPicture.Left = Me.ClientSize.Width - 16
        End If

        'Collision Detection. Calls GameOver Method
        If (Lambo.Bounds.IntersectsWith(EnemyCar1.Bounds)) Then
            GameOver()
        End If

        If (Lambo.Bounds.IntersectsWith(EnemyCar2.Bounds)) Then
            GameOver()
        End If

        If (Lambo.Bounds.IntersectsWith(EnemyCar3.Bounds)) Then
            GameOver()
        End If

        If (Lambo.Bounds.IntersectsWith(EnemyCar4.Bounds)) Then
            GameOver()
        End If
    End Sub

    Private Sub GameOver()
        'Makes GameOver Text Visible and stops all timers
        GameOverText.Visible = True
        RestartButton.Visible = True
        ExitButton.Visible = True
        MainMenuButton.Visible = True
        RoadMove.Stop()
        MoveUp.Stop()
        MoveDown.Stop()
        ECar1.Stop()
        ECar2.Stop()
        ECar3.Stop()
        ECar4.Stop()
        SpeedUp.Stop()
        'Stops lambo engine sound
        My.Computer.Audio.Stop()
        'Plays car crash sound
        My.Computer.Audio.Play("C:\Users\lukeh\Desktop\Dmacc\VB\Projects\Cars\Cars\Resources\Crash.wav")
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Moving the lambo either up or down depending on the key
        If e.KeyCode = Keys.Left Then
            MoveUp.Start()
        End If

        If e.KeyCode = Keys.Right Then
            MoveDown.Start()
        End If
    End Sub

    Private Sub MoveUp_Tick(sender As Object, e As EventArgs) Handles MoveUp.Tick
        'Blocks the car from going off the top of the screen and handles upward movement
        If (Lambo.Location.Y > -3) Then
            Lambo.Top -= CarSpeed
        End If
    End Sub

    Private Sub MoveDown_Tick(sender As Object, e As EventArgs) Handles MoveDown.Tick
        'Blocks the car from going off the bottom of the screen and handles downward movement
        If (Lambo.Location.Y < 370) Then
            Lambo.Top += CarSpeed
        End If
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        'Stopping the car when the key is up
        MoveDown.Stop()
        MoveUp.Stop()
    End Sub

    Private Sub ECar1_Tick(sender As Object, e As EventArgs) Handles ECar1.Tick
        'Moving the enemy car
        EnemyCar1.Left -= ECarSpeed2

        If EnemyCar1.Right < -20 Then
            Score() 'Adds to score when the player passes the car
            EnemyCar1.Left = Me.ClientSize.Width - rand.Next(-1116, 20)
        End If
    End Sub

    Private Sub ECar2_Tick(sender As Object, e As EventArgs) Handles ECar2.Tick
        'Moving the enemy car
        EnemyCar2.Left -= ECarSpeed1

        If EnemyCar2.Right < -20 Then
            Score() 'Adds to score when the player passes the car
            EnemyCar2.Left = Me.ClientSize.Width - rand.Next(-215, 20)
        End If
    End Sub

    Private Sub ECar3_Tick(sender As Object, e As EventArgs) Handles ECar3.Tick
        'Moving the enemy car
        EnemyCar3.Left -= ECarSpeed1

        If EnemyCar3.Right < -20 Then
            Score() 'Adds to score when the player passes the car
            EnemyCar3.Left = Me.ClientSize.Width - rand.Next(-84, 20)
        End If
    End Sub

    Private Sub ECar4_Tick(sender As Object, e As EventArgs) Handles ECar4.Tick
        'Moving the enemy car
        EnemyCar4.Left -= ECarSpeed2

        If EnemyCar4.Right < -20 Then
            Score() 'Adds to score when the player passes the car
            EnemyCar4.Left = Me.ClientSize.Width - rand.Next(-716, 20)
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Closes program
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub RestartButton_Click(sender As Object, e As EventArgs) Handles RestartButton.Click
        'Restarts the application after the player crashes

        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)

        'Resets all global variables
        ECarSpeed1 = 4
        ECarSpeed2 = 3
        RoadSpeed = 3
        time = 0
        GameScore = 0
    End Sub

    Private Sub Score()
        'Adds to gamescore and shows on screen
        GameScore += 1
        ScoreText.Text = "Score: " + GameScore.ToString
    End Sub

    Private Sub SpeedUp_Tick(sender As Object, e As EventArgs) Handles SpeedUp.Tick
        'Timer used to speed up objects as the player progresses

        time += 1

        'Hides speed increased text
        If (time Mod 250 = 0) Then
            SpeedIncText.Visible = False
        End If

        'Calls increase speed to speed up the game
        If (time Mod 1000 = 0) Then
            IncreaseSpeed()
        End If
    End Sub

    Private Sub IncreaseSpeed()
        'Speeds up everything when called. Shows Speed Increased message.
        ECarSpeed1 += 1
        ECarSpeed2 += 1
        RoadSpeed += 1

        SpeedIncText.Visible = True
    End Sub

    Private Sub MainMenu_Click(sender As Object, e As EventArgs) Handles MainMenuButton.Click
        Me.Close()
        My.Computer.Audio.Play("C:\Users\lukeh\Desktop\Dmacc\VB\Projects\Cars\Cars\Resources\Werq.wav", AudioPlayMode.BackgroundLoop)
        MainMenu.Show()
    End Sub
End Class
