using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Personal
/// </summary>
public class Personal : SistemaFinanciero
{
    string _trabajo;
    string _usoPrestamo;
    string _cedula;
    string _sexo;
    string _banco;

    public string Trabajo
    {
        get { return _trabajo; }
        set { _trabajo = value;}
    }

    public string UsoPrestamo
    {
        get { return _usoPrestamo; }
        set { _usoPrestamo = value; }
    }

    public string Cedula
    {
        get { return _cedula; }
        set { _cedula = value; }
    }

    public string Sexo
    {
        get { return _sexo; }
        set { _sexo = value; }
    }

    public string Banco
    {
        get { return _banco; }
        set { _banco = value; }
    }

    public Personal(
        string pTipoMoneda, string pPlazo,
        int pMontoMax, int pMontoMin,
        double pInteres,string pTrabajo, string pUsoPrestamo,
        string pCedula, string pSexo, string pBanco
    ) : base(
              pTipoMoneda,  pPlazo, pMontoMax,
              pMontoMin, pInteres
        )
    {
        Trabajo = pTrabajo;
        UsoPrestamo = pUsoPrestamo;
        Cedula = pCedula;
        Sexo = pSexo;
        Banco = pBanco; 
    }

    public override string resultadoCredito()
    {
        return base.resultadoCredito() + Trabajo + "," + 
        UsoPrestamo + "," + Cedula + "," + Sexo + ","
        + Banco + ","
            ;
    }
}