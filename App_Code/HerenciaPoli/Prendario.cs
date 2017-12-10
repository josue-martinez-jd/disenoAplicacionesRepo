using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Prendario
/// </summary>
public class Prendario : SistemaFinanciero
{
    Boolean _vehiculo;
    Boolean _motocicleta;
    Boolean _casa;
    Boolean _terreno;
    Boolean _tecnologia; 
    
    public Boolean Vehiculo
    {
        get { return _vehiculo; }
        set { _vehiculo = value; }
    }

    public Boolean Motocicleta
    {
        get { return _motocicleta; }
        set { _motocicleta = value; }
    }

    public Boolean Casa
    {
        get { return _casa; }
        set { _casa = value; }
    }

    public Boolean Terreno
    {
        get { return _terreno; }
        set { _terreno = value; }
    }

    public Boolean Tecnologia
    {
        get { return _tecnologia; }
        set { _tecnologia = value; }
    }

    public Prendario(
        string pTipoMoneda, string pPlazo,
        int pMontoMax, int pMontoMin,
        double pInteres, Boolean pVehiculo, Boolean pMotocicleta,
        Boolean pCasa, Boolean pTerreno, Boolean pTecnologia
        ) : base(
              pTipoMoneda, pPlazo, pMontoMax,
              pMontoMin, pInteres
        )
    {
        Vehiculo = pVehiculo; 
        Motocicleta = pMotocicleta;
        Casa = pCasa;
        Terreno = pTerreno;
        Tecnologia = pTecnologia; 
    }

    public string traduceBoolean(Boolean si_no)
    {
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
             " Vehiculo:" + traduceBoolean(Vehiculo) + "," +
             " Motocicleta:" + traduceBoolean(Motocicleta) + "," +
            " Casa:" + traduceBoolean(Casa) + "," +
            " Terreno:" + traduceBoolean(Terreno) + "," +
            " Tecnologia:" + traduceBoolean(Tecnologia)
            ;
    }


}