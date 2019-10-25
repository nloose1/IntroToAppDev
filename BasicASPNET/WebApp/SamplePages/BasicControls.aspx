<%@ Page Title="Commom Web Controls" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BasicControls.aspx.cs" Inherits="WebApp.SamplePages.BasicControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Basic Common Web Form Contorls</h1>
    <table align="center" style="width: 80%">
        <tr>
            <td align="right" style="height: 20px">Enter a value from 1-4</td>
            <td style="height: 20px">
                <asp:TextBox ID="NumberChoice" runat="server" OnTextChanged="TextBox1_TextChanged" ToolTip="Enter 1-4"></asp:TextBox>
&nbsp;
                <asp:Button ID="SubmitNumberChoice" runat="server" BackColor="White" ClientIDMode="Predictable" Text="Submit" />
            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="AlterLabel" runat="server" Text="Course Choice"></asp:Label></td>
            <td>
                <asp:RadioButtonList ID="ChoiceList" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">

                    <asp:ListItem Value="1">COMP1008</asp:ListItem>
                    <asp:ListItem Value="2">CPSC1517</asp:ListItem>
                    <asp:ListItem Value="3">DMIT1508</asp:ListItem>
                    <asp:ListItem Value="4">DMIT2018</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Literal ID="Literal1" runat="server" Text="Programing Course"></asp:Literal></td>
            <td>
                <asp:CheckBox ID="ProgramingCourseActive" runat="server" Text="(programming course if checked)" /></td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label2" runat="server" Text="Using label as read only output"></asp:Label>
            </td>
            <td>
                <asp:Label ID="DisplayDataRO" runat="server" ></asp:Label>

            </td>
        </tr>
        <tr>
            <td align="right">
                <asp:Label ID="Label4" runat="server" Text="Selection of Course"></asp:Label>

            </td>
            <td>
                <asp:DropDownList ID="CollectionChoiceList" runat="server"></asp:DropDownList>
                &nbsp;&nbsp;
                <asp:LinkButton ID="LinkButton1" runat="server">Submit Selection</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" align="center">
                <asp:Label ID="MessageLabel" runat="server"></asp:Label>

            </td>
        </tr>
    </table>
</asp:Content>
