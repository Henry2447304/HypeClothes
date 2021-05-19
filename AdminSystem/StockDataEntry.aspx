<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblProductID" runat="server" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtProductID" runat="server" Height="16px" Width="164px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblProductDescription" runat="server" Text="Product Description" width="68px"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductDescription" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="68px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStockQuantity" runat="server" Text="Stock Quantity" width="68px"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" OnTextChanged="TextBox1_TextChanged1"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblStockDate" runat="server" Text="Date" width="68px"></asp:Label>
        <asp:TextBox ID="txtStockDate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chkStock" runat="server" Text="In Stock" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" />
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
