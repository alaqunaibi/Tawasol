<%@ Page language="c#" Inherits="TawasolWeb.WebForm1" CodeFile="WebForm1.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<script language="javascript" type="text/javascript">
			
			var oInterval ='';
			var y=0;
			
			function TimeOut()
			{
					//oInterval=window.setInterval(GetHandleStatus,2000,'JavaScript');
					document.getElementById("lnkBtnRefresh").click; 
			}
			
			function GetHandleStatus()
			{
				
				document.getElementById("txtHandleStatus").value=y++;
				var t;
				t=document.getElementById("txtClientId").value;
				if (t.length>0)
				{ 
					
					document.getElementById("lnkBtnRefresh").click();
					//document.getElementById("btnGetHandleStatus").click();
					window.clearInterval(oInterval);
				}
				
				
//				if (document.getElementById("txtHandleStatus").value==1)
//				{
					//window.clearInterval(oInterval); 
//				}
				  
			}
			
		</script>
	</HEAD>
	<body bgColor="#ffe1a2">
		<form id="Form1" method="post" runat="server">
			<table width="35%" border="0">
				<tr>
					<td><asp:label id="lblClientName" runat="server" Height="16px" Width="136px" BorderStyle="None"
							Font-Bold="True" ForeColor="OrangeRed" BorderColor="Transparent" BackColor="Transparent">Your Name</asp:label></td>
					<td><asp:textbox id="txtClientName" runat="server" BorderColor="#FFE1A2" BackColor="Bisque"></asp:textbox></td>
				</tr>
				<tr>
					<td><asp:label id="lblMobile" runat="server" Height="24px" Width="136px" BorderStyle="None" Font-Bold="True"
							ForeColor="OrangeRed" BorderColor="Transparent" BackColor="Transparent">Your Mobile</asp:label></td>
					<td><asp:textbox id="txtMobile" runat="server" BorderColor="#FFE1A2" BackColor="Bisque"></asp:textbox></td>
				</tr>
				<tr>
					<td style="HEIGHT: 25px"><asp:label id="lblEmail" runat="server" Height="24px" Width="136px" BorderStyle="None" Font-Bold="True"
							ForeColor="OrangeRed" BorderColor="Transparent" BackColor="Transparent">Your Email</asp:label></td>
					<td style="HEIGHT: 25px"><asp:textbox id="txtEmail" runat="server" BorderColor="#FFE1A2" BackColor="Bisque"></asp:textbox></td>
				</tr>
				<tr>
					<td><asp:button id="btnConnect" runat="server" Height="32px" Width="88px" BorderStyle="Ridge" Font-Bold="True"
							ForeColor="OrangeRed" BorderColor="DarkGoldenrod" BackColor="Moccasin" Text="Connect" onclick="btnConnect_Click"></asp:button></td>
					<td>&nbsp;
					</td>
				</tr>
			</table>
			<table id="TableMessage">
				<tr>
					<td><asp:textbox id="txtRecievedMessages" runat="server" Height="200px" Width="408px" BorderColor="#FFE1A2"
							BackColor="Bisque" TextMode="MultiLine"></asp:textbox></td>
				</tr>
				<tr>
					<td><asp:textbox id="txtSendMessage" runat="server" Height="74px" Width="400px" BorderColor="#FFE1A2"
							BackColor="Bisque" TextMode="MultiLine"></asp:textbox></td>
				</tr>
				<tr>
					<td><asp:button id="Button1" runat="server" Height="32px" Width="88px" BorderStyle="Ridge" Font-Bold="True"
							ForeColor="OrangeRed" BorderColor="DarkGoldenrod" BackColor="Moccasin" Text="Send" onclick="Button1_Click"></asp:button></td>
				</tr>
				<tr>
					<td><asp:linkbutton id="lnkBtnRefresh" runat="server" onclick="lnkBtnRefresh_Click">Refresh</asp:linkbutton><asp:textbox id="txtIPAddress" runat="server" Width="120px"></asp:textbox><asp:textbox id="txtClientId" runat="server" Width="120px" BackColor="#ece9d8"></asp:textbox><asp:textbox id="txtHandleStatus" runat="server" Width="120px" BackColor="#ece9d8"></asp:textbox><asp:button id="btnGetHandleStatus" runat="server" Text="Button" onclick="btnGetHandleStatus_Click"></asp:button></td>
				</tr>
			</table>
		</form>
		</TBODY></TABLE>
	</body>
</HTML>
