using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * La clase Camion hereda de Vehiculo y Agrega: 
 * - returnCostoTipoCarga(): recibe un string con el tipo de carga y retorna costo extra 
 * 
 * Ademas destacar que se sobreescribe con Polimorfismo: 
 * - CostoTotal()
 * - returnCostoTotalLabel()
 * **/
public class Camion : Vehiculo
{
    private string _tipoCarga;

    public string TipoCarga { get { return _tipoCarga; } set { _tipoCarga = value; } }

    public Camion(
        string pPuntoSalida, string pPuntoLLegada,
        double pDistanciaKM, string pDimensionCarga,
        double pPesoCarga, int pCostoKilometro,
        string pTipoCarga
    ) : base(
        pPuntoSalida, pPuntoLLegada,
        pDistanciaKM, pDimensionCarga,
        pPesoCarga, pCostoKilometro
        )
    {
        TipoCarga = pTipoCarga; 
    }

    /**
     * returnCostoTipoCarga() es usado para cobrar un extra por
     * el tipo de carga utilizado en el camion 
     * **/
    public double returnCostoTipoCarga()
    {
        double carga = 0 ;
        if (TipoCarga == "Plantas")
        {
            carga = 500; 
        } else if (TipoCarga == "Madera") {
            carga = 1500; 
        } else if (TipoCarga == "Tecnologia")
        {
            carga = 3000;
        }
        return carga; 
    }

    /**
   * CostoTotal() es heredado de Vehiculo;  pero se agrega 
   * un calculo extra sobre  
   * returnCostoTipoCarga() * Costo_Kilometro/1.5
   * **/
    public override double CostoTotal()
    {
        return base.CostoTotal() + ((returnCostoTipoCarga() * (base.Costo_Kilometro / 1.5)) );
    }

    /**
   * returnCostoTotalLabel() es heredado de Vehiculo; 
   * luego se agrega el tipoCarga() y al final 
   * se agrega el sobreescrito CostoTotal()
   * **/

    public override string returnCostoTotalLabel(Vehiculo tipoVehiculo, string puntoSalida, string puntoLlegada)
    {
        return base.returnCostoTotalLabel(tipoVehiculo, puntoSalida, puntoLlegada) +
        " / " + " Tipo Carga: " + TipoCarga + " / " + " Costo: ₡" + CostoTotal().ToString();
    }
}