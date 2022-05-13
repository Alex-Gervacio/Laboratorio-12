using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_11
{
    public class Universidad
    {
        public string NombreU { get; set; }
        public string Sede { get; set; }

       public List<Alumno> Alumnos { get; set; }
       public List<Profesor> Profesores { get; set; }
       public List<Administrativo> Administrativos { get; set; }
    }
}