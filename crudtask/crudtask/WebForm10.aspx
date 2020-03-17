<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="crudtask.WebForm10" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    Faculty Id<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
Faculty Name<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
</asp:Content>