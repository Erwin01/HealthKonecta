using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32Meucci.Common
{
    #region [Conexión a la Base de Datos]
    public class Common
    {
        //const string ConStringName = "cnncapa";
        const string ConStringName = "capacitacion";

        public static string ConnString = string.Empty;
        static Common()
        {
            if (System.Configuration.ConfigurationManager.ConnectionStrings[ConStringName] != null)
                ConnString = System.Configuration.ConfigurationManager.ConnectionStrings[ConStringName].ConnectionString;
            else
                throw new Fwk.Exceptions.TechnicalException("Está Faltando la Cadena de Conexion");
        }
    } 
    #endregion

    public enum TipoParametrosEnum
    {
         EstadoCivil = 100,
         Sexo = 200,
         TipoDoc = 300,
    }
}
