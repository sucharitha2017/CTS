<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Webform.aspx.cs" Inherits="TraineeApp.Webform" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Label">id</asp:Label>
    <br />
        <asp:TextBox ID="tidp" runat="server"></asp:TextBox>
    <br />
        <asp:Button ID="Button4th" runat="server" Text="ShowPar" OnClick="Buttonsp" />
    <br />
        <asp:GridView ID="GridView2" runat="server"></asp:GridView>

        
</div>

</asp:Content>
    