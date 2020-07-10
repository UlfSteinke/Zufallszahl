Public Class Zahlenraten

    Dim pruefzahl As Integer
    Dim loesung As Integer
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll

        Label1.Text = TrackBar1.Value
        pruefzahl = TrackBar1.Value

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If loesung = pruefzahl Then

            TextBox1.Text = "Volltreffer"

        Else

            TextBox1.Text = "Leider falsch!"

        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        TextBox1.Text = CSng(loesung)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        loesung = CInt(Math.Floor((100 - 1 + 1) * Rnd())) + 1

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        loesung = TrackBar1.Value
        TrackBar1.Value = 1
        Label1.Text = TrackBar1.Value
        pruefzahl = TrackBar1.Value

    End Sub
End Class