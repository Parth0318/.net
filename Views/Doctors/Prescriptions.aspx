<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Doctors/DoctorMaster.master" AutoEventWireup="false" CodeFile="Prescriptions.aspx.vb" Inherits="Views_Doctors_Prescriptions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" Runat="Server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Prescription Detail</h2>
                <br /><br /><br />
                <form>
  <div class="mb-3">
    <label for="PatientCb">Patient</label>
      <asp:DropDownList ID="PatientCb" runat="server" class="form-control">
         
      </asp:DropDownList>
  </div>
  <div class="mb-3">
    <label for="MedicineTb">Medicines</label>
    <input type="text" class="form-control" id="MedicineTb" runat="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="TestCb">Lab Test</label>
     <asp:DropDownList ID="TestCb" runat="server" class="form-control">
         
      </asp:DropDownList>
    
  </div>

   <div class="mb-3">
    <label for="CostTb">Cost</label>
    <input type="number" class="form-control" id="CostTb" runat="server" required="required"/>
    
  </div>  
   
  <div class="d-grid">
      <label runat="server" id="ErrMsg" class="text-danger"></label>  <br />
  
  <asp:Button ID="SaveBtn" runat="server" Text="Save Prescription"  class="btn btn-warning btn-block text-white" BackColor="#00CCFF" ForeColor="Black" />

  </div>
  

</form>

            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/pre.jpg" height="450px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <h1>Prescription Detials</h1>
                        <asp:GridView ID="PrescriptionGV"  runat="server" CssClass="grid-view" AutoGenerateSelectButton="True" selectionMode="Single" Width="100%">
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

