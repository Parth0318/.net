Imports Dental_Care

Partial Class Views_Admin_Doctors
    Inherits System.Web.UI.Page

    Private Con As Models.Functions
    Private key As Integer = 0

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Con = New Models.Functions()
        ShowDoctors()
    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(control As Control)

    End Sub

    Private Sub ShowDoctors()
        Dim Query As String = "Select * from DoctorTb1"
        DoctorsGV.DataSource = Con.GetDatas(Query)
        DoctorsGV.DataBind()
    End Sub

    Protected Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim DocName As String = DocNameTb.Value
            Dim DocPhone As String = DocPhoneTb.Value
            Dim DocExp As String = DocExpTb.Value
            Dim DocSpec As String = SpecializationTb.Value
            Dim DocGen As String = GenderCb.SelectedValue
            Dim DocAdd As String = AddressTb.Value
            Dim DocDOB As String = DOBTb.Value
            Dim DocPass As String = PasswordTb.Value
            Dim DocEmail As String = EmailTb.Value

            Dim Query As String = "insert into DoctorTb1 values('{0}','{1}',{2},'{3}','{4}','{5}','{6}','{7}','{8}')"
            Query = String.Format(Query, DocName, DocPhone, DocExp, DocSpec, DocGen, DocAdd, DocDOB, DocPass, DocEmail)
            Con.SetDatas(Query)
            ShowDoctors()
            ErrMsg.InnerText = "Doctor Added!!"
            DocNameTb.Value = ""
            DocPhoneTb.Value = ""
            DocExpTb.Value = ""
            SpecializationTb.Value = ""
            AddressTb.Value = ""
            PasswordTb.Value = ""
            GenderCb.SelectedIndex = -1
            EmailTb.Value = ""
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub DoctorsGV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DoctorsGV.SelectedIndexChanged
        DocNameTb.Value = DoctorsGV.SelectedRow.Cells(2).Text
        DocPhoneTb.Value = DoctorsGV.SelectedRow.Cells(3).Text
        DocExpTb.Value = DoctorsGV.SelectedRow.Cells(4).Text
        SpecializationTb.Value = DoctorsGV.SelectedRow.Cells(5).Text
        GenderCb.SelectedValue = DoctorsGV.SelectedRow.Cells(6).Text
        AddressTb.Value = DoctorsGV.SelectedRow.Cells(7).Text
        DOBTb.Value = DoctorsGV.SelectedRow.Cells(8).Text
        PasswordTb.Value = DoctorsGV.SelectedRow.Cells(9).Text
        EmailTb.Value = DoctorsGV.SelectedRow.Cells(10).Text
        If DocNameTb.Value = "" Then
            key = 0
        Else
            key = Convert.ToInt32(DoctorsGV.SelectedRow.Cells(1).Text)
        End If
    End Sub

    Protected Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If DocNameTb.Value = "" Then
                ErrMsg.InnerText = "Select a Doctor!!"
            Else
                Dim Query As String = "delete from DoctorTb1 where DocId={0}"
                Query = String.Format(Query, DoctorsGV.SelectedRow.Cells(1).Text)
                Con.SetDatas(Query)
                ShowDoctors()
                ErrMsg.InnerText = "Doctor Deleted!!"
                key = 0
                DocNameTb.Value = ""
                DocPhoneTb.Value = ""
                DocExpTb.Value = ""
                SpecializationTb.Value = ""
                AddressTb.Value = ""
                PasswordTb.Value = ""
                GenderCb.SelectedIndex = -1
                EmailTb.Value = ""
            End If
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            Dim DocName As String = DocNameTb.Value
            Dim DocPhone As String = DocPhoneTb.Value
            Dim DocExp As String = DocExpTb.Value
            Dim DocSpec As String = SpecializationTb.Value
            Dim DocGen As String = GenderCb.SelectedValue
            Dim DocAdd As String = AddressTb.Value
            Dim DocDOB As String = DOBTb.Value
            Dim DocPass As String = PasswordTb.Value
            Dim DocEmail As String = EmailTb.Value

            Dim Query As String = "update DoctorTb1 set DocName = '{0}',DocPhone = '{1}',DocExp = {2},DocSpec = '{3}',DocGen = '{4}',DocAdd = '{5}',DocDob = '{6}',DocPass = '{7}',DocEmail = '{8}' where DocId = {9}"
            Query = String.Format(Query, DocName, DocPhone, DocExp, DocSpec, DocGen, DocAdd, DocDOB, DocPass, DocEmail, DoctorsGV.SelectedRow.Cells(1).Text)
            Con.SetDatas(Query)
            ShowDoctors()
            ErrMsg.InnerText = "Doctor updated!!"
            DocNameTb.Value = ""
            DocPhoneTb.Value = ""
            DocExpTb.Value = ""
            SpecializationTb.Value = ""
            AddressTb.Value = ""
            PasswordTb.Value = ""
            GenderCb.SelectedIndex = -1
            EmailTb.Value = ""
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub
End Class
