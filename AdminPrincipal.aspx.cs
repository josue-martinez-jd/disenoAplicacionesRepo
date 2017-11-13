using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminPrincipal : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void insertEstudiantesValues(DropDownList dropdown)
    {
        dropdown.Items.Clear();
        int cont = 0;
        foreach (string i in Matricula.Matriculas)
        { 
            string[] estudiantes = i.Split(' ');
            dropdown.Items.Insert(cont, estudiantes[0]);
            cont++;
        }
    }


    protected void drpEscogeEstudiante_SelectedIndexChanged(object sender, EventArgs e)
    {
        lblEstudiante.Text = Matricula.returnEstudianteSeleccionado(drpEscogeEstudiante.SelectedItem.Text); 
    }

    protected void btnActualizarLista_Click(object sender, EventArgs e)
    {
        insertEstudiantesValues(drpEscogeEstudiante); 
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        Administrador.MatriculasAceptadas.Add(lblEstudiante.Text); 
        Matricula.eliminaMatricula(drpEscogeEstudiante.SelectedItem.Text);
        lblAlertaMatricula.Text = "Matricula Aceptada"; 
    }

    protected void btnRechazar_Click(object sender, EventArgs e)
    {
        Administrador.MatriculaRechazadas.Add(lblEstudiante.Text);
        Matricula.eliminaMatricula(drpEscogeEstudiante.SelectedItem.Text);
        lblAlertaMatricula.Text = "Matricula Rechazada";
    }
}