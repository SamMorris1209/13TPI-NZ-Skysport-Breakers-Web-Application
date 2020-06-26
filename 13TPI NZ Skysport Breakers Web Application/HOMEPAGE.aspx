<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HOMEPAGE.aspx.cs" Inherits="_13TPI_NZ_Skysport_Breakers_Web_Application.WebForm1" %>

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


.bgimg-1, .bgimg-2, .bgimg-3 {
  background-attachment: fixed;
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
}


.bgimg-1 {
  background-image: url('/w3images/parallax1.jpg');
  min-height: 100%;
}


.bgimg-2 {
  background-image: url("/w3images/parallax2.jpg");
  min-height: 400px;
}


.bgimg-3 {
  background-image: url("/w3images/parallax3.jpg");
  min-height: 400px;
}

.w3-wide {letter-spacing: 10px;}
.w3-hover-opacity {cursor: pointer;}


@media only screen and (max-device-width: 1600px) {
  .bgimg-1, .bgimg-2, .bgimg-3 {
    background-attachment: scroll;
    min-height: 400px;
  }
}
    .auto-style1 {
        width: 1852px;
        height: 686px;
    }
</style>
<body style="background-color:black;color:white">

    <form id="form1" runat="server">


<div class="w3-top" style="background-color:black">
  <div class="w3-bar" id="myNavbar">
    <a class="w3-bar-item w3-button w3-hover-black w3-hide-medium w3-hide-large w3-right" href="javascript:void(0);" onclick="toggleFunction()" title="Toggle Navigation Menu">
      <i class="fa fa-bars"></i>
    </a>
    <a class="w3-bar-item " onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white">
      <asp:Button ID="Home_Button" runat="server" OnClick="Home_Button_Click" Text="HOME" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" />
      </a>&nbsp;
      <a class="w3-bar-item w3-hide-small" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white"><i class="fa fa-user"></i>
          <asp:Button ID="Players_Button" runat="server" OnClick="Players_Button_Click" Text="PLAYERS" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" /></a>
    
      <a class="w3-bar-item w3-hide-small" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white"><i><img src="IMAGES/GOODDATE.png" style="width:20px;height:20px;"></i>
          <asp:Button ID="Schedule_Button" runat="server" OnClick="Schedule_Button_Click" Text="SCHEDULE" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'"/></a>
   
      <a class="w3-bar-item w3-hide-small" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white"><i><img src="IMAGES/BBALL.png" style="width:20px;height:20px;" /></i>
          <asp:Button ID="Tips_Button" runat="server" Text="TIPS AND TRICKS" OnClick="Tips_Button_Click" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'"/></a>
   
      <a class="w3-bar-item w3-hide-small" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white"><i><img src="IMAGES/vidoes.png" style="width:20px;height:20px;" /></i> 
          <asp:Button ID="Videos_Button" runat="server" Text="VIDEOS" OnClick="Videos_Button_Click" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'"/> </a>
   
      <a class="w3-bar-item w3-hide-small w3-right" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white">
          <asp:Button ID="login_button" runat="server" Text="LOGIN/REGISTER" OnClick="login_button_Click" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'"/>
    </a>
  </div>

  <div id="navDemo" class="w3-bar-block w3-white w3-hide w3-hide-large w3-hide-medium" style="background-color:black">
    <a href="#about" class="w3-bar-item w3-button" onclick="Button1_Click">PLAYERS</a>
    <a href="#portfolio" class="w3-bar-item w3-button" onclick="toggleFunction()">SCHEDULE</a>
    <a href="#contact" class="w3-bar-item w3-button" onclick="toggleFunction()">TIPS AND TRICKS</a>
    <a href="#contact" class="w3-bar-item w3-button" onclick="toggleFunction()">VIDEOS</a>
  </div>
</div>

    <p>
        &nbsp;</p>
        <img alt="" class="auto-style1" src="IMAGES/Sky-Sport-Breakers-Logo-White.png" style="background-image:url(IMAGES/spark-arena.jfif);margin-left:auto;margin-right:auto;width:101%"/>

    </form>
    </body>

    </html>