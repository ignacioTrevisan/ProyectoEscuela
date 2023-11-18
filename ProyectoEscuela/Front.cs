using EntidadPermiso;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadProfesor;
using NotasAlumnos;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static ProyectoEscuela.inicioSesion;

namespace ProyectoEscuela
{
    public partial class Front : Form
    {
        string cargo = "";
        public Front()
        {
            InitializeComponent();
            
             
        }
       

        private void btn_nuevoAlumno_Click(object sender, EventArgs e)
        {
            if (cargo == "")
            {
                NuevoAlumno formulario = new NuevoAlumno();
                formulario.ShowDialog();
            }
            else 
            {
                MessageBox.Show("No posee permisos para acceder a este area ");
            }
        }

        private void btn_asistencias_Click(object sender, EventArgs e)
        {
            if (cargo == "")
            {
                TomarAsistencia formulario = new TomarAsistencia();
                formulario.ShowDialog();
            }
            else 
            {
                MessageBox.Show("No posee permisos para acceder a este area ");
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            consulta f = new consulta();
            f.ShowDialog();
        }

        private void Front_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarNota formulario = new RegistrarNota();
            formulario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RecursosSalas formulario = new RecursosSalas();
            formulario.ShowDialog();
        }
    }
}
