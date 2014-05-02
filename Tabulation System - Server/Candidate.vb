Public Class Candidate

    Private Sub Candidate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv_candidates.Font = txt_image.Font
        populateDGV()
    End Sub

    Private Sub populateDGV()
        Dim sql As String = "SELECT id, image, number, name, sponsor, info from t_candidate ORDER BY number ASC"
        Dim row As String()

        dgv_candidates.Rows.Clear()

        'query select
        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            'populate datagridview
            While reader.Read
                If reader.HasRows Then
                    row = New String() {reader(0), reader(2), reader(3), reader(4), reader(5), reader(1)}
                    dgv_candidates.Rows.Add(row)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Connect.constring.Close()
        End Try
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        setControlEnabled(False, True, False, False, False, True, False, True, True, True, True, True)

        pb_image.Image = Nothing
        dgv_candidates.Enabled = False
    End Sub

    Private Sub setControlEnabled(ByVal add As Boolean, ByVal save As Boolean, ByVal update As Boolean, ByVal edit As Boolean, ByVal delete As Boolean, ByVal cancel As Boolean, ByVal image As Boolean, ByVal browse As Boolean, ByVal number As Boolean, ByVal name As Boolean, ByVal sponsor As Boolean, ByVal info As Boolean)
        btn_add.Enabled = add
        btn_save.Enabled = save
        btn_update.Enabled = update
        btn_edit.Enabled = edit
        btn_delete.Enabled = delete
        btn_cancel.Enabled = cancel
        txt_image.Enabled = image
        btn_browse.Enabled = browse
        txt_candidate_no.Enabled = number
        txt_name.Enabled = name
        txt_sponsor.Enabled = sponsor
        txt_info.Enabled = sponsor
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        setControlEnabled(True, False, False, True, True, False, False, False, False, False, False, False)
        txt_candidate_no.Text = ""
        txt_image.Text = ""
        txt_info.Text = ""
        txt_name.Text = ""
        txt_sponsor.Text = ""

        dgv_candidates.Enabled = True
    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        OpenFileDialog.ShowDialog()
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk
        txt_image.Text = OpenFileDialog.FileName

        pb_image.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog.FileName)
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim fileName As String = System.IO.Path.GetFileName(txt_image.Text)
        Dim sql As String = "INSERT INTO t_candidate(image, number, name, sponsor, info) VALUES('" & fileName & "', '" & txt_candidate_no.Text & "', '" & txt_name.Text & "', '" & txt_sponsor.Text & "', '" & txt_info.Text & "')"
        Dim msgResult As Integer = MsgBoxResult.Yes

        'check for required fields
        If txt_image.Text = "" And txt_candidate_no.Text = "" And txt_name.Text = "" Then
            MsgBox("Please fill up fields with(*)")
            Exit Sub
        End If

        'check if candidate number is numeric
        If Not IsNumeric(txt_candidate_no.Text) Then
            MsgBox("Please input a numeric value in candidate number")
            Exit Sub
        End If

        'check if candidate number already exist in db
        If Functions.isExist("SELECT * FROM t_candidate WHERE number = '" & txt_candidate_no.Text & "'") = True Then
            MsgBox("Candidate number already exist!")
            Exit Sub
        End If

        'check if candidate name already exist in db
        If Functions.isExist("SELECT * FROM t_candidate WHERE name = '" & txt_name.Text & "'") = True Then
            MsgBox("Candidate name already exist!")
            Exit Sub
        End If

        'check if file exist to server
        'if not, copy image
        'if exist, dont copy image 
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Images\" & fileName) Then
            'copy image file to server
            Try
                System.IO.File.Copy(txt_image.Text, Application.StartupPath & "\Images\" & fileName)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        Else
            msgResult = MsgBox("File already exist! Do you want to continue saving candidate?", MessageBoxButtons.YesNo, "Caption")
        End If

        If msgResult = MsgBoxResult.Yes Then
            If Functions.sqlInsert(sql) = True Then
                MsgBox("Successfully saved!")
                setControlEnabled(True, False, False, True, True, False, False, False, False, False, False, True)

                txt_candidate_no.Text = ""
                txt_image.Text = ""
                txt_info.Text = ""
                txt_name.Text = ""
                txt_sponsor.Text = ""

                dgv_candidates.Enabled = True

                populateDGV()
            End If
        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        Dim id As String

        Try
            id = dgv_candidates.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        Dim sql As String = "SELECT image, number, name, sponsor, info FROM t_candidate WHERE id = '" & id & "'"

        If id = Nothing Then
            MsgBox("No data selected!")
            Exit Sub
        End If

        dgv_candidates.Enabled = False

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    pb_image.Image = System.Drawing.Bitmap.FromFile(Application.StartupPath & "\images\" & reader(0))
                    txt_image.Text = reader(0)
                    txt_candidate_no.Text = reader(1)
                    txt_name.Text = reader(2)
                    txt_sponsor.Text = reader(3)
                    txt_info.Text = reader(4)

                    setControlEnabled(False, False, True, False, False, True, False, True, True, True, True, True)
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim fileName As String = System.IO.Path.GetFileName(txt_image.Text)
        Dim id As String

        Try
            id = dgv_candidates.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        Dim sql As String = "UPDATE t_candidate SET image = '" & txt_image.Text & "', number = '" & txt_candidate_no.Text & "', name = '" & txt_name.Text & "', sponsor = '" & txt_sponsor.Text & "', info = '" & txt_info.Text & "' WHERE id = '" & id & "'"
        Dim msgResult As Integer = MsgBoxResult.Yes

        'check for required fields
        If txt_image.Text = "" And txt_candidate_no.Text = "" And txt_name.Text = "" Then
            MsgBox("Please fill up fields with(*)")
            Exit Sub
        End If

        'check if candidate number is numeric
        If Not IsNumeric(txt_candidate_no.Text) Then
            MsgBox("Please input a numeric value in candidate number")
            Exit Sub
        End If

        'check if candidate number already exist in db
        If Functions.isExist("SELECT * FROM t_candidate WHERE number = '" & txt_candidate_no.Text & "' AND id <> '" & id & "'") = True Then
            MsgBox("Candidate number already exist!")
            Exit Sub
        End If

        'check if candidate name already exist in db
        If Functions.isExist("SELECT * FROM t_candidate WHERE name = '" & txt_name.Text & "' AND id <> '" & id & "'") = True Then
            MsgBox("Candidate name already exist!")
            Exit Sub
        End If

        'check if file exist to server
        'if not, copy image
        'if exist, dont copy image 
        If Not My.Computer.FileSystem.FileExists(Application.StartupPath & "\Images\" & fileName) Then
            'copy image file to server
            Try
                System.IO.File.Copy(txt_image.Text, Application.StartupPath & "\Images\" & fileName)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
        Else
            msgResult = MsgBox("File already exist! Do you want to continue saving candidate?", MessageBoxButtons.YesNo)
        End If

        If msgResult = MsgBoxResult.Yes Then
            If Functions.sqlInsert(sql) = True Then
                MsgBox("Successfully updated!")
                setControlEnabled(True, False, False, True, True, False, False, False, False, False, False, False)

                txt_candidate_no.Text = ""
                txt_image.Text = ""
                txt_info.Text = ""
                txt_name.Text = ""
                txt_sponsor.Text = ""

                dgv_candidates.Enabled = True

                populateDGV()
            End If
        End If

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim id As String

        Try
            id = dgv_candidates.SelectedCells(0).Value
        Catch ex As Exception
            MsgBox("No data selected!")
            Exit Sub
        End Try

        Dim msgResult As Integer = MsgBox("Are you sure you want to delete candidate?", MsgBoxStyle.YesNo)
        Dim sql As String = "DELETE FROM t_candidate WHERE id = '" & id & "'"

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
                pb_image.Image = Nothing
                populateDGV()
            End Try
        End If
    End Sub

    Private Sub dgv_candidates_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_candidates.SelectionChanged
        pb_image.Image = System.Drawing.Bitmap.FromFile(Application.StartupPath & "\Images\" & dgv_candidates.SelectedCells(5).Value)
    End Sub
End Class