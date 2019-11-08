<%@ Page Title="User Reg" Language="C#" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="UserReg.aspx.cs" Inherits="WebApplication1.Pages.UserReg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>User Registration</h1>
    <div class="alert alert-info">
        <blockquote>
            please fill this out and submit
        </blockquote>
    </div>

    <asp:RequiredFieldValidator ID="RequiredFirstName" runat="server" ErrorMessage="First Name Required" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredLastName" runat="server" ErrorMessage="Last Name Required" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="LastName"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredUserName" runat="server" ErrorMessage="User Name Required" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="UserName"></asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareEmail" runat="server" ErrorMessage="Email Address must match confirm email" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="Email" Operator="NotEqual" ValueToCompare="ConfirmEmail" Type="String"></asp:CompareValidator>

    <asp:CompareValidator ID="ComparePassword" runat="server" ErrorMessage="Password must match confirm Password" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="Password" Operator="NotEqual" ValueToCompare="ConfirmPassword" Type="String"></asp:CompareValidator>

    <asp:RegularExpressionValidator ID="RegularExpressionPassword" runat="server" ErrorMessage="Password must be between 4 and 8 and have one numeric diget" Display="None" SetFocusOnError="true" ForeColor="Firebrick" ControlToValidate="Password" ValidationExpression="^(?=.*\d).{4,8}$"></asp:RegularExpressionValidator>


    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" />


    <div class="row">
        <div class="col-md-10">
            <fieldset class="form-horizontal">
                <asp:Label ID="Label1" runat="server" Text="First Name" AssociatedControlID="FirstName"></asp:Label>  
                <asp:TextBox ID="FirstName" runat="server"></asp:TextBox>

                <asp:Label ID="Label2" runat="server" Text="Last Name" AssociatedControlID="LastName"></asp:Label>  
                <asp:TextBox ID="LastName" runat="server"></asp:TextBox>

                <asp:Label ID="Label3" runat="server" Text="User Name" AssociatedControlID="UserName"></asp:Label>  
                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>

                <asp:Label ID="Label4" runat="server" Text="Email Address" AssociatedControlID="Email"></asp:Label>  
                <asp:TextBox ID="Email" runat="server"></asp:TextBox>

                <asp:Label ID="Label5" runat="server" Text="Confirm Email" AssociatedControlID="ConfirmEmail"></asp:Label>  
                <asp:TextBox ID="ConfirmEmail" runat="server"></asp:TextBox>

                <asp:Label ID="Label6" runat="server" Text="Password" AssociatedControlID="Password"></asp:Label>  
                <asp:TextBox ID="Password" runat="server" MaxLength="8"></asp:TextBox>

                <asp:Label ID="Label7" runat="server" Text="Confirm Password" AssociatedControlID="ConfirmPassword"></asp:Label>  
                <asp:TextBox ID="ConfirmPassword" runat="server" MaxLength="8"></asp:TextBox>

            </fieldset>
                <asp:CheckBox ID="Terms" runat="server" text="I agree to terms"/><br />

                <asp:Button ID="Submit" runat="server" Text="Enter Reg" OnClick="Submit_Click" />

            <asp:Label ID="Message" runat="server" ></asp:Label><br />
            <asp:GridView ID="RegList" runat="server"></asp:GridView>

        </div>
    </div>
    <script src="../Scripts/bootwrap-freecode.js"></script>
</asp:Content>

