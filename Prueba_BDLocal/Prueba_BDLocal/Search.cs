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
    public partial class Search : Form
    {

        public Search()
        {
            InitializeComponent();
            llenaListView();
        }

        public void llenaListView()
        {
            List<Imodelo> l = new List<Imodelo>();
            l.Add(new Imodelo() { Nombre = "crankarm", Apellido1 = "1234" });

            listView1.View = View.Details;
            listView1.Columns.Add("Nombre");
            listView1.Columns.Add("Apellido");
            ListViewItem lvi1 = new ListViewItem();

            lvi1.SubItems.Add(l[0].Nombre);
            listView1.Items.Add(lvi1);
        }
    }
}
