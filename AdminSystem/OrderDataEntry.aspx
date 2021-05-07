<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderID" runat="server" Text="Order ID"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtOrderID" runat="server" style="margin-top: 0px"></asp:TextBox>
            &nbsp;
            &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <p>
&nbsp;<asp:Label ID="lblTotalItem" runat="server" Text="Total Item" width="57px"></asp:Label>
&nbsp;
                <asp:TextBox ID="txtTotalItem" runat="server" style="margin-bottom: 0px"></asp:TextBox>
            </p>
        </div>
        <p>
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="57px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDeliveryAddress" runat="server" Text="Delivery Address" width="57px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtDeliveryAddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateOrdered" runat="server" Text="Date Ordered" width="57px"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtDateOrdered" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblItemAvailable" runat="server" Text="Item All Available" width="57px"></asp:Label>
&nbsp;
            <asp:CheckBox ID="chkAvailable" runat="server" Text="Yes" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
