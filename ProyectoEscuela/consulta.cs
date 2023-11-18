using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NegocioAlumnos;
using EntidadAlumno;
using static Negocio.NegocioAlumnos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoEscuela
{
    public partial class consulta : Form
    {
        List<Alumno> ListaAlumnos = new List<Alumno>();
        public consulta()
        {
            InitializeComponent();
            buscarAlumnos(0);
        }

     
        private void mostrarAlumnos()
        {
            DataTable dt = Negocio.NegocioAlumnos.buscarinasistencias();
            dataGridView1.DataSource = dt;
            
        } 

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // verificar si se hizo clic en una celda válida
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.Value != null) // verificar si la celda tiene algún valor
                {
                    string nombre = cell.Value.ToString();
                    MessageBox.Show("Hola " + nombre + "!");
                }
            }
        }

        
        private void buscarAlumnos(double dni)
        {
           
            string curso = txtCurso.Text;
            string division = txtDivision.Text;


            if (string.IsNullOrEmpty(curso) || string.IsNullOrEmpty(division))
            {
                ListaAlumnos = Negocio.NegocioAlumnos.Get(dni);
            }
            else
            {
                ListaAlumnos = Negocio.NegocioAlumnos.Get(dni, curso, division);
            }

            refreshgrid();

        }
        private void refreshgrid()
        {
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = ListaAlumnos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDni.Text))
            {
                double dni = Convert.ToDouble(txtDni.Text);
                buscarAlumnos(dni);
            }
            else
            {
                double dni = 0;
                buscarAlumnos(dni);
            }
        }
    }
}
