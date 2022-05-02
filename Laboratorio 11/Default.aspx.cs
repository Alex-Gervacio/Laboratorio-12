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
    public partial class _Default : Page
    {
        static List<Nota> NotasTemp = new List<Nota>();
        static List<Alumno> AlumnosTemp = new List<Alumno>();
        static List<Universidad> universidades = new List<Universidad>();

        protected void GuardarJson()
        {
            string json = JsonConvert.SerializeObject(universidades);
            string archivo = Server.MapPath("Universidades.json");
            System.IO.File.WriteAllText(archivo, json);
        }
        protected void Cargar()
        {
            string archivo = Server.MapPath("Universidades.json");

            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();

            jsonStream.Close();

            universidades = JsonConvert.DeserializeObject<List<Universidad>>(json);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Cargar();
            }

        }

        protected void ButtonNotas_Click(object sender, EventArgs e)
        {
            Nota nota = new Nota();
            nota.Curso = TextBoxCurso.Text;
            nota.Punteo = Convert.ToInt16(TextBoxPunteo.Text);

            NotasTemp.Add(nota);
            GridView1.DataSource = NotasTemp;
            GridView1.DataBind();
        }

        protected void ButtonIngresarAlumno_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = TextBoxNombre.Text;
            alumno.Apellido = TextBoxApellido.Text;
            alumno.Carne = TextBoxCarne.Text;
            alumno.Notas = NotasTemp.ToArray().ToList();

            AlumnosTemp.Add(alumno);

            NotasTemp.Clear();
        }

        protected void ButtonUniversidad_Click(object sender, EventArgs e)
        {
            Universidad universidad = new Universidad();
            universidad.NombreU = DropDownList1.SelectedValue;
            universidad.Alumnos = AlumnosTemp.ToArray().ToList();

            universidades.Add(universidad);

            GuardarJson();

            AlumnosTemp.Clear();
        }
    }
}