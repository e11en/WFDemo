<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Workflow.Web.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server"> 
    <div> 
        <asp:Label Text="Your name: " runat="server" /> 
        <asp:TextBox ID="TextBoxName" runat="server" /> 
        <asp:Button ID="ButtonCreateGreeting" Text="Create greeting" runat="server" onclick="ButtonCreateGreeting_Click" /> 
        <br /> 
        <asp:Label ID="LabelGreeting" Text="" runat="server" /> 
    </div> 
    </form> 
</body>
</html>

