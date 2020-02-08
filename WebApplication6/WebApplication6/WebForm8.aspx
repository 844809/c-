<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication6.WebForm8" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    Trainee ID<br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="showbid" OnClick="showbid"></asp:Button>
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>