<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Laboration/LaboratorianMaster.master" AutoEventWireup="false" CodeFile="LabTest.aspx.vb" Inherits="Views_Laboration_Lab_Test" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" Runat="Server">
      <div class="container-fluid">
          <div class="row" style="height:50px"></div>
        <div class="row">
            <div class="col-md-4">
                <h2>Laboratorian Test Detials</h2>
                <form>
  <div class="mb-3">
    <label for="Tb"> Name</label>
    <input type="text" class="form-control" id="LabNameTb" runat="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="TestCostTb">Test Cost</label>
    <input type="test" class="form-control" id="TestCostTb" runat="server" required="required"/>
  </div> 
  <div class="row" style="height:150px"></div>

 <label runat="server" id="ErrMsg" class="text-danger"></label>  <br />
  <asp:Button ID="EditBtn" runat="server" Text="  Edit  " class="btn btn-warning" BackColor="Yellow" ForeColor="Black" />
  <asp:Button ID="SaveBtn" runat="server" Text="  Save  "  class="btn btn-primary" BackColor="#00CCFF" ForeColor="Black" />
  <asp:Button ID="DeleteBtn" runat="server" Text="  Delete  " class="btn btn-danger" BackColor="Red" ForeColor="Black" />

</form>

            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/lab.jpg" height="300px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <h1>Laboratorian Test Detials</h1>
                        <asp:GridView ID="LabTestGV"  runat="server" CssClass="grid-view" AutoGenerateSelectButton="True" selectionMode="Single" Width="100%">
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                    </asp:GridView>
                </div>
                
            </div>
        </div>
    </div>
</asp:Content>

