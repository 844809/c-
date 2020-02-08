<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tejaform.aspx.cs" Inherits="WebApplication4.teja" %>

<asp:Content ID="id124" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Enter name"></asp:Label>
        <br  />
        <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Enter Dob"></asp:Label>
        <br/>
        <asp:Calendar ID="Calender1" runat="server"></asp:Calendar>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Enter Gender"></asp:Label>
        <br  />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="183px">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>male</asp:ListItem>
        </asp:RadioButtonList>
        <br/>
        <asp:Label ID="Label4" runat="server" Text="Tick mark Hobbies"></asp:Label>
        <br/>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Reading books</asp:ListItem>
            <asp:ListItem>playing</asp:ListItem>
            <asp:ListItem>singing</asp:ListItem>
        </asp:CheckBoxList>
        <br/>
        <asp:Label ID="label15" runat="server" Text="Education"></asp:Label>
         <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
             <asp:ListItem>High school</asp:ListItem>
             <asp:ListItem>intermediate</asp:ListItem>
             <asp:ListItem>btech</asp:ListItem>
        </asp:DropDownList>
        <br  />
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Submit_Click" />


    </div>
    <div class="jumbotron">

    </div>
</asp:Content>