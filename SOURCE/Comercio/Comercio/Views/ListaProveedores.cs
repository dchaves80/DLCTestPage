using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercio.Properties;
using Model;

namespace Comercio.Views
{
    public partial class ListaProveedores : Form
    {
        public ListaProveedores()
        {
            InitializeComponent();
        }



        private void ListaProveedores_Load(object sender, EventArgs e)
        {
            LlenarDataGrid();
            
        }

        private void LlenarDataGrid()
        {
            dgvListadoProveedores.Rows.Clear();
            List<Proveedor> ListadoProveedores = Proveedor.GetAll();
            if (ListadoProveedores == null)
            {
                lblNoHayProveedores.Visible = true;
                dgvListadoProveedores.Enabled = false;
            }
            else
            {

                lblNoHayProveedores.Visible = false;
                dgvListadoProveedores.Enabled = true;

                Bitmap B = new Bitmap(Resources.edit);

                for (int a = 0; a<ListadoProveedores.Count;a++)
                {
                    Proveedor p = ListadoProveedores[a];
                    DataGridViewRow R = new DataGridViewRow();
                    R.CreateCells(dgvListadoProveedores);

                    R.Cells[dgvListadoProveedores.Columns["Id"].Index].Value = p.ID.ToString();
                    R.Cells[dgvListadoProveedores.Columns["nombre"].Index].Value = p.NOMBRE;
                    R.Cells[dgvListadoProveedores.Columns["Telefono"].Index].Value = p.TELEFONO;
                    R.Cells[dgvListadoProveedores.Columns["CUIT"].Index].Value = p.CUIT;
                    R.Cells[dgvListadoProveedores.Columns["Editar"].Index].Value = B;
                    dgvListadoProveedores.Rows.Add(R);
                    
                    
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ABM_Proveedor newP = new ABM_Proveedor(Constants.ABM_Mode.NuevoReg);
            newP.ShowDialog();
            ListaProveedores LP = new ListaProveedores();
            LP.Show();
            LP.MdiParent=this.MdiParent;
            this.Close();
        }

        private void ListaProveedores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView s = sender as DataGridView;
        }

        private void dgvListadoProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            int IdProveedor = int.Parse(dgvListadoProveedores["Id", e.RowIndex].Value.ToString());
            ABM_Proveedor ABM = new ABM_Proveedor(Constants.ABM_Mode.Editar, IdProveedor);
            ABM.FormClosed += ABM_FormClosed;
            ABM.ShowDialog(this);
            

           
        }

        private void ABM_FormClosed(object sender, FormClosedEventArgs e)
        {
            LlenarDataGrid();
        }

        private void dgvListadoProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
