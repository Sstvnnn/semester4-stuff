<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="_2702295373_PSDQuiz.View.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Burger King</h1>
        <asp:GridView ID="burgerGV" runat="server" AutoGenerateColumns="False" OnRowEditing="burgerGV_RowEditing" OnRowDeleting="burgerGV_RowDeleting">
            <Columns>
                <asp:BoundField DataField="BurgerId" HeaderText="ID"/>
                <asp:BoundField DataField="BurgerName" HeaderText="Name"/>
                <asp:BoundField DataField="BurgerPrice" HeaderText="Price"/>
                <asp:BoundField DataField="BurgerStatus" HeaderText="Status"/>
                <asp:TemplateField HeaderText="Actions">
                    <ItemTemplate>
                        <asp:Button ID="UpdateBtn" runat="server" Text="Update Status" CommandName="Edit"/>
                        <asp:Button ID="DeleteBtn" runat="server" Text="Delete" CommandName="Delete"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div>
            <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="goToInsertPageBtn" runat="server" Text="Insert" OnClick="goToInsertPageBtn_Click" />
        </div>
    </form>
</body>
</html>
