<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertPage.aspx.cs" Inherits="LatihanQuiz1.View.InsertPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Ramen Name: "></asp:Label>
            <asp:TextBox ID="NameTb" runat="server"></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="PriceLbl" runat="server" Text="Ramen Price: "></asp:Label>
            <asp:TextBox ID="PriceTb" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="TypeLbl" runat="server" Text="Ramen Type: "></asp:Label>
            <asp:DropDownList ID="TypeDdl" runat="server"
                DataValueField="RamenTypeID" DataTextField="RamenTypeName"></asp:DropDownList>
        </div>
        <asp:Label ID="ErrorLbl" runat="server" Text=" " ForeColor="Red"></asp:Label>
        <asp:Button ID="InsertBtn" runat="server" Text="Insert Ramen" OnClick="InsertBtn_Click" />
    </form>
</body>
</html>
