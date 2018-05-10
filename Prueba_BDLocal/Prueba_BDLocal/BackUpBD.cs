using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Prueba_BDLocal
{
    class BackUpBD
    {
        public void consultarDatos(string consulta)
        {
            Conexion con = new Conexion();

            con.ExecuteQuery(consulta, "Select");
        }
        public void EscribeFichero()
        {
            StreamWriter w = new StreamWriter("");
        } 
    }
}
