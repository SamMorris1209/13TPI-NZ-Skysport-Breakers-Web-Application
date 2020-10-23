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
        <asp:Label ID="Video1Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Video2Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Video3Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Video4Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Video5Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Video6Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Video7Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Video8Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Video9Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="RulesCheck" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="ThreePointersCheck" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Task1Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Task2Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Task3Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="Task4Check" runat="server" Text="" Visible ="false"></asp:Label>
        <asp:Label ID="UserIDlbl" runat="server" Text="" Visible="false"></asp:Label>
         <asp:Label ID="ProgressValue" runat="server" Text="" Visible="false"></asp:Label>
        <asp:Label ID="lblLevel" runat="server" Text="" Visible="false"></asp:Label>
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
                <br/>
                Beginner Section:
                </div>
            <div class="w3-quarter">
                <p class="w3-center"><asp:Label ID="txtBeginnerDribble" runat="server" Text="Beginner's guide to dribbling- Once you have finished watching the video, click the button and watch your progression! Note: once the button has been used, it cannot be used again!"></asp:Label></p>
                <p class="w3-center"><asp:Button ID="btnBeginnerDribble" runat="server" Text="+20 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnBeginnerDribble_Click"/></p>
                <p class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/CMQp0bwjokw" frameborder="0" allowfullscreen></iframe></p>
            </div>
            <div class="w3-quarter">
                <p class="w3-center"><asp:Label ID="txtBeginnerPassing" runat="server" Text="Beginner's guide to passing- Once you have finished watching the video, click the button and watch your progression! Note: once the button has been used, it cannot be used again!"></asp:Label></p>
                <p class="w3-center"><asp:Button ID="btnBeginnerPassing" runat="server" Text="+20 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnBeginnerPassing_Click"/></p>
                <p class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/PukmYnApL2Y" frameborder="0" allowfullscreen></iframe></p>
            </div>
            <div class="w3-quarter">
                <p class="w3-center"><asp:Label ID="txtBeginnerShooting" runat="server" Text="Beginner's guide to shooting- Once you have finished watching the video, click the button and watch your progression! Note: once the button has been used, it cannot be used again!"></asp:Label></p>
                <p class="w3-center"><asp:Button ID="btnBeginnerShooting" runat="server" Text="+20 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnBeginnerShooting_Click"/></p>
                <p class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/BloEnNbz4qk" frameborder="0" allowfullscreen></iframe></p>
            </div>
            <div class="w3-quarter">
                <p class="w3-center"><asp:Label ID="txtRules" runat="server" Text="To learn to play basketball, It is also very important that you learn the rules of the game. Consider reading the rules available below to get some understanding of the game!"></asp:Label></p>
                <p class="w3-center"><asp:Button ID="btnRules" runat="server" Text="+40 Progress"  BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnRules_Click"/></p>
                <iframe height="270" width="420" src="https://www.youtube.com/embed/oyjYgmsM00Q" frameborder="0" allowfullscreen></iframe>
            </div>
            </asp:Label>
        <asp:Label ID="IntermediateContent" runat="server" Text="">           
            <div>
                .
            </div>
            <div class="w3-center">Intermediate Section:</div>
            <div class="w3-quarter">
                <div class="w3-center"><asp:Label ID="txtIntermediatePositioning" runat="server" Text="Positioning"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnIntermediatePositioning" runat="server" Text="+30 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnIntermediatePositioning_Click"/></div>
                <div class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/4_4CymXARWQ" frameborder="0" allowfullscreen></h></iframe></div>
            </div>
            <div class="w3-quarter">
                <div class="w3-center"><asp:Label ID="txtIntermediateTricks" runat="server" Text="Tricks"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnIntermediateTricks" runat="server" Text="+20 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnIntermediateTricks_Click"/></div>
                <div class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/Qszm4R4_DJ8" frameborder="0" allowfullscreen></h></iframe></div>
            </div>
            <div class="w3-quarter">
                <div class="w3-center"><asp:Label ID="txtIntermediateHandling" runat="server" Text="Handling"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnIntermediateHandlng" runat="server" Text="+30 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnIntermediateHandling_Click"/></div>
                <div class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/kw4D9iM8cDs" frameborder="0" allowfullscreen></h></iframe></div>
            </div>
            <div class="w3-quarter">
                <div class="w3-center"><asp:Label ID="txt3Pointers" runat="server" Text="3 Pointers"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btn3Pointers" runat="server" Text="+20 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btn3Pointers_Click"/></div>
                <div class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/XfcI36XgeLE" frameborder="0" allowfullscreen></h></iframe></div>
            </div>
        </asp:Label>
        <asp:Label ID="AdvancedContent" runat="server" Text="">
            <div class="w3-center">
                Advanced Section:
            </div>
            <div class="w3-third">
                 <div class="w3-center"><asp:Label ID="txtDunking" runat="server" Text="Dunking"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnDunking" runat="server" Text="+40 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnDunking_Click"/></div>
                <div class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/KqTq2bl1XqE" frameborder="0" allowfullscreen></h></iframe></div>
            </div>
            <div class="w3-third">
                 <div class="w3-center"><asp:Label ID="txtADribbling" runat="server" Text="Advanced Dribbling"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnADribbling" runat="server" Text="+40 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnADribbling_Click"/></div>
                <div class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/bnjed9YVCRs" frameborder="0" allowfullscreen></iframe></div>
            </div>
            <div class="w3-third">
                 <div class="w3-center"><asp:Label ID="txtAPositioning" runat="server" Text="Advanced Shooting"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnAPositioning" runat="server" Text="+40 Progress" BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnAPositioning_Click"/></div>
                <div class="w3-center"><iframe height="270" width="420" src="https://www.youtube.com/embed/nuiPr66rCcw" frameborder="0" allowfullscreen></iframe></div>
            </div>
            <div class="w3-third">
                <div class="w3-center"><asp:Label ID="txtThreePointerP" runat="server" Text="Practice your 3-Pointers! Try to score 10 out of 20 attempted shots. Once done, click the button below for a reward!"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnThreePointerP" runat="server" Text="+20 Progress"  BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnThreePointerP_Click"/></div>
            </div>
            <div class="w3-third">
                 <div class="w3-center"><asp:Label ID="txtAPassing" runat="server" Text="Practice your Passing! Try catching fast-paced passes- go for 60 seconds and try catch at least 90% of all balls thrown. Once done, click the button below for a reward!"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnAPassing" runat="server" Text="+20 Progress"  BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnAPassing_Click"/></div>
            
            </div>
            <div class="w3-third">
                 <div class="w3-center"><asp:Label ID="txtBlocking" runat="server" Text="Practice your Blocking! Block incoming shots into the hoop from another player until you can block at least 20% of shots taken. Once done, click the button below for a reward!"></asp:Label></div>
                <div class="w3-center"><asp:Button ID="btnBlocking" runat="server" Text="+20 Progress"  BackColor="Black" BorderStyle="Solid" ForeColor="White" onmouseover="this.style.backgroundColor='#0085bd'" onmouseout="this.style.backgroundColor='Black'" Font-Size="Larger" OnClick="btnBlocking_Click"/></div>
            
            </div>
            
        </asp:Label>
    </form>
</body>
</html>
