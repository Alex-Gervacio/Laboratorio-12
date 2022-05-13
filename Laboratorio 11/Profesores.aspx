<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="Laboratorio_11.Profesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Profesores</h1>
    <p>
        Universidad:
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Mesoamericana</asp:ListItem>
            <asp:ListItem>Landivar</asp:ListItem>
            <asp:ListItem>San Carlos</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Nombre:
        <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
    </p>
    <p>
        Apellido:<asp:TextBox ID="TextBoxApellido" runat="server"></asp:TextBox>
    </p>
    <p>
        Profesión:<asp:TextBox ID="TextBoxProfesion" runat="server"></asp:TextBox>
    </p>
    <p>
        ID:<asp:TextBox ID="TextBoxID" runat="server"></asp:TextBox>
    </p>
    <p>
        Dirección:<asp:TextBox ID="TextBoxDireccion" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="ButtonIngresar" runat="server" OnClick="ButtonIngresar_Click" Text="Ingresar Profesor" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
