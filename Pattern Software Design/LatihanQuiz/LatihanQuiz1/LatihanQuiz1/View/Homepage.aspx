<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="LatihanQuiz1.View.Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>SerokYa</h1>
        <asp:Button ID="goToInsertPageBtn" runat="server" Text="Insert Ramen" OnClick="goToInsertPageBtn_Click" />
        <div>
            <asp:GridView ID="gvRamen" runat="server" OnRowDeleting="gvRamen_RowDeleting" OnRowEditing="gvRamen_RowEditing" AutoGenerateColumns="False" >
                <Columns>
                    <asp:BoundField DataField = "RamenID" HeaderText="ID"/>
                    <asp:BoundField DataField = "RamenName" HeaderText="NAME"/>
                    <asp:BoundField DataField = "RamenPrice" HeaderText="PRICE"/>
                    <asp:BoundField DataField = "RamenTypeID" HeaderText="TYPE ID"/>

                    <asp:TemplateField HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="EditBtn" runat="server" Text="Edit" CommandName="Edit"/>
                            <asp:Button ID="DeleteBtn" runat="server" Text="Delete" CommandName="Delete"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
