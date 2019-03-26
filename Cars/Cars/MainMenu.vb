Public Class MainMenu
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PlayButton_Click(sender As Object, e As EventArgs) Handles PlayButton.Click
        Me.Hide()
        Form.Show()
    End Sub

    Private Sub HowPlayButton_Click(sender As Object, e As EventArgs) Handles HowPlayButton.Click
        Me.Hide()
        Instructions.Show()
    End Sub

    Private Sub PlaySound()
        My.Computer.Audio.Play("C:\Users\lukeh\Desktop\Dmacc\VB\Projects\Cars\Cars\Resources\Werq.wav",
        AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlaySound()
    End Sub
End Class