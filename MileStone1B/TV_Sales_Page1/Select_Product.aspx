<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Select_Product.aspx.cs" Inherits="TV_Sales_Page1.Select_Product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <br />
Here are the products we are currently offering:<br />
<br />
<asp:DropDownList ID="ddlTvChoice" runat="server" 
    onselectedindexchanged="DropDownList1_SelectedIndexChanged" Width="140px">
</asp:DropDownList>
&nbsp;&nbsp;&nbsp;
<asp:Button ID="btn_go" runat="server" onclick="btn_go_Click" Text="Go!!" 
    Width="70px" />
</asp:Content>
