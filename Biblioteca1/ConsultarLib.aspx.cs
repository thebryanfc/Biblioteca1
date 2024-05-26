using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Biblioteca1.Libros
{
    public partial class ConsultarLib : System.Web.UI.Page
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
                        // Abrir la conexión
                        connection.Open();

                        // Llenar el DataTable con los resultados de la consulta
                        adapter.Fill(dataTable);

                        // Verificar si se encontraron filas
                        if (dataTable.Rows.Count > 0)
                        {
                            // Si se encontraron filas, enlazar el DataTable a la GridView
                            gridView1.DataSource = dataTable;
                            gridView1.DataBind();
                        }
                        else
                        {
                            // Si no se encontraron filas, mostrar un mensaje
                            Response.Write("<script>alert('No se encontraron libros.');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Manejar cualquier error que ocurra durante la ejecución de la consulta
                        Response.Write("<script>alert('Error al consultar los libros: " + ex.Message + "');</script>");
                    }
                }
            }
        }
    }
}
