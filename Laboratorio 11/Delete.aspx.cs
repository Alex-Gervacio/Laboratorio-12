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
    public partial class Delete : System.Web.UI.Page
    {
        static List<Universidad> universidades = new List<Universidad>();
        static List<Profesor> profesor = new List<Profesor>();
        static string id;

        protected void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Profesores.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Profesores.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            profesor = JsonConvert.DeserializeObject<List<Profesor>>(json);
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            id = TextBoxID.Text;
            bool encontrado = false;

            foreach (var u in profesor)
            {
                Profesor profEl = profesor.Find(c => c.IDprof == id);

                if (profEl != null)
                {
                    TextBoxNombre.Text = profEl.Nombre;
                    TextBoxApellido.Text = profEl.Apellido;
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Response.Write("<script>alert('No se econtró el Carné')</script>");
                id = "";
                TextBoxID.Text = "";
                TextBoxNombre.Text = "";
                TextBoxApellido.Text = "";
            }
        }

        protected void ButtonEliminar_Click(object sender, EventArgs e)
        {
            foreach (var u in universidades)
            {
                Profesor profEl = profesor.Find(c => c.IDprof == id);

                if (profEl == null)
                {
                    u.Profesores.Remove(profEl);
                }
            }
            GuardarJson();
        }
    }
}