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
        static List<Administrativo> admin = new List<Administrativo>();
        static string igss;

        protected void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(admin);
            string archivo = Server.MapPath("Administrativos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string archivo = Server.MapPath("Administrativos.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            admin = JsonConvert.DeserializeObject<List<Administrativo>>(json);
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            igss = TextBoxIGSS.Text;
            bool encontrado = false;

            foreach ( var u in admin )
            {
                Administrativo admisAc = admin.Find(c => c.IGSS == igss);
                
                if ( admisAc != null )
                {
                    TextBoxNombre.Text = admisAc.Nombre;
                    TextBoxApellido.Text = admisAc.Apellido;
                    CalendarInicio.SelectedDate = admisAc.fechaIncio;
                    CalendarFin.SelectedDate = admisAc.fechaFin;
                    encontrado = true;
                }    
            }
            if (!encontrado)
            {
                Response.Write("<script>alert('No se econtró el IGSS')</script>");
                igss = "";
                TextBoxIGSS.Text = "";
                TextBoxNombre.Text = "";
                TextBoxApellido.Text = "";
            }

        }

        protected void ButtonActualizar_Click(object sender, EventArgs e)
        {
            foreach ( var u in universidades )
            {
                int admisAc = u.Administrativos.FindIndex(c => c.IGSS == igss);

                if (admisAc > -1)
                {
                    u.Administrativos[admisAc].Apellido = TextBoxApellido.Text;
                    u.Administrativos[admisAc].Nombre = TextBoxNombre.Text;

                    GuardarJson();
                }
            }
        }
    }
}