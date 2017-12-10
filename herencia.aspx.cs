using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class herencia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCrear_Click(object sender, EventArgs e)
    {
        libro book;
        book = new libro(Int16.Parse(txtID.Text), txtNombre.Text,txtEditorial.Text);
        lblMostrar.Text = book.Id.ToString() + " Nombre: " + book.Nombre + " Editorial: "  + book.Editorial ; 
    }

    protected void btnMuestraPoli_Click(object sender, EventArgs e)
    {
        publicacion publi = new publicacion(2,"publi 1");
        libro lib = new libro(3, "libro 1", "This");

        lblMostrar.Text = publi.publicar() + "\n" + lib.publicar();
    }
}