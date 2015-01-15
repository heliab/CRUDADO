<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="listbooks.aspx.cs" Inherits="CRUDADO.listbooks" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head4" runat="server">
    <title>List Books</title>
</head>
<body>
    <form id="form4" runat="server">
        <h2>List Of Books</h2>
        <asp:GridView ID="GridView1" runat="server" Width="100%">
            <HeaderStyle BackColor="Red" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
        <br />
        <a href="Menu.aspx">Go Back To Menu</a>
    </form>
</body>
</html>