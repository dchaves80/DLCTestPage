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
    public partial class ABM_GRID_UnidadesDeMedida : Form
    {
        public ABM_GRID_UnidadesDeMedida()
        {
            InitializeComponent();
        }

        private void ABM_GRID_UnidadesDeMedida_Load(object sender, EventArgs e)
        {
            fillgrid();
        }

        void fillgrid()
        {
            dataGridView1.Rows.Clear();
            List<Unidad> l = Model.Unidad.GetAll();
            if (l != null)
            {
                if (l.Count > 0)
                {
                    foreach (Unidad u in l)
                    {
                        DataGridViewRow r = new DataGridViewRow();
                        r.CreateCells(dataGridView1);
                        r.Cells[0].Value = u.NOMBRE_UNIDAD;
                        r.Cells[1].Value = u.SIMBOLO;
                        dataGridView1.Rows.Add(r);

                    }
                }
            }

        }

        private void btnGuardarUnidad_Click(object sender, EventArgs e)
        {
            bool validate = false;
            validate = (txtunidadname.Text != null) ? true : false;
            validate = (txtsimbolounidad.Text != null && validate == true) ? true : false;

            if (validate == true)
            {
                Unidad.InsertUnidad(txtunidadname.Text, txtsimbolounidad.Text);
                fillgrid();
                txtsimbolounidad.Text = "";
                txtunidadname.Text = "";
            }
            else { MessageBox.Show(this, "Faltan datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }



        }
    }
}
