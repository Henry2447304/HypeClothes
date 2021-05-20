<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStock.aspx.cs" Inherits="DeleteStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Are you sure you want to delete this record?</p>
        <p>
            <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
