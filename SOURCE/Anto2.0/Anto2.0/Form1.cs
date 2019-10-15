using Data2.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Anto2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime Start = cldstart.Value;
            DateTime End = cldend.Value;

            
            List<Struct_Factura> ListadoF = Data2.Class.Struct_Factura.GetFacturasBetweenDates(Start, End, 1, false, Data2.Class.Struct_Factura.TipoDeFactura.Null);
            dtgvFacturas.Rows.Clear();
            dtgvDetalle.Rows.Clear();
                
            if (ListadoF != null && ListadoF.Count > 0)
            {
                foreach (Struct_Factura F in ListadoF)
                {
                    DataGridViewRow R = new DataGridViewRow();
                    R.CreateCells(dtgvFacturas);
                    R.Cells[0].Value = F.Id.ToString();
                    R.Cells[1].Value = F.Id.ToString();
                    R.Cells[2].Value = F.Fecha.ToString();
                    dtgvFacturas.Rows.Add(R);
                }
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarClientes();
        }

        private void LlenarClientes()
        {
            List<Struct_Cliente> ClienteList = Struct_Cliente.SearchClient("%%%", 1);
            if (ClienteList != null && ClienteList.Count > 0)
            {
                foreach (Struct_Cliente C in ClienteList)
                {
                    DataGridViewRow dr = new DataGridViewRow();
                    dr.CreateCells(dtgvClientes);
                    dr.Cells[0].Value = C.ID.ToString();
                    dr.Cells[1].Value = C.RS;
                    dr.Cells[2].Value = C.DNI;
                    dr.Cells[3].Value = C.DOMICILIO;
                    dtgvClientes.Rows.Add(dr);
                }
            }
        }

        private void dtgvFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgvDetalle.Rows.Clear();
            int IdFactura = int.Parse(dtgvFacturas.SelectedRows[0].Cells[0].Value.ToString());
            Struct_Factura F = Struct_Factura.GetFacturaById(1, IdFactura);
            if (F != null)
            {
                List<Struct_DetalleFactura> listdet = F.GetDetalle();

                foreach (Struct_DetalleFactura det in listdet) { 
                DataGridViewRow R = new DataGridViewRow();
                R.CreateCells(dtgvDetalle);

                    if (det.PRODUCTO != null)
                    {

                        R.Cells[0].Value = det.PRODUCTO.Id;
                        R.Cells[1].Value = det.PRODUCTO.Descripcion;
                        R.Cells[2].Value = det.PRODUCTO.CodigoBarra;
                        R.Cells[3].Value = det.isdec ? det.DETALLEDEC.ToString() : det.DETALLEINT.ToString();
                        R.Cells[4].Value = det.getTotalConIva().ToString();
                    }
                    else
                    {
                        R.Cells[1].Value = "Producto borrado";
                    }
                    dtgvDetalle.Rows.Add(R);
                }

            }

        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            if (dtgvFacturas.SelectedRows.Count > 0 && dtgvClientes.SelectedRows.Count > 0)
            {
                int idfactura = int.Parse(dtgvFacturas.SelectedRows[0].Cells[0].Value.ToString());
                int idCliente = int.Parse(dtgvClientes.SelectedRows[0].Cells[0].Value.ToString());

                Struct_Factura F = Struct_Factura.GetFacturaById(1, idfactura);
                Struct_Cliente C = Struct_Cliente.GetClient(idCliente, 1);

                string filename = "c:\\cliente[idfile]_" + C.RS.ToLower().Replace(" ", "").Substring(0, 5) + ".txt";
                string salidaname = "c:\\salida[idfile]_" + C.RS.ToLower().Replace(" ", "").Substring(0, 5) + ".txt";
                bool exist = true;
                int counter = 0;
                while (exist == true)
                {
                    string newfilename = filename.Replace("[idfile]", counter.ToString());
                    string newSalida = salidaname.Replace("[idfile]", counter.ToString());
                    if (File.Exists(newfilename) == true)
                    {
                        counter++;
                    }
                    else
                    {
                        filename = newfilename;
                        salidaname = newSalida;
                        exist = false;
                    }
                }



                List<String> textLines = new List<string>();
                textLines.Add("@FACTABRE|T|C|A|1|P|10|R|I|......" + C.RS.Substring(0, (C.RS.Length<13?C.RS.Length:13)) + "||CUIT|" + C.DNI.Replace(".", "").Replace("-", "") + "|N|" + C.DOMICILIO.Substring(0, (C.DOMICILIO.Length<10?C.DOMICILIO.Length:10)) + "|||C");
                List<Struct_DetalleFactura> Detalle = F.GetDetalle();
                foreach (Struct_DetalleFactura D in Detalle)
                {
                    
                    textLines.Add("@FACTITEM|......" + D.PRODUCTO.Descripcion.ToUpper().Substring(0,(D.PRODUCTO.Descripcion.Length<10?D.PRODUCTO.Descripcion.Length:10)) + "|" + (D.isdec  ? D.DETALLEDEC.ToString("#.00") : D.DETALLEINT.ToString()) + "|"+ (((100m*D.PRODUCTO.PrecioFinal)/121m)).ToString("#.00") + "|21.00|" + "M|1|0||||0|0");
                }

                textLines.Add("@FACTCIERRA|T|M|FINAL");
                textLines.Add("");

                string[] S = textLines.ToArray();

                File.WriteAllLines(filename,S,Encoding.Default);

                ProcessStartInfo PSI = new ProcessStartInfo("C:\\IXBATCH\\ixbatchw.exe", "-p COM3 -i " + filename + " -o " + salidaname + " -s 9600 ");
                PSI.UseShellExecute = true;
                PSI.WorkingDirectory = "C:\\IXBATCH";
                Process.Start(PSI).WaitForExit();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una factura y un cliente para poder realizar la impresion del ticket");
            }
        }




        private void btnConsumidorFinal_Click(object sender, EventArgs e)
        {
            if (dtgvFacturas.SelectedRows.Count >0)
            {
                int idfactura = int.Parse(dtgvFacturas.SelectedRows[0].Cells[0].Value.ToString());
                int idCliente = int.Parse(dtgvClientes.SelectedRows[0].Cells[0].Value.ToString());

                Struct_Factura F = Struct_Factura.GetFacturaById(1, idfactura);
                

                string filename = "c:\\clienteTicket[idfile]" + ".txt";
                string salidaname = "c:\\salida[idfile]_" +  ".txt";

                bool exist = true;
                int counter = 0;
                while (exist == true)
                {
                    string newfilename = filename.Replace("[idfile]", counter.ToString());
                    string newSalida = salidaname.Replace("[idfile]", counter.ToString());
                    if (File.Exists(newfilename) == true)
                    {
                        counter++;
                    }
                    else
                    {
                        filename = newfilename;
                        salidaname = newSalida;
                        exist = false;
                    }
                }

                
                List <String> textLines = new List<string>();
                textLines.Add("@TIQUEABRE|C|");
                List<Struct_DetalleFactura> Detalle = F.GetDetalle();
                foreach (Struct_DetalleFactura D in Detalle)
                {

                    textLines.Add("@TIQUEITEM|......" + D.PRODUCTO.Descripcion.ToUpper().Substring(0, (D.PRODUCTO.Descripcion.Length < 10 ? D.PRODUCTO.Descripcion.Length : 10)) + "|" + (D.isdec ? D.DETALLEDEC.ToString("#.00") : D.DETALLEINT.ToString()) + "|" + D.PRODUCTO.PrecioFinal.ToString("#.00") + "|" + D.PRODUCTO.IVA.ToString("#.00") + "|" + "M|1|0|0|0|");
                }
                textLines.Add("@TIQUESUBTOTAL|P|Subtotal");
                textLines.Add("@TIQUECIERRA|T|");
                textLines.Add("");

                string[] S = textLines.ToArray();

                File.WriteAllLines(filename, S, Encoding.Default);

                ProcessStartInfo PSI = new ProcessStartInfo("C:\\IXBATCH\\ixbatchw.exe", "-p COM3 -i " + filename + " -o " + salidaname + " -s 9600 ");
                PSI.UseShellExecute = true;
                PSI.WorkingDirectory = "C:\\IXBATCH";
                Process.Start(PSI).WaitForExit();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una factura y un cliente para poder realizar la impresion del ticket");
            }
        }

        private void btnCierreZ_Click(object sender, EventArgs e)
        {
            string filename = "c:\\Cierre[idfile]" + ".txt";
            

            bool exist = true;
            int counter = 0;
            while (exist == true)
            {
                string newfilename = filename.Replace("[idfile]", counter.ToString());
                
                if (File.Exists(newfilename) == true)
                {
                    counter++;
                }
                else
                {
                    filename = newfilename;
                
                    exist = false;
                }
            }

            List<String> textLines = new List<string>();
            textLines.Add("@CIERREZ|");
            string[] S = textLines.ToArray();

            File.WriteAllLines(filename, S, Encoding.Default);

            ProcessStartInfo PSI = new ProcessStartInfo("C:\\IXBATCH\\ixbatchw.exe", "-p COM3 -i " + filename + " -o " + "c:\\salidacierrez.txt" + " -s 9600 ");
            PSI.UseShellExecute = true;
            PSI.WorkingDirectory = "C:\\IXBATCH";
            Process.Start(PSI).WaitForExit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgvFacturas.SelectedRows.Count > 0 && dtgvClientes.SelectedRows.Count > 0)
            {
                int idfactura = int.Parse(dtgvFacturas.SelectedRows[0].Cells[0].Value.ToString());
                int idCliente = int.Parse(dtgvClientes.SelectedRows[0].Cells[0].Value.ToString());

                Struct_Factura F = Struct_Factura.GetFacturaById(1, idfactura);
                Struct_Cliente C = Struct_Cliente.GetClient(idCliente, 1);

                string filename = "c:\\cliente[idfile]_" + C.RS.ToLower().Replace(" ", "").Substring(0, 5) + ".txt";
                string salidaname = "c:\\salida[idfile]_" + C.RS.ToLower().Replace(" ", "").Substring(0, 5) + ".txt";
                bool exist = true;
                int counter = 0;
                while (exist == true)
                {
                    string newfilename = filename.Replace("[idfile]", counter.ToString());
                    string newSalida = salidaname.Replace("[idfile]", counter.ToString());
                    if (File.Exists(newfilename) == true)
                    {
                        counter++;
                    }
                    else
                    {
                        filename = newfilename;
                        salidaname = newSalida;
                        exist = false;
                    }
                }



                List<String> textLines = new List<string>();
                textLines.Add("@FACTABRE|T|C|B|1|P|10|R|E|......" + C.RS.Substring(0, (C.RS.Length < 13 ? C.RS.Length : 13)) + "||CUIT|" + C.DNI.Replace(".", "").Replace("-", "") + "|N|DDEMOD " + C.DOMICILIO.Substring(0, (C.DOMICILIO.Length < 20 ? C.DOMICILIO.Length : 20)) + "|||C");
                List<Struct_DetalleFactura> Detalle = F.GetDetalle();
                foreach (Struct_DetalleFactura D in Detalle)
                {

                    textLines.Add("@FACTITEM|......" + D.PRODUCTO.Descripcion.ToUpper().Substring(0, (D.PRODUCTO.Descripcion.Length < 10 ? D.PRODUCTO.Descripcion.Length : 10)) + "|" + (D.isdec ? D.DETALLEDEC.ToString("#.00") : D.DETALLEINT.ToString()) + "|" + D.PRODUCTO.PrecioFinal.ToString("#.00") + "|21.00|" + "M|1|0||||0|0");
                }

                textLines.Add("@FACTCIERRA|T|M|FINAL");
                textLines.Add("");

                string[] S = textLines.ToArray();

                File.WriteAllLines(filename, S, Encoding.Default);

                ProcessStartInfo PSI = new ProcessStartInfo("C:\\IXBATCH\\ixbatchw.exe", "-p COM3 -i " + filename + " -o " + salidaname + " -s 9600 ");
                PSI.UseShellExecute = true;
                PSI.WorkingDirectory = "C:\\IXBATCH";
                Process.Start(PSI).WaitForExit();

            }
            else
            {
                MessageBox.Show("Debe seleccionar una factura y un cliente para poder realizar la impresion del ticket");
            }

        }
    }
}
