<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SKILLS.aspx.cs" Inherits="_13TPI_NZ_Skysport_Breakers_Web_Application.SKILLS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
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
        <asp:HiddenField ID="hfUserID" runat="server" />
        <asp:Label ID="Userlbl" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="Passlbl" runat="server" Text="" Visible="False"></asp:Label>
        <asp:Label ID="Skilllbl" runat="server" Text="" Visible="False"></asp:Label>
            <div class="w3-top" style="background-color:black">
   <div class="w3-bar" id="myNavbar">
    <a class="w3-bar-item w3-button w3-hover-black w3-hide-medium w3-hide-large w3-right" href="javascript:void(0);" onclick="toggleFunction()" title="Toggle Navigation Menu">
      <i class="fa fa-bars"></i>
    </a>
    <a class="w3-bar-item " onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white">
      <asp:Button ID="Back_Button" runat="server" OnClick="Back_Button_Click" Text="BACK TO TIPS AND TRICKS" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" />
      </a>
        <a class="w3-bar-item w3-hide-small" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" style="color:white"><i></i>
          <asp:Button ID="Home_Button" runat="server" OnClick="Home_Button_Click" Text="HOME" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" /></a>
    
        </div>
                </div>

            <p> l</p>
        <asp:Label ID="testlbl" runat="server" Text="" Visible="false"></asp:Label>
         <asp:Label ID="ProgressValue" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="lblSkillLVL" runat="server" Text="">
    <h3 class="w3-center">Please Choose your skill level</h3>
    <div class="w3-center">      
        <a><asp:Button ID="btnBeginner" runat="server" Text="BEGINNER" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnBeginner_Click" /></a>
        <p>New to Basketball: want to learn the basics </p>
        <asp:Button ID="btnIntermediate" runat="server" Text="INTERMEDIATE" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnIntermediate_Click" />
        <p>Have a decent knowledge but want to learn new skills</p>
        <asp:Button ID="btnAdvanced" runat="server" Text="ADVANCED" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnAdvanced_Click" />
        <p class="w3-center">Already understand the game well but want to refine skills and learn tricks</p>
    </div>
            </asp:Label>
        <asp:Label ID="BeginnerContent" runat="server" Text="">
            <div class="w3-center">
                <p>Here is your progress- watch videos and complete tasks to gain points! work your way up to the next stage!</p>
            <asp:Label ID="lblProgress" runat="server" Text="/100" Font-Size="Large"></asp:Label>
                </div>
            <div class="w3-quarter">
                <p class="w3-center">Learn to dribble! -- Click this button to try a dribbling task:</p>
                <p class="w3-center"><asp:Button ID="btnBeginnerDribble" runat="server" Text="TASK" BackColor="Black" BorderStyle="None" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnBeginnerDribble_Click"/></p>
                <p class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/CMQp0bwjokw" frameborder="0" allowfullscreen></iframe></p>
            </div>
            <div class="w3-quarter">
                <p>aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</p>
                 <iframe height="270" width="420" src="https://www.youtube.com/embed/CMQp0bwjokw" frameborder="0" allowfullscreen></iframe>
            </div>
            </asp:Label>
        <asp:Label ID="IntermediateContent" runat="server" Text="" Visible ="false">
            hi<asp:Button ID="btnIntertask" runat="server" Text="TASK" OnClick="btnIntertask_Click"/><asp:Label ID="IlblProgress" runat="server" Text=""></asp:Label>
        </asp:Label>
        <asp:Label ID="AdvancedContent" runat="server" Text="" Visible ="false">
            hiye
        </asp:Label>
    </form>
</body>
</html>
