Imports Dental_Care

Partial Class Views_Admin_Laboration
    Inherits System.Web.UI.Page

    Private Con As Models.Functions
    Private key As Integer = 0

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Con = New Models.Functions()
        showLaboratorian()
    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(control As Control)

    End Sub

    Private Sub showLaboratorian()
        Dim Query As String = "select * from LaboratorianTb1"
        LaboratorianGV.DataSource = Con.GetDatas(Query)
        LaboratorianGV.DataBind()
    End Sub

    Protected Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim LabName As String = LabNameTb.Value
            Dim LabEmail As String = EmailTb.Value
            Dim LabPass As String = PasswordTb.Value
            Dim LabPhone As String = PhoneTb.Value
            Dim LabAddress As String = LabAddressTb.Value
            Dim LabGen As String = GenderCb.SelectedItem.Value

            Dim Query As String = "insert into LaboratorianTb1 values ('{0}', '{1}', {2}, '{3}', '{4}', '{5}')"
            Query = String.Format(Query, LabName, LabEmail, LabPass, LabPhone, LabAddress, LabGen)
            Con.SetDatas(Query)
            showLaboratorian()
            ErrMsg.InnerText = "Laboratorian Added!!"
            LabNameTb.Value = ""
            EmailTb.Value = ""
            PasswordTb.Value = ""
            PhoneTb.Value = ""
            LabAddressTb.Value = ""
            GenderCb.SelectedIndex = -1
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub LaboratorianGV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LaboratorianGV.SelectedIndexChanged
        LabNameTb.Value = LaboratorianGV.SelectedRow.Cells(2).Text
        EmailTb.Value = LaboratorianGV.SelectedRow.Cells(3).Text
        PasswordTb.Value = LaboratorianGV.SelectedRow.Cells(4).Text
        PhoneTb.Value = LaboratorianGV.SelectedRow.Cells(5).Text
        LabAddressTb.Value = LaboratorianGV.SelectedRow.Cells(6).Text
        GenderCb.SelectedItem.Value = LaboratorianGV.SelectedRow.Cells(7).Text
        If LabNameTb.Value = "" Then
            key = 0
        Else
            key = Convert.ToInt32(LaboratorianGV.SelectedRow.Cells(1).Text)
        End If
    End Sub

    Protected Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If LabAddressTb.Value = "" Then
                ErrMsg.InnerText = "Select a Laboratorian!!"
            Else
                Dim Query As String = "delete from LaboratorianTb1 where LabId={0}"
                Query = String.Format(Query, LaboratorianGV.SelectedRow.Cells(1).Text)
                Con.SetDatas(Query)
                showLaboratorian()
                ErrMsg.InnerText = "Laboratorian Deleted!!"
                key = 0
                LabNameTb.Value = ""
                EmailTb.Value = ""
                PasswordTb.Value = ""
                PhoneTb.Value = ""
                LabAddressTb.Value = ""
                GenderCb.SelectedIndex = -1
            End If
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            Dim LabName As String = LabNameTb.Value
            Dim LabEmail As String = EmailTb.Value
            Dim LabPass As String = PasswordTb.Value
            Dim LabPhone As String = PhoneTb.Value
            Dim LabAddress As String = LabAddressTb.Value
            Dim LabGen As String = GenderCb.SelectedItem.Value
            Dim Query As String = "update LaboratorianTb1 set LabName = '{0}',LabEmail = '{1}',LabPass = '{2}',LabPhone = '{3}',LabAddress = '{4}',LabGen = '{5}' where LabId = {6}"
            Query = String.Format(Query, LabName, LabEmail, LabPass, LabPhone, LabAddress, LabGen, LaboratorianGV.SelectedRow.Cells(1).Text)
            Con.SetDatas(Query)
            showLaboratorian()
            ErrMsg.InnerText = "Laboratorian updated!!"
            key = 0
            LabNameTb.Value = ""
            EmailTb.Value = ""
            PasswordTb.Value = ""
            PhoneTb.Value = ""
            LabAddressTb.Value = ""
            GenderCb.SelectedIndex = -1
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub
End Class
