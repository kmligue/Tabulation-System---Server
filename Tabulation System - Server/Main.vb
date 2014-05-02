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

    Private Sub CriteriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CriteriaToolStripMenuItem.Click
        Criteria.Owner = Me
        Criteria.MdiParent = Me.MdiParent
        Criteria.Show()
    End Sub

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_event.Text = ""
        DataGridView.Font = cb_category.Font
    End Sub

    Private Sub GownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GownToolStripMenuItem.Click
        lbl_event.Text = "Gown"
        populateCbCategory()

        DataGridView.Columns.Clear()

        Dim candidateNo As New DataGridViewTextBoxColumn
        candidateNo.HeaderText = "Candidate No."
        candidateNo.Name = "candidate_no"
        candidateNo.ReadOnly = True
        candidateNo.Width = 200
        DataGridView.Columns.Add(candidateNo)

        Dim candidate As New DataGridViewTextBoxColumn
        candidate.HeaderText = "Candidate"
        candidate.Name = "candidate"
        candidate.ReadOnly = True
        candidate.Width = 350
        DataGridView.Columns.Add(candidate)

        Dim score As New DataGridViewTextBoxColumn
        score.HeaderText = "Score"
        score.Name = "score"
        score.ReadOnly = True
        DataGridView.Columns.Add(score)

    End Sub

    Private Sub populateCbCategory()
        cb_category.Items.Clear()

        Dim sql As String = "SELECT username FROM t_judge ORDER BY username ASC"

        cb_category.Items.Add("Overall")

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    cb_category.Items.Add(reader(0).ToString.Substring(0, 1).ToUpper & reader(0).ToString.Substring(1, reader(0).ToString.Length - 1))
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try
    End Sub

    Private Sub cb_category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_category.SelectedIndexChanged

        DataGridView.Rows.Clear()

        If lbl_event.Text = "Gown" Then
            populateDGVGown()
        ElseIf lbl_event.Text = "Talent" Then
            populateDGVTalent()
        ElseIf lbl_event.Text = "Interview" Then
            populateDGVInterview()
        ElseIf lbl_event.Text = "Swimwear" Then
            populateDGVSwimwear()
        ElseIf lbl_event.Text = "Final" Then
            populateDGVFinal()
        End If


    End Sub

    Private Sub TalentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TalentToolStripMenuItem.Click
        lbl_event.Text = "Talent"
        populateCbCategory()

        DataGridView.Columns.Clear()

        Dim candidateNo As New DataGridViewTextBoxColumn
        candidateNo.HeaderText = "Candidate No."
        candidateNo.Name = "candidate_no"
        candidateNo.ReadOnly = True
        candidateNo.Width = 200
        DataGridView.Columns.Add(candidateNo)

        Dim candidate As New DataGridViewTextBoxColumn
        candidate.HeaderText = "Candidate"
        candidate.Name = "candidate"
        candidate.ReadOnly = True
        candidate.Width = 350
        DataGridView.Columns.Add(candidate)

        Dim score As New DataGridViewTextBoxColumn
        score.HeaderText = "Score"
        score.Name = "score"
        score.ReadOnly = True
        DataGridView.Columns.Add(score)
    End Sub

    Private Sub populateDGVGown()
        Dim row As String()
        Dim sql As String

        If cb_category.SelectedItem = "Overall" Then
            sql = "SELECT number, candidate, score FROM v_gown_overall ORDER BY score DESC"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = Sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        Else
            Dim judgeName As String = cb_category.SelectedItem

            sql = "SELECT number, candidate, score FROM v_gown WHERE judge = '" & judgeName & "'"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = Sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        End If
    End Sub

    Private Sub populateDGVTalent()
        Dim row As String()
        Dim sql As String

        If cb_category.SelectedItem = "Overall" Then
            sql = "SELECT number, candidate, score FROM v_talent_overall ORDER BY score DESC"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        Else
            Dim judgeName As String = cb_category.SelectedItem

            sql = "SELECT number, candidate, score FROM v_talent WHERE judge = '" & judgeName & "'"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        End If
    End Sub

    Private Sub populateDGVInterview()
        Dim row As String()
        Dim sql As String

        If cb_category.SelectedItem = "Overall" Then
            sql = "SELECT number, candidate, score FROM v_interview_overall ORDER BY score DESC"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        Else
            Dim judgeName As String = cb_category.SelectedItem

            sql = "SELECT number, candidate, score FROM v_interview WHERE judge = '" & judgeName & "'"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        End If
    End Sub

    Private Sub populateDGVSwimwear()
        Dim row As String()
        Dim sql As String

        If cb_category.SelectedItem = "Overall" Then
            sql = "SELECT number, candidate, score FROM v_swimwear_overall ORDER BY score DESC"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        Else
            Dim judgeName As String = cb_category.SelectedItem

            sql = "SELECT number, candidate, score FROM v_swimwear WHERE judge = '" & judgeName & "'"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        End If
    End Sub

    Private Sub populateDGVFinal()
        Dim row As String()
        Dim sql As String

        If cb_category.SelectedItem = "Overall" Then
            sql = "SELECT number, candidate, score FROM v_final_overall ORDER BY score DESC"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        Else
            Dim judgeName As String = cb_category.SelectedItem

            sql = "SELECT number, candidate, score FROM v_final WHERE judge = '" & judgeName & "'"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.reader = Functions.com.ExecuteReader

                While reader.Read
                    If reader.HasRows Then
                        row = New String() {reader(0), reader(1), Format(reader(2), "0.00")}

                        DataGridView.Rows.Add(row)
                    End If
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
            End Try
        End If
    End Sub

    
    Private Sub InterviewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InterviewToolStripMenuItem.Click
        lbl_event.Text = "Interview"
        populateCbCategory()

        DataGridView.Columns.Clear()

        Dim candidateNo As New DataGridViewTextBoxColumn
        candidateNo.HeaderText = "Candidate No."
        candidateNo.Name = "candidate_no"
        candidateNo.ReadOnly = True
        candidateNo.Width = 200
        DataGridView.Columns.Add(candidateNo)

        Dim candidate As New DataGridViewTextBoxColumn
        candidate.HeaderText = "Candidate"
        candidate.Name = "candidate"
        candidate.ReadOnly = True
        candidate.Width = 350
        DataGridView.Columns.Add(candidate)

        Dim score As New DataGridViewTextBoxColumn
        score.HeaderText = "Score"
        score.Name = "score"
        score.ReadOnly = True
        DataGridView.Columns.Add(score)
    End Sub

    Private Sub SwimwearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwimwearToolStripMenuItem.Click
        lbl_event.Text = "Swimwear"
        populateCbCategory()

        DataGridView.Columns.Clear()

        Dim candidateNo As New DataGridViewTextBoxColumn
        candidateNo.HeaderText = "Candidate No."
        candidateNo.Name = "candidate_no"
        candidateNo.ReadOnly = True
        candidateNo.Width = 200
        DataGridView.Columns.Add(candidateNo)

        Dim candidate As New DataGridViewTextBoxColumn
        candidate.HeaderText = "Candidate"
        candidate.Name = "candidate"
        candidate.ReadOnly = True
        candidate.Width = 350
        DataGridView.Columns.Add(candidate)

        Dim score As New DataGridViewTextBoxColumn
        score.HeaderText = "Score"
        score.Name = "score"
        score.ReadOnly = True
        DataGridView.Columns.Add(score)
    End Sub

    Private Sub FinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinalToolStripMenuItem.Click
        lbl_event.Text = "Final"
        populateCbCategory()

        DataGridView.Columns.Clear()

        Dim candidateNo As New DataGridViewTextBoxColumn
        candidateNo.HeaderText = "Candidate No."
        candidateNo.Name = "candidate_no"
        candidateNo.ReadOnly = True
        candidateNo.Width = 200
        DataGridView.Columns.Add(candidateNo)

        Dim candidate As New DataGridViewTextBoxColumn
        candidate.HeaderText = "Candidate"
        candidate.Name = "candidate"
        candidate.ReadOnly = True
        candidate.Width = 350
        DataGridView.Columns.Add(candidate)

        Dim score As New DataGridViewTextBoxColumn
        score.HeaderText = "Score"
        score.Name = "score"
        score.ReadOnly = True
        DataGridView.Columns.Add(score)
    End Sub
End Class