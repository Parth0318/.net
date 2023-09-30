<%@ Page Title="" Language="VB" MasterPageFile="~/Views/Admin/AdminMaster.master" AutoEventWireup="false" CodeFile="Doctors.aspx.vb" Inherits="Views_Admin_Doctors" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <nav class="navbar navbar-expand-lg bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" href="#">Dental Care</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link href="Doctors.aspx">Doctors</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="Laboration.aspx">Laboratorian</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="#">Receptionist</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="../Login.aspx">Logout</a>
        </li>
    </div>
  </div>
</nav>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" Runat="Server">
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-3">
                <h2>Doctors Detail</h2>
                <form>
  <div class="mb-3">
    <label for="exampleInputEmail1">Doctor Name</label>
    <input type="text" class="form-control" id="DocNameTb" runat="server" required="required"/>
    
  </div>
  <div class="mb-3">
    <label for="DocPhoneTb">Phone Number</label>
   <input type="text" class="form-control" id="DocPhoneTb" runat="server" required="required" />

    
  </div>
  <div class="mb-3">
    <label for="DocExptb">Doctor Experience</label>
    <input type="text" class="form-control" id="DocExpTb" runat="server" required="required" />
    
  </div>

   <div class="mb-3">
    <label for="SpacializationTb">Spacialization</label>
    <input type="text" class="form-control" id="SpecializationTb" runat="server" required="required" />
    
  </div>  
   
  <div class="mb-3">
    <label for="PasswordTb">Password</label>
    <input type="text" class="form-control" id="PasswordTb" runat="server" required="required"/>
  </div>
  <div class="mb-3">
    <label for="GenderCb">Gender</label>
      <asp:DropDownList ID="GenderCb" runat="server" class="form-control">
          <asp:ListItem>Male</asp:ListItem>
           <asp:ListItem>Female</asp:ListItem>
      </asp:DropDownList>
    
  </div>  
  <div class="mb-3">
    <label for="AddressTb">Address</label>
    <input type="text" class="form-control" id="AddressTb" runat="server" required="required"/>
  </div> 
   <div class="mb-3">
    <label for="DOBTb">Date of Birth</label>
    <input type="date" class="form-control" id="DOBTb" runat="server" required="required"/>
  </div> 
                    
    <div class="mb-3">
    <label for="EmailTb">Email</label>
    <input type="email" class="form-control" id="EmailTb" runat="server" required="required"/>
  </div> 
  
 <label runat="server" id="ErrMsg" class="text-danger"></label>  <br />
  <asp:Button ID="EditBtn" runat="server" Text="Edit" class="btn btn-warning" BackColor="Yellow" ForeColor="Black" />
  <asp:Button ID="SaveBtn" runat="server" Text="Save"  class="btn btn-primary" BackColor="#00CCFF" ForeColor="Black" />
  <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger" BackColor="Red" ForeColor="Black" />

</form>

            </div>
            <div class="col-md-9">
                <div class="row">
                    <div class="col">
                        <img src="../../Assets/Images/doct.jpg" height="300px" width="100%" class="rounded-3" />
                    </div>
                </div>
                <div class="row">
                    <h1>Doctors Detials</h1>
                         <asp:GridView ID="DoctorsGV"  runat="server" CssClass="grid-view" AutoGenerateSelectButton="True" selectionMode="Single" Width="100%">
                    
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

