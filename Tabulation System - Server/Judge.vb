Public Class Judge

    Private Sub Judge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_judge.Font = btn_add.Font
        populateDGV()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        setControlEnabled(False, True, False, False, False, True, True, True)
        dgv_judge.Enabled = False
    End Sub

    Private Sub setControlEnabled(ByVal add As Boolean, ByVal save As Boolean, ByVal update As Boolean, ByVal edit As Boolean, ByVal delete As Boolean, ByVal cancel As Boolean, ByVal username As Boolean, ByVal password As Boolean)
        btn_add.Enabled = add
        btn_save.Enabled = save
        btn_update.Enabled = update
        btn_edit.Enabled = edit
        btn_delete.Enabled = delete
        btn_cancel.Enabled = cancel
        txt_password.Enabled = password
        txt_username.Enabled = username
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        setControlEnabled(True, False, False, True, True, False, False, False)
        txt_password.Text = ""
        txt_username.Text = ""
        dgv_judge.Enabled = True
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim id As String

        Try
            id = dgv_judge.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        dgv_judge.Enabled = False

        Dim sql As String = "SELECT username, password FROM t_judge WHERE id = '" & id & "'"

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    txt_password.Text = reader(1)
                    txt_username.Text = reader(0)
                    setControlEnabled(False, False, True, False, False, True, True, True)
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim sql As String = "INSERT INTO t_judge(username, password, status) VALUES('" & txt_username.Text & "', '" & txt_password.Text & "', 0)"

        If txt_password.Text = "" And txt_username.Text = "" Then
            MsgBox("Please fill up fields with(*)")
            Exit Sub
        End If

        If Functions.isExist("SELECT * FROM t_judge WHERE username = '" & txt_username.Text & "'") = True Then
            MsgBox("Username already exist!")
            Exit Sub
        End If

        If Functions.sqlInsert(sql) = True Then
            MsgBox("Successfully saved!")
            setControlEnabled(True, False, False, True, True, False, False, False)
            txt_password.Text = ""
            txt_username.Text = ""
            populateDGV()
            dgv_judge.Enabled = True
        End If

    End Sub

    Private Sub populateDGV()
        dgv_judge.Rows.Clear()
        Dim sql As String = "SELECT id, username, password, status FROM t_judge"
        Dim row As String()

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    Dim status As String = "logout"

                    If reader(3) = 1 Then
                        status = "login"
                    End If

                    row = New String() {reader(0), reader(1), reader(2), status}
                    dgv_judge.Rows.Add(row)
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
            id = dgv_judge.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        If txt_password.Text = "" And txt_username.Text = "" Then
            MsgBox("Please fill up fields with(*)")
            Exit Sub
        End If

        If Functions.isExist("SELECT * FROM t_judge WHERE username = '" & txt_username.Text & "' AND id <> '" & id & "'") = True Then
            MsgBox("Username already exist!")
            Exit Sub
        End If

        Dim sql As String = "UPDATE t_judge SET username = '" & txt_username.Text & "', password = '" & txt_password.Text & "'"

        If Functions.sqlInsert(sql) = True Then
            MsgBox("Successfully updated!")
            dgv_judge.Enabled = True
            txt_password.Text = ""
            txt_username.Text = ""
            setControlEnabled(True, False, False, True, True, False, False, False)
            populateDGV()
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As String

        Try
            id = dgv_judge.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        Dim msgResult As Integer = MsgBox("Are you sure you want to delete judge?", MsgBoxStyle.YesNo)
        Dim sql As String = "DELETE FROM t_judge WHERE id = '" & id & "'"

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