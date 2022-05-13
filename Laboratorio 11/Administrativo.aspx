<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Administrativo.aspx.cs" Inherits="Laboratorio_11.Administrativo1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Personal Administrativo</h1>
    <p>
        Universidad:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Mesoamericana</asp:ListItem>
            <asp:ListItem>Landivar</asp:ListItem>
            <asp:ListItem>San Carlos</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Nombre:&nbsp; <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
    </p>
    <p>
        Apellido:
        <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
    </p>
    <p>
        IGSS:
        <asp:TextBox ID="TextBoxIGSS" runat="server"></asp:TextBox>
    </p>
    <p>
        Dirección:
        <asp:TextBox ID="TextBoxDirección" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha de incio<asp:Calendar ID="CalendarInicio" runat="server"></asp:Calendar>
    </p>
    <p>
        Fecha de fin<asp:Calendar ID="CalendarFin" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Button ID="ButtonAgregar" runat="server" OnClick="ButtonAgregar_Click" Text="Agregar Personal" />
    </p>
    <p>
        <asp:Button ID="ButtonUniversidad" runat="server" OnClick="ButtonUniversidad_Click" Text="Guardar personal de la Universidad" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
