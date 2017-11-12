﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AñadirPruebas.aspx.cs" Inherits="www.Añadir_Pruebas" %>

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
            <h2>Añadir prueba</h2>
            <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Evaluador"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
            
            <br />
            <asp:Label ID="Label3" runat="server" Text="Aspirante"></asp:Label>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>
            <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" SelectionMode="Multiple"></asp:ListBox>
            <br />    
            <asp:Button ID="Button1" runat="server" Text="Aceptar" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClick="Button2_Click" />
        </div>
        
    </form>
</body>
</html>
