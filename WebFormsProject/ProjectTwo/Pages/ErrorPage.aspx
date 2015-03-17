<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="ProjectTwo.ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Global Watches</title>
    <style type="text/css">
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="content">
    <h1><strong>Just nu har vi svåra problem. Kolla in Kudvenkat nedan, han har bättre koll än vi har!
        </strong></h1>
        <p>
            <asp:Image ID="Image1" runat="server" />
        </p>
    </div>
        
        <div id="video">
            <iframe src="https://www.youtube.com/embed/SXmVym6L8dw?list=PLAC325451207E3105" frameborder="0" allowfullscreen style="width: 1295px; height: 466px"></iframe>
        </div>
    </form>
    </body>
</html>
