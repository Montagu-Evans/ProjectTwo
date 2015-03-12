<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Collection.aspx.cs" Inherits="ProjectTwo.Collection" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="Armani">
        <p>&nbsp;</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
   BorderColor="#336699" BorderStyle="Solid" BorderWidth="2px"
   CellPadding="4"
   DataSourceID="SqlDataSource2" ForeColor="#333333" Width="971px" OnRowCommand="GridView1_RowCommand">
                
   <Columns>

      <asp:BoundField DataField="Text"  HeaderText="Produkt"
         SortExpression="Text" />

       <asp:BoundField DataField="UnitPrice" HeaderText="Pris" SortExpression="UnitPrice" />
                        
       <asp:TemplateField>
           <ItemTemplate>
               <asp:LinkButton runat="server" Text="add"></asp:LinkButton>
           </ItemTemplate>
       </asp:TemplateField>
                        

   </Columns>
               
</asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Clocks %>" SelectCommand="SELECT [Text], [UnitPrice] FROM [Articles]"></asp:SqlDataSource>
    </div>
</asp:Content>
