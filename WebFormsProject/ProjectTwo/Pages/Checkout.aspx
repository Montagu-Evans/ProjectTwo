<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="ProjectTwo.Kassorskan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 85%;
            height: 490px;
        }
        .auto-style3 {
            width: 137px;
            height: 28px;
        }
        .auto-style4 {
            height: 28px;
        }
    .auto-style7 {
        width: 137px;
        height: 30px;
    }
    .auto-style8 {
        height: 30px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style7">Adress:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBoxAddress" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Postkod:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBoxZip" runat="server" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Postort:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="ButtonOrder" runat="server" Text="Beställ order" OnClick="ButtonOrder_Click" />
            </td>
            <td class="auto-style4">&nbsp;</td>
        </tr>
        </table>
</asp:Content>
