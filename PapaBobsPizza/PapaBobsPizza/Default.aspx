<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PapaBobsPizza.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="Image1" runat="server" CssClass="auto-style2" ImageUrl="~/PapaBob.png" />
&nbsp;<span class="auto-style1"><strong><span class="auto-style2"> Papa Bob&#39;s Pizza and Software</span><br />
        <br />
        <br />
        <br />
        </strong>
        <asp:RadioButton ID="sizeSmall" runat="server" GroupName="sizeGroup" Text="Baby Bob Size (10&quot;) - $10" />
        <strong>
        <br />
        </strong>
        <asp:RadioButton ID="sizeMedium" runat="server" GroupName="sizeGroup" Text="Mama Bob Size (13&quot;) - $13" />
        <strong>
        <br />
        </strong>
        <asp:RadioButton ID="largeSize" runat="server" GroupName="sizeGroup" Text="Papa Bob Size (16&quot;) - $16" />
        <strong>
        <br />
        <br />
        </strong>
        <asp:RadioButton ID="thinCrust" runat="server" GroupName="crustType" Text="Thin Crust" />
        <br />
        </span>
        <asp:RadioButton ID="thickCrust" runat="server" GroupName="crustType" style="font-family: Arial, Helvetica, sans-serif" Text="Deep Dish (+$2)" />
        <br />
        <br />
        <asp:CheckBox ID="pepperoni" runat="server" style="font-family: Arial, Helvetica, sans-serif" Text="Pepperoni (+$1.50)" />
        <br />
        <asp:CheckBox ID="onions" runat="server" style="font-family: Arial, Helvetica, sans-serif" Text="Onions (+$0.75)" />
        <br />
        <asp:CheckBox ID="greenpeppers" runat="server" style="font-family: Arial, Helvetica, sans-serif" Text="Green Peppers (+$0.50)" />
        <br />
        <asp:CheckBox ID="redpeppers" runat="server" style="font-family: Arial, Helvetica, sans-serif" Text="Red Peppers (+$0.75)" />
        <br />
        <asp:CheckBox ID="achovies" runat="server" style="font-family: Arial, Helvetica, sans-serif" Text="Anchovies (+$2)" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" style="font-family: Arial, Helvetica, sans-serif; font-weight: 700; font-size: large" Text="Papa Bob's"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" style="font-weight: 700; font-family: Arial, Helvetica, sans-serif; font-size: x-large; color: #FF0000" Text="Special Deal"></asp:Label>
        <br />
        <br />
        Save $2.00 when you add Pepperoni, Green Peppers and Anchovies OR Pepperoni, Red Peppers and Onions to your pizza. <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Purchase" />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Total: "></asp:Label>
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
        <br />
        <br />
        Sorry, at this time you can only order one pizza online, and pick-up only...we need a better website!</div>
    </form>
    <p>
        <br />
    </p>
</body>
</html>
