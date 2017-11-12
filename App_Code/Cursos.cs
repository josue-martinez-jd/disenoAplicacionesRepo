using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public static class Cursos
{
    static ArrayList _lstCursos = new ArrayList { "Español", "Matemática", "Estudio Sociales", "Quimica" };

    public static ArrayList ListaCursos
    {
        get
        {
            return _lstCursos;
        }

        set
        {
            _lstCursos = value;
        }
    }

    public static void insertNuevoCurso(string curso)
    {
        Boolean existe = false;
        for (int i = 0; i < ListaCursos.Count; i++)
        {
            if (ListaCursos[i].Equals(curso))
            {
                existe = true;
            }
        }
        if (!existe)
        {
            ListaCursos.Add(curso);
        }
    }
}