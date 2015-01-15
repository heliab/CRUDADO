<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deletebook.aspx.cs" Inherits="CRUDADO.deletebook" %>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head2" runat="server">
    <title>Delete Book</title>
</head>
<body>
    <form id="form2" runat="server">
    <h2>Delete Book</h2>
    Enter Book Id : 
    <asp:TextBox ID="txtBookid" runat="server"></asp:TextBox>
    <p />
    <asp:Button ID="btnDelete" runat="server" Text="Delete Book" OnClick="btnDelete_Click"/>
    <p />
    <asp:Label ID="lblMsg" runat="server" EnableViewState="False"></asp:Label>
    <p />
    <a href="Menu.aspx">Go Back To Menu</a>
    </form>
</body>
</html>
