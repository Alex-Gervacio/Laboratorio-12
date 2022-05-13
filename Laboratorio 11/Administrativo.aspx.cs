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
    public partial class Administrativo1 : System.Web.UI.Page
    {
        static List<Administrativo> admin = new List<Administrativo>();
        static List<Universidad> universidades = new List<Universidad>();

        protected void GuardarJson ()
        {
            string json = JsonConvert.SerializeObject(admin);
            string archivo = Server.MapPath("Administrativos.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Cargar()
        {
            string archivo = Server.MapPath("Administrativos.json");

            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();

            jsonStream.Close();
            if (json.Length >0)
            {
                admin = JsonConvert.DeserializeObject<List<Administrativo>>(json);
            }

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar();
            }
        }

        protected void ButtonAgregar_Click(object sender, EventArgs e)
        {
            Administrativo administrativo = new Administrativo();
            administrativo.Nombre = TextBoxNombre.Text;
            administrativo.Apellido = TextBoxApellido.Text;
            administrativo.IGSS = TextBoxIGSS.Text;
            administrativo.Direccion = TextBoxDirección.Text;
            administrativo.fechaIncio = CalendarInicio.SelectedDate;
            administrativo.fechaFin = CalendarFin.SelectedDate;

            admin.Add(administrativo);
            GuardarJson();
        }

        protected void ButtonUniversidad_Click(object sender, EventArgs e)
        {
            Universidad universidad = new Universidad();
            universidad.NombreU = DropDownList1.SelectedValue;
            universidad.Administrativos = admin.ToArray().ToList();

            universidades.Add(universidad);
            GuardarJson();
            admin.Clear();
        }
    }
}