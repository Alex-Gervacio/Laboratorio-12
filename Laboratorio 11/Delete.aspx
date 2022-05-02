<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Laboratorio_11.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Eliminar</h1>
    <p>
        Carne
        <asp:TextBox ID="TextBoxCarne" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonBuscar" runat="server" Text="Buscar" OnClick="ButtonBuscar_Click" />
    </p>
    <p>
        Nombre
        <asp:TextBox ID="TextBoxNombre" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        Apellido
        <asp:TextBox ID="TextBoxApellido" runat="server" Enabled="False"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" OnClick="ButtonEliminar_Click" />
    </p>
</asp:Content>
