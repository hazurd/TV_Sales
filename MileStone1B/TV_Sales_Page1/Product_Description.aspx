<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product_Description.aspx.cs" Inherits="TV_Sales_Page1.Product_Description" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Image ID="img_tv" runat="server" Height="300px" Width="420px" />
   &nbsp;
   <asp:HyperLink ID="HyperLink1" runat="server" 
        NavigateUrl="~/Select_Product.aspx">Back</asp:HyperLink>
&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/cart.aspx">Cart</asp:HyperLink>
&nbsp;
    <br />
&nbsp;&nbsp;
    <asp:TextBox ID="txtQuantWant" runat="server"></asp:TextBox>
&nbsp;
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Add To Cart!!" />
&nbsp;&nbsp;
    <asp:Label ID="lblHowMuch" runat="server" Text="Label"></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Remove All From Cart" />
<br />
<asp:Label ID="lbl" runat="server" BorderStyle="None" Font-Bold="True" 
    Font-Size="Medium" Text="Description:"></asp:Label>
&nbsp;<asp:Label ID="lbldes" runat="server" Text="Label"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<asp:Label ID="lbl1" runat="server" BorderStyle="None" Font-Bold="True" 
    Font-Size="Medium" Text="Price:"></asp:Label>
&nbsp;<asp:Label ID="lblprice" runat="server" Text="Label"></asp:Label>
<br />
<asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Medium" 
    Text="Quantity:"></asp:Label>
<asp:Label ID="lblquant" runat="server" Text="Label"></asp:Label>
<br />
&nbsp;
</asp:Content>
