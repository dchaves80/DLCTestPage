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
    

    public partial class abm_articulos : Form
    {

        List<Model.FormaDePagoControlListener> FORMAPAGO_LISTENER = new List<FormaDePagoControlListener>();

        public abm_articulos()
        {
            InitializeComponent();
        }

        void fillProveedores()
        {
            cmbProveedores.Items.Clear();
            cmbProveedores.Items.Add(new cmbItem("(Ninguno)", -1));
            List<Model.Proveedor> listaProveedores = Model.Proveedor.GetAll();
            if (listaProveedores != null) { 
            foreach (Proveedor p in listaProveedores)
            {
                cmbProveedores.Items.Add(new cmbItem(p.NOMBRE, p.ID));
            }
            cmbProveedores.SelectedIndex = 0;
            }
        }


        void fillFormasDePago()
        {
            List<Model.FormaDePago> fp = Model.FormaDePago.GetAll();
            
            if (fp != null)
            {
                int y = 0;
                foreach (Model.FormaDePago f in fp)
                {
                    Controles.FormaDePago ctrl = new Controles.FormaDePago(f);
                    FORMAPAGO_LISTENER.Add(new FormaDePagoControlListener(ctrl.chkBoxEnabled, ctrl.rdProcentage, ctrl.txtValue, ctrl.lblPrecioFinal,f));
                    ctrl.txtValue.TextChanged += TxtValue_TextChanged;
                    ctrl.rdProcentage.CheckedChanged += RdProcentage_CheckedChanged;
                        ctrl.Location = new Point(ctrl.Location.X, y);
                    pnlFormasDePago.Controls.Add(ctrl);
                    y += 45;
                    
                }
            }
        }

        private void RdProcentage_CheckedChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void TxtValue_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        void fillUnidades()
        {
            List<Unidad> lu = Unidad.GetAll();
            if (lu != null)
            {
                foreach (Unidad u in lu)
                {
                    cmbUnidad.Items.Add(new cmbItem(u.NOMBRE_UNIDAD, u.ID));
                }
            }
        }

        private void ABM_Articulo_Load(object sender, EventArgs e)
        {
            fillProveedores();
            fillUnidades();
            fillFormasDePago();
           
        }

        private void calcular()
        {
            decimal bruto;
            decimal iva;
            decimal neto;
            decimal ganancia;
            decimal final;

            decimal brutosiniva;
            decimal netosiniva;
            decimal gananciasiniva;
            decimal finalsiniva;
            decimal diferencia;

            bool error = false;

            txtBruto.ForeColor = Color.Black;
            txtIva.ForeColor = Color.Black;
            txtGanancia.ForeColor = Color.Black;

            try
            {
                bruto = decimal.Parse(txtBruto.Text);
                iva = decimal.Parse(txtIva.Text);
                ganancia = decimal.Parse(txtGanancia.Text);
                neto = ((iva * bruto) / 100)+bruto;
                final = ((ganancia * neto) / 100)+neto;
                txtNeto.Text = neto.ToString();
                txtFinal.Text = final.ToString();

                brutosiniva = bruto;
                netosiniva = bruto;
                gananciasiniva = ganancia;
                finalsiniva = ((gananciasiniva * netosiniva) / 100) + netosiniva;
                diferencia = final - finalsiniva;

                txtSinIvaBruto.Text = brutosiniva.ToString("#.00");
                txtSinIvaNeto.Text = netosiniva.ToString("#.00");
                txtSinIvaGanancia.Text = gananciasiniva.ToString("#.00");
                txtSinIvaFinal.Text = finalsiniva.ToString("#.00");
                txtDiferencia.Text = diferencia.ToString("#.00");



                foreach (Model.FormaDePagoControlListener i in FORMAPAGO_LISTENER)
                {
                    if (i.ENABLED == true)
                    {
                        decimal pf = 0;
                        if (i.PERCENT == true)
                        {
                            pf = (final * decimal.Parse(i.TXTVALUE.Text) / 100) + final;
                            i.LBLPRECIOFINAL.Text = pf.ToString();
                        }
                        else
                        {
                            pf = (final + decimal.Parse(i.TXTVALUE.Text));
                            i.LBLPRECIOFINAL.Text = pf.ToString();
                        }
                    }
                    else
                    {
                        i.TXTVALUE.Text = "0";
                    }
                }


            }
            catch (Exception e)
            {
                error = true;
            }
            if (error == true)
            {
                btnGuardar.Enabled = false;
                txtBruto.ForeColor = Color.Red;
                txtIva.ForeColor = Color.Red;
                txtGanancia.ForeColor = Color.Red;
            }
            else
            {
                btnGuardar.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Desea guardar este articulo?", "Creación de articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cmbItem p = (cmbItem)cmbProveedores.SelectedItem;
                cmbItem u = (cmbItem)cmbUnidad.SelectedItem;
                List<FormaDePagoDatarow> DR = new List<FormaDePagoDatarow>();
                foreach (Controles.FormaDePago fp in pnlFormasDePago.Controls)
                {
                    if (fp.chkBoxEnabled.Checked == true)
                    {
                        DR.Add(new FormaDePagoDatarow(fp.rdProcentage.Checked, fp.FORMADEPAGO.ID, decimal.Parse(fp.txtValue.Text)));
                    }
                }

                Articulo A = Articulo.NewArticle(txtNombreArticulo.Text, txtCodigo.Text, u.VALUE,p.VALUE, 0,decimal.Parse(txtBruto.Text),decimal.Parse(txtIva.Text),decimal.Parse(txtNeto.Text),decimal.Parse(txtGanancia.Text),decimal.Parse(txtFinal.Text),DR);
                

                if (MessageBox.Show(this, "Desea cargar otro articulo al sistema?", "Creación de articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    abm_articulos a = new abm_articulos();
                    this.Close();
                    a.ShowDialog(this.Parent);
                }
                else
                {
                    this.Close();
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBruto_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtIva_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtGanancia_TextChanged(object sender, EventArgs e)
        {
            calcular();
        }

        private void txtFinal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
