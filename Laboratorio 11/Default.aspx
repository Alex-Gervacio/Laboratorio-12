<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_11._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Alumnos</h1>
        <p>Univerisidad<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Mesoamericana</asp:ListItem>
            <asp:ListItem>Landivar</asp:ListItem>
            <asp:ListItem>San Carlos</asp:ListItem>
            <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>Alumno</p>
        <p>Nombre<asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </p>
        <p>Apellido<asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
        </p>
        <p>Carne<asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
        </p>
        <p>Notas</p>
        <p>Curso<asp:TextBox ID="TextBoxCurso" runat="server"></asp:TextBox>
        </p>
        <p>Punteo<asp:TextBox ID="TextBoxPunteo" runat="server"></asp:TextBox>
            <asp:Button ID="ButtonNotas" runat="server" OnClick="ButtonNotas_Click" Text="Ingresar notas del alumno" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </p>
        <p>
            <asp:Button ID="ButtonIngresarAlumno" runat="server" OnClick="ButtonIngresarAlumno_Click" Text="Ingresar alumno a la Universidad" />
        </p>
        <p>
            <asp:Button ID="ButtonUniversidad" runat="server" OnClick="ButtonUniversidad_Click" Text="Guardar Universidad" />
        </p>
    </div>

</asp:Content>
