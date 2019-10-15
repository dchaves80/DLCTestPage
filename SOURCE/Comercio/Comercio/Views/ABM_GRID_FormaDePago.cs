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
    public partial class ABM_GRID_FormaDePago : Form
    {
        public ABM_GRID_FormaDePago()
        {
            InitializeComponent();
        }

        private void ABM_GRID_FormaDePago_Load(object sender, EventArgs e)
        {
            fillgrid();
        }



        private void fillgrid()
        {
            dtgvFormaDePago.Rows.Clear();
            List<FormaDePago> l = FormaDePago.GetAll();
            if (l != null)
            {
                foreach (FormaDePago f in l)
                {
                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dtgvFormaDePago);
                    r.Cells[0].Value = f.NOMBRE;
                    dtgvFormaDePago.Rows.Add(r);
                }
            }

        }

        private void btnFormaDePago_Click(object sender, EventArgs e)
        {
            bool validate = false;
            validate = (txtFormaDePago.Text != null) ? true : false;
            if (validate == true)
            {
                FormaDePago.InsertNew(txtFormaDePago.Text);
                fillgrid();
            }
            else
            {
                MessageBox.Show(this, "Faltan datos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
