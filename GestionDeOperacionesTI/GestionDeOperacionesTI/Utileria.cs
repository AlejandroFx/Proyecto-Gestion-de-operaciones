using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionDeOperacionesTI
{
    class Utileria
    {
        static String StrConexion = "Data Source=DESKTOP-6815RH5\\SQLEXPRESS;Initial Catalog=ControlIncidenciasDB;Integrated Security=True";

        public static string GetConnectionString()
        {
            return StrConexion;
        }

        public static bool ValidaTexto(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (!(Char.IsLetter(C)))
                    return true;
            }
            return false;
        }
        public static bool ValidaTextoNum(string Cadena)
        {
            foreach (char C in Cadena)
            {
                if (C < '0' || C > '9')
                    return true;
            }
            return false;
        }
        public static string CadenaSinEspacios(string Cadena)
        {
            string str = Cadena.Replace(" ", "");
            return str;
        }
        public static bool IsEmpty(string Cadena)
        {
            if (string.IsNullOrWhiteSpace(Cadena) || string.IsNullOrEmpty(Cadena))
                return true;

            return false;
        }
    }
}
