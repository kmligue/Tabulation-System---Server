Public Class Criteria

    Private Sub Criteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_criteria.Font = btn_add.Font
    End Sub

    Private Sub populateEventComboBox()
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

        populateEventComboBox()
    End Sub
End Class