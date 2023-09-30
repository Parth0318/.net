Imports Dental_Care

Partial Class Views_Doctors_Prescriptions
    Inherits System.Web.UI.Page

    Private Con As Models.Functions

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Con = New Models.Functions()
        ShowPrescription()
        GetTest()
        GetPatient()
    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(control As Control)

    End Sub

    Private Sub ShowPrescription()
        Dim Query As String = "select * from PrescriptionTb1"
        PrescriptionGV.DataSource = Con.GetDatas(Query)
        PrescriptionGV.DataBind()
    End Sub

    Private Sub GetTest()
        Dim Query As String = "select * from LabTestTb1"
        TestCb.DataTextField = Con.GetDatas(Query).Columns("TestName").ToString()
        TestCb.DataValueField = Con.GetDatas(Query).Columns("TestId").ToString()
        TestCb.DataSource = Con.GetDatas(Query)
        TestCb.DataBind()
    End Sub

    Private Sub GetPatient()
        Dim Query As String = "select * from PatientTb1"
        PatientCb.DataTextField = Con.GetDatas(Query).Columns("PatName").ToString()
        PatientCb.DataValueField = Con.GetDatas(Query).Columns("PatId").ToString()
        PatientCb.DataSource = Con.GetDatas(Query)
        PatientCb.DataBind()
    End Sub

    Protected Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim Doctor As String = 301
            Dim Patient As String = PatientCb.SelectedValue.ToString()
            Dim Medicine As String = MedicineTb.Value
            Dim Test As String = TestCb.SelectedValue.ToString()
            Dim Cost As String = CostTb.Value


            Dim Query As String = "insert into PrescriptionTb1 values ({0}, {1}, '{2}', {3}, '{4}')"
            Query = String.Format(Query, Doctor, Patient, Medicine, Test, Cost)
            Con.SetDatas(Query)
            ShowPrescription()
            ErrMsg.InnerText = "Prescription Added!!"
            MedicineTb.Value = ""
            CostTb.Value = ""
            PatientCb.SelectedIndex = -1
            TestCb.SelectedIndex = -1
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub
End Class
