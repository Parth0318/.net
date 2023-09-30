    <%@ Page Title="" Language="VB" MasterPageFile="~/Views/Receptionist/ReceptionistMaster.master" AutoEventWireup="false" CodeFile="Patients.aspx.vb" Inherits="Views_Receptionist_Patients" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" Runat="Server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Patient Detail</h2>
                <form>
  <div class="mb-3">
    <label for="PatNameTb">Name</label>
    <input type="text" class="form-control" id="PatNameTb" runat="server" required="required"/>
  </div>
   <div class="mb-3">
    <label for="PhoneTb">Phone</label>
    <input type="number" class="form-control" id="PhoneTb" runat="server" required="required"/>
  </div>  
  <div class="mb-3">
    <label for="Gender-Cb">Gender</label>
     <asp:DropDownList ID="GenderCb" runat="server" class="form-control">
          <asp:ListItem>Male</asp:ListItem>
           <asp:ListItem>Female</asp:ListItem>
      </asp:DropDownList>
  </div>  
  <div class="mb-3">
    <label for="DOBTb">DOB</label>
    <input type="date" class="form-control" id="DOBTb" runat="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="AddressTb">Address</label>
    <input type="text" class="form-control" id="AddressTb" runat="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="AllergyTb">Allergies</label>
    <input type="text" class="form-control" id="AllergyTb" runat="server" required="required"/>
  </div>
  
  
 <label runat="server" id="ErrMsg" class="text-danger"></label>  <br />
  <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" BackColor="Yellow" ForeColor="Black" />
  <asp:Button ID="SaveBtn" runat="server" Text="Save"  class="btn btn-primary" BackColor="#00CCFF" ForeColor="Black" />
  <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" BackColor="Red" ForeColor="Black" />

</form>

            </div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/pat.jpg" height="350px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <h1>Patient List</h1>
                        <asp:GridView ID="PatientList"  runat="server" CssClass="grid-view" AutoGenerateSelectButton="True" selectionMode="Single" Width="100%">
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

