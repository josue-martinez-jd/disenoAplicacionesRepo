using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Hipoteca
/// </summary>
public class Hipoteca : SistemaFinanciero

{
    Boolean _propiedad;
    Boolean _terreno;
    Boolean _asegurado;
    Boolean _mayorEdad;
    Boolean _confidente; 

    public Boolean Propiedad
    {
        get { return _propiedad; }
        set { _propiedad = value; }
    }

    public Boolean Terreno
    {
        get { return _terreno; }
        set { _terreno = value; }
    }

    public Boolean Asegurado
    {
        get { return _asegurado; }
        set { _asegurado = value; }
    }

    public Boolean MayorEdad
    {
        get { return _mayorEdad; }
        set { _mayorEdad = value; }
    }

    public Boolean Confidente
    {
        get { return _confidente; }
        set { _confidente = value; }
    }

    public Hipoteca( 
        string pTipoMoneda, string pPlazo,
        int pMontoMax, int pMontoMin,
        double pInteres, Boolean pPropiedad, Boolean pTerreno,
        Boolean pAsegurado, Boolean pMayorEdad, Boolean pConfidente
            ) : base(
             
              pTipoMoneda, pPlazo, pMontoMax,
              pMontoMin, pInteres
        )
    {
        Propiedad = pPropiedad;
        Terreno = pTerreno;
        Asegurado = pAsegurado;
        MayorEdad = pMayorEdad;
        Confidente = pConfidente; 
    }

    public string traduceBoolean (Boolean si_no) { 
        string booleanEsperado;  
        if (si_no == true)
        {
            booleanEsperado = "si";
        }
        else
        {
            booleanEsperado = "no";
        }
        return booleanEsperado;
    }

    public override string resultadoCredito()
    {
        return base.resultadoCredito() +
             " Propiedad:" + traduceBoolean(Propiedad) + "," +
             " Terreno:" + traduceBoolean(Terreno) + "," +
            " Asegurado:" +traduceBoolean(Asegurado) + "," +
            " MayorEdad:" + traduceBoolean(MayorEdad) +  "," +
            " Confidente:" + traduceBoolean(Confidente)
            ;
    }
}