<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication6.WebForm6" %>

<asp:Content ID="id123" ContentPlaceHolderID="MainContent" runat="server">
    Trainee ID<br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
    <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="input doesnt exceed 9" ControlToValidate="TextBox1" ForeColor="Blue" MaximumValue="9" MinimumValue="1" Type="Integer" ValidationGroup="tg"></asp:RangeValidator><br />
    Trainee name<br />
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="please enter name" ControlToValidate="TextBox2" ForeColor="#00CC66" ValidationGroup="tg"></asp:RequiredFieldValidator><br />
    Trainee location<br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="please enter location" ControlToValidate="TextBox3" ForeColor="#FF6699" ValidationGroup="tg"></asp:RequiredFieldValidator><br />
    Trainee Domain<br />
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="please enter valid domain" ControlToValidate="TextBox4" ForeColor="#CC3300" ValidationGroup="tg"></asp:RequiredFieldValidator><br />
    startdate<br />
    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#FF6666" ValidationGroup="tg" />
    <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Insert" ValidationGroup="tg" />

</asp:Content>