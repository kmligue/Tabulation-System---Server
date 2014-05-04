Public Class Elimination

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim sql As String = "SELECT number FROM v_top WHERE score <> 'null' ORDER BY score DESC LIMIT " & txt_generate.Text
        Dim number As String = ""

        Try
            Connect.constring.Open()
            Functions.com.Connection = Connect.constring
            Functions.com.CommandText = sql
            Functions.reader = Functions.com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    If number = "" Then
                        number &= reader(0)
                    Else
                        number &= ", " & reader(0)
                    End If
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        If Not number = "" Then
            sql = "UPDATE t_candidate SET top = 1 WHERE number IN (" & number & ")"

            Try
                Connect.constring.Open()
                Functions.com.Connection = Connect.constring
                Functions.com.CommandText = sql
                Functions.com.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.constring.Close()
                MsgBox("Successfully updated!")
            End Try
        Else
            MsgBox("Cannot generate top " & txt_generate.Text & ".")
        End If
    End Sub

    Private Sub txt_generate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_generate.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class