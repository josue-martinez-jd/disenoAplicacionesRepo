using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaPrincipal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblUserLogged.Text = Session["idUsuario"].ToString(); 
    }

    protected void btnGuardarMateria_Click(object sender, EventArgs e)
    {
        Cursos.insertNuevoCurso(txtMateria.Text);
        insertCursosValues(drpEscogeMateria);
        txtMateria.Text = ""; 
    }

    public  void insertCursosValues(DropDownList dropdown)
    {
        dropdown.Items.Clear(); 
        int cont = 0;
        foreach (string i in Cursos.ListaCursos)
        {
            dropdown.Items.Insert(cont, i);
            cont++;
        }
    }

    protected void btnEscogerMateria_Click(object sender, EventArgs e)
    {
        insertCursosValues(drpEscogeMateria); 
    }

    protected void btnGuardarEscogido_Click(object sender, EventArgs e)
    {
        lblNombres.Text = Estudiante.returnInfoEstudiante(Estudiante.Nombres);
        lblApellidos.Text = Estudiante.returnInfoEstudiante(Estudiante.Apellidos);
        lblCorreos.Text = Estudiante.returnInfoEstudiante(Estudiante.Correos);
    }

    protected void btnCrearMatricula_Click(object sender, EventArgs e)
    {
        Matricula.guardaNuevaMatricula(lblNombres.Text,lblApellidos.Text,lblCorreos.Text, drpEscogeMateria.SelectedItem.Text); 
    }

    protected void btnNoCrearMatricula_Click(object sender, EventArgs e)
    {
        lblNombres.Text = ""; 
        lblApellidos.Text = "";
        lblCorreos.Text = "";
        insertCursosValues(drpEscogeMateria); 
    }

    protected void btnCerrarSesion_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Response.Redirect("index.aspx"); 
    }
}
