<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllStudents.aspx.cs" Inherits="UniManagementSystem.UI.ShowAllStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="allStudentsGridView" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
        <Columns>
            <asp:TemplateField HeaderText="Student Name">
                <ItemTemplate>
                 <%#Eval("StudentName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Registration Number">
                <ItemTemplate>
                    <%#Eval("RegNo") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Department">
                <ItemTemplate>
                    <%#Eval("DepartmentName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Email">
                <ItemTemplate>
                    <asp:HiddenField ID="idHiddenField" runat="server" Value='<%#Eval("StudentId") %>'/>
                    <%#Eval("Email") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="deleteLinkButton" runat="server" Text="Update" OnClick="UpdateLinkButton_Click">Update</asp:LinkButton>
                    <asp:LinkButton ID="updateLinkButton" runat="server" Text="Delete" OnClick="DeleteLinkButton_Click">Delete</asp:LinkButton>

                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
    
    </div>
    </form>
</body>
</html>
