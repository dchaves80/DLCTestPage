using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercio.Controles
{
    public partial class FormaDePago : UserControl
    {
        private Model.FormaDePago formapago;
        public Model.FormaDePago FORMADEPAGO { get => formapago; }
        

        public FormaDePago(Model.FormaDePago fp)
        {
            formapago = fp;
            InitializeComponent();
        }

        /*public setearReferenciaFormaDePago()
        {

        }*/
        
        private void FormaDePago_Load(object sender, EventArgs e)
        {
            DeshabilitarControl();
            chkBoxEnabled.Text = formapago.NOMBRE;
        }

        private void chkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxEnabled.Checked == true)
            {
                HabilitarControl();
            }
            else
            {
                DeshabilitarControl();
            }
        }

        private void DeshabilitarControl()
        {
            rdPrecioFinal.Enabled = false;
            rdProcentage.Enabled = false;
            txtValue.Enabled = false;
        }

        private void HabilitarControl()
        {
            rdPrecioFinal.Enabled = true;
            rdProcentage.Enabled = true;
            txtValue.Enabled = true;
        }
    }
}
