<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEntry.aspx.cs" Inherits="UniManagementSystem.UI.DepartmentEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>
                
                <asp:Label ID="departmentCodeLabel" runat="server" Text="Code"></asp:Label>
                
            </td>
            <td>
                
                <asp:TextBox ID="departmentCodeTextBox" runat="server"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
                
                <asp:Label ID="departmentNameLabel" runat="server" Text="Name"></asp:Label>
                
            </td>
            <td>
                
                <asp:TextBox ID="departmentNameTextBox" runat="server"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                <asp:Button ID="SaveButton" runat="server" OnClick="SaveButton_Click" Text="Save" />
            </td>
        </tr>
        <tr>
            <td>
                
            </td>
            <td>
                
                <asp:Label ID="departmentMessageLabel" runat="server" Text="Label"></asp:Label>
                
            </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
