<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPage.aspx.cs" Inherits="FinalQuiz.View.InsertPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Insert Burger</h1>
        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="NameTb" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="PriceTb" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="ErrorLbl" runat="server" Text=" "></asp:Label>
            <br />
            <asp:Button ID="InsertBtn" runat="server" Text="Insert Burger" OnClick="InsertBtn_Click"/>
        </div>
    </form>
</body>
</html>
