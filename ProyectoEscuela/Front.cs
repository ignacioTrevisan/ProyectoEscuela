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
using NegocioAlumnos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;

namespace ProyectoEscuela
{
    public partial class Front : Form
    {
        const string usuario = "Luggrenadriana@gmail.com";
        const string password = "jyfi avhd kalc fgqp"; 
        string cargo = GlobalVariables.cargo;
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"/DocumentosPDF";
        public Front()
        {
            InitializeComponent();
            int i = GlobalVariables.id;

            
        }
       

        private void btn_nuevoAlumno_Click(object sender, EventArgs e)
        {
            if ( cargo == "Director")
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
            if (cargo == "profesor")
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
            if (cargo == "Director")
            {
                consulta f = new consulta();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("No posee permisos para acceder a este area ");
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            string error = "";
            StringBuilder mensajeBuilder = new StringBuilder();
            mensajeBuilder.Append(textBox4.Text);
            string de = "nachotizii988@gmail.com";
            string para = Negocio.NegocioAlumnos.getgmail(textBox2.Text);
            string asunto = textBox3.Text;
            DateTime fecha = DateTime.Now.Date;

            enviarCorreo (mensajeBuilder, fecha, de, para, asunto, out error);
        }
        private static void enviarCorreo(StringBuilder mensaje, DateTime fecha, string de, string para, string asunto, out string error) 
        {
            error = "";
            try
            {
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("correo {0:dd/MM/yyyy} a las {0:hh:mm:ss} horas , \n\n", fecha));
                mensaje.Append(Environment.NewLine);
                MailMessage ms = new MailMessage();
                ms.From = new MailAddress(de);
                ms.To.Add(para);
                ms.Subject = asunto;
                ms.Body = mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(usuario, password);
                smtp.EnableSsl = true;
                smtp.Send(ms);
                error = "Correo enviado exitosamente ";
                MessageBox.Show(error);
            }
            catch (Exception ex)    
            {
                error = "Error: "+ ex.Message;
                MessageBox.Show(error);
                return;
            }
        }

    }
}
