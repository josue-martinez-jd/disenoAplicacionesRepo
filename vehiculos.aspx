<%@ Page Title="" Language="C#" MasterPageFile="~/principal.master" AutoEventWireup="true" CodeFile="vehiculos.aspx.cs" Inherits="vehiculos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="InformacionTransporte" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table runat="server">
        <tr>
            <td>Punto Salida:<asp:TextBox ID="txtPuntoSalida" runat="server"></asp:TextBox></td>
            <td>Punto LLegada:<asp:TextBox ID="txtPuntoLLegada" runat="server"></asp:TextBox></td> 
            <td>Distancia (KM)<asp:TextBox ID="txtDistancia" type="number" runat="server"></asp:TextBox></td>
        </tr>
         <tr>
            <td>Dimensiones Carga(L):<asp:TextBox ID="txtDimensionesCarga" type="number" runat="server"></asp:TextBox></td>
            <td>Peso Carga (Kg)<asp:TextBox ID="txtPesoCarga" type="number" runat="server"></asp:TextBox></td> 
        </tr>
        <tr>
            <td><asp:Button ID="txtCalculaCosto" Text="Calcular" runat="server" OnClick="txtCalculaCosto_Click"></asp:Button></td>
        </tr>
    </table>
      <asp:Label ID="lblMuestraCalculo" style="color:red; width:500px" runat="server"></asp:Label>
</asp:Content>

