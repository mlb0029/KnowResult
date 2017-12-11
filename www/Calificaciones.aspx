<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calificaciones.aspx.cs" Inherits="www.Calificaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
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
                <h2 id="Titulo">Calificaciones</h2>
        </div>
    </form>
</body>
</html>
