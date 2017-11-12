<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu_Admin.aspx.cs" Inherits="www.Menu_Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float:right">
            <asp:Label ID="user" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Rol" runat="server" Text="Label"></asp:Label>
             <br />
            <asp:Button ID="Cerrar" runat="server" Text="Cerrar" OnClick="Cerrar_Click" />
             <br />
        </div>
        <div>
        <asp:Button ID="Button1" runat="server" Text="Añadir prueba" OnClick="Button1_Click" />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Añadir usuario" OnClick="Button2_Click" />
         <br />
            </div>
        <p>
            
        </p>
    </form>
</body>
</html>
