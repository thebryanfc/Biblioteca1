using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace Biblioteca1.Libros
{
    public partial class AgregarLib : System.Web.UI.Page
    {
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            int idDeLibro = int.Parse(textBox1.Text);
            string nombreDelLibro = textBox2.Text;
            string editorial = textBox3.Text;
            string autor = textBox4.Text;
            string genero = textBox5.Text;
            int numeroDePaginas = int.Parse(textBox6.Text);

            string connectionString = "Server=DESKTOP-IQ9P5M3\\SQLEXPRESS;Database=control_biblioteca;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO libros(codigo_lib,nom,editorial,autor,genero,num_pag) VALUES (@IDDeLibro, @NombreDelLibro, @Editorial, @Autor, @Genero, @NumeroDePaginas)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IDDeLibro", idDeLibro);
                    command.Parameters.AddWithValue("@NombreDelLibro", nombreDelLibro);
                    command.Parameters.AddWithValue("@Editorial", editorial);
                    command.Parameters.AddWithValue("@Autor", autor);
                    command.Parameters.AddWithValue("@Genero", genero);
                    command.Parameters.AddWithValue("@NumeroDePaginas", numeroDePaginas);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        Response.Write("<script>alert('Libro insertado con éxito.');</script>");
                    }
                    catch (Exception ex)
                    {
                        Response.Write("<script>alert('Error al insertar el libro: " + ex.Message + "');</script>");
                    }

                }
            }
        }
    }
}