<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebIntro.aspx.cs" Inherits="WebIntro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="#ffe1a2">
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" />
        <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <table width="35%" border="0">
                    <tr>
                        <td>
                            <asp:Label ID="lblClientName" runat="server" Height="16px" Width="136px" BorderStyle="None"
                                Font-Bold="True" ForeColor="OrangeRed" BorderColor="Transparent" BackColor="Transparent">Your Name</asp:Label></td>
                        <td style="width: 158px">
                            <asp:TextBox ID="txtClientName" runat="server" BorderColor="#FFE1A2" BackColor="Bisque"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblMobile" runat="server" Height="24px" Width="136px" BorderStyle="None"
                                Font-Bold="True" ForeColor="OrangeRed" BorderColor="Transparent" BackColor="Transparent">Your Mobile</asp:Label></td>
                        <td style="width: 158px">
                            <asp:TextBox ID="txtMobile" runat="server" BorderColor="#FFE1A2" BackColor="Bisque"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="height: 25px">
                            <asp:Label ID="lblEmail" runat="server" Height="24px" Width="136px" BorderStyle="None"
                                Font-Bold="True" ForeColor="OrangeRed" BorderColor="Transparent" BackColor="Transparent">Your Email</asp:Label></td>
                        <td style="height: 25px; width: 158px;">
                            <asp:TextBox ID="txtEmail" runat="server" BorderColor="#FFE1A2" BackColor="Bisque"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="btnConnect" runat="server" Text="Connect" Height="30px" Width="88px"
                                BorderStyle="Ridge" Font-Bold="True" ForeColor="OrangeRed" BorderColor="DarkGoldenrod"
                                BackColor="Moccasin" OnClick="btnConnect_Click" /></td>
                        <td style="width: 158px">
                            &nbsp;
                            <asp:Timer ID="Timer1" runat="server" OnTick="Timer1_Tick" Interval="1000" Enabled="False">
                            </asp:Timer>
                            <asp:Label ID="Label1" runat="server" Width="116px"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
          <div id="msglayer" runat="server"  >
            <asp:Timer ID="Timer2" runat="server" OnTick="Refresh" Enabled="False" Interval="1000">
            </asp:Timer>
            <asp:UpdatePanel ID="UpdatePanel_msg" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <table id="TableMessage" width="100%" runat="server" style="display: none">
                        <tr>
                            <td>
                                <asp:Label ID="lblWelComeLetter" runat="server" Width="546px" Font-Bold="True" ForeColor="#006600"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 466px; height: 158px;">
                                <asp:TextBox ID="txtRecieveMessages" runat="server" Height="122px" TextMode="MultiLine"
                                    Width="420px"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Timer2" EventName="Tick" />
                </Triggers>
            </asp:UpdatePanel>
            <asp:UpdatePanel ID="UpdatePanel_SendTools" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <table id="SendMsgTxt" runat="server" style ="display:none">
                        <tr>
                            <td >
                                <asp:TextBox ID="txtSendMessage" runat="server" Height="39px" TextMode="MultiLine"
                                    Width="422px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td  >
                                <asp:Button ID="btnSend" runat="server" Height="32px" Width="88px" BorderStyle="Ridge"
                                    Font-Bold="True" ForeColor="OrangeRed" BorderColor="DarkGoldenrod" BackColor="Moccasin"
                                    Text="Send" OnClick="btnSend_Click"></asp:Button></td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
           </div> 
           
            <asp:UpdatePanel ID="UpdatePanel_hdn" runat="server">
                <ContentTemplate>
                    <table id="txtVariables_Ipaddress" style="display: none">
                        <tr>
                            <td>
                                <div style="width: 492px; height: 27px">
                                    <asp:TextBox ID="txtIPAddress" runat="server" Width="120px"></asp:TextBox><asp:TextBox
                                        ID="txtClientId" runat="server" Width="120px" BackColor="#ece9d8"></asp:TextBox><asp:Button
                                            ID="btnGetHandleStatus" runat="server" OnClick="btnGetHandleStatus_Click" Text="Button" /><asp:TextBox
                                                ID="txtHandleStatus" runat="server" Width="120px" BackColor="#ece9d8"></asp:TextBox></div>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="22px" ImageUrl="~/Images/Stoplight_Single0.gif"
            OnClick="ImageButton1_Click" Width="23px" />
        
    </form>
</body>
</html>
