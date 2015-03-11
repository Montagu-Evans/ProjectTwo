<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Collection.aspx.cs" Inherits="ProjectTwo.Collection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="Armani">
        <p>&nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Text" HeaderText="Text" SortExpression="Text" />
                <asp:BoundField DataField="UnitPrice" HeaderText="UnitPrice" SortExpression="UnitPrice" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Clocks %>" SelectCommand="SELECT [Text], [UnitPrice] FROM [Articles]"></asp:SqlDataSource>
        <asp:Button ID="ButtonVarukorg" runat="server" OnClick="ButtonVarukorg_Click1" Text="Lägg i varukorgen" />
    </div>
</asp:Content>
