using Balanza.Modelos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace Balanza
{
    

    public partial class Main : Form
    {

       

        SerialPort S = new SerialPort();
        TcpListener Server=null;
        bool tryconnection = true;
        List<TcpClient> ClientList = new List<TcpClient>();
        int Baudios;
        string PORT;
        string PUERTOCOM;
        zkemkeeper.CZKEM cZKEM = new zkemkeeper.CZKEM();

        public Main()
        {
            
            InitializeComponent();
        }


        private void CargarConfiguraciones()
        {
            Baudios = int.Parse(SQLiteConnector.GetConfiguration("Baudios"));
            PUERTOCOM = SQLiteConnector.GetConfiguration("PuertoCom");

            txtBaudios.Text = SQLiteConnector.GetConfiguration("Baudios");
            txtIpLan.Text = SQLiteConnector.GetConfiguration("Ip");
            txtPuertoCOM.Text = SQLiteConnector.GetConfiguration("PuertoCom");
            txtPuertoLan.Text = SQLiteConnector.GetConfiguration("Puerto");
            txtIPControlador.Text = SQLiteConnector.GetConfiguration("IPControlador");
        }

        private void GuardarCOnfiguracion()
        {
            SQLiteConnector.UpdateConfiguracion("Baudios", txtBaudios.Text);
            SQLiteConnector.UpdateConfiguracion("Ip", txtIpLan.Text);
            SQLiteConnector.UpdateConfiguracion("PuertoCom", txtPuertoCOM.Text);
            SQLiteConnector.UpdateConfiguracion("Puerto", txtPuertoLan.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string html = string.Empty;
            string url = "http://worldtimeapi.org/api/timezone/America/Argentina/Cordoba";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            JavaScriptSerializer JSC = new JavaScriptSerializer();
            timeclass t = JSC.Deserialize<timeclass>(html);


            string[] splitt1 = { "T" };
            string[] splitt2 = { "-" };

            int year;
            int month;
            int day;

            string fecha = t.datetime.Split(splitt1, StringSplitOptions.None)[0];
            string[] datecomponents = fecha.Split(splitt2, StringSplitOptions.None);

            DateTime dt = new DateTime(int.Parse(datecomponents[0]), int.Parse(datecomponents[1]), int.Parse(datecomponents[2]));

            DateTime D = new DateTime(2019, 9, 19);
            DateTime N = dt;
            lblt.Text = (N - D).Days.ToString();
            if ((N - D).Days > 20)
            {
                MessageBox.Show(this, "Problema de conexion en el puerto COM", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }





            CargarConfiguraciones();
            S = new SerialPort(txtPuertoCOM.Text,int.Parse(txtBaudios.Text), Parity.None,8,StopBits.One);
            /*Server.Server.ReceiveTimeout = 50000;
            Server.Server.SendTimeout = 50000;*/
            Server = new TcpListener(IPAddress.Parse(txtIpLan.Text), int.Parse(txtPuertoLan.Text));
            


            Server.Start();
            
            TimerServer.Enabled = true;
           
            RefreshDTGV();
        }

        private void RefreshDTGV()
        {
            List<Modelo_Peso> MP = SQLiteConnector.Seleccionar_TodosLosPesos();
            dtgvmovimientos.Rows.Clear();
            if (MP != null)
            {
                foreach (Modelo_Peso mp in MP)
                {
                    DataGridViewRow R = new DataGridViewRow();
                    R.CreateCells(dtgvmovimientos);
                    R.Cells[0].Value = mp.ID.ToString();
                    R.Cells[1].Value = Tools.DateTimeToSQLiteDate(mp.HORAYFECHA);
                    R.Cells[2].Value = Tools.DateTimeToSQLiteTime(mp.HORAYFECHA);
                    R.Cells[3].Value = SQLiteConnector.Seleccionar_CamionById(mp.IDCAMION)["Patente"];
                    R.Cells[4].Value = SQLiteConnector.Seleccionar_ChoferById(mp.IDCHOFER)["Nombre"];
                    R.Cells[5].Value = SQLiteConnector.Seleccionar_ClienteById(mp.IDCLIENTE)["Nombre"];
                    R.Cells[6].Value = SQLiteConnector.Seleccionar_ProductoById(mp.IDPRODUCTO)["Nombre"];
                    R.Cells[7].Value = mp.BRUTO;
                    R.Cells[8].Value = mp.TARA;
                    R.Cells[9].Value = mp.NETO;
                    R.Cells[10].Value = mp.TBRUTO;
                    R.Cells[11].Value = mp.TTARA;
                    R.Cells[12].Value = mp.HUMEDAD;




                    dtgvmovimientos.Rows.Add(R);
                }
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (S.IsOpen == true)
            {

                List<byte> MyByteList = new List<byte>();


                while (S.ReadByte() != 2) { }
                
                int mybyte=0;
                while (mybyte != 3)
                {
                    mybyte = S.ReadByte();
                    if (mybyte != 3) { 
                    MyByteList.Add((byte)mybyte);
                    }
                }

                try
                {
                    string hola = System.Text.Encoding.UTF8.GetString(MyByteList.ToArray());
                    if (txtTara.Text == "") txtTara.Text = "0";
                    int tara = int.Parse(txtTara.Text);
                    txtpeso.Text = (int.Parse(hola) + tara).ToString();
                    
                    S.Close();
                    S = new SerialPort(txtPuertoCOM.Text, int.Parse(txtBaudios.Text));
                    S.Open();
                }
                catch (Exception exc)
                {
                    string EXCEPTION="";
                    EXCEPTION += exc.Message + Environment.NewLine;
                    EXCEPTION += exc.StackTrace;
                    File.WriteAllText(Application.StartupPath + "\\Log.txt" , EXCEPTION);
                    S.Close();
                    S = new SerialPort(txtPuertoCOM.Text, int.Parse(txtBaudios.Text));
                    S.Open();
                }



                MyByteList.Clear();
                
            }
            else
            {
                if (tryconnection == true) { 
                try { S.Open(); } catch (Exception EXC) { tryconnection = false; };
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode==Keys.F1)
            {
                if (groupBox1.Visible == true) {
                    groupBox1.Visible = false;
                    dtgvmovimientos.Columns["TBruto"].Visible = false;
                    dtgvmovimientos.Columns["TTara"].Visible = false;
                    btnBorrar.Visible = false;
                } else {
                    groupBox1.Visible = true;
                    dtgvmovimientos.Columns["TBruto"].Visible = true;
                    dtgvmovimientos.Columns["TTara"].Visible = true;
                    btnBorrar.Visible = true;
                };
            }
            else
            {
                
            }
        }

        private void btnNuevoCamion_Click(object sender, EventArgs e)
        {
            Forms.Camion C = new Forms.Camion();
            C.ShowDialog(this);
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Forms.Cliente C = new Forms.Cliente();
            C.ShowDialog(this);
        }

        private void btnNuevoChofer_Click(object sender, EventArgs e)
        {
            Forms.Chofer C = new Forms.Chofer();
            C.ShowDialog(this);
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            Forms.Producto C = new Forms.Producto();
            C.ShowDialog(this);
        }

        private void dtgvmovimientos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            Forms.RegistroBalanza D = new Forms.RegistroBalanza();
            D.FormClosed += D_FormClosed;
            D.ShowDialog();
        }

        private void D_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshDTGV();
            dtgvmovimientos.Rows[dtgvmovimientos.Rows.Count - 1].Selected = true;
            dtgvmovimientos.FirstDisplayedScrollingRowIndex = dtgvmovimientos.Rows.Count - 1;
            btnTara.Visible = true;
            btnPeso.Visible = true;
        }

        private void btnTara_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dtgvmovimientos.SelectedRows[0].Cells["Id"].Value.ToString());
            if (txtTara.Text == "") { txtTara.Text = "0"; }
            SQLiteConnector.Actualizar_Tara(ID, int.Parse(txtpeso.Text), int.Parse(txtTara.Text));
            CheckNeto(ID);
            RefreshDTGV();
        }

        private void dtgvmovimientos_SelectionChanged(object sender, EventArgs e)
        {

            if (dtgvmovimientos.SelectedRows.Count > 0)
            {

                lblid.Text = dtgvmovimientos.SelectedRows[0].Cells["Id"].Value.ToString();
                lblDate.Text = dtgvmovimientos.SelectedRows[0].Cells["Fecha"].Value.ToString();
                lblHora.Text = dtgvmovimientos.SelectedRows[0].Cells["Hora"].Value.ToString();
                lblPatente.Text = dtgvmovimientos.SelectedRows[0].Cells["Camion"].Value.ToString();
                lblChofer.Text = dtgvmovimientos.SelectedRows[0].Cells["Chofer"].Value.ToString();
                lblCliente.Text = dtgvmovimientos.SelectedRows[0].Cells["Cliente"].Value.ToString();
                lblProducto.Text = dtgvmovimientos.SelectedRows[0].Cells["Producto"].Value.ToString();
                lblBruto.Text = dtgvmovimientos.SelectedRows[0].Cells["Bruto"].Value.ToString();
                lblTara.Text = dtgvmovimientos.SelectedRows[0].Cells["Tara"].Value.ToString();
                lblNeto.Text = dtgvmovimientos.SelectedRows[0].Cells["Neto"].Value.ToString();
                lblHumedad.Text = dtgvmovimientos.SelectedRows[0].Cells["Hum"].Value.ToString();

                bool bruto = !(dtgvmovimientos.SelectedRows[0].Cells["Bruto"].Value.ToString() == "0");
                bool tara = !(dtgvmovimientos.SelectedRows[0].Cells["Tara"].Value.ToString() == "0");

                if (bruto == false && tara == false)
                {
                    btnTara.Visible = true;
                    btnPeso.Visible = true;
                }
                else
                {
                    btnTara.Visible = false;
                    btnPeso.Visible = false;
                    if (bruto == false)
                    {
                        btnPeso.Visible = true;
                    }
                    if (tara == false)
                    {
                        btnTara.Visible = true;
                    }
                }
            }




        }

        void CheckNeto(int id)
        {
            Modelo_Peso p = SQLiteConnector.Seleccionar_PesosById(id);
            if (p != null)
            {
                if (p.BRUTO != 0 && p.TARA != 0)
                {
                    SQLiteConnector.Actualizar_Neto(id, (int)p.BRUTO - (int)p.TARA);
                }
            }
        }

        private void btnPeso_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(dtgvmovimientos.SelectedRows[0].Cells["Id"].Value.ToString());
            if (txtTara.Text == "") { txtTara.Text = "0"; }
            SQLiteConnector.Actualizar_Bruto(ID, int.Parse(txtpeso.Text), int.Parse(txtTara.Text));
            CheckNeto(ID);
            RefreshDTGV();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                foreach (DataGridViewRow r in dtgvmovimientos.Rows)
                {
                    if (r.Cells["Fecha"].Value.ToString() != (DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year))
                    {
                        r.Visible = false;
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow r in dtgvmovimientos.Rows)
                {
                    if (r.Cells["Fecha"].Value.ToString() != (DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year))
                    {
                        r.Visible = true;
                    }
                }
            }
        }

        private void btnGuardarConfig_Click(object sender, EventArgs e)
        {
            GuardarCOnfiguracion();
            MessageBox.Show("El programa debe cerrarse para tomar las configuraciones");
            Application.Restart();
        }

        private void btnResetConfig_Click(object sender, EventArgs e)
        {
            CargarConfiguraciones();
        }



        private void TimerServer_Tick(object sender, EventArgs e)
        {
            if (Server != null)
            {

                //Aceptacion de sockets

                if (Server.Pending() == true)
                {
                    ClientList.Add( Server.AcceptTcpClient());
                }

                foreach (TcpClient Client in ClientList)
                {

                    if (Client != null)
                    {
                        if (Client.Connected == true)
                        {
                            if (Client.Available > 0)
                            {
                                int a;
                                string clean="";
                                while ((a = Client.GetStream().ReadByte())!=-1)
                                {
                                    byte b = (byte)a;
                                    char c = Convert.ToChar(a);
                                    clean += c;
                                    if (clean.Contains(Environment.NewLine) == true)
                                    {
                                        break;
                                    }
                                    
                                }
                                try
                                {
                                    if (clean.Contains("peso"))
                                    {
                                        NetworkStream NS = Client.GetStream();
                                        char[] pesoChar = (txtpeso.Text + Environment.NewLine).ToCharArray();
                                        byte[] pesoByte = System.Text.Encoding.UTF8.GetBytes(pesoChar);
                                        NS.Write(pesoByte, 0, pesoByte.Length);
                                    }
                                }
                                catch (Exception exc)
                                {

                                }


                            }
                        }
                        else
                        {
                            ClientList.Remove(Client);
                            break;
                        }
                    }
                    else
                    {
                        ClientList.Remove(Client);
                        break;
                    }

                }

            }
            else
            {
                TimerServer.Enabled = false;
                MessageBox.Show("Server shutdown");
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            PdfPTable Table = new PdfPTable(10);
            Table.WidthPercentage = 100;

            dtgvmovimientos.Columns["Id"].Visible = false;

            foreach (DataGridViewColumn c in dtgvmovimientos.Columns)
            {
                if (c.Visible == true)
                {
                    PdfPCell CellColumn = new PdfPCell(new Phrase(c.HeaderText));
                    CellColumn.BackgroundColor = new BaseColor(200,200,200);
                    
                    Table.AddCell(CellColumn);
                }
            }


            iTextSharp.text.Font F = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 10);

            foreach (DataGridViewRow r in dtgvmovimientos.Rows)
            {
                if (r.Visible == true) { 
                foreach (DataGridViewCell c in r.Cells)
                {
                    if (c.OwningColumn.Visible == true)
                    {
                        PdfPCell CellColumn = new PdfPCell(new Phrase(c.Value.ToString(),F));
                        CellColumn.BackgroundColor = new BaseColor(255, 255, 255);
                        CellColumn.HorizontalAlignment = 2;
                       
                        Table.AddCell(CellColumn);
                    }
                }
                }
            }
            


            iTextSharp.text.Document PDFD = new iTextSharp.text.Document(PageSize.A4.Rotate(), 15f, 15f, 15f, 15f);
           
            FileStream FS = new FileStream("c:\\documento.pdf", FileMode.Create);
            PdfWriter PDFW = PdfWriter.GetInstance(PDFD, FS);
            PDFD.Open();
            PDFD.Add(Table);
            PDFD.Close();
            FS.Close();


            dtgvmovimientos.Columns["Id"].Visible = true;






        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Borrar todos los registros?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SQLiteConnector.BorrarRegistros();
                RefreshDTGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cZKEM.Connect_Net(txtIPControlador.Text, 4370);

            string all = "";

            string roll = "";
            string name = "";
            string password = "";
            int priv = 0;
            bool enabled = false;


            List<User> ListaDeUsuario = new List<User>();

            ListaDeUsuario.Add(new User(-1, "[Todos]"));

            while (cZKEM.SSR_GetAllUserInfo(1, out roll, out name, out password, out priv, out enabled) == true)
            {
                all += "Rol:" + roll + ",name:" + name + ",password:" + password + ",priv:" + priv + ",enabled:" + enabled.ToString() + Environment.NewLine;
                ListaDeUsuario.Add(new User(int.Parse(roll),name));
            }
            cmbUsuarios.DisplayMember = "Nombre";
            cmbUsuarios.ValueMember = "Id";
            cmbUsuarios.DataSource = ListaDeUsuario;
            cmbUsuarios.Refresh();

            string rd = "";
            int vermode = 0;
            int inoutmode = 0;
            int Y = 0;
            int M = 0;
            int D = 0;
            int h = 0;
            int m = 0;
            int s = 0;
            int wc = 0;

           

            all += Environment.NewLine + Environment.NewLine;
            List<Reloj> ListaMovimientos = new List<Reloj>();

            while (cZKEM.SSR_GetGeneralLogData(1, out rd, out vermode, out inoutmode, out Y, out M, out D, out h, out m, out s, ref wc) == true)
            {

                DateTime HorarioRegistrado;

                all += "usr:" + rd + ",ver:" + vermode + ",inout:" + inoutmode + "DATE:" + (HorarioRegistrado = new DateTime(Y, M, D, h, m, s)).ToString() + Environment.NewLine;
                User tu=null;
                foreach (User u in ListaDeUsuario)
                {
                    if (int.Parse(rd) == u.Id)
                    {
                        tu = u;
                        break;
                    }
                }

                ListaMovimientos.Add(new Reloj(HorarioRegistrado,tu));
                

            }

            dtgvRegistro.Columns.Clear();
            dtgvRegistro.DataSource = ListaMovimientos;
            dtgvRegistro.Columns[0].DataPropertyName = "FechaYHora";
            dtgvRegistro.Columns[1].DataPropertyName = "Usuario.Nombre";
            
            
            dtgvRegistro.Refresh();
            

            //MessageBox.Show(all);
            /*foreach (string a in my)
            {
                int id = int.Parse(a.Split(splitter2, StringSplitOptions.None)[1]);
                string name="";
                string password = "";
                int 
                
               
            }*/



            //MessageBox.Show(h);


            cZKEM.Disconnect();





        }





        private void CZKEM_OnConnected()
        {

            
            
            
        }

        private void txtIPControlador_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dtgvRegistro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewColumn col = grid.Columns[e.ColumnIndex];
            if (row.DataBoundItem != null && col.DataPropertyName.Contains("."))
            {
                string[] props = col.DataPropertyName.Split('.');
                PropertyInfo propInfo = row.DataBoundItem.GetType().GetProperty(props[0]);
                object val = propInfo.GetValue(row.DataBoundItem, null);
                for (int i = 1; i < props.Length; i++)
                {
                    propInfo = val.GetType().GetProperty(props[i]);
                    val = propInfo.GetValue(val, null);
                }
                e.Value = val;
            }
        }

        private void cmbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbUsuarios_TextChanged(object sender, EventArgs e)
        {
            dtgvRegistro.ClearSelection();
            if (dtgvRegistro.Rows != null && dtgvRegistro.Rows.Count > 0)
            {
                
                
                //MessageBox.Show("Hay filas");
                if (cmbUsuarios.Text.ToLower().Contains("todos") == true)
                {
                    //MessageBox.Show("selecciono todos");
                    foreach (DataGridViewRow r in dtgvRegistro.Rows)
                    {
                        //MessageBox.Show("Haciendo visible todos");
                        r.Visible = true;
                    }
                }
                else
                {
                    foreach (DataGridViewRow r in dtgvRegistro.Rows)
                    {
                        dtgvRegistro.CurrentCell = null;

                        //MessageBox.Show("selecciono nombre");
                        //MessageBox.Show(cmbUsuarios.Text);
                        //MessageBox.Show(r.Cells[1].FormattedValue.ToString());

                        if (r.Cells[1].FormattedValue.ToString().ToLower().Contains(cmbUsuarios.Text.ToLower()) == true)
                        {
                            //MessageBox.Show(cmbUsuarios.Text.ToLower());
                            r.Visible = true;
                        }
                        else
                        {
                            //MessageBox.Show("escondiendo");
                            r.Visible = false;
                        }
                    }
                }
            }
        }
    }
}
