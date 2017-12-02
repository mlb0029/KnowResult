<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="www.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <h2 id="Titulo">Login</h2>

        <asp:Label ID="LabelError" runat="server" ></asp:Label>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Cuenta"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

        <br />
        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="botonlog_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Recuperar contraseña" OnClick="Button2_Click" />
    </form>
</body>
</html>

