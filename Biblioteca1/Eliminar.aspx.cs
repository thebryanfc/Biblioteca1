using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace Biblioteca1.Libros
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void ButtonConsultar_Click(object sender, EventArgs e)
        {
            int idDeLibro;
            if (int.TryParse(textBoxID1.Text, out idDeLibro))
            {
                ConsultarLibro(idDeLibro);
            }
            else
            {
                Response.Write("Por favor, ingrese un ID de libro válido.");
            }
        }

        private void ConsultarLibro(int idDeLibro)
        {
            // Cadena de conexión a tu base de datos SQL Server
            string connectionString = "Server=DESKTOP-IQ9P5M3\\SQLEXPRESS;Database=control_biblioteca;Trusted_Connection=True;";

            // Consulta SQL para seleccionar el libro por ID
            string query = "SELECT codigo_lib, nom, editorial, autor, genero, num_pag FROM libros WHERE codigo_lib = @IDDeLibro";

            // Crear una conexión SQL
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Crear un comando SQL con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Agregar el parámetro IDDeLibro a la consulta
                    command.Parameters.AddWithValue("@IDDeLibro", idDeLibro);

                    // Crear un adaptador SQL para ejecutar el comando y llenar un DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        
                        connection.Open();
                        adapter.Fill(dataTable);                   
                        if (dataTable.Rows.Count > 0)
                        {
                            gridView1.DataSource = dataTable;
                            gridView1.DataBind();
                        }
                        else
                        {
                            Response.Write("<script>alert('No se encontraron libros.');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error al consultar los libros: " + ex.Message + "');</script>");
                    }
                }
            }
        }
        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-IQ9P5M3\\SQLEXPRESS;Database=control_biblioteca;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = "DELETE FROM libros WHERE codigo_lib = @codigo_lib";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@codigo_lib", textBoxID1.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();

                    // Actualizar GridView después de eliminar
                    gridView1.DataSource = null;
                    gridView1.DataBind();
                    Response.Write("<script>alert('Libro Se Elimino Correctamente.');</script>");
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('Error al consultar los libros: " + ex.Message + "');</script>");
                }
            }
        }
    }
}