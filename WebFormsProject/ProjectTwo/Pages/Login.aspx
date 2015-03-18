<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectTwo.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="../Styling/Login.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 96%;
            height: 196px;
        }
        .auto-style4 {
        }
        .auto-style7 {
            height: 12px;
        }
        .auto-style8 {
            width: 419px;
            height: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="loginWrap">
        <p>
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
        
        <asp:Label ID="Label1" runat="server" Text="Användarnamn: " Font-Names="Comic Sans MS" Font-Underline="True" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style8">
        <asp:TextBox ID="TextBoxUserName" runat="server" Height="16px" Font-Names="Comic Sans MS" BorderStyle="Inset"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUserName" ErrorMessage="Skriv in användarnamn" ForeColor="Red" ValidateRequestMode="Enabled">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
            <asp:Label ID="Label2" runat="server" Text="Lösenord: " Font-Bold="False" Font-Names="Comic Sans MS" Font-Underline="True" ForeColor="White"></asp:Label>
                </td>
                <td class="auto-style8">
            <asp:TextBox ID="TextBoxPassword" runat="server" Height="16px" TextMode="Password" Font-Names="Comic Sans MS" BorderStyle="Inset"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ForeColor="Red" ErrorMessage="Skriv in lösenord">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="margin-left: 80px">&nbsp; </td>
                <td class="auto-style8">
        <asp:Button ID="ButtonLogIn" runat="server" OnClick="ButtonLogIn_Click" Text="Log in" BorderStyle="Solid" Font-Names="Comic Sans MS" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="margin-left: 80px" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="White" Font-Names="Comic Sans MS" Height="43px" style="margin-left: 0px" Width="463px"/>
                </td>
            </tr>
            <tr>
                <td class="auto-style4" style="margin-left: 80px" colspan="2">
            <asp:Label ID="LabelLoginMessage" runat="server" ForeColor="White" Font-Names="Comic Sans MS"></asp:Label>
                    </td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            &nbsp;</p>
        </div>    
    </form>
</body>
</html>
