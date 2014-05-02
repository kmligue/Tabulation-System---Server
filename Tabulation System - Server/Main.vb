Public Class Main

    Private Sub Main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Login.Show()
        Login.txt_username.Focus()
    End Sub

    Private Sub strip_candidate_Click(sender As Object, e As EventArgs) Handles strip_candidate.Click
        Candidate.Owner = Me
        Candidate.MdiParent = Me.MdiParent
        Candidate.Show()
    End Sub

    Private Sub JudgeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JudgeToolStripMenuItem.Click
        Judge.Owner = Me
        Judge.MdiParent = Me.MdiParent
        Judge.Show()
    End Sub

    Private Sub EventToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EventToolStripMenuItem.Click
        Event_Form.Owner = Me
        Event_Form.MdiParent = Me.MdiParent
        Event_Form.Show()
    End Sub
End Class