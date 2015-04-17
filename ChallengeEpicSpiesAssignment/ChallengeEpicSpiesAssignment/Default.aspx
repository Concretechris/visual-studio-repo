<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssignment.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" Width="164px" />
        <br />
        <br />
        <strong><span class="auto-style1">Spy New Assignment Form<br />
        <br />
        </span></strong><span class="auto-style2">Spy Code Name:&nbsp; </span>
        <asp:TextBox ID="spyName" runat="server" Height="18px" style="margin-top: 0px" Width="128px"></asp:TextBox>
        <br />
        <br />
        New Assignment Name:&nbsp;
        <asp:TextBox ID="assignmentName" runat="server" Height="18px"></asp:TextBox>
        <br />
        <br />
        End Date of Previous Assignment<asp:Calendar ID="endDate" runat="server" OnSelectionChanged="endDate_SelectionChanged"></asp:Calendar>
        <br />
        Start Date of New Assignment<asp:Calendar ID="startDate" runat="server"></asp:Calendar>
        <br />
        End Date of New Assignment<asp:Calendar ID="newEndDate" runat="server"></asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Assign Spy" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
