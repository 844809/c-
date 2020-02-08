<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebAppdataoperations.WebForm2" %>

<asp:Content ID="cont1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" Text="resname" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" Text="resloc" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" Text="opentime" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:Label ID="Label4" Text="closetime" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Label ID="Label5" Text="ID" runat="server"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" OnClick="Button-Click" runat="server" Text="insert" Height="47px" Width="115px"  />   
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
      

     
        
    </div>
</asp:Content>