using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio_11
{
    public class Administrativo: Persona
    {
        public string IGSS { get; set; }
        public string Profesion { get; set; }
        public DateTime fechaIncio { get; set; }
        public DateTime fechaFin { get; set; }
    }
}