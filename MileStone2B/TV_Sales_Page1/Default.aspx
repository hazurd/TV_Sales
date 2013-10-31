<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="TV_Sales_Page1._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to Dave's Television Sales!!
    </h2>
    <p>
        To learn more about my products visit 
        <asp:HyperLink ID="HyperLink1" runat="server" 
            NavigateUrl="~/Select_Product.aspx">Television Choices :).</asp:HyperLink>
    </p>
    <p>
        <asp:Image ID="Image1" runat="server" Height="400px" ImageAlign="Right" 
            ImageUrl="~/Images/homeIMG.jpg" Width="400px" />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/cart.aspx">Cart</asp:HyperLink>
    </p>

</asp:Content>
