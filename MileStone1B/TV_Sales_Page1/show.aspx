<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="TV_Sales_Page1.show" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="Tv_Grid" runat="server" OnSelectedIndexChanged="Tv_Grid_SelectedIndexChanged">
    </asp:GridView>
</asp:Content>


