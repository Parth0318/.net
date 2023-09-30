Imports System.Data
Imports System.Data.SqlClient

Namespace Dental_Care.Models
    Public Class Functions
        Private Con As SqlConnection
        Private Cmd As SqlCommand
        Private dt As DataTable
        Private ConStr As String
        Private sda As SqlDataAdapter

        Public Sub New()
            ConStr = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Parth Rohit\Documents\ClinicASPDb.mdf;Integrated Security=True;Connect Timeout=30"
            Con = New SqlConnection(ConStr)
            Cmd = New SqlCommand()
            Cmd.Connection = Con
        End Sub

        Public Function SetDatas(sql As String) As Integer
            Dim cnt As Integer = 0
            If (Con.State = ConnectionState.Closed) Then
                Con.Open()
            End If
            Cmd.CommandText = sql
            cnt = Cmd.ExecuteNonQuery()
            Con.Close()
            Return cnt
        End Function

        Public Function GetDatas(Query As String) As DataTable
            dt = New DataTable()
            sda = New SqlDataAdapter(Query, ConStr)
            sda.Fill(dt)
            Return dt
        End Function
    End Class
End Namespace
