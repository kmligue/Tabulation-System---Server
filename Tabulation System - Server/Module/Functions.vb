Imports MySql.Data.MySqlClient

Module Functions

    Public com As New MySqlCommand
    Public reader As MySqlDataReader

    Public Function sqlInsert(ByVal sql As String) As Boolean
        Dim result As Boolean = True

        Try
            Connect.constring.Open()
            com.Connection = Connect.constring
            com.CommandText = sql
            com.ExecuteNonQuery()
        Catch ex As Exception
            result = False
            MsgBox(ex.Message)
        Finally
            Connect.constring.Close()
        End Try

        Return result
    End Function

    Public Function isExist(ByVal sql As String) As Boolean
        Dim result As Boolean = False

        Try
            Connect.constring.Open()
            com.Connection = Connect.constring
            com.CommandText = sql
            reader = com.ExecuteReader

            While reader.Read
                If reader.HasRows Then
                    result = True
                    Exit While
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Connect.constring.Close()
        End Try

        Return result
    End Function

End Module
