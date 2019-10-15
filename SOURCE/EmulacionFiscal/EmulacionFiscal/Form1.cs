using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Diagnostics;

using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EmulacionFiscal
{
    public partial class Form1 : Form
    {


        List<int> SearchedIndex;
        int CurrentPosition = -1;
        string[] myconfigs;

        public Form1()
        {
            InitializeComponent();
        }


        OCXFISLib.EpsonTicket ET;

        private void Form1_Load(object sender, EventArgs e)
        {

            string ejecutable = Application.StartupPath;

            if (File.Exists(ejecutable + "\\config")==false)
            {
                File.Create(ejecutable + "\\config").Close();
                File.AppendAllText
                    (
                    ejecutable + "\\config",
                    "PORT:5" + Environment.NewLine +
                    "IDDNN:5" + Environment.NewLine +
                    "HOST:./SQLCLOVERFIELD" + Environment.NewLine +
                    "CATALOG:DBS" + Environment.NewLine +
                    "USER:USR" + Environment.NewLine +
                    "PASS:PSW" + Environment.NewLine
                    );
                Application.Exit();
            }

            try {

                string[] configs = System.IO.File.ReadAllLines(ejecutable + "\\config");
                myconfigs = configs;
                
            } catch (Exception excepte)
            {
                MessageBox.Show(excepte.Message);
                Application.Exit();
            }
            
            
            //axDriverFiscal1.OnDriverError += AxDriverFiscal1_OnDriverError;
            //axDriverFiscal1.OnFiscalError += AxDriverFiscal1_OnFiscalError;
            //axDriverFiscal1.IF_OPEN("COM5", 9600);
            
            
            







            /*
            axPrinterFiscal1.OpenTicket();
            axPrinterFiscal1.SendTicketItem(ref item, ref cuantity, ref unitprice, ref ivatax, ref cuali, ref bundle, ref it);
            axPrinterFiscal1.GetTicketSubtotal(ref impresion, ref SUBT);
            axPrinterFiscal1.SendTicketPayment(ref pago, ref importe,ref tipopago);


            axPrinterFiscal1.CloseTicket();
            MessageBox.Show(axPrinterFiscal1.FiscalStatus);*/
        }

      

        string ConvertDateTimeToString(DateTime pD)
        {
            string year = pD.Year.ToString();
            string month = pD.Month.ToString();
            string day = pD.Day.ToString();
            string hour = pD.Hour.ToString();
            string minute = pD.Minute.ToString();
            string second = pD.Second.ToString();

            return year + "-" + month + "-" + day + " " + hour + ":" + minute + ":" + second; 
        }

        string getconfig(string configname)
        {
            for (int a = 0; a < myconfigs.Length; a++) { 
            if (myconfigs[a].ToLower().Contains(configname)==true)
            {
                    string[] splitter = { ":" };
                    return myconfigs[a].Split(splitter, StringSplitOptions.None)[1];
                    
            } 
            }
            return "none";
        }

        string formconnectionstring(string host, string catalog, string user, string pass)
        {
            //"Data Source=.\\SQLCLOVERFIELD;Initial Catalog=Minion;User ID=sa;Password=cloverfield161185"
            string ConnectionString = "Data Source=[host];Initial Catalog=[catalog];User ID=[user];Password=[pass]";
            ConnectionString = ConnectionString.Replace("[host]", host);
            ConnectionString = ConnectionString.Replace("[catalog]", catalog);
            ConnectionString = ConnectionString.Replace("[user]", user);
            ConnectionString = ConnectionString.Replace("[pass]", pass);
            return ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            MinionDataSetTableAdapters.SELECT_FACTURASBetweenDatesTableAdapter TA = new MinionDataSetTableAdapters.SELECT_FACTURASBetweenDatesTableAdapter();
            MinionDataSet.SELECT_FACTURASBetweenDatesDataTable DT = new MinionDataSet.SELECT_FACTURASBetweenDatesDataTable();
            TA.Connection.ConnectionString = formconnectionstring(getconfig("host"), getconfig("catalog"), getconfig("user"), getconfig("pass"));
            
            //cambiar iduser 1 por 2
            TA.Fill(DT,int.Parse(getconfig("iddnn")), ConvertDateTimeToString(DateTime.Now.AddDays(-10)), ConvertDateTimeToString(DateTime.Now.AddDays(1)), "0", false);
            txt_Search.Text = "";
            DisableSearch();
            if (SearchedIndex != null)
            {
                SearchedIndex.Clear();
            }
            CurrentPosition = -1;
          

            if (DT.Rows.Count > 0)
            {
                for (int a = 0; a < DT.Rows.Count; a++)
                {
                    MinionDataSetTableAdapters.GetDetalleFacturaTableAdapter TADF = new MinionDataSetTableAdapters.GetDetalleFacturaTableAdapter();
                    TADF.Connection.ConnectionString= formconnectionstring(getconfig("host"), getconfig("catalog"), getconfig("user"), getconfig("pass")); 
                    MinionDataSet.GetDetalleFacturaDataTable DTDF = new MinionDataSet.GetDetalleFacturaDataTable();
                    TADF.Fill(DTDF, int.Parse(DT.Rows[a]["Id"].ToString()), int.Parse(getconfig("iddnn")));
                    if (DTDF.Count > 0)
                    {
                        for (int b = 0; b < DTDF.Count; b++)
                        {
                            MinionDataSetTableAdapters.select_singlearticlebaseTableAdapter TASA = new MinionDataSetTableAdapters.select_singlearticlebaseTableAdapter();
                            TASA.Connection.ConnectionString= formconnectionstring(getconfig("host"), getconfig("catalog"), getconfig("user"), getconfig("pass"));
                            MinionDataSet.select_singlearticlebaseDataTable DTSA = new MinionDataSet.select_singlearticlebaseDataTable();
                            TASA.Fill(DTSA, int.Parse(getconfig("iddnn")), int.Parse(DTDF.Rows[b]["IdArticulo"].ToString()));
                            string Articulo = "Articulo Vario";
                            string CodigoInterno = "00000000";
                            if (DTSA.Rows.Count > 0)
                            {
                                Articulo = DTSA[0]["Descripcion"].ToString().Replace(" ", ".");
                                CodigoInterno = DTSA[0]["CodigoInterno"].ToString().Replace(" ", ".");
                                string cantidad = DTDF.Rows[b]["CantidadINT"].ToString();
                                string preciou = DTDF.Rows[b]["PrecioFinal"].ToString();
                                string IVA = DTDF.Rows[b]["IVA"].ToString();
                                string TOTAL = (decimal.Parse(cantidad) * decimal.Parse(preciou)).ToString();



                                DataGridViewRow R = new DataGridViewRow();
                                R.CreateCells(dataGridView1);
                                R.Cells[0].Value = CodigoInterno;
                                R.Cells[1].Value = Articulo;
                                R.Cells[2].Value = cantidad;
                                R.Cells[3].Value = preciou;
                                R.Cells[4].Value = IVA;
                                R.Cells[5].Value = TOTAL;




                                dataGridView1.Rows.Add(R);
                            }
                        }
                    }
                }
            } else
            {
                MessageBox.Show("No hay vendidos recientemente...");

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            string item = "cena";
            string cuantity = "1000";
            string unitprice = "2300";
            string ivatax = "2100";
            string cuali = "M";
            string bundle = "1";
            string it = "0";
            string impresion = "p";
            string SUBT = "SUBT";
            string pago = "pago";
            string tipopago = "T";
            string importe = "1000";
            string losha = "";
            //ET = axDriverFiscal1.EpsonTicket;
            
            File.Delete("c:\\ticket.txt");
            File.Create("c:\\ticket.txt").Close();

            File.AppendAllText("c:\\ticket.txt", "@TIQUEABRE|C|" + Environment.NewLine,Encoding.ASCII);

            //ET.TIQUEABRE("");
            

            for (int a = 0; a<dataGridView1.Rows.Count; a++)
            {

                if (dataGridView1.Rows[a].Cells[6].FormattedValue.ToString() == "True") { 


                item = dataGridView1.Rows[a].Cells[1].Value.ToString();
                    cuantity = dataGridView1.Rows[a].Cells[2].Value.ToString();

                    if (item.Length > 19)
                    {
                        item = item.Substring(0, 18);
                    }

                    item = "*demo*" + item.Substring(0, item.Length - 6);

                    unitprice = dataGridView1.Rows[a].Cells[3].Value.ToString();

                    char[] Mask = { ',', '.' };

                    string ent = unitprice.Split(Mask)[0];
                    string dec = unitprice.Split(Mask)[1];
                    dec = dec + "000000";
                    dec = dec.Substring(0, 2);
                    unitprice = ent +"."+  dec;





                    ivatax = dataGridView1.Rows[a].Cells[4].Value.ToString();

                    ent = ivatax.Split(Mask)[0];
                    dec = ivatax.Split(Mask)[1];
                    dec = dec + "000000";
                    dec = dec.Substring(0, 2);
                    ivatax =ent + "." + dec;
                    string moduloitem = "@TIQUEITEM|[item]|[cant]|[preciou]|[iva]|M|1|0|0|" + Environment.NewLine;
                    moduloitem = moduloitem.Replace("[item]", item.ToUpper());
                    moduloitem = moduloitem.Replace("[cant]", cuantity);
                    moduloitem = moduloitem.Replace("[preciou]", unitprice);
                    moduloitem = moduloitem.Replace("[iva]", ivatax);

                      File.AppendAllText("c:\\ticket.txt", moduloitem,Encoding.ASCII);
                    //ET.TIQUEITEM(item, double.Parse(cuantity), double.Parse(unitprice), double.Parse(ivatax), "", 1, 0, 0);
                }


            }

            File.AppendAllText("c:\\ticket.txt","@TIQUESUBTOTAL|P|Subtotal"+Environment.NewLine+"@TIQUECIERRA|T|", Encoding.ASCII);
            Thread.Sleep(300);
            //axPrinterFiscal1.SendTicketPayment(ref pago, ref importe, ref tipopago);
            //ET.TIQUEPAGO(pago, double.Parse(importe), tipopago);
            //axPrinterFiscal1.GetTicketSubtotal(ref impresion, ref SUBT);
            //ET.TIQUESUBTOTAL(impresion, SUBT);
            //axPrinterFiscal1.CloseTicket();
            //ET.TIQUECIERRA("");

            ProcessStartInfo PSI = new ProcessStartInfo("c:\\ixbatch\\ixbatchw.exe", "-p COM" + getconfig("port") + " -i c:\\Ticket.txt -o c:\\salida.txt -s 9600");
            PSI.UseShellExecute = true;
            
            Process P = Process.Start(PSI);
            P.WaitForExit();
            

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string j = "Z";
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Text = "Resultado:";

            if (SearchedIndex == null)
            {
                SearchedIndex = new List<int>();
            }
            CurrentPosition = -1;
            SearchedIndex.Clear();

            if (dataGridView1.Rows.Count > 0 && txt_Search.Text.Trim()!="")
            {
                EnableSearch();
                for (int a = 0; a < dataGridView1.Rows.Count; a++)
                {
                    if (dataGridView1.Rows[a].Cells[1].Value.ToString().ToLower().Contains(txt_Search.Text.ToLower()))
                    {
                        SearchedIndex.Add(a);
                    }
                }
                label1.Text += SearchedIndex.Count.ToString();
            }
            else
            {
                DisableSearch();
                CurrentPosition = -1;
            }
        }

        void EnableSearch()
        {
            btn_next.Enabled = true;
            btn_prevoius.Enabled = true;
        }

        void DisableSearch()
        {
            btn_next.Enabled = false;
            btn_prevoius.Enabled = false;
        }

        private void btn_prevoius_Click(object sender, EventArgs e)
        {
            CurrentPosition--;

            

            if (CurrentPosition <= -1)
            {
                CurrentPosition = SearchedIndex.Count-1;
            }
            SelectPosition();

        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            CurrentPosition++;
            if (CurrentPosition >= SearchedIndex.Count)
            {
                CurrentPosition = 0;
            }

            if (CurrentPosition < 0)
            {
                CurrentPosition = 0;
            }
            SelectPosition();
        }

        void SelectPosition()
        {
            try { 
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.Rows[SearchedIndex[CurrentPosition]].Selected = true;
            dataGridView1.CurrentCell = dataGridView1.SelectedRows[0].Cells[0];
            } catch (Exception e)
            {
                CurrentPosition = 0;
            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
