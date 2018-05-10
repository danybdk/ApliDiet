using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_BDLocal
{
    public partial class AltaNueva : Form
    {
        public AltaNueva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
            string sql = "INSERT INTO Users (Nombre, Apellido1, Apellido2, FNac, Telefono) " +
                "VALUES (" + "'" + textNombre.Text + "'" + ", " + "'" + textApe1.Text + "'" + ", " + "'" + textApe2.Text + "'" + ", " + "'" + dateNacimiento.Text + "'" + ", " + "'" + textTel.Text + "'"+")";
            c.Conectar();
            c.AbrirConn();
            c.ExecuteQuery(sql, "Insert");
            c.CerrarCon();
            MessageBox.Show("Cliente " + textNombre.Text.ToString() + " dado de alta correctamente.", "Nuevo cliente.", MessageBoxButtons.OK);
        }

    }
}
