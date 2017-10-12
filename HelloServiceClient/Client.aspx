<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Client.aspx.cs" Inherits="HelloServiceClient.Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:TextBox id="txtMessage" runat="server"></asp:TextBox><br />
            <asp:Label id="lblMessage" runat="server"></asp:Label><br />
            <asp:Button id="btnShowMessage" runat="server" Text="Show Message" OnClick="btnShowMessage_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
