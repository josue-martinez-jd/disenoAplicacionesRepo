using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class vehiculos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void txtCalculaCosto_Click(object sender, EventArgs e)
    {
        if (Convert.ToInt32(txtPesoCarga.Text) <=10 )
        {
            Motocicleta moto = new Motocicleta(
                txtPuntoSalida.Text, txtPuntoLLegada.Text, 
                Convert.ToDouble(txtDistancia.Text), txtDimensionesCarga.Text,
                Convert.ToDouble(txtPesoCarga.Text), 5, 
                "Yamaha", 25.5
            );
            lblMuestraCalculo.Text = moto.returnCostoTotalLabel(moto,txtPuntoSalida.Text, txtPuntoLLegada.Text); 
        } else if(Convert.ToInt32(txtPesoCarga.Text) > 10 && Convert.ToInt32(txtPesoCarga.Text) <= 2000)
        {
            Pickup pickup = new Pickup(
                txtPuntoSalida.Text, txtPuntoLLegada.Text,
                Convert.ToDouble(txtDistancia.Text), txtDimensionesCarga.Text,
                Convert.ToDouble(txtPesoCarga.Text),20,30.5
            );
            lblMuestraCalculo.Text = pickup.returnCostoTotalLabel(pickup, txtPuntoSalida.Text, txtPuntoLLegada.Text);
        }
        else if (Convert.ToInt32(txtPesoCarga.Text) > 2000 && Convert.ToInt32(txtPesoCarga.Text) <= 5000)
        {
            Camion camion = new Camion(
                txtPuntoSalida.Text, txtPuntoLLegada.Text,
                Convert.ToDouble(txtDistancia.Text), txtDimensionesCarga.Text,
                Convert.ToDouble(txtPesoCarga.Text), 35, "Tecnologia"
            );
            lblMuestraCalculo.Text = camion.returnCostoTotalLabel(camion, txtPuntoSalida.Text, txtPuntoLLegada.Text);
        }
        else if (Convert.ToInt32(txtPesoCarga.Text) > 5000 && Convert.ToInt32(txtPesoCarga.Text) <= 30000)
        {
            Furgon furgon = new Furgon(
                txtPuntoSalida.Text, txtPuntoLLegada.Text,
                Convert.ToDouble(txtDistancia.Text), txtDimensionesCarga.Text,
                Convert.ToDouble(txtPesoCarga.Text), 50, 10
            );
            lblMuestraCalculo.Text = furgon.returnCostoTotalLabel(furgon, txtPuntoSalida.Text, txtPuntoLLegada.Text);
        }
        else
        {
            lblMuestraCalculo.Text = "Error! Cannot calculate";
            txtPesoCarga.Text = ""; 
        }
    }
}