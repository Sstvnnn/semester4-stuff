<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="FinalQuiz.View.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Burger King</h1>
        <div>
            <asp:GridView ID="burgerGV" runat="server" AutoGenerateColumns="False" OnRowEditing="burgerGV_RowEditing" OnRowDeleting="burgerGV_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="BurgerId" HeaderText="ID"/>
                    <asp:BoundField DataField="BurgerName" HeaderText="NAME"/>
                    <asp:BoundField DataField="BurgerPrice" HeaderText="PRICE"/>
                    <asp:BoundField DataField="BurgerStatus" HeaderText="STATUS"/>
                    <asp:TemplateField HeaderText="ACTIONS">
                        <ItemTemplate>
                            <asp:Button ID="UpdateBtn" runat="server" Text="UDPATE STATUS" CommandName="Edit"/>
                            <asp:Button ID="DeleteBtn" runat="server" Text="DELETE" CommandName="Delete"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="goToInsertPageBtn" runat="server" Text="Insert" OnClick="goToInsertPageBtn_Click"/>
        </div>
    </form>
</body>
</html>
