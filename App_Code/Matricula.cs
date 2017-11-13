using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Matricula
/// </summary>
public static class Matricula
{
    static ArrayList _matriculas = new ArrayList {" "};
    static int _contadorMatriculas; 

    public static ArrayList Matriculas
    {
        get
        {
            return _matriculas;
        }

        set
        {
            _matriculas = value;
        }
    }

    public static int ContadorMatriculas
    {
        get
        {
            return _contadorMatriculas;
        }

        set
        {
            _contadorMatriculas = value;
        }
    }

    public static void guardaNuevaMatricula(string nombre, string apellido, string correo,string materia)
    {
        Matriculas.Add(
            nombre + " " + apellido + 
            " Correo = " + correo + 
            " Materia = " + materia
        ); 
    }

    public static string returnEstudianteSeleccionado(string estudiante)
    {
        string matricula = null; 
        foreach (string i in Matriculas)
        {
            if (i.Contains(estudiante))
            {
                matricula = i;
            }
        }
        return matricula; 
    }

    public static void eliminaMatricula(string estudiante)
    {
        int cont = 0;
        int posicion = 0; 
        foreach (string i in Matriculas)
        {
            if (i.Contains(estudiante))
            {
                posicion = cont;  
            }
            cont++;
        }
        Matriculas.RemoveAt(posicion);
    }
}