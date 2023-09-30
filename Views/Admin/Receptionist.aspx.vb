Imports System.Activities.Statements
Imports System.Web.ModelBinding
Imports Dental_Care

Partial Class Views_Admin_Receptionist
    Inherits System.Web.UI.Page

    Private Con As Models.Functions
    Private key As Integer = 0

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Con = New Models.Functions()
        ShowReceptionist()
    End Sub

    Public Overrides Sub VerifyRenderingInServerForm(control As Control)

    End Sub

    Private Sub ShowReceptionist()
        Dim Query As String = "Select * from ReceptionistTb1"
        ReceptionistGV.DataSource = Con.GetDatas(Query)
        ReceptionistGV.DataBind()
    End Sub

    Protected Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            Dim RName As String = RecNameTb.Value
            Dim REmail As String = RecEmailTb.Value
            Dim RAdd As String = AddressTb.Value
            Dim RPhone As String = PhoneTb.Value
            Dim Password As String = PasswordTb.Value
            Dim Query As String = "insert into ReceptionistTb1 values('{0}','{1}','{2}','{3}','{4}')"
            Query = String.Format(Query, RName, REmail, RAdd, RPhone, Password)
            Con.SetDatas(Query)
            ShowReceptionist()
            ErrMsg.InnerText = "Receptionist Added!!"
            RecNameTb.Value = ""
            RecEmailTb.Value = ""
            AddressTb.Value = ""
            PhoneTb.Value = ""
            PasswordTb.Value = ""
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub ReceptionistGV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ReceptionistGV.SelectedIndexChanged
        RecNameTb.Value = ReceptionistGV.SelectedRow.Cells(2).Text
        RecEmailTb.Value = ReceptionistGV.SelectedRow.Cells(3).Text
        AddressTb.Value = ReceptionistGV.SelectedRow.Cells(4).Text
        PhoneTb.Value = ReceptionistGV.SelectedRow.Cells(5).Text
        PasswordTb.Value = ReceptionistGV.SelectedRow.Cells(6).Text
        If RecNameTb.Value = "" Then
            key = 0
        Else
            key = Convert.ToInt32(ReceptionistGV.SelectedRow.Cells(1).Text)
        End If
    End Sub

    Protected Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        Try
            If RecNameTb.Value = "" Then
                ErrMsg.InnerText = "Select a Receptionist!!"
            Else
                Dim Query As String = "delete from ReceptionistTb1 where RecId={0}"
                Query = String.Format(Query, ReceptionistGV.SelectedRow.Cells(1).Text)
                Con.SetDatas(Query)
                ShowReceptionist()
                ErrMsg.InnerText = "Receptionist Deleted!!"
                key = 0
                RecNameTb.Value = ""
                RecEmailTb.Value = ""
                AddressTb.Value = ""
                PhoneTb.Value = ""
                PasswordTb.Value = ""
            End If
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub

    Protected Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        Try
            Dim RName As String = RecNameTb.Value
            Dim REmail As String = RecEmailTb.Value
            Dim RAdd As String = AddressTb.Value
            Dim RPhone As String = PhoneTb.Value
            Dim Password As String = PasswordTb.Value
            Dim Query As String = "update ReceptionistTb1 set RecName = '{0}',RecEmail = '{1}',RecAdd = '{2}',RecPhone = '{3}',RecPassword = '{4}' where RecId = {5}"
            Query = String.Format(Query, RName, REmail, RAdd, RPhone, Password, ReceptionistGV.SelectedRow.Cells(1).Text)
            Con.SetDatas(Query)
            ShowReceptionist()
            ErrMsg.InnerText = "Receptionist updated!!"
            RecNameTb.Value = ""
            RecEmailTb.Value = ""
            AddressTb.Value = ""
            PhoneTb.Value = ""
            PasswordTb.Value = ""
        Catch ex As Exception
            ErrMsg.InnerText = ex.Message
        End Try
    End Sub
End Class
