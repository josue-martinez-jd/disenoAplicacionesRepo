<%@ Page Title="" Language="C#" MasterPageFile="~/principal.master" AutoEventWireup="true" CodeFile="financiera.aspx.cs" Inherits="financiera" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%-- int _id { get; set; }
    string _nombre;
    string _nombreComercial;
    string _tipoMoneda;
    string _plazo;
    int _montoMax;
    int _montoMin; --%>
    <h3>Informacion Principal Prestamo</h3>
    <table>
        <tr>
            <th>Tipo  Moneda </th>
            <th>Plazo(Meses)   </th>
            <th>Monto Maximo </th>
            <th>Monto Minimo </th>
        </tr>
        <tr>
            <td>  
                <asp:TextBox ID="txtTipoMoneda" runat="server" ></asp:TextBox>
            </td>
            <td>  
                <asp:TextBox ID="txtPlazo" runat="server" ></asp:TextBox>
            </td>
            <td>  
                <asp:TextBox ID="txtMontoMax" runat="server" ></asp:TextBox>
            </td>
            <td>  
                <asp:TextBox ID="txtMontoMin" runat="server" ></asp:TextBox>
            </td>
        </tr>
    </table>
    <br />
    <asp:Label ID="lblInformacionPrestamo" runat="server" ></asp:Label>
    <br />
    <table>
        <tr>
            <td> <asp:Button ID="btnPersonal" runat="server" Text="Personal" OnClick="btnPersonal_Click"  /></td>
            <td> <asp:Button ID="btnHipoteca" runat="server" Text="Hipoteca"  OnClick="btnHipoteca_Click"/></td>
            <td> <asp:Button ID="btnPyme" runat="server" Text="PYME" OnClick="btnPyme_Click" /></td>
            <td> <asp:Button ID="btnPrendario" runat="server" Text="Prendario" OnClick="btnPrendario_Click" /></td>
        </tr>
    </table>
    <br />
   <%-- <div class="requisitos">
        <table>
           <tr>
               <td>Nombre: <asp:TextBox ID="txtNombre" runat="server"> </asp:TextBox> </td>
               <td>Uso Prestamo: <asp:TextBox ID="txtUsoPrestamo" runat="server"> </asp:TextBox> </td>
               <td>Cedula: <asp:TextBox ID="txtCedula" runat="server"> </asp:TextBox> </td>
               <td>Sexo: <asp:TextBox ID="txtSexo" runat="server"> </asp:TextBox> </td>
               <td>Banco: <asp:TextBox ID="txt" runat="server"> </asp:TextBox> </td>
           </tr>
        </table>
    </div>--%>
</asp:Content>

