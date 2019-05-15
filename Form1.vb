Public Class BattleShip
    Dim game_state As Integer

    Function resetField() As Task

        If game_state = 1 Then


            Select Case MsgBox("Sind Sie sicher?", MsgBoxStyle.YesNo, "Neues Spiel")
                Case MsgBoxResult.Yes
                    For index As Integer = 1 To 6
                        CType(Me.Controls("ef_a" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("ef_b" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("ef_c" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("ef_d" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("ef_e" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("ef_f" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("gf_a" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("gf_b" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("gf_c" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("gf_d" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("gf_e" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next
                    For index As Integer = 1 To 6
                        CType(Me.Controls("gf_f" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
                    Next

                    gb_infop.Enabled = True
                    gb_infop.Enabled = True
                    gb_setzen.Enabled = True
                    btn_start.Enabled = True
                    game_state = 1
                Case MsgBoxResult.No

            End Select
        ElseIf game_state = 0 Then
            For index As Integer = 1 To 6
                CType(Me.Controls("ef_a" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("ef_b" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("ef_c" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("ef_d" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("ef_e" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("ef_f" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("gf_a" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("gf_b" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("gf_c" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("gf_d" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("gf_e" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next
            For index As Integer = 1 To 6
                CType(Me.Controls("gf_f" + index.ToString()), PictureBox).BackColor = Color.CornflowerBlue
            Next

            gb_infop.Enabled = True
            gb_infop.Enabled = True
            gb_setzen.Enabled = True
            btn_start.Enabled = True
            game_state = 1

        End If



    End Function

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        game_state = 0
        MessageBox.Show("Error: 0x8007F4001 Desktop Manager failed.")
    End Sub

    Private Sub NeuesSpielToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuesSpielToolStripMenuItem.Click
        resetField()
    End Sub

    Private Sub HilfeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HilfeToolStripMenuItem.Click
        frmHelp.Show()
    End Sub

    Private Sub ZurücksetztenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZurücksetztenToolStripMenuItem.Click
        Select Case MsgBox("Möchten Sie das Spiel zurücksetzen?", MsgBoxStyle.YesNo, "Zurücksetzen")
            Case MsgBoxResult.Yes
                For index As Integer = 1 To 6
                    CType(Me.Controls("ef_a" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("ef_b" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("ef_c" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("ef_d" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("ef_e" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("ef_f" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("gf_a" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("gf_b" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("gf_c" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("gf_d" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("gf_e" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next
                For index As Integer = 1 To 6
                    CType(Me.Controls("gf_f" + index.ToString()), PictureBox).BackColor = Color.DarkGray
                Next

                gb_infop.Enabled = False
                gb_infop.Enabled = False
                gb_setzen.Enabled = False
                btn_start.Enabled = False
                game_state = 0
            Case MsgBoxResult.No

        End Select
    End Sub


End Class
