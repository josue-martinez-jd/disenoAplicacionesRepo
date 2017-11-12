<%@ Page Title="" Language="C#" MasterPageFile="~/login.master" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <table class="auto-style24">
            <tr>
                <td class="auto-style15">Usuario:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtUser" runat="server" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style22" rowspan="2">
                </td>
            </tr>
            <tr>
                <td class="auto-style16">Password:</td>
                <td class="auto-style8">
                    <asp:TextBox ID="txtPass" type ="password" runat="server" Width="158px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="lblIngresar" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Button ID="btnAbrirRegistro" runat="server" Text="Registrar" OnClick="btnAbrirRegistro_Click1" />
                </td>
            </tr>
        </table>

        <div  id="divRegister">
                <asp:Panel runat="server" ID="pnlRegister">
<table id="tblRegister" class="auto-style13" >
        <tr>
            <td class="auto-style20">
                <h2>Registro
                </h2>
            </td>
            <td class="auto-style21">
                </td>
        </tr>
        <tr>
            <td class="auto-style14">Nombre:</td>
            <td class="auto-style12">
                <asp:TextBox ID="txtNombre" runat="server" Width="205px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Apellidos: </td>
            <td class="auto-style12">
                <asp:TextBox ID="txtApellidos" runat="server" Width="205px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style14">Usuario: </td>
            <td class="auto-style12">
                <asp:TextBox ID="txtUsuario" runat="server" Width="205px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Correo: </td>
            <td class="auto-style1">
                <asp:TextBox ID="txtCorreo" runat="server" Width="205px"></asp:TextBox>
            </td>
        </tr>
             <tr>
            <td class="auto-style14">Contraseña: </td>
            <td class="auto-style12">
                <asp:TextBox type="password" ID="txtPassReg" runat="server" Width="205px"></asp:TextBox>
                 </td>
        </tr>
        
             <tr>
                 <td class="auto-style14">Administrador: </td>
                 <td class="auto-style12">
                     <asp:CheckBox ID="chkAdmin" runat="server" OnCheckedChanged="chkAdmin_CheckedChanged" />
                 </td>
        </tr>
        
             <tr>
            <td class="auto-style14">
        <asp:Label ID="lblRegistro" runat="server" ForeColor="Red"></asp:Label>
                 </td>
            <td class="auto-style12">
                    &nbsp;</td>
        </tr>
        
             <tr>
            <td class="auto-style18">
                    <asp:Button ID="btnRegistrar" runat="server" Text="Registrarse" onClick="btnRegistrar_Click" Height="20px" />
                 </td>
            <td class="auto-style19">
                 </td>
        </tr>
    </table>
</asp:Panel>
  
        </div>
</asp:Content>

