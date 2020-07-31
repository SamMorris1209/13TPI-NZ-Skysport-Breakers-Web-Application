<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN.aspx.cs" Inherits="_13TPI_NZ_Skysport_Breakers_Web_Application.LOGIN" %>

<!DOCTYPE html>

<html>
<title>NZ Skysports Breakers</title>
<meta charset="UTF-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css">
<link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Lato">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
<style>
body,h1,h2,h3,h4,h5,h6 {font-family: "Lato", sans-serif;}
body, html {
  height: 100%;
  color: #777;
  line-height: 1.8;
}

/* Create a Parallax Effect */
.bgimg-1, .bgimg-2, .bgimg-3 {
  background-attachment: fixed;
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
}

/* First image (Logo. Full height) */
.bgimg-1 {
  background-image: url('/w3images/parallax1.jpg');
  min-height: 100%;
}

/* Second image (Portfolio) */
.bgimg-2 {
  background-image: url("/w3images/parallax2.jpg");
  min-height: 400px;
}

/* Third image (Contact) */
.bgimg-3 {
  background-image: url("/w3images/parallax3.jpg");
  min-height: 400px;
}

.w3-wide {letter-spacing: 10px;}
.w3-hover-opacity {cursor: pointer;}

/* Turn off parallax scrolling for tablets and phones */
@media only screen and (max-device-width: 1600px) {
  .bgimg-1, .bgimg-2, .bgimg-3 {
    background-attachment: scroll;
    min-height: 400px;
  }
}
    </style>
<body style="background-color:black;color:white">

    <form id="form1" runat="server">

<div class="w3-top" style="background-color:black">
  <div class="w3-bar" id="myNavbar">
      <img src="IMAGES/Sky-Sport-Breakers-Logo-White.png" style="width:10%;height:10%"/> <asp:Button ID="Button1" runat="server" Text="HOME" BackColor="Black" BorderStyle="None" Font-Bold="True" ForeColor="White" Height="47px" Width="116px" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='black'"  onclick="HomeLogo_Click" />
  </div> 
</div>
         <div style="background-color:black; margin-bottom: 19px;">
        <br/>
        <br/>
        <p>
    <asp:Label ID="Label1" runat="server" Text="Sign In" Font-Bold="True" Font-Italic="True" Font-Names="Segoe UI Black" Font-Size="XX-Large" ForeColor="White"></asp:Label>
       </p>
        <asp:Label ID="Label3" runat="server" Text="Username:" Font-Bold="True" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="White"></asp:Label>
        <p class="w3-center">
        <asp:TextBox ID="txtUsernameIn" runat="server" Height="55px" Width="575px" BackColor="#F0E6C5" Font-Size="Large" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
            </p>
          <asp:Label ID="Label4" runat="server" Text="Password:" Font-Bold="True" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="White"></asp:Label>
        <p class="w3-center">
        <asp:TextBox ID="txtPasswordIn" runat="server" Height="55px" Width="575px" BackColor="#F0E6C5" Font-Size="Large" onkeydown = "return (event.keyCode!=13);" TextMode="Password"></asp:TextBox>
            </p>
             <p class="w3-center">
             <asp:Button ID="btnSignIn" runat="server" Text="Sign In!" BorderStyle="Groove" Font-Bold="False" Font-Size="Large" OnClick="btnSignIn_Click" />
                 <asp:Label ID="Label10" runat="server" Font-Size="Large" ForeColor="Red" Height="0px" Text="Password is incorrect" Visible="False"></asp:Label>
                 </p>
        <p style="color:white">
            ________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________________
        </p>
                <p>
    <asp:Label ID="Label2" runat="server" Text="Sign Up" ForeColor="White" Font-Bold="True" Font-Italic="True" Font-Names="Segoe UI Black" Font-Size="XX-Large"></asp:Label>
            </p>
        <asp:Label ID="Label8" runat="server" Text="First Name:" Font-Bold="True" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="White"></asp:Label>
        <p class="w3-center">
        <asp:TextBox ID="txtFirstname" runat="server" Height="55px" Width="575px" BackColor="#F0E6C5" Font-Size="Large" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
            </p>
          <asp:Label ID="Label9" runat="server" Text="Last Name:" Font-Bold="True" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="White"></asp:Label>
        <p class="w3-center">
        <asp:TextBox ID="txtLastname" runat="server" Height="55px" Width="575px" BackColor="#F0E6C5" Font-Size="Large" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
            </p>
        <asp:Label ID="Label5" runat="server" Text="Username:" Font-Bold="True" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="White" ></asp:Label>
        <p class="w3-center">
        <asp:TextBox ID="txtUsername" runat="server" Height="55px" Width="575px" BackColor="#F0E6C5" Font-Size="Large" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
            </p>
          <asp:Label ID="Label6" runat="server" Text="Password:" Font-Bold="True" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="White"></asp:Label>
        <p class="w3-center">
        <asp:TextBox ID="txtPassword" runat="server" Height="55px" Width="575px" BackColor="#F0E6C5" Font-Size="Large" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
            </p>
        <asp:Label ID="Label7" runat="server" Text="Confirm Password:" Font-Bold="True" Font-Names="Segoe UI Black" Font-Size="X-Large" ForeColor="White"></asp:Label>
        <p class="w3-center">
        <asp:TextBox ID="txtConfirmpassword" runat="server" Height="55px" Width="575px" BackColor="#F0E6C5" Font-Size="Large" onkeydown = "return (event.keyCode!=13);"></asp:TextBox>
            </p>
              <p class="w3-center">
             <asp:Button ID="btnSignUp" runat="server" Text="Sign Up!" BorderStyle="Groove" Font-Bold="False" Font-Size="Large" OnClick="btnSignUp_Click" />
                 </p>
        </div>
        <asp:HiddenField ID="HFSearch" runat="server" />
    </form>
    </body>
    <script>

    </script>
    </html>
