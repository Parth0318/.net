Imports System.Data
Imports System.Diagnostics
Imports Dental_Care

Partial Class Views_Login
    Inherits System.Web.UI.Page

    Private Con As Models.Functions

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Con = New Models.Functions()
    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(control As Control)
        ' Add any specific rendering verification code if needed
    End Sub

    Protected Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If RoleCb.SelectedIndex = 0 Then
            ErrMsg.InnerText = "Select a Role!!"
        ElseIf RoleCb.SelectedIndex = 1 Then
            If EmailTb.Value = "Admin@gmail.com" AndAlso PasswordTb.Value = "admin" Then

                Dim role As String = "Admin"
                Session("uid") = 1
                Session("role") = role
                Session.Timeout = 10
                Dim r_url As String = ResolveUrl("~/Views/Admin/Doctors.aspx")

                System.Diagnostics.Debug.WriteLine("Redirecting to URL: " & r_url) ' Add this line for debugging
                Response.Redirect(r_url)



            Else
                ErrMsg.InnerText = "Invalid Admin!!"
            End If

        ElseIf RoleCb.SelectedIndex = 2 Then
            ErrMsg.InnerText = "Select a Doctor!!"
            Dim Query As String = "Select * from DoctorTb1 where DocEmail = '{0}' and DocPass = '{1}'"
            Query = String.Format(Query, EmailTb.Value, PasswordTb.Value)
            Dim dt As DataTable = Con.GetDatas(Query)
            If dt.Rows.Count = 0 Then
                ErrMsg.InnerText = "Invalid Doctor!!"
            Else
                Dim role As String = "Doctors"
                Session("uid") = dt.Rows(0)(0).ToString()
                Session("role") = role
                Session.Timeout = 10
                Dim r_url As String = "Doctors/Prescriptions.aspx"
                Response.Redirect(r_url)
            End If
        ElseIf RoleCb.SelectedIndex = 3 Then
            ErrMsg.InnerText = "Select a Receptionist!!"
            Dim Query As String = "Select * from ReceptionistTb1 where RecEmail = '{0}' and RecPassword = '{1}'"
            Query = String.Format(Query, EmailTb.Value, PasswordTb.Value)
            Dim dt As DataTable = Con.GetDatas(Query)
            If dt.Rows.Count = 0 Then
                ErrMsg.InnerText = "Invalid Receptionist!!"
            Else
                Dim role As String = "Receptionist"
                Session("uid") = dt.Rows(0)(0).ToString()
                Session("role") = role
                Session.Timeout = 10
                Dim r_url As String = ResolveUrl("~/Views/Receptionist/Patients.aspx")

                System.Diagnostics.Debug.WriteLine("Redirecting to URL: " & r_url)
                Response.Redirect(r_url)
            End If

        ElseIf RoleCb.SelectedIndex = 4 Then
            ErrMsg.InnerText = "Select a Laboratorian!!"
            Dim Query As String = "Select * from LaboratorianTb1 where LabEmail = '{0}' and LabPass = '{1}'"
            Query = String.Format(Query, EmailTb.Value, PasswordTb.Value)
            Dim dt As DataTable = Con.GetDatas(Query)
            If dt.Rows.Count = 0 Then
                ErrMsg.InnerText = "Invalid Laboratorian!!"
            Else
                Dim role As String = "Doctors"
                Session("uid") = dt.Rows(0)(0).ToString()
                Session("role") = role
                Session.Timeout = 10
                Dim r_url As String = ResolveUrl("~/Views/Laboration/LabTest.aspx")

                System.Diagnostics.Debug.WriteLine("Redirecting to URL: " & r_url)
                Response.Redirect(r_url)

            End If
        End If

    End Sub
End Class
