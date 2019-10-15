using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio.Views
{
    public partial class ListaArticulos : Form
    {
        public ListaArticulos()
        {
            InitializeComponent();
        }

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            abm_articulos abmarticulo = new abm_articulos();
            abmarticulo.ShowDialog(this);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<Articulo> LA = Articulo.SelectByName(txtBuscar.Text);
            if (LA != null)
            {
                foreach (Articulo a in LA)
                {
                    DataGridViewRow dgvr = new DataGridViewRow();
                    dgvr.CreateCells(dataGridView1);
                    dgvr.Cells[0].Value = a.ID;
                    dgvr.Cells[1].Value = a.CODIGO;
                    dgvr.Cells[2].Value = a.NOMBRE;
                    dgvr.Cells[3].Value = "[En desarrollo]";
                    dataGridView1.Rows.Add(dgvr);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlListaPrecios.Controls.Clear();
            List<FormaDePagoDatarow> l = FormaDePagoDatarow.GetByIdArt(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            Articulo art = Articulo.getById(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
            lblNombreArticulo.Text = art.NOMBRE;
            lblProveedor.Text = Proveedor.GetById(art.IDPROVEEDOR).NOMBRE;
            if (l != null)
            {
                for (int a=0;a<l.Count;a++)
                {
                    FormaDePagoDatarow dr = l[a];
                    Controles.ControlPrecio CP = new Controles.ControlPrecio(dr);
                    pnlListaPrecios.Controls.Add(CP);
                    CP.Location = new Point(0, a * 60);

                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
