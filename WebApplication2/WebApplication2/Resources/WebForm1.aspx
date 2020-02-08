<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotran">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br  />
        <br  />
        <asp:Button ID="Button1" runat="server" Text="Button1" />
       
        <br  />
        <br  />
        <asp:DataList ID="DataList1" runat="server" RepeatColumns="2">
            <ItemTemplate>
                <asp:Image ID="Image1"
                    ImageUrl='<%# Eval("Name", "~/Resources/{0}")%>'
                    width="350px" Height="350px" runat="server" />
                <br  />
                <%# Eval("Name") %>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>