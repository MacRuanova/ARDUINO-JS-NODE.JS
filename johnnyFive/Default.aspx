<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnPrender" runat="server" OnClick="btnPrender_Click" Text="Encender" />
        <asp:Button ID="btnApagar" runat="server" OnClick="btnApagar_Click" Text="Apagar" Width="72px" />
    
    </div>
    </form>
</body>
</html>
