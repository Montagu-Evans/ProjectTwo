<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="ProjectTwo.Checkout" %>
<%@ Import Namespace="System.Globalization" %>
<%@ Import Namespace="System.Web.Configuration" %>
<%@ Import Namespace="DAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 43%;
            height: 12px;
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

    h2 {
        font-size: 20px;    
    }
    .auto-style2 {
        border: black solid 1px;  
    }

        .auto-style9 {
            width: 95px;
            height: 28px;
        }
        .auto-style10 {
            border: black solid 1px;
            width: 95px;
        }
        .auto-style11 {
            width: 107px;
        }
        .auto-style12 {
            border: black solid 1px;
            width: 107px;
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
                <asp:TextBox ID="TextBoxZip" runat="server" AutoCompleteType="HomeZipCode"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxZip" ErrorMessage="Skriv in postkod" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBoxZip" Display="Dynamic" ErrorMessage="Enbart siffror och mellanslag" ForeColor="Red" ValidationExpression="^[0-9]{5}$">*</asp:RegularExpressionValidator>
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
            <td class="auto-style4">&nbsp;<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" CssClass="clean-list" />
                <asp:Button ID="ButtonOrder" runat="server" Text="Beställ order" OnClick="ButtonOrder_Click" />
            </td>
        </tr>
        </table>
    
    <h2>Din orderspecifikation</h2>
    <table class="auto-style1">
        <tr class="auto-style2">
            <td><strong>Produkt</strong> </td> 
        <td class="auto-style11"><strong>Pris</strong></td>
        <td class="auto-style9"><strong>Antal</strong> </td>
        </tr>
        <% decimal sum = 0; %>
        <% foreach (var orderRow in ((Order) Session["order"]).OrderRows)
           {
               sum += orderRow.Sum;
        %>
        <tr>
            <td class="auto-style2">
                <%: orderRow.ProductName %>
            </td>
            <td class="auto-style12">
                <%: orderRow.ProductPrice + ":-" %>
            </td>
            <td class="auto-style10">
                <%: orderRow.Quantity %>
            </td>
        </tr>
        <% }%>
        <tr>
            <td class="auto-style2"><strong>Summa: <%:sum.ToString("C0") %></strong></td>
        </tr>
        
        
    </table>
    
</asp:Content>
