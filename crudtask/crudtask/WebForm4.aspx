<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="crudtask.WebForm4" %>

<asp:Content ID="id1213" ContentPlaceHolderID="MainContent" runat="server">
    student Id<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
Student Name<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="submit" OnClick="Button1_Click" />
</asp:Content>
