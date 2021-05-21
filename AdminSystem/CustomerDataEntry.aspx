<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="CustomerId" runat="server" Text="Customer ID"></asp:Label>
        <asp:TextBox ID="txtCustomerId" runat="server" OnTextChanged="txtCustomerId_TextChanged"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        <br />
        <asp:Label ID="CustomerName" runat="server" Text="Customer Name" width="79px"></asp:Label>
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Address" runat="server" Text="Address" width="79px"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="DoB" runat="server" Text="Date of birth" width="79px"></asp:Label>
        <asp:TextBox ID="txtDoB" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Postcode" runat="server" Text="Postcode" width="79px"></asp:Label>
        <asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="GdprRequest" runat="server" Text="GDPR Request"></asp:Label>
        <asp:CheckBox ID="chkGdprRequest" runat="server" Text="Requested" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click1" />
    </form>
</body>
</html>
