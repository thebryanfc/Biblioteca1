﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Biblioteca1.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Menu Principal</title>
    <link rel="stylesheet" href="Elementos/Agregar.css">
    <script src="Elementos/Menu.js" defer></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav id='menu'>
                <input type='checkbox' id='responsive-menu' onclick='updatemenu()'><label></label>
                <ul>
                    <li><a class='dropdown-arrow' href=''>Inicio</a>
                    <li><a class='dropdown-arrow' href=''>Libros</a>
                        <ul class='sub-menus'>
                            <li><a href="AgregarLib.aspx">Agregar</a></li>
                            <li><a href="ListarLib.aspx">Listar</a></li>
                            <li><a href="ConsultarLib.aspx">Consultar</a></li>
                            <li><a href="ModificarLib.aspx">Modificar</a></li>
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
    </form>
</body>
</html>
