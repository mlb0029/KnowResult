<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AñadirPruebas.aspx.cs" Inherits="www.Añadir_Pruebas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Añadir prueba</h2>
            <input name ="idPrueba" type="hidden" />
             <label>Nombre de la prueba <input name ="nombre" type="text" /></label>
            <br/>
            <label>Evaluador de la prueba <select name ="evaluador"><% %></select></label>
            <br/>
            <input name="enviar" type ="submit"value="Añadir" />

        </div>
    </form>
</body>
</html>
