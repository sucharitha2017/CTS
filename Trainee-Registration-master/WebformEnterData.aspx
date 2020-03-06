<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="WebformEnterData.aspx.cs" Inherits="TraineeApp.WebformEnterData" %>

<asp:Content ContentPlaceHolderID ="MainContent" runat="server">
    <div class="jumbotron">
        <asp:RequiredFieldValidator ID ="TextBox" runat="server" ControlToValidate="tid" ErrorMessage="Must Enter ID" ForeColor="#FF3300" Text="ID"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="tid" runat="server"></asp:TextBox>
        <br />
        <asp:RequiredFieldValidator ID="tname" runat="server" ControlToValidate="name" ErrorMessage="Must Enter Name" ForeColor="#FF3300" Text="Name"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="name" runat="server" ForeColor="#FF3300"></asp:TextBox>
        <br />
        <asp:Label ID="location" runat="server" Text="Location"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Selected="True">Hyderabad</asp:ListItem>
            <asp:ListItem>Chennai</asp:ListItem>
            <asp:ListItem>Bangalore</asp:ListItem>
            <asp:ListItem>Mumbai</asp:ListItem>
            <asp:ListItem>Kolkata</asp:ListItem>
            <asp:ListItem>Delhi</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="techdomain" runat="server" Text="Techmonain"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>Java</asp:ListItem>
            <asp:ListItem>.Net</asp:ListItem>
            <asp:ListItem>C</asp:ListItem>
            <asp:ListItem>c++</asp:ListItem>
            <asp:ListItem>Selenium</asp:ListItem>
            <asp:ListItem>Data Ware House</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="startdate" runat="server" Text="Date"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="button1st" runat="server" Text="Insert" OnClick="ButtonIns" />
        <br />
        <asp:Label ID="val" runat="server" Text=" "></asp:Label>
    </div>
</asp:Content>