﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="order.aspx.cs" Inherits="order" %>&nbsp;<!DOCTYPE html><html xmlns="http://www.w3.org/1999/xhtml"><head runat="server"><title></title><style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            height: 23px;
            width: 222px;
        }
        .auto-style3 {
            width: 222px;
        }
    </style></head><body><form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">
                        OrderID</td>
                    <td class="auto-style1" id="tableMain">
                        <asp:TextBox ID="txtOrderID" runat="server"></asp:TextBox>
                        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        CustomerID</td>
                    <td id="tableMain">
                        <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        ShippingAddress</td>
                    <td id="tableMain">
                        <asp:TextBox ID="txtShippingAddress" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        OrderDate</td>
                    <td id="tableMain">
                        <asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="Shipped?"></asp:Label>
                    </td>
                    <td id="tableMain">
                        <asp:Label ID="lblShipped" runat="server" Text="No Status"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    
                    <td>
                        <asp:CheckBox ID="chkShipped" runat="server" Text="Order Shipped" />
                    </td>
                </tr>
                <tr>
       
                    
                    <td>
                        <asp:Label ID="lblError" runat="server" Text="All good!"></asp:Label>
                    </td>
                </tr>
                <tr>
       
                    
                    <td>
                        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click1" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
    </form>
    <p>
        &nbsp;</p>
    <p>
                        &nbsp;</p>
</body>
</html>
