<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IntroducirCalificaciones.aspx.cs" Inherits="www.IntroducirCalificaciones" %>

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
                <h2>Calificar prueba</h2>
         
             
            
        </div>
         
        <asp:Label ID="Label1" runat="server" Text="Selecciona la prueba:"></asp:Label>
         <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
         </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" >
        </asp:DropDownList>
          <br />
                 <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
         <asp:Button ID="Button1" runat="server" Text="Calificar" OnClick="Button1_Click" />
         
        
         
    </form>
</body>
</html>
