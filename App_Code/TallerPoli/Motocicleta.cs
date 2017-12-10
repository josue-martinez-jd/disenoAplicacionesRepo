using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * La clase Motocicleta hereda de Vehiculo y Agrega dos atributos extra: 
 * - MarcaMotocicleta: Informativo 
 * - CostoEquipoProteccion: Agrega un extra al Costo Total del Transporte
 * 
 * Ademas destacar que se sobreescribe con Polimorfismo: 
 * - CostoTotal()
 * - returnCostoTotalLabel()
 * **/
public class Motocicleta : Vehiculo
{
    private string _marcaMotocicleta;
    private double _costoEquipoProteccion;

    public string MarcaMotocicleta { get { return _marcaMotocicleta; } set { _marcaMotocicleta = value; } }
    public double CostoEquipoProteccion { get { return _costoEquipoProteccion; } set { _costoEquipoProteccion = value; } }

    public Motocicleta(
        string pPuntoSalida, string pPuntoLLegada,
        double pDistanciaKM, string pDimensionCarga,
        double pPesoCarga, int pCostoKilometro,
        string pMarcaMotocicleta, double pCostoEquipoProteccion
    ) : base(
        pPuntoSalida, pPuntoLLegada,
        pDistanciaKM, pDimensionCarga,
        pPesoCarga,pCostoKilometro
        )
    {
        MarcaMotocicleta = pMarcaMotocicleta;
        CostoEquipoProteccion = pCostoEquipoProteccion; 
    }
  /**
   * CostoTotal() es heredado de Vehiculo;  pero se agrega 
   * un calculo extra sobre el CostoEquipoProteccion() * Costo_Kilometro
   * **/
    public override double CostoTotal()
    {
        return base.CostoTotal() + (CostoEquipoProteccion * base.Costo_Kilometro);
    }

    /**
     * returnCostoTotalLabel() es heredado de Vehiculo; pero agrega
     * MarcaMotocicleta() e agrega el sobreescrito CostoTotal()
     * **/

    public override string returnCostoTotalLabel(Vehiculo tipoVehiculo, string puntoSalida, string puntoLlegada)
    {
        return base.returnCostoTotalLabel(
            tipoVehiculo, puntoSalida, puntoLlegada
            ) + 
            " / Marca Motocicleta: " + MarcaMotocicleta + " / " + 
            " Costo: ₡" + CostoTotal().ToString();
    }
}