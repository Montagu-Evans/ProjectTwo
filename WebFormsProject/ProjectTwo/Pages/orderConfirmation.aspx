<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="OrderConfirmation.aspx.cs" Inherits="ProjectTwo.Pages.OrderConfirmation" %>

<%@ Import Namespace="DAL" %>
<%@ Import Namespace="ProjectTwo.Pages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><strong>Tack för din beställning,
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>!</strong></h1>
    <div id="">
        <h3>Din order behandlas på vårt lager och kommer att skickas till dig inom kort!</h3>
    </div>

    <h4>Du har väl inte missat att vi erbjuder kostnadsfritt byte? Mer info hittar du på vår hemsida. Som du är på just nu. Eh..</h4>
    <h4><strong>Och kom ihåg - hos oss på
        <asp:HyperLink runat="server" NavigateUrl="Default.aspx">Global Watches</asp:HyperLink>
        hittar du våra senaste nyheter!</strong></h4>
    <h4><strong>Vänligen kontakta alltid vår
        <asp:HyperLink runat="server" NavigateUrl="Login.aspx">kundtjänst</asp:HyperLink>
        vid felexpedition eller reklamation så att vi kan göra vårt yttersta för att hjälpa dig och se till att problemet uppstår igen!</strong></h4>

</asp:Content>
