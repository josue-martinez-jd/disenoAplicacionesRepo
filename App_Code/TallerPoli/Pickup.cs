using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * La clase Pickup hereda de Vehiculo y Agrega: 
 * - CostoLona: CostoExtra para asegurar la carga  
 * - CostoExtraPeso(): Si la carga es mayor a 1000 o 1500 kg se cobra extra
 * 
 * Ademas destacar que se sobreescribe con Polimorfismo: 
 * - CostoTotal()
 * - returnCostoTotalLabel()
 * **/
public class Pickup : Vehiculo
{
    private double _costoLona;

    public double CostoLona { get { return _costoLona; } set { _costoLona = value; } }

    public Pickup(
        string pPuntoSalida, string pPuntoLLegada,
        double pDistanciaKM, string pDimensionCarga,
        double pPesoCarga, int pCostoKilometro, 
        double pCostoLona
    ) : base(
        pPuntoSalida, pPuntoLLegada,
        pDistanciaKM, pDimensionCarga,
        pPesoCarga, pCostoKilometro
        )
    {
        CostoLona = pCostoLona; 
    }

    /**
     * CostoExtraPeso() es usado para cobrar mas cuando las carga
     * supera los 1000 y 1500 kg de peso 
     * **/
    public double CostoExtraPeso()
    {
        double costoExtra = 0; 
        if (base.PesoCarga >=1000 && base.PesoCarga < 1500)
        {
            costoExtra = 100; 
        } else if (base.PesoCarga >= 1500)
        {
            costoExtra = 300; 
        }
        return costoExtra; 
    }

    /**
   * CostoTotal() es heredado de Vehiculo;  pero se agrega 
   * un calculo extra sobre el CostoLona() * Costo_Kilometro/2.5 + 
   * CostoExtraPeso() si la carga es mayor a 1000kg o 1500kg 
   * **/
    public override double CostoTotal()
    {
        return base.CostoTotal() + ((CostoLona * (base.Costo_Kilometro/2.5)) + CostoExtraPeso());
    }

    /**
    * returnCostoTotalLabel() es heredado de Vehiculo; y 
    * solo agrega el sobreescrito CostoTotal()
    * **/

    public override string returnCostoTotalLabel(Vehiculo tipoVehiculo, string puntoSalida, string puntoLlegada)
    {
        return base.returnCostoTotalLabel(
            tipoVehiculo, puntoSalida, puntoLlegada
            ) + " / " +
            " Costo: ₡" + CostoTotal().ToString();
    }
}