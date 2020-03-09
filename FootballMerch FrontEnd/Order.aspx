<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="Order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</head>
<body>
     <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style1">OrderID</td>
                <td class="auto-style1">
                    <input id="txtOrderId" name="txtOrderId" type="text" /></td>
            </tr>
            <tr>
                <td>CustomerID</td>
                <td>
                    <input id="txtCustomerID" name="txtCustomerID" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style2">OrderDate</td>
                <td>
                    <input id="txtOrderDate" name="txtOrderDate" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style3">ShippingAddress</td>
                <td class="auto-style3">
                    <input id="txtOrderDate" name="txtOrderDate" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style3">OrderShipped</td>
                <td class="auto-style3">
                    <input id="txtOrderShipped" name="txtOrderShipped" type="text" /></td>
            </tr>
            <tr>
                <td class="auto-style3">HasShipped</td>
                <td class="auto-style3">
                    <input id="chkHasShipped" name="chkHasShipped" type="checkbox" /></td>
            </tr>
            <tr>
                <td class="auto-style3">Error:</td>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <input id="btnOK" name="btnOK" type="submit" value="Okay" /><input id="Button2" name="btnCancel" type="button" value="Cancel" /></td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
        </table>
    </form>
     <p>
         &nbsp;</p>
</body>
</html>
