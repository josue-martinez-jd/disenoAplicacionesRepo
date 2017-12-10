using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class publicacion
{
    private int _id;
    private string _Nombre; 

    public int Id
    {
        get { return _id; }
        set { _id = value;}
    }

    public string Nombre
    {
        get { return _Nombre; }
        set { _Nombre = value; }
    }

    public publicacion(int pId, string pNombre)
    {
        Id = pId;
        Nombre = pNombre; 
    }

    public virtual string publicar()
    {
        return "Publicacion publicada"; 
    }
}