<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Views_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Libs/bootstrap-5.3.1-dist/css/bootstrap.min.css" />
    <style>
        .content-box {
            background-color: rgba(255, 255, 255, 0.8);
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
            height:440px;
            width:420px;
        }
    </style>
</head>
<body style="background-image:url(../Assets/Images/log.jpg);background-size:cover">
    <div class="container-fluid d-flex justify-content-center align-items-center" style="height: 100vh;">
        <div class="content-box">
            <h1 class="t" style="color:#A3A7E4">Dental Care Clinic</h1>
            <br />
            <form id="form1" runat="server">
                <div class="form-group">
                    <label for="EmailTb" class="form-label">Email address</label>
                    <input type="email" class="form-control" id="EmailTb" runat="server" style="max-width: 420px" required="required" />

                </div>
                <br />
                <div class="form-group">
                    <label for="PasswordTb">Password</label>
                    <input type="password" class="form-control" id="PasswordTb" runat="server" style="max-width: 420px" required="required" />

                </div>
                <br />
                <div class="form-check">
                 
                   <asp:DropDownList ID="RoleCb" runat="server" class="form-control">
                        <asp:ListItem>--Select Role--</asp:ListItem>
                       <asp:ListItem>Admin</asp:ListItem>
                        <asp:ListItem>Doctor</asp:ListItem>
                        <asp:ListItem>Receptionist</asp:ListItem>
                        <asp:ListItem>Laboratorian</asp:ListItem>
                    </asp:DropDownList>
                </div>
                
                <div class="d-grid">
                     <label runat="server" id="ErrMsg" class="text-danger">  </label>  <br />
                     <asp:Button ID="EditBtn" runat="server" Text="Login" class="btn btn-primary btn-block" style="background-color:#A3A7E4" />
                   

                </div>
            </form>
        </div>
    </div>
</body>
</html>
