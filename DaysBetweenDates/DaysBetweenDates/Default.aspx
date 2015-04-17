<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DaysBetweenDates.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        How many days have elapsed?<br />
        <br />
        Choose one date:<asp:Calendar ID="myCalendar1" runat="server" OnSelectionChanged="myCalendar1_SelectionChanged"></asp:Calendar>
        <br />
        <br />
        Choose a second date:<asp:Calendar ID="myCalendar2" runat="server" OnSelectionChanged="myCalendar2_SelectionChanged"></asp:Calendar>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
