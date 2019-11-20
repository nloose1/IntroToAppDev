<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReceivingPage.aspx.cs" Inherits="WebApp.SamplePages.ReceivingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Receiving data from the sqlquery page</h1>
    <asp:Label ID="Messagelabel" runat="server"></asp:Label>
    <asp:Button ID="Back" runat="server" Text="Back" OnClick="Back_Click" />
</asp:Content>
