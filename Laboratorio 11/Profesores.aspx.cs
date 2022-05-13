using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.IO;

namespace Laboratorio_11
{
    public partial class Profesores : System.Web.UI.Page
    {
        static List<Profesor> profesores = new List<Profesor>();

        protected void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(profesores);
            string archivo = Server.MapPath("Profesores.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Cargar()
        {
            string archivo = Server.MapPath("Profesores.json");

            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();

            jsonStream.Close();
            if (json.Length >0)
            {
                profesores = JsonConvert.DeserializeObject<List<Profesor>>(json);
            }
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar();
            }
        }

        protected void ButtonIngresar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            profesor.Nombre = TextBoxNombre.Text;
            profesor.Apellido = TextBoxApellido.Text;
            profesor.TituloUniversitario = TextBoxProfesion.Text;
            profesor.IDprof = TextBoxID.Text;
            profesor.Direccion = TextBoxDireccion.Text;

            profesores.Add(profesor);

            GuardarJson();
        }


    }
}