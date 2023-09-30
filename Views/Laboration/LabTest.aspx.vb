
Imports Dental_Care

Partial Class Views_Laboration_Lab_Test
    Inherits System.Web.UI.Page


    Private Con As Models.Functions
    Private key As Integer = 0

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Con = New Models.Functions()
        showTest()
    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(control As Control)

    End Sub

    Private Sub showTest()
        Dim Query As String = "select * from LabTestTb1"
        LabTestGV.DataSource = Con.GetDatas(Query)
        LabTestGV.DataBind()
    End Sub

    Protected Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim TestName As String = LabNameTb.Value
            Dim TestCost As String = TestCostTb.Value
            Dim Query As String = "insert into LabTestTb1 values ('{0}', '{1}',{2})"
            Query = String.Format(Query, TestName, TestCost, Session("uid"))
            Con.SetDatas(Query)
            showTest()
            ErrMsg.InnerText = "Test Added!!"
            LabNameTb.Value = ""
            TestCostTb.Value = ""
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub


    Protected Sub LabTestGV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LabTestGV.SelectedIndexChanged
        LabNameTb.Value = LabTestGV.SelectedRow.Cells(2).Text
        TestCostTb.Value = LabTestGV.SelectedRow.Cells(3).Text

        If LabNameTb.Value = "" Then
            key = 0
        Else
            key = Convert.ToInt32(LabTestGV.SelectedRow.Cells(1).Text)
        End If
    End Sub

    Protected Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            Dim TestName As String = LabNameTb.Value
            Dim TestCost As String = TestCostTb.Value
            Dim Query As String = "update LabTestTb1 set TestName = '{0}',TestCost = {1} where TestId = {2}"
            Query = String.Format(Query, TestName, TestCost, LabTestGV.SelectedRow.Cells(1).Text)
            Con.SetDatas(Query)
            showTest()
            ErrMsg.InnerText = "Test updated!!"
            key = 0
            LabNameTb.Value = ""
            TestCostTb.Value = ""
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If LabNameTb.Value = "" Then
                ErrMsg.InnerText = "Select a Test!!"
            Else
                Dim Query As String = "delete from LabTestTb1 where TestId={0}"
                Query = String.Format(Query, LabTestGV.SelectedRow.Cells(1).Text)
                Con.SetDatas(Query)
                showTest()
                ErrMsg.InnerText = "Lab Test Deleted!!"
                key = 0
                LabNameTb.Value = ""
                TestCostTb.Value = ""
            End If
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub
End Class
