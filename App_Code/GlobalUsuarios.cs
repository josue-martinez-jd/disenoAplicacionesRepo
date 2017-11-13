using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GlobalUsuarios
/// </summary>
public static class GlobalUsuarios
{
    static ArrayList _users = new ArrayList();

    public static ArrayList GlobalUsers
    {
        get
        {
            return _users;
        }
        set
        {
            _users = value;
        }
    }
    /**
     * The user and password are set on the same arraylist, 
     * then they are separated in next two methods 
     * **/
    public static string setUsuarios(string usuario, string password)
    {
        return usuario + ":" + password;
    }


    /**
     * The next two methods are done here, 
     * just so the only thing called it's the 
     * object 
     * **/
    public static string Usuario (string usuario) { 
     return usuario.Split(':')[0];
    }

    public static string Password(string usuario)
    {
        return usuario.Split(':')[1];
    }
}