<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Admin/AdminMaster.master" AutoEventWireup="false" CodeFile="Receptionist.aspx.vb" Inherits="Views_Admin_Receptionist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" Runat="Server">

     <nav class="navbar navbar-expand-lg bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Dental Care</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link" href="Doctors.aspx">Doctors</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="Laboration.aspx">Laboratorian</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="Receptionist.aspx">Receptionist</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="../Login.aspx">Logout</a>
        </li>
    </div>
  </div>
</nav>

     <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <h2>Receptionist Detail</h2>
                <form>
  <div class="mb-3">
    <label for="RecNameTb"> Name</label>
    <input type="text" class="form-control" id="RecNameTb" runat="server" required="required"/>
    
  </div>
  <div class="mb-3">
    <label for="RecEmailTb">Email</label>
    <input type="email" class="form-control" id="RecEmailTb" runat="server" required="required"/>
    
  </div>
  <div class="mb-3">
    <label for="AddressTb">Address</label>
    <input type="text" class="form-control" id="AddressTb" runat="server" required="required"/>
    
  </div>

   <div class="mb-3">
    <label for="PhoneTb">Phone</label>
    <input type="number" class="form-control" id="PhoneTb" runat="server" required="required"/>
    
  </div>  
   
  <div class="mb-3">
    <label for="PasswordTb">Password</label>
    <input type="text" class="form-control" id="PasswordTb" runat="server"  required="required"/>
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
                        <img src="../../Assets/Images/rec.jpg" height="400px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <h1>Receptionist Details</h1>
                    <asp:GridView ID="ReceptionistGV"  runat="server" CssClass="grid-view" AutoGenerateSelectButton="True" selectionMode="Single" Width="100%">
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

