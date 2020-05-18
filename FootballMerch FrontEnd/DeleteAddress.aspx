<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteAddress.aspx.cs" Inherits="DeleteAddress" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
        </div>
        <asp:Button ID="BtnYes" runat="server" Height="29px" OnClick="btnYes_Click" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</body>
</html>
