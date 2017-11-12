using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GlobalUsuarios
/// </summary>
public static class GlobalUsuarios
{
    static string[] _users = new string[] { "", "", "", "", "", "", "", "", "", "" };
    static string[] _passwords = new string[] { "", "", "", "", "", "", "", "", "", "" };


    public static string[] GlobalUsers
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

    public static string[] GlobalPasswords
    {
        get
        {
            return _passwords;
        }
        set
        {
            _passwords = value;
        }
    }
}