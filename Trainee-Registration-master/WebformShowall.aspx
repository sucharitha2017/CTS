<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebformShowall.aspx.cs" Inherits="TraineeApp.WebformShowall" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <div class ="jumbotron">
        
        <asp:Button ID="Button2nd" runat="server" Text="Show" OnClick="Buttonsh" />

    
     
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>
