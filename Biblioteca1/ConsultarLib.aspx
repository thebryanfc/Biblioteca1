<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultarLib.aspx.cs" Inherits="Biblioteca1.Libros.ConsultarLib" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consultar Libro</title>
    <link rel="stylesheet" href="Elementos/Consul.css">
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
        <br /><br />
        <div class="Consul">
            <h2>Consultar Libro</h2>
            <label for="textBoxID1">ID De Libro</label>
            <asp:TextBox ID="textBoxID1" runat="server" required="required"></asp:TextBox>
            <asp:Button ID="buttonConsultar" runat="server" Text="Consultar" OnClick="ButtonConsultar_Click" />
            <br />
            <asp:GridView ID="gridView1" runat="server" AutoGenerateColumns="False" EmptyDataText="No se encontraron libros.">
                <Columns>
                    <asp:BoundField DataField="codigo_lib" HeaderText="Código de Libro" />
                    <asp:BoundField DataField="nom" HeaderText="Nombre del Libro" />
                    <asp:BoundField DataField="editorial" HeaderText="Editorial" />
                    <asp:BoundField DataField="autor" HeaderText="Autor" />
                    <asp:BoundField DataField="genero" HeaderText="Género" />
                    <asp:BoundField DataField="num_pag" HeaderText="Número de Páginas" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
