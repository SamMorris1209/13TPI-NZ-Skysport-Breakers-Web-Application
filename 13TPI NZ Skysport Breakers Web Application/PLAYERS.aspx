<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PLAYERS.aspx.cs" Inherits="_13TPI_NZ_Skysport_Breakers_Web_Application.PLAYERS" %>

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
.ButtonClass
{
    cursor: pointer;
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
    .auto-style1 {
        width: 1852px;
        height: 686px;
    }
.container {
  position: relative;
  width: 100%;
}

 

.image {
  display: block;
  width: 100%;
  height: auto;
}

 

.overlay {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  height: 100%;
  width: 100%;
  opacity: 0;
 /* transition: .5s ease; */
  /*background-color: #008CBA;*/
}

 

.container .overlay {
  opacity: 1;
}

 

.first {
  color: white;
  font-size: 30px;
  position: absolute;
  top: 10%;
  left: 17%;
  -webkit-transform: translate(-50%, -50%);
  -ms-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
  text-align: left;
  font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
    
}
.last {
  color: white;
  font-size: 30px;
  position: absolute;
  top: 20%;
  left: 17%;
  -webkit-transform: translate(-50%, -50%);
  -ms-transform: translate(-50%, -50%);
  transform: translate(-50%, -50%);
  text-align: left;
  font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif
}
</style>
<body style="background-color:black;color:white">

    <form id="form1" runat="server">

<!-- Navbar (sit on top) -->
<div class="w3-top" style="background-color:black">
   <div class="w3-bar" id="myNavbar">
    <a class="w3-bar-item w3-button w3-hover-black w3-hide-medium w3-hide-large w3-right" href="javascript:void(0);" onclick="toggleFunction()" title="Toggle Navigation Menu">
      <i class="fa fa-bars"></i>
    </a>
    <a class="w3-bar-item " onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white">
      <asp:Button ID="Home_Button" runat="server" OnClick="Home_Button_Click" CssClass="ButtonClass" Text="HOME" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" />
      </a>&nbsp;
      <a class="w3-bar-item w3-hide-small" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white"><i class="fa fa-user"></i>
          <asp:Button ID="Players_Button" runat="server" OnClick="Players_Button_Click" CssClass="ButtonClass" Text="PLAYERS" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" /></a>
   
      <a class="w3-bar-item w3-hide-small" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white"><i><img src="IMAGES/BBALL.png" style="width:20px;height:20px;" /></i>
          <asp:Button ID="Tips_Button" runat="server" Text="TIPS AND TRICKS" OnClick="Tips_Button_Click" CssClass="ButtonClass" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'"/></a>
   
      <a class="w3-bar-item w3-hide-small" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white"><i><img src="IMAGES/vidoes.png" style="width:20px;height:20px;" /></i> 
          <asp:Button ID="Videos_Button" runat="server" Text="VIDEOS" OnClick="Videos_Button_Click" CssClass="ButtonClass" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'"/> </a>
   
       <a class="w3-bar-item w3-hide-small w3-right" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white">
          <asp:Button ID="logout_button" runat="server" Text="LOGOUT" OnClick="logout_button_Click" CssClass="ButtonClass" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Visible="False" /></a>
    

      <a class="w3-bar-item w3-hide-small w3-right" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white">
          <asp:Button ID="login_button" runat="server" Text="LOGIN/REGISTER" OnClick="login_button_Click" CssClass="ButtonClass" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'"/>
    </a>
  </div>

  <!-- Navbar on small screens -->
  <div id="navDemo" class="w3-bar-block w3-white w3-hide w3-hide-large w3-hide-medium" style="background-color:black">
    <a href="#about" class="w3-bar-item w3-button" onclick="Button1_Click">PLAYERS</a>
    <a href="#portfolio" class="w3-bar-item w3-button" onclick="toggleFunction()">SCHEDULE</a>
    <a href="#contact" class="w3-bar-item w3-button" onclick="toggleFunction()">TIPS AND TRICKS</a>
    <a href="#contact" class="w3-bar-item w3-button" onclick="toggleFunction()">VIDEOS</a>
  </div>
</div>

<!-- First Parallax Image with Logo Text -->
    <p>
        &nbsp;</p>
        <img alt="" class="auto-style1" src="IMAGES/Sky-Sport-Breakers-Logo-White.png" style="background-image:url(IMAGES/spark-arena.jfif);margin-left:auto;margin-right:auto;width:101%"/>
        <div class="w3-container w3-padding-64 w3-center" id="team">
<h2>OUR TEAM</h2>
<p>Meet the team - our office rats:</p>

 

<div class="w3-row"><br>

 

<div class="w3-third">
  <div class="container">
  <img src="Images\Player Images\BREAKERS_01_TomAbercrombie_1267.png" alt="Tom Abercrombie" class="image" style="width:80%; height: 550px;border:groove 2px cornflowerblue;">
     <div class="overlay">
    <div class="first">Tom </div>
         <div class="last">Abercrombie </div>

 

  </div>

 

</div>
</div>

 

<div class="w3-third">
  <div class="container">
  <img src="Images\Player Images\BREAKERS_02_CoreyWebster_2813.png" alt="Corey Webster" style="width:80%; height: 550px;border:groove 2px cornflowerblue;">
<h2 style="color:black;font-size:xx-large;border:2px solid cornflowerblue;">Corey Webster</h2>
</div>
</div>

 

<div class="w3-third">
  <div class="container">
  <img src="Images\Player Images\BREAKERS_03_FinnDelany_3065.png" alt="Finn Delany" style="width:80%; height: 550px;border:groove 2px black;">
<h2 style="color:black;font-size:xx-large;border:2px solid cornflowerblue;">Finn Delany</h2>
</div>
</div>

 

<div class="w3-third">
  <div class="container">
  <img src="Images\Player Images\BREAKERS_04_TomVodanovich_5271.png" alt="Tom Vodanovich" style="width:80%; height: 550px;border:groove 2px black;">
<h2 style="color:black;font-size:xx-large;border:2px solid cornflowerblue;">Tom Vodanovich</h2>
</div>
</div>

 

    <div class="w3-third">
  <div class="container">
  <img src="Images\Player Images\BREAKERS_05_JordanNgatai_6592.png" alt="Jordan Ngatai" style="width:80%; height: 550px;border:groove 2px black;">
<h2 style="color:black;font-size:xx-large;border:2px solid cornflowerblue;">Jordan Ngatai</h2>
</div>
</div>

 

    <div class="w3-third">
  <div class="container">
  <img src="C:\Users\ac94093\source\repos\WebApplication2\WebApplication2\Images\Player Images\BREAKERS_06_RobLoe_7860.png" alt="Rob Loe" style="width:80%; height: 550px;border:groove 2px black;">
<h2 style="color:black;font-size:xx-large;border:2px solid cornflowerblue;">Rob Loe</h2>
</div>
</div>

 


</div>
</div>

 
</form>
</body>
</html>
