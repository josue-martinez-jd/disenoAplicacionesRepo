using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * La clase Furgon hereda de Vehiculo y Agrega: 
 * - CantidadContenedores: Un furgon puede tener varios contenedores
 * entonces los multiplica por el costo total 
 * 
 * Ademas destacar que se sobreescribe con Polimorfismo: 
 * - CostoTotal()
 * - returnCostoTotalLabel()
 * **/
public class Furgon : Vehiculo
{
    private int _cantidadContenedores;

    public int CantidadContenedores { get { return _cantidadContenedores; } set { _cantidadContenedores = value; } }

    public Furgon(
        string pPuntoSalida, string pPuntoLLegada,
        double pDistanciaKM, string pDimensionCarga,
        double pPesoCarga, int pCostoKilometro,
        int pCantidadContenedores
    ) : base(
        pPuntoSalida, pPuntoLLegada,
        pDistanciaKM, pDimensionCarga,
        pPesoCarga, pCostoKilometro
    )
    
    {
        CantidadContenedores = pCantidadContenedores; 
    }

    /**
  * CostoTotal() es heredado de Vehiculo; 
  * pero se multiplica por la CantidadContenedores
  * **/

    public override double CostoTotal()
    {
        return CantidadContenedores * base.CostoTotal() ;
    }

    /**
   * returnCostoTotalLabel() es heredado de Vehiculo; 
   * y al final se agrega el sobreescrito CostoTotal()
   * **/

    public override string returnCostoTotalLabel(Vehiculo tipoVehiculo, string puntoSalida, string puntoLlegada)
    {
        return base.returnCostoTotalLabel(tipoVehiculo, puntoSalida, puntoLlegada) +
        " / " + " Costo: ₡" + CostoTotal().ToString();
    }
}