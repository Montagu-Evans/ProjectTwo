<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="ProjectTwo.Kassorskan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 85%;
           
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
                <asp:TextBox ID="TextBoxAddress" runat="server" style="margin-bottom: 0px" AutoCompleteType="HomeStreetAddress"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Skriv in adress" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Postkod:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBoxZip" runat="server" TextMode="Number" AutoCompleteType="HomeZipCode"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxZip" ErrorMessage="Skriv in postkod" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">Postort:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBoxCity" runat="server" AutoCompleteType="HomeCity"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxCity" ErrorMessage="Skriv in postort " ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">
                &nbsp;</td>
            <td class="auto-style4">&nbsp;<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                <asp:Button ID="ButtonOrder" runat="server" Text="Beställ order" OnClick="ButtonOrder_Click" />
            </td>
        </tr>
        </table>
</asp:Content>
