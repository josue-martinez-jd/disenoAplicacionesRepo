using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SistemaFinanciero
/// </summary>
public class SistemaFinanciero
{
    private string _tipoMoneda;
    private string _plazo;
    private int _montoMax;
    private int _montoMin;
    private double _interes; 

    public string TipoMoneda
    {
        get { return _tipoMoneda; }
        set { _tipoMoneda = value; }
    }

    public string Plazo
    {
        get { return _plazo; }
        set { _plazo = value; }
    }

    public int MontoMaximo
    {
        get { return _montoMax; }
        set { _montoMax = value; }
    }

    public int MontoMinimo
    {
        get { return _montoMin; }
        set { _montoMin = value; }
    }

    public double Interes { get { return _interes; } set { _interes = value; } }

    public SistemaFinanciero(string pTipoMoneda, string pPlazo, int pMontoMax, int pMontoMin,double pInteres)
    {
        TipoMoneda = pTipoMoneda;
        Plazo = pPlazo;
        MontoMaximo = pMontoMax;
        MontoMinimo = pMontoMin;
        Interes = pInteres; 
    }

    public virtual double MontoTotal()
    {
        return ((((MontoMaximo + MontoMinimo) / 2) * Interes) + 
                (MontoMaximo + MontoMinimo) / 2)
                ;
    }

    public virtual double calculoMensual()
    {
        return (MontoTotal() / Convert.ToInt32(Plazo)) * Interes; 
    }

    public virtual string resultadoCredito()
    {
        return TipoMoneda + MontoTotal().ToString()  +
               "   Calculo Mensual: " + TipoMoneda + calculoMensual() + "   ";  
    }
}