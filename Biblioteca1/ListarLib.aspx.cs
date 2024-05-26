using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca1.Libros
{
    public partial class ListarLib : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }

        private void BindGrid()
        {
            // Cadena de conexión a tu base de datos SQL Server
            string connectionString = "Server=DESKTOP-IQ9P5M3\\SQLEXPRESS;Database=control_biblioteca;Trusted_Connection=True;";

            // Consulta SQL para seleccionar todos los libros
            string query = "SELECT codigo_lib, nom, editorial, autor, genero, num_pag FROM libros";

            // Crear una conexión SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear un comando SQL con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Crear un adaptador SQL para ejecutar el comando y llenar un DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        // Abrir la conexión
                        connection.Open();
                        // Llenar el DataTable con los resultados de la consulta
                        adapter.Fill(dataTable);

                        // Verificar si se encontraron filas
                        if (dataTable.Rows.Count > 0)
                        {
                            // Si se encontraron filas, enlazar el DataTable a la GridView
                            gridView.DataSource = dataTable;
                            gridView.DataBind();
                        }
                        else
                        {
                            // Si no se encontraron filas, mostrar un mensaje
                            Response.Write("No se encontraron libros.");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la ejecución de la consulta
                        Response.Write("Error al consultar los libros: " + ex.Message);
                    }
                }
            }
        }
    }
}