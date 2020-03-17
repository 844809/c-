<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm17.aspx.cs" Inherits="crudtask.WebForm17" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /> 
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>