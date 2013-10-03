﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cart.aspx.cs" Inherits="TV_Sales_Page1.cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h1>
        Your Cart:</h1>
    <p>
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/Select_Product.aspx">Products</asp:HyperLink>
    </p>
    <asp:BulletedList ID="blList" runat="server">
    </asp:BulletedList>
    <asp:Label ID="Label1" runat="server" Text="SubTotal:"></asp:Label>
    <asp:Label ID="lblSubTot" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="GST:"></asp:Label>
    <asp:Label ID="lblGst" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="PST:"></asp:Label>
    <asp:Label ID="lblPst" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Total:"></asp:Label>
    <asp:Label ID="lblTot" runat="server" Text="Label"></asp:Label>
    <br />
    <br />

</asp:Content>
