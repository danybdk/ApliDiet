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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            this.Hide();
            AltaNueva an = new AltaNueva();
            an.Show();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BackUpBD bbd = new BackUpBD();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actualizar up = new Actualizar();
            up.Show();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Borrar del = new Borrar();
            del.Show();
        }

        private void BuscarListar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search s = new Search();
            s.Show();
        }
    }
}
