<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyFirstChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="How old are you?"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="ageField" runat="server"></asp:TextBox>
        <br />
&nbsp;<br />
        <asp:Label ID="Label2" runat="server" Text="How much money do you have in your pocket?"></asp:Label>
&nbsp;
        <asp:TextBox ID="moneyField" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Click me to see your fortune!" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
