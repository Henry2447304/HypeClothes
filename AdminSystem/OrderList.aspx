<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="386px" Width="339px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" Height="33px" OnClick="btnAdd_Click" Text="Add" Width="62px" />
        &nbsp;<asp:Button ID="btnEdit" runat="server" Height="33px" OnClick="btnEdit_Click" style="margin-top: 0px" Text="Edit" Width="62px" />
&nbsp;<asp:Button ID="btnDelete" runat="server" Height="33px" OnClick="btnDelete_Click" style="margin-top: 0px" Text="Delete" Width="62px" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
