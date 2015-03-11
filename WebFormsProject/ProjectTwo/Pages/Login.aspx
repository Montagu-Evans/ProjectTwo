<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjectTwo.Login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="../Styling/Login.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 60%;
        }
        .auto-style2 {
            width: 114px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        
        <p>
            &nbsp;</p>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
        
        <asp:Label ID="Label1" runat="server" Text="Username: "></asp:Label>
                </td>
                <td>
        <asp:TextBox ID="TextBoxUserName" runat="server" Height="16px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUserName" ErrorMessage="Enter correct username!" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
                </td>
                <td>
            <asp:TextBox ID="TextBoxPassword" runat="server" Height="16px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Enter correct password!" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="margin-left: 80px">&nbsp; </td>
                <td>
        <asp:Button ID="ButtonLogIn" runat="server" OnClick="ButtonLogIn_Click" Text="Log in" BorderStyle="Solid" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="margin-left: 80px">&nbsp;</td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2" style="margin-left: 80px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            <asp:Label ID="LabelLoginMessage" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
