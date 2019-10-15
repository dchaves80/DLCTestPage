using Comercio.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cargaDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.ListaProveedores LP = new Views.ListaProveedores();
            LP.MdiParent = this;
            LP.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Views.ABM_GRID_UnidadesDeMedida um = new Views.ABM_GRID_UnidadesDeMedida();
            um.MdiParent=this;
            um.Show();
        }

        private void cargaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Views.ABM_GRID_FormaDePago fp = new Views.ABM_GRID_FormaDePago();
            fp.MdiParent = this;
            fp.Show();
        }

        private void cargaDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaArticulos LA = new ListaArticulos();
            LA.MdiParent = this;
            LA.Show();
        }
    }
}
