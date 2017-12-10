using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * La clase Vehiculo va a ser la padre de: 
 * - Motocicleta
 * - Pickup 
 * - Camion
 * - Furgon 
 * **/
public class Vehiculo
{
    private string _puntoSalida;
    private string _puntoLLegada;
    private double _distanciaKM;
    private string _dimensionCarga;
    private double _pesoCarga;
    private int _costo_Kilometro; 

    public string PuntoSalida { get {return _puntoSalida;} set { _puntoSalida = value;  } }
    public string PuntoLLegada { get { return _puntoLLegada; } set { _puntoLLegada = value; } }
    public double Distancia { get { return _distanciaKM; } set { _distanciaKM = value; } }
    public string DimensionCarga { get { return _dimensionCarga; } set { _dimensionCarga = value; } }
    public double PesoCarga { get { return _pesoCarga; } set { _pesoCarga = value; } }
    public int Costo_Kilometro { get { return _costo_Kilometro; } set { _costo_Kilometro = value; } }

    public Vehiculo(
        string pPuntoSalida, string pPuntoLLegada,
        double pDistanciaKM, string pDimensionCarga,
        double pPesoCarga, int pCostoKilometro
    )
    {
        PuntoSalida = pPuntoSalida;
        PuntoLLegada = pPuntoLLegada;
        Distancia = pDistanciaKM;
        DimensionCarga = pDimensionCarga;
        PesoCarga = pPesoCarga;
        Costo_Kilometro = pCostoKilometro; 
    }
    /**
     * Los siguientes metodos tienen una combinacion de Tell Don't ask y Polimorfismo,
     * al ser usados como base para los distintos hijos de esta clase padre
     */
    public virtual double CostoTotal ()
    {
        return Distancia * Costo_Kilometro; 
    }

    /**
     * Importante destacar que este metodo utiliza como parametros:
     * - Vehiculo: para leer que tipo de hijo Vehiculo se utiliza 
     * - Punto Llegada: Informativo
     * - Punto Salida: Informativo
     * **/
    public virtual string returnCostoTotalLabel(Vehiculo tipoVehiculo,string puntoSalida, string puntoLlegada)
    {
        return "Tipo Transporte: " + tipoVehiculo.ToString() + " / Viaje: Punto Salida - " + PuntoSalida + " - " + puntoLlegada; 
    }
}