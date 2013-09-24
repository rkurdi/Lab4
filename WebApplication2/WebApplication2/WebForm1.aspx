<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body bgcolor="#cccccc" text="#000099">
    <form id="form1" runat="server">
    <p align="center">
        Number 1:<asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
    </p>
    <p align="center">
        Number 2:<asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
    </p>
    <p align="center">
        &nbsp;</p>
    <p align="center">
        Result: 
        <asp:Label ID="RES" runat="server"></asp:Label>
    </p>
    <p align="center">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p align="center">
&nbsp;<asp:Button ID="Plus" runat="server" BackColor="#FFFF66" BorderColor="#0066FF" 
            Height="100px" onclick="Plus_Click1" Text="+" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Subtract" runat="server" BackColor="#FFFF66" 
            BorderColor="#0066FF" Height="100px" onclick="Subtract_Click1" Text="-" 
            Width="100px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Multiply" runat="server" BackColor="#FFFF66" 
            BorderColor="#0066FF" Height="100px" onclick="Multiply_Click1" 
            style="margin-left: 0px" Text="*" Width="100px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Devide" runat="server" BackColor="#FFFF66" 
            BorderColor="#0066FF" Height="100px" onclick="Devide_Click" Text="/" 
            Width="100px" />
    </p>
    </form>
</body>
</html>
