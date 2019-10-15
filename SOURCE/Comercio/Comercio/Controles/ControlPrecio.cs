using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Comercio.Controles
{
    public partial class ControlPrecio : UserControl
    {
        public ControlPrecio(FormaDePagoDatarow dr)
        {
            InitializeComponent();
            Model.FormaDePago fp =  Model.FormaDePago.GetById(dr.IDFORMAPAGO);
            lblNombre.Text = fp.NOMBRE;
            lblPRECIO.Text = calcularpreciofinal(dr, Articulo.getById(dr.IDARTICULO)).ToString("#.00");
        }

        decimal calcularpreciofinal(FormaDePagoDatarow dr, Articulo art)
        {
            if (dr.ISPERCENT)
            {
                return ((art.PRECIOFINAL * dr.VALUE) / 100) + art.PRECIOFINAL;
            }
            else
            {
                return art.PRECIOFINAL + dr.VALUE;
            }
        }

        

        private void ControlPrecio_Load(object sender, EventArgs e)
        {

        }
    }
}
