using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class FormaDePagoControlListener
    {
        CheckBox enabled;
        RadioButton percent;
        TextBox value;
        Label preciofinal;
        FormaDePago formadepago;

        public bool ENABLED { get => enabled.Checked; }
        public bool PERCENT { get => percent.Checked; }
        public TextBox TXTVALUE { get => value; }
        public Label LBLPRECIOFINAL { get => preciofinal; }
        public FormaDePago FORMADEPAGO { get => formadepago; }

        public FormaDePagoControlListener(CheckBox enab, RadioButton per, TextBox val, Label prec, FormaDePago FP)
        {
            enabled = enab;
            percent = per;
            value = val;
            preciofinal = prec;
            formadepago = FP;
        }

    }
}
