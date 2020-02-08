<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication6.WebForm7" %>

<asp:Content ID="id124" ContentPlaceHolderID="MainContent" runat="server">
    Trainee ID<br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    Trainee name<br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="update" OnClick="update" />
</asp:Content>