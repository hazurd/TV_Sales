<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TV_Choice.aspx.cs" Inherits="TV_Sales_Page1.TV_Choice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    Pick a Television Brand:
    <asp:DropDownList ID="ddlTvChoice" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ddlTvChoice_SelectedIndexChanged">
    </asp:DropDownList>
    <p>
        <asp:Image ID="imgTV" runat="server" BorderStyle="Dotted" Height="300px" 
            Width="420px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Image ID="imgOutOfStock" runat="server" ImageUrl="~/Images/OutofStock.jpg" 
            Visible="False" />
    </p>
    <asp:TextBox ID="txtCheck" runat="server"></asp:TextBox>
    <asp:Button ID="btnOrder" runat="server" onclick="btnOrder_Click" 
        Text="Button" />
&nbsp;&nbsp;
    <asp:Label ID="lblStock" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
