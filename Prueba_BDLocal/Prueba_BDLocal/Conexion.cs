using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
namespace Prueba_BDLocal
{
    class Conexion
    {
        private SqlConnection _conn;
        string constring = ConfigurationManager.ConnectionStrings["Prueba_BDLocal.Properties.Settings.BDLocalConnectionString"].ConnectionString;

        public void Conectar()
        {
            _conn = new SqlConnection(constring);

        }
        public void AbrirConn()
        {
            _conn.Open();
        }
        public void CerrarCon()
        {
            _conn.Close();
        }
        public void ExecuteQuery(string query, string type)
        {
            Conectar();
            if (type.Equals("Update") || type.Equals("Insert") || type.Equals("Delete"))
            {
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.CommandType = CommandType.Text;
                AbrirConn();
                int rowsAffected = cmd.ExecuteNonQuery();
                CerrarCon();
            }
            else if (type.Equals("Select"))
            {
                Conectar();
                SqlCommand cmd = new SqlCommand(query, _conn);
                AbrirConn();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(String.Format("{0}", reader[1], reader[2]));
                }
                CerrarCon();
            }
        }
    }
}
