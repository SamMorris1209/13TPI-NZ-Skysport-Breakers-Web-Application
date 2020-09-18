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
body,h1,h2,h4,h5 {font-family: "Lato", sans-serif;}
body, html {
  height: 100%;
  color: #777;
  line-height: 1.8;
}
h3{
    font-family: Bahnschrift;
    font-weight:bold;
    text-align:center; 
    vertical-align:central
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

.big{
         height:100px;
     }
.picture{
         height:700px;
     }



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
          <asp:Button ID="logout_button" runat="server" Text="LOGOUT" OnClick="logout_button_Click" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'"/></a>
    
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
        <div style="background-color:dodgerblue;">
            <h3>#UNBREAKABLE</h3>
            </div>
            <table>
                <tr>
                    <th style=" vertical-align:text-top; text-align:center">
                        <h4>About breakers<h4/>
                    </th>
                </tr>
                <tr>
                    <td style=" vertical-align:text-top;"  >
                        <p style="border: 1px solid dodgerblue;">
                            About breakers text goes here:
                        The New Zealand Breakers are a New Zealand professional
                            basketball team based in Auckland. The Breakers compete
                            in the National Basketball League (NBL) and play their
                            home games at Spark Arena. The team was founded in 2003
                            by three Waikato businessmen, Dallas Fisher, Michael
                            Redman and Keith Ward, and remains the only team in the
                            league to compete from New Zealand. The team was bought
                            by Liz and Paul Blackwell in 2005.[1][2] The couple owned
                            the team until February 2018, when a consortium headed by
                            former NBA player Matt Walsh became the majority shareholders
                            via a newly formed company called Breakers Basketball Ltd.[3]
The Breakers are one of two teams (the other being the now-absent Singapore Slingers) from
                            outside of Australia to have competed in the NBL. In 2011, the
                            Breakers won their first NBL Championship and successfully defended
                            it in 2012 and 2013. They re-claimed the title in 2015 before 
                            finishing as runners-up in 2016.

                        </p>
                        <h4 style=" vertical-align:text-top; text-align:center; text"> Current season overlook: </h4>
                        <p style="border: 1px solid dodgerblue;">
                            For the 2019–20 season, the Breakers acquired the services of
                            coach Dan Shamir, who in-turn recruited seven new players,[71]
                            including US teen sensation R. J. Hampton as part of the NBL Next
                            Stars program.[72] As a result, long-time guard Shea Ili parted
                            ways with the club.[73][74] Along with the departure of Braswell
                            as coach, general manager and long-time Breaker Dillon Boucher
                            left the club, as did assistant coach Michael Fitchett.[75][76]
                            The regular season began with just two wins from their first nine
                            games.[77] The club endured a number of injuries with four starting
                            players (Finn Delany, Rob Loe, Scotty Hopson and Corey Webster) 
                            all having extended time on the sidelines during the first half of
                            the season.[78] The club's attempt to cover for the injuries saw the
                            signing of former NBA player Glen Rice Jr..[79][80] However, Rice
                            was suspended indefinitely by the club after just three games for 
                            off-court misdemeanors.[81][82] Despite the controversy surrounding
                            the club, the Breakers were playing to record home crowds[83] and the
                            24 October encounter against the Illawarra Hawks—which saw Hampton
                            matched-up with LaMelo Ball—was the most-watched game in NBL history
                            with nearly two million views globally on Facebook. There were an 
                            estimated five million views on highlights from the game shared on 
                            social media platforms including Twitter, Instagram and YouTube.[84]
                            The club's playoff hopes looked dashed after first dropping to a 2–8
                            record and later a 4–10 record at the end of round 12. A remarkable 
                            turn around occurred from round 13 onwards with the Breakers reaching
                            8–10 by the end of December following a four-game winning streak,[85]
                            and then winning 11 of their last 14 games to finish the season 15–13,
                            only missing the playoffs on points differential.[86][87] The late-season
                            push saw the Breakers being dubbed "the team no one wants to play in the
                            playoffs".[88]
                        </p>
                       
                    </td>
                    <td style="padding-left:100px;"class="picture">

                            <img src="IMAGES/Tom Abercrombie - Dunk.jpg" style="height:774px; width:1000px; border:solid thin; border-color:dodgerblue;"/>

                        
                    </td>
                </tr>
            </table>

    </form>
    </body>

    </html>