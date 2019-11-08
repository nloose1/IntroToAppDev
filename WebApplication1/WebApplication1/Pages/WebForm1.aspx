<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Pages.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Movie Library</h1>
    


    <asp:RequiredFieldValidator ID="RequiredMovieTitle" runat="server" ErrorMessage="Required Movie Title" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="MovieTitle" ></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredYear" runat="server" ErrorMessage="Required Year" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="Year" ></asp:RequiredFieldValidator>
    <asp:RangeValidator ID="RangeValidatorYear" runat="server" ErrorMessage="Must be between 1900 and now (INT)" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="Year" MinimumValue="1900" MaximumValue="2019" Type="Integer"></asp:RangeValidator>


    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger"/>

    <div class="row">
        <div class="col-md-6">
            <fieldset class="form-horizontal">
            <asp:Label ID="Label1" runat="server" Text="Title" AssociatedControlID="MovieTitle"></asp:Label>
            <asp:TextBox ID="MovieTitle" runat="server"></asp:TextBox>

            <asp:Label ID="Label2" runat="server" Text="Year" AssociatedControlID="Year"></asp:Label>
            <asp:TextBox ID="Year" runat="server"></asp:TextBox>

            <asp:Label ID="Label3" runat="server" Text="Media" AssociatedControlID="Medias"></asp:Label>
                <asp:RadioButtonList ID="Medias" runat="server" RepeatDirection="Vertical" RepeatLayout="Flow">
                    <asp:ListItem Value="1">DVD</asp:ListItem>
                    <asp:ListItem Value="2">VHS</asp:ListItem>
                    <asp:ListItem Value="3">File</asp:ListItem>
                </asp:RadioButtonList>
                <asp:Label ID="Message" runat="server" ></asp:Label><br />


            <asp:Label ID="Label4" runat="server" Text="Rating" AssociatedControlID="Rating"></asp:Label>
            <asp:RadioButtonList ID="Rating" runat="server" RepeatDirection="Vertical" RepeatLayout="Flow">
                <asp:ListItem Value="1">General</asp:ListItem>
                <asp:ListItem Value="2">PG</asp:ListItem>
                <asp:ListItem Value="3">14A</asp:ListItem>
                <asp:ListItem Value="4">18A</asp:ListItem>
                <asp:ListItem Value="5">R</asp:ListItem>
            </asp:RadioButtonList>

            <asp:Label ID="Label5" runat="server" Text="Rewiew" AssociatedControlID="Review"></asp:Label>
            <asp:DropDownList ID="Review" runat="server">
                <asp:ListItem Value="1">1 Star</asp:ListItem>
                <asp:ListItem Value="2">2 Star</asp:ListItem>
                <asp:ListItem Value="3">3 Star</asp:ListItem>
                <asp:ListItem Value="4">4 Star</asp:ListItem>
                <asp:ListItem Value="5">5 Star</asp:ListItem>
            </asp:DropDownList>

            <asp:Label ID="Label6" runat="server" Text="ISBN" AssociatedControlID="ISBN"></asp:Label>
            <asp:TextBox ID="ISBN" runat="server"></asp:TextBox>

                </fieldset>
            <div class="row">
                <asp:Button ID="Submit" runat="server" Text="Add" OnClick="Submit_Click" />
            </div>

            <asp:GridView ID="LibraryList" runat="server"></asp:GridView>

        </div>
    </div>
        <script src="../Scripts/bootwrap-freecode.js"></script>
    </asp:Content>
