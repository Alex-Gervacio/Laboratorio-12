<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="Laboratorio_11.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Actualizar</h1>
    <p>
        Ingrese IGSS
        <asp:TextBox ID="TextBoxIGSS" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Buscar Personal" />
    </p>
    <p>
        Nombre <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
    </p>
    <p>
        Apellido
        <asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
    </p>
    <p>
        Fecha de incio de labores
        <asp:Calendar ID="CalendarInicio" runat="server"></asp:Calendar>
    </p>
    <p>
        Fecha de fin de labores
        <asp:Calendar ID="CalendarFin" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Button ID="ButtonActualizar" runat="server" Text="Actualizar Datos" OnClick="ButtonActualizar_Click" />
    </p>
</asp:Content>
