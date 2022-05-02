using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Newtonsoft.Json;

namespace Laboratorio_11
{
    public partial class Update : System.Web.UI.Page
    {
        static List <Universidad> universidades = new List <Universidad> ();
        static string carne;

        protected void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Universidades.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            universidades = JsonConvert.DeserializeObject<List<Universidad>>(json);
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            carne = TextBoxCarne.Text;
            bool encontrado = false;

            foreach ( var u in universidades )
            {
                Alumno alumnoAc = u.Alumnos.Find(c => c.Carne == carne);
                
                if ( alumnoAc != null )
                {
                    TextBoxNombre.Text = alumnoAc.Nombre;
                    TextBoxApellido.Text = alumnoAc.Apellido;
                    encontrado = true;
                }    
            }
            if (!encontrado)
            {
                Response.Write("<script>alert('No se econtró el Carné')</script>");
                carne = "";
                TextBoxCarne.Text = "";
                TextBoxNombre.Text = "";
                TextBoxApellido.Text = "";
            }

        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
            foreach ( var u in universidades )
            {
                int alumnoAc = u.Alumnos.FindIndex(c => c.Carne == carne);

                if (alumnoAc > -1)
                {
                    u.Alumnos[alumnoAc].Apellido = TextBoxApellido.Text;
                    u.Alumnos[alumnoAc].Nombre = TextBoxNombre.Text;

                    GuardarJson();
                }
            }
        }
    }
}