using EntidadPermiso;
using EntidadAlumno;
using EntidadNota;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ProyectoEscuela.Front;
using NotasAlumnos;
using static ProyectoEscuela.inicioSesion;
using NegocioAlumnos;

namespace ProyectoEscuela
{
    public partial class RegistrarNota : Form
    {
        public List<Nota> notas = new List<Nota>();
        public List<Nota> lista = new List<Nota>();
        public List <Alumno> alumnos = new List<Alumno> ();
        int i = 0;
        public string materia = "";
        public string curso = "";
        public string division = "";

        public RegistrarNota()
        {
            InitializeComponent();
            lista = GetCursos(GlobalVariables.id);
            
            int tam = lista.Count;
            while (i < tam)
            {
                comboBox1.Items.Add("curso: " + lista[i].Curso + " Division: " + lista[i].Division + " materia: " + lista[i].Materia);
                i++;
            }
        }

        private void btnConfirmarMateria_Click(object sender, EventArgs e)
        {
            

        }
        public static List<Nota> GetCursos(int id)
        {
            List<Nota> lista = new List<Nota>();
            lista = NegocioProfesor.GetPermisos(id);
            int tam = lista.Count;
            int i = 0;
            
            return lista;
        }

        private void refreshGrid()
        {

            bindingSource1.DataSource = null;
            bindingSource1.DataSource = notas;
            dataGridView1.DataSource = bindingSource1;
            int i = 0;
            int tamaño = alumnos.Count;
            while (i < tamaño) 
            {
                comboBox2.Items.Add(alumnos[i].Apellido +" " + alumnos[i].Nombre);
                i++;
            }
        }

        private List<Nota> getnotas()
        {
            int i = comboBox1.SelectedIndex;
            materia = lista[i].Materia;
            curso = lista[i].Curso;
            division = lista[i].Division;
            int idProfesor = GlobalVariables.id;
            MessageBox.Show("materia: " + materia + " .curso: " + curso + " division: " + division + " idprofesor: " + idProfesor);
            return notas = NotasNegocio.GetNotas(curso, division, materia, idProfesor);
        }

        private List <Alumno>GetAlumnos() 
        {
            int i = comboBox1.SelectedIndex;
            materia = lista[i].Materia;
            curso = lista[i].Curso;
            division = lista[i].Division;
            double dni = 0;
            return alumnos = Negocio.NegocioAlumnos.Get(dni, curso, division);
        }


        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            registrar();
        }

        public void registrar()
        {
            int id = comboBox2.SelectedIndex;
            MessageBox.Show(alumnos[i].Nombre);
            NotasNegocio.registrarNotas(materia, alumnos[id].Dni, txtNota.Text, GlobalVariables.id);
            actualizarPorAlumno();
        }

        public void actualizarPorAlumno() 
        {
            int id = comboBox2.SelectedIndex;
            List<Nota> alumno = new List<Nota>();
            alumno = NotasNegocio.GetNotasXAlumno(alumnos[id].Dni, materia, GlobalVariables.id, alumnos[id].Curso, alumnos[id].division);
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = alumno;
            dataGridView1.DataSource = bindingSource1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            i = 0;
            getnotas();
            GetAlumnos();

            if (!string.IsNullOrEmpty(materia) || (!string.IsNullOrEmpty(curso)) || (!string.IsNullOrEmpty(division)))
            {
                if (notas.Count < 1)
                {
                    MessageBox.Show("No se encontraron datos, probablemente no tenga permisos para acceder a datos de esta materia y curso " + GlobalVariables.id);
                }
                else
                {
                    txtNota.Text = notas[i].Calificacion;
                }
            }
            else
            {
                MessageBox.Show("Por favor, complete todos los datos ");
            }
            refreshGrid();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPorAlumno();
        }
       
    }
}
