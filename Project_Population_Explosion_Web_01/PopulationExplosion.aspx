<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PopulationExplosion.aspx.cs" Inherits="Project_Population_Explosion_Web_01.PopulationExplosion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Population Explosion</h1>

    <h2>Please enter the desired maximum population ceiling!!!</h2>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <hr />

    <asp:Label ID="Label1" runat="server" Text="Results : "></asp:Label>

    <hr />

    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    
</asp:Content>
