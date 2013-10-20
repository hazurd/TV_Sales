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
    <br />
    <br />
    <asp:GridView ID="product_grid" runat="server" AutoGenerateColumns="False">
    <Columns>
          <asp:templatefield headertext="Author Name">
                <ItemTemplate>
                <asp:HyperLink ID="Testing" runat="server"
                NavigateUrl='<%# "~/Product_Description.aspx?img=" + Eval("Name") %>'
                Text='<%# Eval("Name") %>' />
                </ItemTemplate>
          </asp:templatefield>
    </Columns>
    <Columns>
          <asp:templatefield headertext="Image">
                <ItemTemplate>
                <asp:Image ID="Image1" runat="server"
                ImageUrl='<%# Eval("ImageUrl") %>' Height="40px" Width="40px" />
                </ItemTemplate>
          </asp:templatefield>
    </Columns>  
    <Columns>
          <asp:templatefield headertext="Description">
                <ItemTemplate>
                <asp:Label ID="grid_decription" runat="server" Width="300px"
                 Text='<%# DecriptionUrl(Eval("Name").ToString())  %>' />
                </ItemTemplate>
          </asp:templatefield>
    </Columns>  
    <Columns>
        <asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="${0}" />
    </Columns>
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
