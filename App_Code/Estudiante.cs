using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Estudiante
/// </summary>
public static class Estudiante
{
    static string estudianteLoggeado;
    static ArrayList _lstNombres = new ArrayList();
    static ArrayList _lstApellidos = new ArrayList();
    static ArrayList _lstCorreos = new ArrayList();

    public static string EstudianteLoggeado 
    {
        get
        {
            return estudianteLoggeado;
        }

        set
        {
            estudianteLoggeado = value;
        }
    }

    public static ArrayList Nombres
    {
        get
        {
            return _lstNombres;
        }

        set
        {
            _lstNombres = value;
        }
    }

    public static ArrayList Apellidos
    {
        get
        {
            return _lstApellidos;
        }

        set
        {
            _lstApellidos = value;
        }
    }

    public static ArrayList Correos
    {
        get
        {
            return _lstCorreos;
        }

        set
        {
            _lstCorreos = value;
        }
    }

    public static void guardarNuevoEstudiante(string usuario, string nombres, string apellidos, string correos)
    {
        EstudianteLoggeado = usuario;
        Nombres.Add(EstudianteLoggeado + ":" + nombres);
        Apellidos.Add(EstudianteLoggeado + ":" + apellidos);
        Correos.Add(EstudianteLoggeado + ":" + correos);
    }

    public static string returnInfoEstudiante(ArrayList arraylist)
    {
        string info = null;
        foreach (string i in arraylist)
        {
            string[] estudiantes = i.Split(':');
            if (i.Contains(EstudianteLoggeado))
            {
                info = estudiantes[1];
            }
        }                                                                                               
        return info;
    }

    
}