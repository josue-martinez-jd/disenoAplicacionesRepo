<%@ Page Title="" Language="C#" MasterPageFile="~/principal.master" AutoEventWireup="true" CodeFile="AdminPrincipal.aspx.cs" Inherits="AdminPrincipal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 30px;
        }
        .auto-style3 {
            height: 30px;
            width: 186px;
        }
        .auto-style4 {
            width: 186px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2> Seccion de Administradores<table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:Button ID="btnActualizarLista" runat="server" Text="Actualizar Lista" Width="144px" OnClick="btnActualizarLista_Click" />
            </td>
            <td class="auto-style2">
                <asp:DropDownList ID="drpEscogeEstudiante" runat="server" AutoPostBack="True" OnSelectedIndexChanged="drpEscogeEstudiante_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="lblEstudiante" runat="server" ></asp:Label>
            </td>
        </tr>
        <!-- 
        <asp:Panel id="pnlAceptar_Rechazar" runat="server"> 
            -->
        <tr>
            <td class="auto-style4">
                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" Width="138px" OnClick="btnAceptar_Click" />
            </td>
            <td>
                <asp:Button ID="btnRechazar" runat="server" Text="Rechazar" OnClick="btnRechazar_Click" />
            </td>
            <td>
                <asp:Label ID="lblAlertaMatricula" runat="server" BorderColor="Red" ForeColor="Red" ></asp:Label>
            </td>
        </tr>
        <!-- 
        </asp:Panel>
       -->
        </table>
    </h2>
</asp:Content>

