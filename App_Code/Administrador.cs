using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class Administrador
{
    static Boolean _isAdmin = false;
    static ArrayList _matriculaAceptada = new ArrayList();
    static ArrayList _matriculaRechazada = new ArrayList();


    public static Boolean IsAdmin
    {
        get
        {
            
            return _isAdmin;
        }

        set
        {
            _isAdmin = value; 
        }
    }

    public static ArrayList MatriculasAceptadas
    {
        get
        {
            return _matriculaAceptada;
        }

        set
        {
            _matriculaAceptada = value;
        }
    }

    public static ArrayList MatriculaRechazadas
    {
        get
        {
            return _matriculaRechazada;
        }

        set
        {
            _matriculaRechazada = value;
        }
    }
}