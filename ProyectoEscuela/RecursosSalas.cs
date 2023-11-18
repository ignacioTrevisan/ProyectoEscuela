using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadRecursosSalas;
using Negocio;
using NegocioAlumnos;
using static ProyectoEscuela.inicioSesion;

namespace ProyectoEscuela
{
    public partial class RecursosSalas : Form
    {
        List<ReservasRecursosSalas> lista = new List<ReservasRecursosSalas>();
        public RecursosSalas()
        {
            InitializeComponent();
            getRecursos();
            getdos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RecursosSalas_Load(object sender, EventArgs e)
        {

            lista = NegociosRecursosSalas.GetReservas(lista);
            refreshgrid();
        }
        private void refreshgrid()
        {
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = lista;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string recurso = comboBox2.Text;
            string estado = textBox1.Text;
            DateTime fecha = dateTimePicker1.Value.Date;
            string fechados = Convert.ToString(fecha);
            string id = Convert.ToString(GlobalVariables.id);
            string comentarios = textBox3.Text;
            string tiempoReserva = textBox2.Text;
            if (comentarios == "") 
            {
                comentarios = "--";
            }
            if (estado == "") 
            {
                estado = "--";
            }
            if (!string.IsNullOrEmpty(recurso) && !string.IsNullOrEmpty(tiempoReserva))
            {
                NegociosRecursosSalas.RegistrarReservas(recurso, fechados, estado, comentarios, id, tiempoReserva);
                dataGridView1.Rows.Clear();
                lista = NegociosRecursosSalas.GetReservas(lista);
                refreshgrid();
            }
            else 
            {
                MessageBox.Show("Complete todas las casillas, por favor. ");
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void getdos()
        {
            int i = 0;
            List<string> lista = new List<string>();
            lista = getRecursos();
            while (i < lista.Count)
            {
                comboBox2.Items.Add(lista[i]);
                i++;
            }

        }
        public List<string> getRecursos() 
        {
           
            List<string> lista = new List<string>();
            
            return lista = NegociosRecursosSalas.GetRecursos();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox4.Text);
            int a = NegociosRecursosSalas.Eliminar(id);
         
            dataGridView1.Rows.Clear();
            lista = NegociosRecursosSalas.GetReservas(lista);
            refreshgrid();
        }
    }
}
