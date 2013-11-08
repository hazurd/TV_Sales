<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="TV_Sales_Page1.ErrorPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        OH OH!</p>
    <p>
        You got an Error :(&nbsp;&nbsp;
    </p>
    <p>
        <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
    </p>
</asp:Content>
