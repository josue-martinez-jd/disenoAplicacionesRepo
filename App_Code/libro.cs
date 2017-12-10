using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for libro
/// </summary>
public class libro:publicacion
{ 
    private string _Editorial; 
    public string Editorial
    {
        get { return _Editorial; }
        set { _Editorial = value; }
    }
        public libro(int pId, string pNombre, string pEditorial):base(pId,pNombre)
    {
        Editorial = pEditorial; 
    }

    public override string publicar()
    {
        return "Libro Publicado";
    }
}