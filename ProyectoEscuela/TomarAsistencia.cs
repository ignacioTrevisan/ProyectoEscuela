using EntidadAlumno;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoEscuela.Front;
using NegocioAlumnos;



namespace ProyectoEscuela
{
    public partial class TomarAsistencia : Form
    {
        public int id = 1;
        public TomarAsistencia()
        {
            InitializeComponent();
            siguiente();
        }

        private void btn_presente_Click(object sender, EventArgs e)
        {
            siguiente();
        }
        public void siguiente()
        {

            string query = "SELECT COUNT(*) FROM Alumnos";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                int count = (int)cmd.ExecuteScalar();
            
                connection.Close();

                if (id <= count)
                {
                    string traerdni = "SELECT DNI FROM Alumnos WHERE id = @id";
                    string traernombre = "SELECT NOMBRE FROM Alumnos WHERE id = @id";
                    
                    string conStringdos = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
                    using (SqlConnection connectiondos = new SqlConnection(conStringdos))
                    {
                        connectiondos.Open();
                        SqlCommand cmddos = new SqlCommand(traernombre, connectiondos);
                        SqlCommand cmdtres = new SqlCommand(traerdni, connectiondos);
                        cmddos.Parameters.AddWithValue("@id", id);
                        cmdtres.Parameters.AddWithValue("@id", id);
                        string nombres = (string)cmddos.ExecuteScalar();
                        double dni = (double)cmdtres.ExecuteScalar();
                        label1.Text = Convert.ToString(dni);
                        lbl_alumno.Text = nombres;
                        id = id + 1;
                        connectiondos.Close();
                    }
                }
                else 
                {
                    MessageBox.Show("No hay alumno ");
                }
            }
        }

        private void btn_buscarAlumno_Click(object sender, EventArgs e)
        {
            string dni = textBox1.Text;
            buscar(dni);
        }
        public void buscar(string dni) 
        {
            Alumno a = new Alumno();
            a.Dni = Convert.ToString(dni);
            int idEmp = Negocio.NegocioAlumnos.buscar(a);
            lbl_alumno.Text = a.Nombre;
            label1.Text =   a.Dni;
            id = a.Id+1;
        }
        private Boolean verificarRegistro()
        {
            string query = "SELECT COUNT(*) FROM asistencias WHERE DNI = @dni AND fecha = @fecha";
            string conString = System.Configuration.ConfigurationManager.ConnectionStrings["conexionDB"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@dni", label1.Text);
                string fecha = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                cmd.Parameters.AddWithValue("@fecha", fecha);
                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void btn_prese_Click(object sender, EventArgs e)
        {
            string estado = "presente";
            DateTime fechacompleta = dateTimePicker1.Value.Date;
            string fecha = Convert.ToString(fechacompleta);
            string dni = label1.Text;
            registrarestado(estado, fecha, dni);
            
        }

        private void registrarestado(string estado, string fecha, string dni)
        {

            Negocio.NegocioAlumnos.registrarEstado(estado, fecha, dni);
            MessageBox.Show(dni + " fue registrado como " + estado + " el dia " + fecha + " exitosamente");

        }

        private void btn_ausente_Click(object sender, EventArgs e)
        {
            string estado = "ausente";
            string dni = label1.Text;
            DateTime fechacompleta = dateTimePicker1.Value.Date;
            string fecha = Convert.ToString(fechacompleta);
            registrarestado(estado, fecha, dni);
            
        }
    }
}
