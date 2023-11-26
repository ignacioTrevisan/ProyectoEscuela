using EntidadNota;
using EntidadProfesor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DatosAlumnos
{
    public class datosProfesores
    {

        public static int buscarDirectivo(string dni, string pass)
        {
            string query = "SELECT COUNT(*) FROM directivos WHERE cargo = 'director' AND DNI = @dni AND contraseña=@pass";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@pass", pass);
                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }


        }

        public static void eliminar(string text)
        {
            int idAlumnoCreado = 1;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            string query = "DELETE FROM DIRECTIVOS WHERE DNI = @dni";

            using (SqlConnection connection = new SqlConnection(conString))
            {
              
                SqlCommand cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@dni", text);
                try
                {
                    connection.Open();
                    idAlumnoCreado = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static List<Nota> GetPermisos(int id)
        {
            List<Nota> lista = new List<Nota>();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("verificarPermisos", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@idProfesor", id);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Nota n = new Nota();
                    n.Materia = Convert.ToString(reader["materia"]);
                    n.Curso = Convert.ToString(reader["año"]);
                    n.Division = Convert.ToString(reader["division"]);
                    lista.Add(n);
                }
                reader.Close();
                con.Close();
                return lista;
            }
        }

        public static profesor getProfesor(string dni)
        {
            profesor p = new profesor();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                SqlCommand command = new SqlCommand("getProfesor", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@dni", dni);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {

                    p.Dni = Convert.ToString(reader["dni"]);
                    p.Nombre = Convert.ToString(reader["nombre"]);
                    p.Apellido = Convert.ToString(reader["apellido"]);
                    p.FechaNacimiento = Convert.ToDateTime(reader["fechadenacimiento"]);
                    p.Email = Convert.ToString(reader["email"]);
                    p.Domicilio = Convert.ToString(reader["domicilio"]);
                    p.Telefono = Convert.ToString(reader["telefono"]);

                }
                reader.Close();
                con.Close();
                return p;
            }
        }

        public static int insertar(profesor p)
        {
            int idAlumnoCreado = 0;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("insertarProfesor", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", p.Nombre);
                command.Parameters.AddWithValue("@apellido", p.Apellido);
                command.Parameters.AddWithValue("@dni", p.Dni);
                command.Parameters.AddWithValue("@fechaNacimiento", p.FechaNacimiento);
                command.Parameters.AddWithValue("@email", p.Email);
                command.Parameters.AddWithValue("@domicilio", p.Domicilio);
                command.Parameters.AddWithValue("@Telefono", p.Telefono);
                command.Parameters.AddWithValue("@contraseña", p.contraseña);
                command.Parameters.AddWithValue("@cargo", "profesor");
                try
                {
                    con.Open();
                    idAlumnoCreado = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception)
                {
                    throw;
                }

                return idAlumnoCreado;
            }

        }

        public static int modificar(profesor p)
        {
            int idAlumnoCreado = 0;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection con = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("ModificarProfesor", con);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@nombre", p.Nombre);
                command.Parameters.AddWithValue("@apellido", p.Apellido);
                command.Parameters.AddWithValue("@dni", p.Dni);
                command.Parameters.AddWithValue("@fechaNacimiento", p.FechaNacimiento);
                command.Parameters.AddWithValue("@email", p.Email);
                command.Parameters.AddWithValue("@domicilio", p.Domicilio);
                command.Parameters.AddWithValue("@Telefono", p.Telefono);
                command.Parameters.AddWithValue("@contraseña", p.contraseña);
                command.Parameters.AddWithValue("@cargo", "Profesor");
                try
                {
                    con.Open();
                    idAlumnoCreado = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception)
                {
                    throw;
                }

                return idAlumnoCreado;
            }
        }


    }
}
