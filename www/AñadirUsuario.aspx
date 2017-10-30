<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AñadirUsuario.aspx.cs" Inherits="www.AñadirUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Añadir usuario</h2>
            <input name ="idUsuario" type="hidden" />
             <label>Cuenta del usuario <input name ="cuenta" type="text" /></label>
            <br/>
             <label>Nombre<input name ="nombre" type="text" /></label>
            <br/>
             <label>Apellidos <input name ="apellidos" type="text" /></label>
            <br/>
             <label>Email <input name ="email" type="text" /></label>
            <br/>
             <label>Password <input name ="password" type="password"/></label>
            <br/>
            <label>Rol <select name ="rol"></select></label>
            <br/>
            <input name="enviar" type ="submit"value="Añadir" />
        </div>
    </form>
</body>
</html>
