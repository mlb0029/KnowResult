<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IntroducirCalificaciones.aspx.cs" Inherits="www.IntroducirCalificaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <h2>Calificar prueba</h2>
         
             
            <label>Prueba <select name ="prueba"></select></label>
            <br/>
            <label> Usuario
                <input name ="calificacion" type="text"/></label>
            <br/>
            <input name="enviar" type ="submit"value="Calificar" />
        </div>
    </form>
</body>
</html>
