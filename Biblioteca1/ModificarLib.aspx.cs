using System;
using System.Data.SqlClient;
using System.Web.UI;

namespace Biblioteca1.Libros
{
    public partial class ModificarLib : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // No se realiza ninguna acción en el Page_Load por el momento.
        }

        protected void ButtonConsultar_Click(object sender, EventArgs e)
        {
            int idDeLibro;
            if (int.TryParse(textBox1.Text, out idDeLibro))
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
            string connectionString = "Server=DESKTOP-IQ9P5M3\\SQLEXPRESS;Database=control_biblioteca;Trusted_Connection=True;";
            string query = "SELECT nom, editorial, autor, genero, num_pag FROM libros WHERE codigo_lib = @IDDeLibro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDDeLibro", idDeLibro);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            textBox2.Text = reader["nom"].ToString();
                            textBox3.Text = reader["editorial"].ToString();
                            textBox4.Text = reader["autor"].ToString();
                            textBox5.Text = reader["genero"].ToString();
                            textBox6.Text = reader["num_pag"].ToString();
                        }
                        else
                        {
                            Response.Write("No se encontró un libro con el ID especificado.");
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Response.Write("Error al consultar el libro: " + ex.Message);
                    }
                }
            }
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            int idDeLibro;
            if (int.TryParse(textBox1.Text, out idDeLibro))
            {
                string nombreDelLibro = textBox2.Text;
                string editorial = textBox3.Text;
                string autor = textBox4.Text;
                string genero = textBox5.Text;
                int numPaginas;
                if (int.TryParse(textBox6.Text, out numPaginas))
                {
                    ModificarLibro(idDeLibro, nombreDelLibro, editorial, autor, genero, numPaginas);
                }
                else
                {
                    Response.Write("Por favor, ingrese un número válido para el número de páginas.");
                }
            }
            else
            {
                Response.Write("Por favor, ingrese un ID de libro válido.");
            }
        }

        private void ModificarLibro(int idDeLibro, string nombreDelLibro, string editorial, string autor, string genero, int numPaginas)
        {
            string connectionString = "Server=DESKTOP-IQ9P5M3\\SQLEXPRESS;Database=control_biblioteca;Trusted_Connection=True;";
            string query = "UPDATE libros SET nom = @NombreDelLibro, editorial = @Editorial, autor = @Autor, genero = @Genero, num_pag = @NumPaginas WHERE codigo_lib = @IDDeLibro";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDDeLibro", idDeLibro);
                    command.Parameters.AddWithValue("@NombreDelLibro", nombreDelLibro);
                    command.Parameters.AddWithValue("@Editorial", editorial);
                    command.Parameters.AddWithValue("@Autor", autor);
                    command.Parameters.AddWithValue("@Genero", genero);
                    command.Parameters.AddWithValue("@NumPaginas", numPaginas);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Response.Write("<script>alert('El libro ha sido modificado exitosamente.');</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('No se pudo modificar el libro.');</script>");
                        }
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error al modificar el libro: " + ex.Message + "');</script>");
                    }
                    finally
                    {
                        connection.Close();
                    }

                }
            }
        }
    }
}
