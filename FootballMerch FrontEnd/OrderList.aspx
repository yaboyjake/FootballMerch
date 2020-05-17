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
    </form>
</body>
</html>
