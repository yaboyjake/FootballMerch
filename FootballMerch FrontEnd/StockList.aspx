<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="StockList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstStockList" runat="server" Height="506px" Width="572px"></asp:ListBox>
        <p>
            <asp:Button ID="BtnAdd" runat="server" OnClick="Button1_Click" style="margin-bottom: 16px" Text="Add"/>
        </p>
        <p>
&nbsp;
            <asp:Button ID="BtnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="BtnEdit" runat="server" OnClick="BtnEdit_Click" Text="Edit" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            Enter a product description
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="ButtonApply" runat="server" OnClick="ButtonApply_Click" Text="Apply" />
            <asp:Button ID="ButtonClear" runat="server" OnClick="ButtonClear_Click" Text="Clear" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        </p>
    </form>
</body>
</html>
