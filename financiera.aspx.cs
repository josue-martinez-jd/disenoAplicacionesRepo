using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class financiera : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPersonal_Click(object sender, EventArgs e)
    {
        Personal personal = new Personal(txtTipoMoneda.Text,
           txtPlazo.Text, Convert.ToInt32(txtMontoMax.Text),
           Convert.ToInt32(txtMontoMin.Text),
           0.30, "Informatico", "Juegos","15151651","Hombre","Nacional"
        );

        lblInformacionPrestamo.Text = personal.resultadoCredito(); 
    }

    protected void btnHipoteca_Click(object sender, EventArgs e)
    {
        Hipoteca hipoteca = new Hipoteca(txtTipoMoneda.Text,
          txtPlazo.Text, Convert.ToInt32(txtMontoMax.Text),
          Convert.ToInt32(txtMontoMin.Text),
          0.05, true, false,false,true,false
       );
        lblInformacionPrestamo.Text = hipoteca.resultadoCredito(); 
    }

    protected void btnPyme_Click(object sender, EventArgs e)
    {
        PYME pyme = new PYME(txtTipoMoneda.Text,
          txtPlazo.Text, Convert.ToInt32(txtMontoMax.Text),
          Convert.ToInt32(txtMontoMin.Text),
          0.01, "Janeiro","35","465465465","TOTALMENTE","Costarricense"
       );
        lblInformacionPrestamo.Text = pyme.resultadoCredito();
    }

    protected void btnPrendario_Click(object sender, EventArgs e)
    {
        Prendario prendario = new Prendario(txtTipoMoneda.Text,
         txtPlazo.Text, Convert.ToInt32(txtMontoMax.Text),
         Convert.ToInt32(txtMontoMin.Text), 0.075,
         true, false,false,false,false
      );
        lblInformacionPrestamo.Text = prendario.resultadoCredito();
    }

    protected void btnPersonal_Click1(object sender, EventArgs e)
    {

    }
}