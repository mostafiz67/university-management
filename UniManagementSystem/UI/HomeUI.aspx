<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeUI.aspx.cs" Inherits="UniManagementSystem.UI.HomeUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:HyperLink ID="studentyEntryHyperLink" runat="server" NavigateUrl="StudentEntry.aspx" >Student Entry</asp:HyperLink>
        <br/>
        <asp:HyperLink ID="showAllStudentsHyperLink" runat="server" NavigateUrl="ShowAllStudents.aspx" >Show All Students</asp:HyperLink>
    <br/>
        <asp:HyperLink ID="studentUpdateHyperLink" runat="server" NavigateUrl="StudentUpdate.aspx" >Student Update</asp:HyperLink>
    
        <br />
        <asp:HyperLink ID="departmentEntryHyperLink" runat="server" NavigateUrl="DepartmentEntry.aspx">Department Entry</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
