using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{ 

    protected void Page_Load(object sender, EventArgs e)
    {
        pnlRegister.Visible = false;
    }

    protected void btnIngresar_Click(object sender, EventArgs e)
    { 
        if (txtUser.Text == null || txtUser.Text == "" ||
            txtPass.Text == null || txtPass.Text == "")
        {
            lblIngresar.Text = "Ingrese usuario o contraseña";
        }
        else
        {
            /**
             Changed all this method of checking the 
            Users and Password because previously it
            wasn't working as expected
             */
            foreach(string i in GlobalUsuarios.GlobalUsers)
            {
                if (i.Contains(txtUser.Text) && GlobalUsuarios.Password(i) == txtPass.Text)
                {
                    Session["idUsuario"] = GlobalUsuarios.Usuario(i);
                    Session["idPassword"] = GlobalUsuarios.Password(i); 
                    if (Administrador.IsAdmin == false)
                    {
                        Response.Redirect("vehiculos.aspx");
                    }
                    else
                    {
                        Response.Redirect("AdminPrincipal.aspx");
                    }
                }
            }
        }
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        GlobalUsuarios.GlobalUsers.Add(GlobalUsuarios.setUsuarios(txtUsuario.Text,txtPassReg.Text)); 
        if (Administrador.IsAdmin == false) 
        { 
            //Estudiante.EstudianteLoggeado = txtUsuario.Text; // We dont need this method as the next method works for that 
            Estudiante.guardarNuevoEstudiante(txtUsuario.Text, txtNombre.Text, txtApellidos.Text, txtCorreo.Text);
        }
        lblIngresar.Text = Administrador.IsAdmin.ToString();
        cleanFills();
    }

    protected void cleanFills()
    {
        txtNombre.Text = "";
        txtApellidos.Text = "";
        txtCorreo.Text = "";
        txtPassReg.Text = "";
        txtUsuario.Text = ""; 
    }

    protected void btnAbrirRegistro_Click1(object sender, EventArgs e)
    {
        pnlRegister.Visible = true;
    }

    protected void btnCalculadora_Click(object sender, EventArgs e)
    {
        Response.Redirect("calculator.aspx");
    }

    protected void chkAdmin_CheckedChanged(object sender, EventArgs e)
    {
        Administrador.IsAdmin=true;
    }
}