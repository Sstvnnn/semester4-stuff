<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="LatihanQuizTerakhir.View.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <%-- ctrl + d -> copy line --%>
        <div>
            <h1>BurgerKing</h1>
            <br />
            <asp:GridView ID="burgerGV" runat="server" AutoGenerateColumns="False" OnRowEditing="burgerGV_RowEditing" OnRowDeleting="burgerGV_RowDeleting">
                <Columns>
                    <asp:BoundField DataField="BurgerId" HeaderText="ID"/>
                    <asp:BoundField DataField="BurgerName" HeaderText="NAME"/>
                    <asp:BoundField DataField="BurgerPrice" HeaderText="PRICE"/>
                    <asp:BoundField DataField="BurgerStatus" HeaderText="STATUS"/>
                    <asp:TemplateField HeaderText="ACTIONS">
                        <ItemTemplate>
                            <asp:Button ID="UpdateBtn" runat="server" Text="Update Status" CommandName="Edit"/>
                            <asp:Button ID="DeleteBtn" runat="server" Text="Delete" CommandName="Delete"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
            <br />
            <asp:Button ID="InsertBtn" runat="server" Text="Insert" OnClick="InsertBtn_Click"/>
        </div>
    </form>
</body>
</html>
