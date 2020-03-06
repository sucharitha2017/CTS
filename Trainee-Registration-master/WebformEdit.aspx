<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebformEdit.aspx.cs" Inherits="TraineeApp.WebformEdit" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Label">id</asp:Label>
    <br />
        <asp:TextBox ID="tidu" runat="server"></asp:TextBox>
    <br />
        <asp:Label ID="Label2" runat="server" Text="Label">techdomain</asp:Label>
    <br />
        <asp:TextBox ID="nameu" runat="server"></asp:TextBox>
    <br />
        <asp:Button ID="Button3rd" runat="server" Text="Update" OnClick="Buttonupd1" />
    <br />
        <asp:Label ID="temp" runat="server" Text=" "></asp:Label>
        
</div>

</asp:Content>
    
