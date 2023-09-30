
Imports Dental_Care

Partial Class Views_Receptionist_Patients
    Inherits System.Web.UI.Page

    Private Con As Models.Functions
    Private key As Integer = 0
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Con = New Models.Functions()
        showPatient()
    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(control As Control)

    End Sub

    Private Sub showPatient()
        Dim Query As String = "select * from PatientTb1"
        PatientList.DataSource = Con.GetDatas(Query)
        PatientList.DataBind()
    End Sub

    Protected Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim PatName As String = PatNameTb.Value
            Dim PatPhone As String = PhoneTb.Value
            Dim PatGen As String = GenderCb.SelectedItem.Value
            Dim PatDOB As String = DOBTb.Value
            Dim PatAdd As String = AddressTb.Value
            Dim PatAllergies As String = AllergyTb.Value
            Dim Query As String = "insert into PatientTb1 values ('{0}', '{1}','{2}','{3}','{4}','{5}',{6})"
            Query = String.Format(Query, PatName, PatPhone, PatGen, PatDOB, PatAdd, PatAllergies, Session("uid"))
            Con.SetDatas(Query)
            showPatient()
            ErrMsg.InnerText = "Patient Added!!"
            PatNameTb.Value = ""
            PhoneTb.Value = ""
            AddressTb.Value = ""
            AllergyTb.Value = ""
            GenderCb.SelectedIndex = -1
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub PatientList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PatientList.SelectedIndexChanged
        PatNameTb.Value = PatientList.SelectedRow.Cells(2).Text
        PhoneTb.Value = PatientList.SelectedRow.Cells(3).Text
        GenderCb.SelectedItem.Value = PatientList.SelectedRow.Cells(4).Text
        DOBTb.Value = PatientList.SelectedRow.Cells(5).Text
        AddressTb.Value = PatientList.SelectedRow.Cells(6).Text
        AllergyTb.Value = PatientList.SelectedRow.Cells(7).Text

        If PatNameTb.Value = "" Then
            key = 0
        Else
            key = Convert.ToInt32(PatientList.SelectedRow.Cells(1).Text)
        End If
    End Sub

    Protected Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If PatNameTb.Value = "" Then
                ErrMsg.InnerText = "Select a Patient!!"
            Else
                Dim Query As String = "delete from PatientTb1 where TestId={0}"
                Query = String.Format(Query, PatientList.SelectedRow.Cells(1).Text)
                Con.SetDatas(Query)
                showPatient()
                ErrMsg.InnerText = "Patient Deleted!!"
                key = 0
                PatNameTb.Value = ""
                PhoneTb.Value = ""
                AddressTb.Value = ""
                AllergyTb.Value = ""
                GenderCb.SelectedIndex = -1
            End If
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            Dim PatName As String = PatNameTb.Value
            Dim PatPhone As String = PhoneTb.Value
            Dim PatGen As String = GenderCb.SelectedItem.Value
            Dim PatDOB As String = DOBTb.Value
            Dim PatAdd As String = AddressTb.Value
            Dim PatAllergies As String = AllergyTb.Value
            Dim Query As String = "update PatientTb1 set PatName = '{0}',PatPhone = '{1}',PatGen = '{2}',PatDOB = '{3}',PatAdd = '{4}',PatAllergies = '{5}' where PatId = {6}"
            Query = String.Format(Query, PatName, PatPhone, PatGen, PatDOB, PatAdd, PatAllergies, PatientList.SelectedRow.Cells(1).Text)
            Con.SetDatas(Query)
            showPatient()
            ErrMsg.InnerText = "Patient updated!!"
            key = 0
            PatNameTb.Value = ""
            PhoneTb.Value = ""
            AddressTb.Value = ""
            AllergyTb.Value = ""
            GenderCb.SelectedIndex = -1
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub
End Class
