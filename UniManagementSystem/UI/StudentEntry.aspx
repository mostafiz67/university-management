<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="UniManagementSystem.UI.StudentEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Registration Number"></asp:Label>
        <asp:TextBox ID="registrationNumberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Department"></asp:Label>
        <asp:DropDownList ID="departmentDropDownList" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" Text="Save" OnClick="saveButton_Click" />
        <br />
        <br />
        <asp:Label ID="entryMessageLabelLabel" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
    <asp:HyperLink ID="homeHyperLink" runat="server" NavigateUrl="HomeUI.aspx" >Home</asp:HyperLink>
</body>
</html>
