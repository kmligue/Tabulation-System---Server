Public Class Criteria

    Private Sub Criteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_criteria.Font = btn_add.Font

        populateDGV()
    End Sub

    Private Sub populateDGV()
        Dim sql As String = "SELECT t_criteria.id, t_event.name, t_criteria.description, t_criteria.score FROM t_criteria INNER JOIN t_event WHERE t_criteria.event_id = t_event.id"
        Dim row As String()

        dgv_criteria.Rows.Clear()

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    row = New String() {reader(0), reader(1).ToString.Substring(0, 1).ToUpper & reader(1).ToString.Substring(1, reader(1).ToString.Length - 1), reader(2), reader(3)}

                    dgv_criteria.Rows.Add(row)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try
    End Sub

    Private Sub populateEventComboBox()
        cb_event.Items.Clear()

        Dim sql As String = "SELECT name FROM t_event"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    cb_event.Items.Add(reader(0).ToString.Substring(0, 1).ToUpper & reader(0).ToString.Substring(1, reader(0).ToString.Length - 1))
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try
    End Sub

    Private Sub setControlEnable(ByVal add As Boolean, ByVal save As Boolean, ByVal edit As Boolean, ByVal update As Boolean, ByVal delete As Boolean, ByVal cancel As Boolean, ByVal event_cb As Boolean, ByVal description As Boolean, ByVal score As Boolean)
        btn_add.Enabled = add
        btn_save.Enabled = save
        btn_update.Enabled = update
        btn_edit.Enabled = edit
        btn_delete.Enabled = delete
        btn_cancel.Enabled = cancel
        cb_event.Enabled = event_cb
        txt_description.Enabled = description
        txt_score.Enabled = score
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        setControlEnable(False, True, False, False, False, True, True, True, True)

        dgv_criteria.Enabled = False
        populateEventComboBox()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        setControlEnable(True, False, True, False, True, False, False, False, False)

        txt_description.Text = ""
        txt_score.Text = ""
        cb_event.SelectedIndex = -1

        dgv_criteria.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim id As Integer = getEventId(cb_event.SelectedItem)

        If id = 0 And txt_description.Text = "" And txt_score.Text = "" Then
            MsgBox("Please fill up fields with(*)")
            Exit Sub
        End If

        If Not IsNumeric(txt_score.Text) Then
            MsgBox("Please input a numeric value in score.")
            Exit Sub
        End If

        Dim sql As String = "INSERT INTO t_criteria(event_id, description, score) VALUES('" & id & "', '" & txt_description.Text & "', '" & txt_score.Text & "')"

        If Functions.sqlInsert(sql) = True Then
            MsgBox("Successfully saved!")
            dgv_criteria.Enabled = True
            txt_description.Text = ""
            txt_score.Text = ""
            cb_event.SelectedIndex = -1
            setControlEnable(True, False, True, False, True, False, False, False, False)
            populateDGV()
        End If

    End Sub

    Private Function getEventId(ByVal eventName As String) As Integer
        Dim id As Integer
        Dim sql As String = "SELECT id FROM t_event WHERE name = '" & eventName & "'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    id = reader(0)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return id
    End Function

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim id As String
        populateEventComboBox()
        cb_event.SelectedItem = dgv_criteria.SelectedCells(1).Value
        dgv_criteria.Enabled = False
        setControlEnable(False, False, False, True, False, True, False, True, True)

        Try
            id = dgv_criteria.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        Dim sql As String = "SELECT description, score FROM t_criteria WHERE id = '" & id & "'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    txt_description.Text = reader(0)
                    txt_score.Text = reader(1)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim id As String

        Try
            id = dgv_criteria.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        If txt_description.Text = "" And txt_score.Text = "" Then
            MsgBox("Please fill up fields with(*)")
            Exit Sub
        End If

        If Not IsNumeric(txt_score.Text) Then
            MsgBox("Please input a numeric value in score.")
            Exit Sub
        End If

        Dim sql As String = "UPDATE t_criteria SET description = '" & txt_description.Text & "', score = '" & txt_score.Text & "' WHERE id = '" & id & "'"

        If Functions.sqlInsert(sql) = True Then
            MsgBox("Successfully updated!")
            setControlEnable(True, False, True, False, True, False, False, False, False)
            cb_event.SelectedIndex = -1
            txt_description.Text = ""
            txt_score.Text = ""
            dgv_criteria.Enabled = True
            populateDGV()
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As String

        Try
            id = dgv_criteria.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        Dim msgResult As Integer = MsgBox("Are you sure you want to delete criteria?", MsgBoxStyle.YesNo)
        Dim sql As String = "DELETE FROM t_criteria WHERE id = '" & id & "'"

        If msgResult = MsgBoxResult.Yes Then
            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.com.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
                populateDGV()
            End Try
        End If

    End Sub
End Class