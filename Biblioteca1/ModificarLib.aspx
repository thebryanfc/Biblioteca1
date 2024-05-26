﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarLib.aspx.cs" Inherits="Biblioteca1.Libros.ModificarLib" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Modificar Libro</title>
   <link rel="stylesheet" href="Elementos/Agregar.css">
<script src="Elementos/Menu.js" defer></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <nav id='menu'>
     <input type='checkbox' id='responsive-menu' onclick='updatemenu()'><label></label>
     <ul>
        <li><a class='dropdown-arrow' href="Menu.aspx">Inicio</a>
         <li><a class='dropdown-arrow' href=''>Libros</a>
             <ul class='sub-menus'>
                 <li><a href="ListarLib.aspx">Listar</a></li>
                 <li><a href="ConsultarLib.aspx">Consultar</a></li>
                 <li><a href="AgregarLib.aspx">Agregar</a></li>
                 <li><a href="Eliminar.aspx">Eliminar</a></li>
             </ul>
         </li>
         <li><a class='dropdown-arrow' href=''>Alumnos</a>
             <ul class='sub-menus'>
                 <li><a href="FueraDeServicio.html">Agregar</a></li>
                 <li><a href="FueraDeServicio.html">Listar</a></li>
                 <li><a href="FueraDeServicio.html">Consultar</a></li>
                 <li><a href="FueraDeServicio.html">Modificar</a></li>
                 <li><a href="FueraDeServicio.html">Eliminar</a></li>
             </ul>
         </li>
         <li><a class='dropdown-arrow' href=''>Prestamos</a>
             <ul class='sub-menus'>
                 <li><a href="FueraDeServicio.html">Agregar</a></li>
                 <li><a href="FueraDeServicio.html">Listar</a></li>
                 <li><a href="FueraDeServicio.html">Consultar</a></li>
                 <li><a href="FueraDeServicio.html">Modificar</a></li>
                 <li><a href="FueraDeServicio.html">Eliminar</a></li>
             </ul>
         </li>
            <li><a class='dropdown-arrow' href="AcercaDe.aspx">Acerca De</a>
            <li><a class='dropdown-arrow' href="Contacto.aspx">Contacto</a>
        </ul>
</nav>
        </div>
        <div class="Container_Agregar">
            <h2>Modificar Libro</h2>
            <label for="textBox1">ID De Libro</label>
            <asp:TextBox ID="textBox1" runat="server" type="number" required="required"></asp:TextBox>
            <asp:Button ID="ButtonConsultar" runat="server" Text="Consultar" OnClick="ButtonConsultar_Click" Width="80px" />

            <label for="textBox2">Nombre Del Libro</label>
            <asp:TextBox ID="textBox2" runat="server"></asp:TextBox>

            <label for="textBox3">Editorial</label>
            <asp:TextBox ID="textBox3" runat="server" ></asp:TextBox>

            <label for="textBox4">Autor</label>
            <asp:TextBox ID="textBox4" runat="server" ></asp:TextBox>

            <label for="textBox5">Genero</label>
            <asp:TextBox ID="textBox5" runat="server" ></asp:TextBox>

            <label for="textBox6">Numero De Paginas</label>
            <asp:TextBox ID="textBox6" runat="server" type="number" ></asp:TextBox>
            <asp:Button ID="ButtonModificar" runat="server" Text="Modificar" OnClick="ButtonModificar_Click" Width="80px" />
        </div>
    </form>
</body>
</html>
