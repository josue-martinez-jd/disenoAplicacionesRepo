using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for PYME
/// </summary>
public class PYME : SistemaFinanciero
{
    string _nombreEmpresa;
    string _numeroEmpleados;
    string _telefonoEmpresa;
    string _dispuestos;
    string _nacionalidad; 

    public string NombreEmpresa
    {
        get { return _nombreEmpresa; }
        set { _nombreEmpresa = value; }
    }

    public string NumeroEmpleados
    {
        get { return _numeroEmpleados; }
        set { _numeroEmpleados = value; }
    }

    public string TelefonoEmpresa
    {
        get { return _telefonoEmpresa; }
        set { _telefonoEmpresa = value; }
    }

    public string Dispuestos
    {
        get { return _dispuestos; }
        set { _dispuestos = value; }
    }

    public string Nacionalidad
    {
        get { return _nacionalidad; }
        set { _nacionalidad = value; }
    }

    public PYME(
        string pTipoMoneda, string pPlazo,
        int pMontoMax, int pMontoMin,
        double pInteres,string pNombreEmpresa,
        string pNumeroEmpleados, string pTelefonoEmpresa,
        string pDispuestos, string pNacionalidad

        ) : base(
              pTipoMoneda, pPlazo, pMontoMax,
              pMontoMin, pInteres
        )
    {
        NombreEmpresa = pNombreEmpresa;
        NumeroEmpleados = pNumeroEmpleados;
        TelefonoEmpresa = pTelefonoEmpresa;
        Dispuestos = pDispuestos;
        Nacionalidad = pNacionalidad; 
    }

    public override string resultadoCredito()
    {
        return base.resultadoCredito() +
             " Nombre Empresa:" + (NombreEmpresa) + "," +
             " Numero Empleados:" + (NumeroEmpleados) + "," +
            " Telefono Empresa:" + (TelefonoEmpresa) + "," +
            " Dispuestos:" + ( Dispuestos) + "," +
            " Nacionalidad:" + (Nacionalidad)
            ;
    }
}