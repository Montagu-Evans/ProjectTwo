<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Kassorskan.aspx.cs" Inherits="ProjectTwo.Kassorskan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 85%;
            height: 490px;
        }
        .auto-style2 {
            width: 137px;
        }
        .auto-style3 {
            width: 137px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">Adress:</td>
            <td>
                <asp:TextBox ID="TextBoxAdress" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Postkod:</td>
            <td>
                <asp:TextBox ID="TextBoxPostkod" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Postort:</td>
            <td>
                <asp:TextBox ID="TextBoxPostort" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="ButtonOrder" runat="server" Text="Beställ order" />
            </td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2"></td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
