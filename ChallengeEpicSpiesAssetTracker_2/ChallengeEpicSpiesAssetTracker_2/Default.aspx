<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/epic-spies-logo.jpg" Width="150px" />
        <br />
        <br />
        <span class="auto-style1"><strong>Asset Performance Tracker</strong></span><br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Asset Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Elections Rigged"></asp:Label>
&nbsp;
        <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Number of subterfuges performed"></asp:Label>
&nbsp;
        <asp:TextBox ID="subTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="submitButton" runat="server" OnClick="submitButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
