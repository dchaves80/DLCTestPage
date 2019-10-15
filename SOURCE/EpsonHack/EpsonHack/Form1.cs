using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace EpsonHack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EPSON_Impresora_Fiscal.PrinterFiscal Ifiscal = new EPSON_Impresora_Fiscal.PrinterFiscal();
            
            Ifiscal.PortNumber = 2;
            Ifiscal.BaudRate = "9600";
            MessageBox.Show(Ifiscal.FeedPaper("A", "20").ToString());
            MessageBox.Show(Ifiscal.CutPaper().ToString());





        }
    }
}
