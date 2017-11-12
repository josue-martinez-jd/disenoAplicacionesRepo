﻿using System;
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
            for (int i = 0; i < GlobalUsuarios.GlobalPasswords.Length; i++)
            {
                if (GlobalUsuarios.GlobalPasswords[i] == txtPass.Text && GlobalUsuarios.GlobalUsers[i] == txtUser.Text)
                {
                    Session["idUsuario"] = GlobalUsuarios.GlobalUsers[i];
                    Session["idPassword"] = GlobalUsuarios.GlobalPasswords[i]; 
                    if(Administrador.IsAdmin == false)
                    {
                        Response.Redirect("PaginaPrincipal.aspx");
                        
                    }else
                    {
                        Response.Redirect("AdminPrincipal.aspx"); 
                    } 
                }
            }
        }
    }

    protected void btnRegistrar_Click(object sender, EventArgs e)
    {
        GlobalUsuarios.GlobalUsers.SetValue(txtUsuario.Text, GlobalUsuarios.GlobalUsers.Length - 1);
        GlobalUsuarios.GlobalPasswords.SetValue(txtPassReg.Text, GlobalUsuarios.GlobalUsers.Length - 1);
        if(Administrador.IsAdmin == false)
        {
            Estudiante.EstudianteLoggeado = txtUsuario.Text;
            Estudiante.guardarNuevoEstudiante(txtNombre.Text,txtApellidos.Text, txtCorreo.Text); 
        }
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
        Administrador.IsAdmin = true; 
    }
}