<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContestEntry.aspx.cs" Inherits="WebApp.SamplePages.ContestEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Contest Entry</h1>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="alert alert-info">
                <blockquote style="font-style: italic">
                    This illustrates some simple controls to fill out an entry form for a contest. 
                    This form will use basic bootstrap formatting and illustrate Validation.
                </blockquote>
                <p>
                    Please fill out the following form to enter the contest. This contest is only available to residents in Western Canada.
                </p>
            </div>
        </div>
    </div>
    <br />
    <div class="row">
        <%-- Validation controls
            they could be placed beside the oppropriate input field
            HOWEVER this would cause bootwrap to fail
            THEREFOR the controls will be grouped before the form or anywhere else--%>
        <asp:RequiredFieldValidator ID="RequiredFirstName" runat="server" ErrorMessage="First Name is required." Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="FirstName"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredLastName" runat="server" ErrorMessage="Last Name is required." Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="LastName"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredStreetAddress" runat="server" ErrorMessage="Street Address is required." Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="StreetAddress1"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredCity" runat="server" ErrorMessage="City is required." Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="City"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredProvince" runat="server" ErrorMessage="Province is required." Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="Province"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredPostalCode" runat="server" ErrorMessage="Postal Code is required." Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="PostalCode"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Postal Code Format (X9X9X9)" Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="PostalCode" ValidationExpression="[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredEmailAddress" runat="server" ErrorMessage="Email Address is required." Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="EmailAddress"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegExEmailAddress" runat="server" ErrorMessage="Invalid Email Address Format" Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="EmailAddress" ValidationExpression="^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredCheckAnswer" runat="server" ErrorMessage="Answer to skill teting question is required." Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="CheckAnswer"></asp:RequiredFieldValidator>
        <%--<asp:CompareValidator ID="CompareCheckAnswer" runat="server" ErrorMessage="Check Answer: DataType check" Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="CheckAnswer" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>--%>
        <asp:CompareValidator ID="CompareCheckAnswer" runat="server" ErrorMessage="Check Answer: Constant Value check" Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="CheckAnswer" Operator="Equal" ValueToCompare="15" Type="Integer"></asp:CompareValidator>
        <%--<asp:CompareValidator ID="CompareCheckAnswer" runat="server" ErrorMessage="Check Answer: Against Another Field check" Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="CheckAnswer" Operator="NotEqual" ControlToCompare="StreetAddress2" Type="Integer"></asp:CompareValidator>--%>

        <%-- Using streetaddress2 to demonstrate the range validation  --%>
        <asp:RangeValidator ID="RangeValidatorStreetAddress2" runat="server" ErrorMessage="Range Sample on street address 2 values 0-100(int)" Display="none" SetFocusOnError="true" ForeColor="#990000" ControlToValidate="StreetAddress2" MinimumValue="0" MaximumValue="100" Type="Integer"></asp:RangeValidator>

        <%-- Validation summery control is used to display the validation errors --%>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger"/>
        
    </div>
  
    <div class="row">
        <div class ="col-md-6">
            <fieldset class="form-horizontal">
                <legend>Application Form</legend>

                <asp:Label ID="Label1" runat="server" Text="First Name"
                     AssociatedControlID="FirstName"></asp:Label>
                <asp:TextBox ID="FirstName" runat="server" 
                    ToolTip="Enter your first name." MaxLength="25"></asp:TextBox> 
                  
                 <asp:Label ID="Label6" runat="server" Text="Last Name"
                     AssociatedControlID="LastName"></asp:Label>
                <asp:TextBox ID="LastName" runat="server" 
                    ToolTip="Enter your last name." MaxLength="25"></asp:TextBox> 
                        
                <asp:Label ID="Label3" runat="server" Text="Street Address 1"
                     AssociatedControlID="StreetAddress1"></asp:Label>
                <asp:TextBox ID="StreetAddress1" runat="server" 
                    ToolTip="Enter your street address." MaxLength="75"></asp:TextBox> 
                  
                  <asp:Label ID="Label7" runat="server" Text="Street Address 2"
                     AssociatedControlID="StreetAddress2"></asp:Label>
                <asp:TextBox ID="StreetAddress2" runat="server" 
                    ToolTip="Enter your additional street address." MaxLength="75"></asp:TextBox> 
                  <br />
                 <asp:Label ID="Label8" runat="server" Text="City"
                     AssociatedControlID="City"></asp:Label>
                <asp:TextBox ID="City" runat="server" 
                    ToolTip="Enter your City name" MaxLength="50"></asp:TextBox> 
                  
                 <asp:Label ID="Label9" runat="server" Text="Province"
                     AssociatedControlID="Province"></asp:Label>
                <asp:DropDownList ID="Province" runat="server" Width="75px">
                    <asp:ListItem Value="AB" Text="AB"></asp:ListItem>
                     <asp:ListItem Value="BC" Text="BC"></asp:ListItem>
                     <asp:ListItem Value="MN" Text="MN"></asp:ListItem>
                     <asp:ListItem Value="SK" Text="SK"></asp:ListItem>
                </asp:DropDownList>
                  
                 <asp:Label ID="Label10" runat="server" Text="Postal Code"
                     AssociatedControlID="PostalCode"></asp:Label>
                <asp:TextBox ID="PostalCode" runat="server" 
                    ToolTip="Enter your postal code"  MaxLength="6"></asp:TextBox> 
                 
                <asp:Label ID="Label2" runat="server" Text="Email"
                     AssociatedControlID="EmailAddress"></asp:Label>
                <asp:TextBox ID="EmailAddress" runat="server" 
                    ToolTip="Enter your email address"
                     TextMode="Email"></asp:TextBox> 
                  
              </fieldset>   
           <p>Note: You must agree to the contest terms in order to be entered.
               <br />
               <asp:CheckBox ID="Terms" runat="server" Text="I agree to the terms of the contest" />
           </p>

            <p>
                Enter your answer to the following calculation instructions:<br />
                Multiply 15 times 6<br />
                Add 240<br />
                Divide by 11<br />
                Subtract 15<br />
                <asp:TextBox ID="CheckAnswer" runat="server" ></asp:TextBox>
            </p>
        </div>
        <div class="col-md-6">   
            <div class="col-md-offset-2">
                <p>
                    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />&nbsp;&nbsp;
                    <asp:Button ID="Clear" runat="server" Text="Clear" CausesValidation="False" OnClick="Clear_Click" 
                         />
                </p>
                <asp:Label ID="Message" runat="server" ></asp:Label><br />

                <asp:GridView ID="EntryList" runat="server"></asp:GridView>
            </div>
        </div>
    </div>
    <script src="../Scripts/bootwrap-freecode.js"></script>
</asp:Content>
