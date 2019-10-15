using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Balanza.Forms
{
    public partial class Chofer : Form
    {
        public Chofer()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtChofer.Text != "" && txtChofer.Text != null)
            {
                SQLiteConnector.AgregarChofer(txtChofer.Text);
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }
    }
}
