Public Class Event_Form

    Private Sub Event_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_event.Font = btn_add.Font

        populateDGV()
    End Sub

    Private Sub setControlEnable(ByVal add As Boolean, ByVal save As Boolean, ByVal edit As Boolean, ByVal update As Boolean, ByVal delete As Boolean, ByVal cancel As Boolean, ByVal name As Boolean, ByVal yes As Boolean, ByVal no As Boolean)
        btn_add.Enabled = add
        btn_save.Enabled = save
        btn_update.Enabled = update
        btn_edit.Enabled = edit
        btn_delete.Enabled = delete
        btn_cancel.Enabled = cancel
        txt_name.Enabled = name
        radio_yes.Enabled = yes
        radio_no.Enabled = no
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        setControlEnable(False, True, False, False, False, True, True, True, True)

        txt_name.Text = ""
        radio_no.Checked = False
        radio_yes.Checked = False

        dgv_event.Enabled = False
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        setControlEnable(True, False, True, False, True, False, False, False, False)

        txt_name.Text = ""
        radio_no.Checked = False
        radio_yes.Checked = False

        dgv_event.Enabled = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_name.Text = "" Or (radio_no.Checked = False And radio_yes.Checked = False) Then
            MsgBox("Please fill up fields with(*)")
            Exit Sub
        End If

        If Functions.isExist("SELECT * FROM t_event WHERE name = '" & txt_name.Text & "'") = True Then
            MsgBox("Name already exist!")
            Exit Sub
        End If

        Dim sql As String = "INSERT INTO t_event(name, enable) VALUES('" & txt_name.Text & "', '" & radio_yes.Checked & "')"

        If Functions.sqlInsert(sql) = True Then
            MsgBox("Successfully saved!")
            dgv_event.Enabled = True
            txt_name.Text = ""
            radio_no.Checked = False
            radio_yes.Checked = False
            setControlEnable(True, False, True, False, True, False, False, False, False)
            populateDGV()
        End If

    End Sub

    Private Sub populateDGV()
        dgv_event.Rows.Clear()

        Dim sql As String = "SELECT id, name, enable FROM t_event"
        Dim row As String()

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    Dim status As String = "Disabled"
                    If reader(2) = "True" Then
                        status = "Enabled"
                    End If

                    row = New String() {reader(0), reader(1).ToString.Substring(0, 1).ToUpper & reader(1).ToString.Substring(1, reader(1).ToString.Length - 1), status}
                    dgv_event.Rows.Add(row)

                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim id As String

        Try
            id = dgv_event.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        dgv_event.Enabled = False
        Dim sql As String = "SELECT name, enable FROM t_event WHERE id = '" & id & "'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    txt_name.Text = reader(0)
                    radio_yes.Checked = CBool(reader(1))
                    radio_no.Checked = Not CBool(reader(1))
                    setControlEnable(False, False, False, True, False, True, True, True, True)
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
            id = dgv_event.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        If txt_name.Text = "" Or (radio_no.Checked = False And radio_yes.Checked = False) Then
            MsgBox("Please fill up fields with(*)")
            Exit Sub
        End If

        If Functions.isExist("SELECT * FROM t_event WHERE name = '" & txt_name.Text & "' AND id <> '" & id & "'") = True Then
            MsgBox("Name already exist!")
            Exit Sub
        End If

        Dim sql As String = "UPDATE t_event SET name = '" & txt_name.Text & "', enable = '" & radio_yes.Checked & "' WHERE id = '" & id & "'"
        Dim sqlDisable As String = "UPDATE t_event SET enable = 'False'"

        If Functions.sqlInsert(sqlDisable) = True Then
            If Functions.sqlInsert(sql) = True Then
                MsgBox("Successfully updated!")
                txt_name.Text = ""
                radio_no.Checked = False
                radio_yes.Checked = False
                dgv_event.Enabled = True
                setControlEnable(True, False, True, False, True, False, False, False, False)
                populateDGV()
            End If

        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As String

        Try
            id = dgv_event.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        Dim msgResult As Integer = MsgBox("Are you sure you want to delete event?", MsgBoxStyle.YesNo)
        Dim sql As String = "DELETE FROM t_event WHERE id = '" & id & "'"

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