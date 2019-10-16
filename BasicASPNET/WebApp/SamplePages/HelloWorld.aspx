<%@ Page Title="Hello World" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HelloWorld.aspx.cs" Inherits="WebApp.SamplePages.HelloWorld" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Hello World</h1>
    <asp:Label ID="HelloString" runat="server" Text="Welcome to the fantastic world of Asp.Net web form pages"></asp:Label>&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Press me" OnClick="Button1_Click" />
</asp:Content>
