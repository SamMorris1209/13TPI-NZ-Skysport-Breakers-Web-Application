<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ADMINPAGE.aspx.cs" Inherits="_13TPI_NZ_Skysport_Breakers_Web_Application.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-size:xx-large">
            <asp:HiddenField ID="hfUserID" runat="server" />
            Admin Dashboard
        </div>
        <br/>
        <p style="font-size:x-large">
        Modify/Delete User:
            </p>
        <br />
        Insert UserID of user you want to modify:
        <asp:TextBox ID="txtID" runat="server" Height="16px" onkeydown = "return (event.keyCode!=13)"></asp:TextBox>
        <br/>
        <asp:Button ID="txtGenerate" runat="server" Text="Generate" OnClick="txtGenerate_Click" />
        <br/>
        <br/>
        First Name: <asp:TextBox ID="txtFirstName" runat="server" onkeydown = "return (event.keyCode!=13)"></asp:TextBox>
        <br/>
        Last Name: <asp:TextBox ID="txtLastName" runat="server" onkeydown = "return (event.keyCode!=13)"></asp:TextBox>
        <br/>
        Username: <asp:TextBox ID="txtUsername" runat="server" onkeydown = "return (event.keyCode!=13)"></asp:TextBox>
        <br/>
        Password: <asp:TextBox ID="txtPassword" runat="server" onkeydown = "return (event.keyCode!=13)"></asp:TextBox>
        <br/>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
        <asp:Label ID="lblSuccessMessage" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="btnReturn" runat="server" Text="Return to Login Page" OnClick="btnReturn_Click" />
    </form>
</body>
</html>
