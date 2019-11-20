<%@ Page Title="Sql Query" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SqlQuery.aspx.cs" Inherits="WebApp.SamplePages.SqlQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>SqlQuery: Non Primary Key field query</h1>
    <div class="offset-2">
        <asp:Label ID="Label1" runat="server" Text="Select a category: "></asp:Label> &nbsp;&nbsp;
        <asp:DropDownList ID="CategoryList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
        <asp:Button ID="Fetch" runat="server" Text="Fetch" CausesValidation="false" OnClick="Fetch_Click"/>
        <br /> <br />
        <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="ProductList" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" GridLines="Horizontal" BorderStyle="None" OnSelectedIndexChanged="ProductList_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="ProductList_PageIndexChanging" PageSize="5">
            <Columns>
                <asp:CommandField SelectText="View" ShowSelectButton="True" ButtonType="Button" CausesValidation="false"></asp:CommandField>
                <asp:TemplateField HeaderText="ID">
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="ProductID" runat="server" Text='<%# Eval("ProductID")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Product">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="ProductName" runat="server" Text='<%# Eval("ProductName")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Qty/Per">
                    <ItemStyle HorizontalAlign="Left"></ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="QtyPer" runat="server" Text='<%# Eval("QuantityPerUnit") == null ? "each" : Eval("QuantityPerUnit")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="$">
                    <ItemStyle HorizontalAlign="Right"></ItemStyle>
                    <ItemTemplate>
                        <asp:Label ID="UnitPrice" runat="server" 
                            Text='<%# string.Format("{0:0.00}", Eval("UnitPrice"))%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Discontinued">
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" Enabled="false" checked='<%# Eval("Discontinued")%>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EmptyDataTemplate>
                this is a message to tell the user there is no data to display
            </EmptyDataTemplate>
            <PagerSettings FirstPageText="Start" LastPageImageUrl="End" Mode="NumericFirstLast" PageButtonCount="3" />
        </asp:GridView>
    </div>
</asp:Content>

