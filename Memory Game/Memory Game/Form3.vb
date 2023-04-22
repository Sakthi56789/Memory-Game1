Public Class Form3
    Dim score As Integer = 0
    Dim tries As Integer = 0







    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        PictureBox1.Visible = False
        PictureBox13.Visible = True
        tries += 1


    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox19.Visible = False
        PictureBox20.Visible = False
        PictureBox16.Visible = False
        PictureBox15.Visible = False
        PictureBox21.Visible = False
        PictureBox22.Visible = False
        PictureBox17.Visible = False
        PictureBox18.Visible = False
        PictureBox23.Visible = False
        PictureBox24.Visible = False

        Label2.Visible = False
        Label3.Visible = False





    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
        PictureBox14.Visible = True
        tries += 1
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox3.Visible = False
        PictureBox19.Visible = True
        tries += 1

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.Visible = False
        PictureBox20.Visible = True
        tries += 1
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PictureBox5.Visible = False
        PictureBox16.Visible = True
        tries += 1
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        PictureBox6.Visible = False
        PictureBox15.Visible = True
        tries += 1

    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        PictureBox7.Visible = False
        PictureBox21.Visible = True
        tries += 1
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        PictureBox8.Visible = False
        PictureBox22.Visible = True
        tries += 1
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        PictureBox9.Visible = False
        PictureBox17.Visible = True
        tries += 1
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        PictureBox10.Visible = False
        PictureBox18.Visible = True
        tries += 1
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        PictureBox11.Visible = False
        PictureBox23.Visible = True
        tries += 1
    End Sub

    Private Sub PictureBox12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox12.Click
        PictureBox12.Visible = False
        PictureBox24.Visible = True
        tries += 1
    End Sub




    Private Sub Timer1_Tick_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label2.Visible = True
        Label3.Visible = True
        Label2.Text = "Score " & score
        Label3.Text = "Tries " & tries

        If PictureBox13.Visible And PictureBox21.Visible Then
            score = score + 10
            PictureBox13.Visible = False
            PictureBox21.Visible = False
            PictureBox1.Visible = False
            PictureBox7.Visible = False

        End If



        If PictureBox14.Visible And PictureBox24.Visible Then
            score = score + 10
            PictureBox14.Visible = False
            PictureBox24.Visible = False
            PictureBox2.Visible = False
            PictureBox12.Visible = False
        End If
        If PictureBox19.Visible And PictureBox18.Visible Then
            score = score + 10
            PictureBox19.Visible = False
            PictureBox18.Visible = False
            PictureBox3.Visible = False
            PictureBox10.Visible = False
        End If
        If PictureBox20.Visible And PictureBox23.Visible Then
            score = score + 10
            PictureBox20.Visible = False
            PictureBox23.Visible = False
            PictureBox4.Visible = False
            PictureBox11.Visible = False
        End If
        If PictureBox16.Visible And PictureBox22.Visible Then
            score = score + 10
            PictureBox16.Visible = False
            PictureBox22.Visible = False
            PictureBox5.Visible = False
            PictureBox8.Visible = False
        End If
        If PictureBox15.Visible And PictureBox17.Visible Then
            score = score + 10
            PictureBox15.Visible = False
            PictureBox17.Visible = False
            PictureBox6.Visible = False
            PictureBox9.Visible = False
        End If




        If PictureBox1.Visible <> PictureBox13.Visible Then
            PictureBox1.Visible = True
            PictureBox13.Visible = False
        End If

        If PictureBox2.Visible <> PictureBox14.Visible Then
            PictureBox2.Visible = True
            PictureBox14.Visible = False
        End If
        If PictureBox3.Visible <> PictureBox19.Visible Then
            PictureBox3.Visible = True
            PictureBox19.Visible = False
        End If

        If PictureBox4.Visible <> PictureBox20.Visible Then
            PictureBox4.Visible = True
            PictureBox20.Visible = False
        End If

        If PictureBox5.Visible <> PictureBox16.Visible Then
            PictureBox5.Visible = True
            PictureBox16.Visible = False

        End If

        If PictureBox6.Visible <> PictureBox15.Visible Then
            PictureBox6.Visible = True
            PictureBox15.Visible = False
        End If

        If PictureBox7.Visible <> PictureBox21.Visible Then
            PictureBox7.Visible = True
            PictureBox21.Visible = False

        End If
        If PictureBox8.Visible <> PictureBox22.Visible Then
            PictureBox8.Visible = True
            PictureBox22.Visible = False

        End If

        If PictureBox9.Visible <> PictureBox17.Visible Then
            PictureBox9.Visible = True
            PictureBox17.Visible = False

        End If

        If PictureBox10.Visible <> PictureBox18.Visible Then
            PictureBox10.Visible = True
            PictureBox18.Visible = False
        End If

        If PictureBox11.Visible <> PictureBox23.Visible Then
            PictureBox11.Visible = True
            PictureBox23.Visible = False
        End If

        If PictureBox12.Visible <> PictureBox24.Visible Then
            PictureBox12.Visible = True
            PictureBox24.Visible = False
        End If

        If score = 60 Then
            Label1.Text = "You Won! Final Score: " & score
        ElseIf tries >= 15 Then
            Label1.Text = "Game Over. Final Score: " & tries
        End If

    End Sub




End Class
