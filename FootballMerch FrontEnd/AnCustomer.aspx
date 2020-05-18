<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblFirstName" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" OnTextChanged="txtFirstName_TextChanged" style="height: 25px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server" OnTextChanged="txtLastName_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPhoneNo" runat="server" Text="Phone Number: "></asp:Label>
            <asp:TextBox ID="txtPhoneNo" runat="server" OnTextChanged="txtPhoneNo_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" OnTextChanged="txtEmail_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDOB" runat="server" Text="Date Of Birth: "></asp:Label>
            <asp:TextBox ID="txtDOB" runat="server" OnTextChanged="txtDOB_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblAddress" runat="server" Text="Address: "></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" OnTextChanged="txtAddress_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblCity" runat="server" Text="City: "></asp:Label>
            <asp:TextBox ID="txtCity" runat="server" OnTextChanged="txtCity_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPostcode" runat="server" Text="Postcode: "></asp:Label>
            <asp:TextBox ID="txtPostcode" runat="server" OnTextChanged="txtPostcode_TextChanged"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LBLIsGuest" runat="server" Text="Guest account? "></asp:Label>
            <br />
            <asp:CheckBox ID="IsGuestValid" runat="server" OnCheckedChanged="IsGuestValid_CheckedChanged" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
