using EntidadProfesor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatosAlumnos;
using EntidadNota;

namespace NegocioAlumnos
{
    public class NegocioProfesor
    {
        public static int insertar(profesor p)
        {
            return datosProfesores.insertar(p);
        }
        public static int modificar(profesor p) 
        {

            return datosProfesores.modificar(p);
        }

        public static int buscarDirectivo(string dni, string pass) {
            int bol = datosProfesores.buscarDirectivo(dni, pass);
            return bol;
        }
        public static List<Nota> GetPermisos(int id) 
        {
            List<Nota> lista = new List<Nota>();
            return datosProfesores.GetPermisos(id);
        }
        public static profesor getProfesor(string dni) 
        {
            return datosProfesores.getProfesor(dni);
        }

        public static void eliminar(string text)
        {
            datosProfesores.eliminar(text);
        }
    }
}
