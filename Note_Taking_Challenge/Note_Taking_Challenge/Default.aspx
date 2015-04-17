<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Note_Taking_Challenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Your Note Taking Preference"></asp:Label>
        <br />
        <br />
    
    </div>
        <asp:RadioButton ID="pencilButton" runat="server" GroupName="prefGroup" Text="Pencil" />
        <br />
        <asp:RadioButton ID="penButton" runat="server" GroupName="prefGroup" Text="Pen" />
        <br />
        <asp:RadioButton ID="phoneButton" runat="server" GroupName="prefGroup" Text="Phone" />
        <br />
        <asp:RadioButton ID="tabletButton" runat="server" GroupName="prefGroup" Text="Tablet" />
        <br />
        <br />
        <asp:Button ID="resultButton" runat="server" OnClick="resultButton_Click" Text="Make it Rain! " />
        <br />
        <br />
        <asp:Image ID="resultImage" runat="server" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
