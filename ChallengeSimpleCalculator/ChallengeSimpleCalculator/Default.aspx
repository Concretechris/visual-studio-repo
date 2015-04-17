<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeSimpleCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Title" runat="server" Font-Bold="True" Font-Size="20pt" Text="Simple Calculator" style="font-family: Arial, Helvetica, sans-serif"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="First Value" style="font-family: Arial, Helvetica, sans-serif"></asp:Label>
&nbsp;
        <asp:TextBox ID="NumberOne" runat="server" OnTextChanged="NumberOne_TextChanged"></asp:TextBox>
        <br />
        <br />
        <span class="auto-style1">Second Value</span>&nbsp;
        <asp:TextBox ID="NumberTwo" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="AdditionButton" runat="server" Height="25px" OnClick="AdditionButton_Click" Text="+" Width="25px" />
&nbsp;&nbsp;
        <asp:Button ID="SubtractionButton" runat="server" Height="25px" Text="-" Width="25px" OnClick="SubtractionButton_Click" />
&nbsp;&nbsp;
        <asp:Button ID="MultiplyButton" runat="server" Height="25px" Text="*" Width="25px" OnClick="MultiplyButton_Click" />
&nbsp;&nbsp;
        <asp:Button ID="DivisionButton" runat="server" Height="25px" Text="/" Width="25px" OnClick="DivisionButton_Click" />
        <br />
        <br />
        <asp:Label ID="ResultLabel" runat="server" BackColor="#6600FF" Font-Bold="True" Font-Size="14pt"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>
