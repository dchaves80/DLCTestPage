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
    public partial class ABM_Proveedor : Form
    {
        Model.Constants.ABM_Mode MODO;
        Proveedor proveedor = null;
        

        public ABM_Proveedor(Model.Constants.ABM_Mode p_MODO, int? p_idProveedor = null)
        {
           


            InitializeComponent();
            MODO = p_MODO;

            if (p_idProveedor != null)
            {
                proveedor = Proveedor.GetById(p_idProveedor.Value);

            }

        }

        private void fillfields()
        {
            txtNombre.Text = proveedor.NOMBRE;
            txtTelefono.Text = proveedor.TELEFONO; ;
            txtCUIT.Text = proveedor.CUIT;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (MODO == Constants.ABM_Mode.NuevoReg)
            {

                Proveedor P = Model.Proveedor.InsertNew(txtNombre.Text, txtTelefono.Text, txtCUIT.Text);
            }
            else
            {
                proveedor.Actualizar(txtNombre.Text, txtTelefono.Text, txtCUIT.Text);
                

            }
            this.Close();


        }

        private void ABM_Proveedor_Load(object sender, EventArgs e)
        {
            if (MODO == Constants.ABM_Mode.Editar) { 
            fillfields();
            }
        }
    }
}
