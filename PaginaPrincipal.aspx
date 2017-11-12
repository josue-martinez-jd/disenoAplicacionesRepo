<%@ Page Title="" Language="C#" MasterPageFile="~/principal.master" AutoEventWireup="true" CodeFile="PaginaPrincipal.aspx.cs" Inherits="PaginaPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 58%;
        }
        .auto-style2 {
            width: 65px;
        }
        .auto-style3 {
            width: 166px;
        }
        .auto-style4 {
            width: 130px;
        }
        .auto-style5 {
            width: 8px;
        }
        .auto-style6 {
            width: 122px;
        }
        .auto-style7 {
            width: 65px;
            height: 23px;
        }
        .auto-style8 {
            width: 166px;
            height: 23px;
        }
        .auto-style9 {
            width: 8px;
            height: 23px;
        }
        .auto-style10 {
            width: 130px;
            height: 23px;
        }
        .auto-style11 {
            width: 122px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Seccion de Estudiantes </h2>
    <asp:Panel id="pnlEstudiantes" runat="server">
         <table class="auto-style1">
        <tr>
            <td colspan="2" class="auto-style10">
                </td>
            <td class="auto-style11">
            </td>
            <td class="auto-style9">
                <asp:Button ID="btnCerrarSesion" runat="server" Text="Cerrar Sesion" OnClick="btnCerrarSesion_Click" />
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td colspan="2" class="auto-style4">
                Usuario:</td>
            <td class="auto-style6">
                <asp:Label ID="lblUserLogged" runat="server" Text=""></asp:Label>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                Crear Materia:
            </td>
            <td class="auto-style3" colspan="2">
                <asp:TextBox ID="txtMateria" runat="server" Width="158px"></asp:TextBox>
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnGuardarMateria" runat="server" Text="Guardar Materia" OnClick="btnGuardarMateria_Click" Width="156px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="btnEscogerMateria" runat="server" Text="Escoger Materia" Width="114px" OnClick="btnEscogerMateria_Click" Height="39px" />
            </td>
            <td class="auto-style3" colspan="2">
                <asp:DropDownList ID="drpEscogeMateria"  Width="158px" runat="server" AutoPostBack="True">
                </asp:DropDownList>
            </td>
            <td class="auto-style5">
                <asp:Button ID="btnGuardarEscogido" runat="server" Text="Guardar Escogida" OnClick="btnGuardarEscogido_Click" />
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lblNombres" runat="server" ></asp:Label>
            </td>
            <td class="auto-style8" colspan="2">
                <asp:Label ID="lblApellidos" runat="server" ></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:Label ID="lblCorreos" runat="server" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Button ID="btnCrearMatricula" runat="server" Text="Crear Matricula" OnClick="btnCrearMatricula_Click" />
            </td>
            <td class="auto-style8" colspan="2">
                <asp:Button ID="btnNoCrearMatricula" runat="server" Text="No Crear Matricula" OnClick="btnNoCrearMatricula_Click" />
            </td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
    </table>
    </asp:Panel>
   

</asp:Content>

