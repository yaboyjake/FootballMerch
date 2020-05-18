<%@ Page Language="C#" AutoEventWireup="true" CodeFile="orderList.aspx.cs" Inherits="OrderList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrderList" runat="server" Height="218px" OnSelectedIndexChanged="lstOrderList_SelectedIndexChanged" Width="414px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="Enter An Address To Filter By"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
