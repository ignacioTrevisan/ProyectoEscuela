using EntidadAlumno;
using EntidadNota;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatosNotas
{
    public class NotasDatos
    {
        public static List<Nota> GetNotas(string curso, string division, string materia, int idProfesor)
        {
            List<Nota> notasLista = new List<Nota>();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                SqlCommand command = new SqlCommand("GetNotas", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@año", curso);
                command.Parameters.AddWithValue("@division", division);
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("idProfesor", idProfesor);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        Nota n = new Nota();
                        n.Nombre = Convert.ToString(reader["nombre"]);
                        n.Apellido = Convert.ToString(reader["apellido"]);
                        n.Materia = Convert.ToString(reader["materia"]);
                        n.Dni = Convert.ToString(reader["dni"]);
                        n.Curso = Convert.ToString(reader["año"]);
                        n.Division = Convert.ToString(reader["division"]);
                        n.Calificacion = Convert.ToString(reader["nota"]);
                        notasLista.Add(n);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return notasLista;
        }

        public static List<Nota> GetNotasXAlumno(string dni, string materia, int idProfesor, string curso, string division)
        {
            List<Nota> alumno = new List<Nota>();
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))

            {
                SqlCommand command = new SqlCommand("GetNotasXAlumno", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@dni", dni);
                command.Parameters.AddWithValue("@materia", materia);
                command.Parameters.AddWithValue("@idprofesor", idProfesor);
                command.Parameters.AddWithValue("@curso", curso);
                command.Parameters.AddWithValue("@division", division);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        Nota n = new Nota();
                        n.Dni = Convert.ToString(reader["DniAlumno"]);
                        n.Nombre = Convert.ToString(reader["nombre"]);
                        n.Apellido = Convert.ToString(reader["apellido"]);
                        n.Materia = Convert.ToString(reader["Materia"]);
                        n.Curso = Convert.ToString(reader["Curso"]);
                        n.Division = Convert.ToString(reader["Division"]);
                        n.Calificacion = Convert.ToString(reader["nota"]);
                        n.comentario = Convert.ToString(reader["Comentario"]);
                        alumno.Add(n);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return alumno;
        
        }

        public static int registroNotas(string materia, string alumno, string nota, int profesor)
        {
            int idAlumnoCreado = 0;
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))

            {

                SqlCommand command = new SqlCommand("IngresarNotas", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@dni", Convert.ToString(alumno));
                command.Parameters.AddWithValue("@materia", Convert.ToString(materia));
                command.Parameters.AddWithValue("@nota", Convert.ToString(nota));
                command.Parameters.AddWithValue("@idprofesor", (profesor));

                try
                {

                    connection.Open();
                    idAlumnoCreado = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();
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
