<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjectTwo.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="Armani">
        &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
   BorderColor="White" BorderStyle="Solid" BorderWidth="20px"
   CellPadding="4"
   DataSourceID="SqlDataSource2" ForeColor="#333333" Width="926px" OnRowCommand="GridView1_RowCommand" Height="344px" style="margin-left: 26px; margin-top: 0px">
                
   <Columns>
       <asp:TemplateField>
           <ItemTemplate>
               <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Watches/rolexNEW.jpg" Width="140px" />
           </ItemTemplate>
       </asp:TemplateField>
      <asp:BoundField DataField="Text"  HeaderText="Produkt"
         SortExpression="Text" />

       <asp:BoundField DataField="UnitPrice" HeaderText="Pris" SortExpression="UnitPrice" />
                        
       <asp:TemplateField>
           <ItemTemplate>
               <asp:LinkButton runat="server" Text="Lägg till"></asp:LinkButton>
           </ItemTemplate>
       </asp:TemplateField>
                        

       
                        

   </Columns>
               
</asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:Clocks %>" SelectCommand="SELECT [Text], [UnitPrice] FROM [Articles]"></asp:SqlDataSource>
    </div>
</asp:Content>
