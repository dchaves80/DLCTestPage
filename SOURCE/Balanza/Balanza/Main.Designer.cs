namespace Balanza
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimerReader = new System.Windows.Forms.Timer(this.components);
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTara = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoCamion = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnNuevoChofer = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.dtgvmovimientos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Camion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chofer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TTara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoRegistro = new System.Windows.Forms.Button();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.tbRegistros = new System.Windows.Forms.TabPage();
            this.tbBalanza = new System.Windows.Forms.TabPage();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.btnPeso = new System.Windows.Forms.Button();
            this.lblNeto = new System.Windows.Forms.Label();
            this.btnTara = new System.Windows.Forms.Button();
            this.lblTara = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblChofer = new System.Windows.Forms.Label();
            this.lblPatente = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbConfiguracion = new System.Windows.Forms.TabPage();
            this.btnGuardarConfig = new System.Windows.Forms.Button();
            this.btnResetConfig = new System.Windows.Forms.Button();
            this.txtIpLan = new System.Windows.Forms.TextBox();
            this.txtBaudios = new System.Windows.Forms.TextBox();
            this.txtPuertoLan = new System.Windows.Forms.TextBox();
            this.txtPuertoCOM = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabHorarios = new System.Windows.Forms.TabPage();
            this.dtgvRegistro = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIPControlador = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.TimerServer = new System.Windows.Forms.Timer(this.components);
            this.lblt = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvmovimientos)).BeginInit();
            this.Tabs.SuspendLayout();
            this.tbRegistros.SuspendLayout();
            this.tbBalanza.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbConfiguracion.SuspendLayout();
            this.tabHorarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerReader
            // 
            this.TimerReader.Enabled = true;
            this.TimerReader.Interval = 500;
            this.TimerReader.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtpeso
            // 
            this.txtpeso.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpeso.ForeColor = System.Drawing.Color.Black;
            this.txtpeso.Location = new System.Drawing.Point(30, 12);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtpeso.Size = new System.Drawing.Size(344, 82);
            this.txtpeso.TabIndex = 0;
            this.txtpeso.Text = "00000000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTara);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1080, 621);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 48);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración";
            this.groupBox1.Visible = false;
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(29, 19);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(181, 20);
            this.txtTara.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "T:";
            // 
            // btnNuevoCamion
            // 
            this.btnNuevoCamion.Location = new System.Drawing.Point(6, 118);
            this.btnNuevoCamion.Name = "btnNuevoCamion";
            this.btnNuevoCamion.Size = new System.Drawing.Size(160, 50);
            this.btnNuevoCamion.TabIndex = 4;
            this.btnNuevoCamion.Text = "Agregar Camion";
            this.btnNuevoCamion.UseVisualStyleBackColor = true;
            this.btnNuevoCamion.Click += new System.EventHandler(this.btnNuevoCamion_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Location = new System.Drawing.Point(6, 174);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(160, 50);
            this.btnNuevoCliente.TabIndex = 5;
            this.btnNuevoCliente.Text = "Agregar Cliente";
            this.btnNuevoCliente.UseVisualStyleBackColor = true;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnNuevoChofer
            // 
            this.btnNuevoChofer.Location = new System.Drawing.Point(6, 6);
            this.btnNuevoChofer.Name = "btnNuevoChofer";
            this.btnNuevoChofer.Size = new System.Drawing.Size(160, 50);
            this.btnNuevoChofer.TabIndex = 6;
            this.btnNuevoChofer.Text = "Agregar Chofer";
            this.btnNuevoChofer.UseVisualStyleBackColor = true;
            this.btnNuevoChofer.Click += new System.EventHandler(this.btnNuevoChofer_Click);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Location = new System.Drawing.Point(6, 62);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(160, 50);
            this.btnNuevoProducto.TabIndex = 7;
            this.btnNuevoProducto.Text = "Agregar Producto";
            this.btnNuevoProducto.UseVisualStyleBackColor = true;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // dtgvmovimientos
            // 
            this.dtgvmovimientos.AllowUserToAddRows = false;
            this.dtgvmovimientos.AllowUserToDeleteRows = false;
            this.dtgvmovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvmovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvmovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Fecha,
            this.Hora,
            this.Camion,
            this.Chofer,
            this.Cliente,
            this.Producto,
            this.Bruto,
            this.Tara,
            this.Neto,
            this.TBruto,
            this.TTara,
            this.Hum});
            this.dtgvmovimientos.Location = new System.Drawing.Point(6, 6);
            this.dtgvmovimientos.MultiSelect = false;
            this.dtgvmovimientos.Name = "dtgvmovimientos";
            this.dtgvmovimientos.ReadOnly = true;
            this.dtgvmovimientos.RowHeadersVisible = false;
            this.dtgvmovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvmovimientos.Size = new System.Drawing.Size(896, 181);
            this.dtgvmovimientos.TabIndex = 8;
            this.dtgvmovimientos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvmovimientos_CellContentClick);
            this.dtgvmovimientos.SelectionChanged += new System.EventHandler(this.dtgvmovimientos_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Camion
            // 
            this.Camion.HeaderText = "Camion";
            this.Camion.Name = "Camion";
            this.Camion.ReadOnly = true;
            this.Camion.Width = 50;
            // 
            // Chofer
            // 
            this.Chofer.HeaderText = "Chofer";
            this.Chofer.Name = "Chofer";
            this.Chofer.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 80;
            // 
            // Bruto
            // 
            this.Bruto.HeaderText = "Bruto";
            this.Bruto.Name = "Bruto";
            this.Bruto.ReadOnly = true;
            this.Bruto.Width = 80;
            // 
            // Tara
            // 
            this.Tara.HeaderText = "Tara";
            this.Tara.Name = "Tara";
            this.Tara.ReadOnly = true;
            this.Tara.Width = 80;
            // 
            // Neto
            // 
            this.Neto.HeaderText = "Neto";
            this.Neto.Name = "Neto";
            this.Neto.ReadOnly = true;
            this.Neto.Width = 80;
            // 
            // TBruto
            // 
            this.TBruto.HeaderText = "TBruto";
            this.TBruto.Name = "TBruto";
            this.TBruto.ReadOnly = true;
            this.TBruto.Visible = false;
            this.TBruto.Width = 80;
            // 
            // TTara
            // 
            this.TTara.HeaderText = "TTara";
            this.TTara.Name = "TTara";
            this.TTara.ReadOnly = true;
            this.TTara.Visible = false;
            this.TTara.Width = 80;
            // 
            // Hum
            // 
            this.Hum.HeaderText = "Hum.";
            this.Hum.Name = "Hum";
            this.Hum.ReadOnly = true;
            this.Hum.Width = 50;
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Location = new System.Drawing.Point(6, 215);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(896, 45);
            this.btnNuevoRegistro.TabIndex = 9;
            this.btnNuevoRegistro.Text = "AGREGAR ENTRADA/SALIDA";
            this.btnNuevoRegistro.UseVisualStyleBackColor = true;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.tbRegistros);
            this.Tabs.Controls.Add(this.tbBalanza);
            this.Tabs.Controls.Add(this.tabPage1);
            this.Tabs.Controls.Add(this.tbConfiguracion);
            this.Tabs.Controls.Add(this.tabHorarios);
            this.Tabs.Location = new System.Drawing.Point(380, 12);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(916, 603);
            this.Tabs.TabIndex = 1;
            // 
            // tbRegistros
            // 
            this.tbRegistros.BackColor = System.Drawing.Color.DimGray;
            this.tbRegistros.Controls.Add(this.btnNuevoChofer);
            this.tbRegistros.Controls.Add(this.btnNuevoProducto);
            this.tbRegistros.Controls.Add(this.btnNuevoCamion);
            this.tbRegistros.Controls.Add(this.btnNuevoCliente);
            this.tbRegistros.Location = new System.Drawing.Point(4, 22);
            this.tbRegistros.Name = "tbRegistros";
            this.tbRegistros.Padding = new System.Windows.Forms.Padding(3);
            this.tbRegistros.Size = new System.Drawing.Size(908, 577);
            this.tbRegistros.TabIndex = 0;
            this.tbRegistros.Text = "Edición";
            // 
            // tbBalanza
            // 
            this.tbBalanza.Controls.Add(this.btnBorrar);
            this.tbBalanza.Controls.Add(this.btnExportar);
            this.tbBalanza.Controls.Add(this.checkBox1);
            this.tbBalanza.Controls.Add(this.panel1);
            this.tbBalanza.Controls.Add(this.dtgvmovimientos);
            this.tbBalanza.Controls.Add(this.btnNuevoRegistro);
            this.tbBalanza.Location = new System.Drawing.Point(4, 22);
            this.tbBalanza.Name = "tbBalanza";
            this.tbBalanza.Padding = new System.Windows.Forms.Padding(3);
            this.tbBalanza.Size = new System.Drawing.Size(908, 577);
            this.tbBalanza.TabIndex = 1;
            this.tbBalanza.Text = "Balanza";
            this.tbBalanza.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(658, 189);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(119, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar Registros";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(783, 189);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(119, 23);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "Exportar PDF";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 193);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(125, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Solo entradas del dia";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.lblHumedad);
            this.panel1.Controls.Add(this.btnPeso);
            this.panel1.Controls.Add(this.lblNeto);
            this.panel1.Controls.Add(this.btnTara);
            this.panel1.Controls.Add(this.lblTara);
            this.panel1.Controls.Add(this.lblBruto);
            this.panel1.Controls.Add(this.lblProducto);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.lblChofer);
            this.panel1.Controls.Add(this.lblPatente);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(6, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 234);
            this.panel1.TabIndex = 12;
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.Location = new System.Drawing.Point(65, 182);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(16, 13);
            this.lblHumedad.TabIndex = 22;
            this.lblHumedad.Text = "...";
            // 
            // btnPeso
            // 
            this.btnPeso.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPeso.Location = new System.Drawing.Point(450, 182);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(112, 40);
            this.btnPeso.TabIndex = 11;
            this.btnPeso.Text = "Registrar PESO";
            this.btnPeso.UseVisualStyleBackColor = false;
            this.btnPeso.Visible = false;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Location = new System.Drawing.Point(492, 139);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(16, 13);
            this.lblNeto.TabIndex = 21;
            this.lblNeto.Text = "...";
            // 
            // btnTara
            // 
            this.btnTara.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTara.Location = new System.Drawing.Point(309, 182);
            this.btnTara.Name = "btnTara";
            this.btnTara.Size = new System.Drawing.Size(122, 40);
            this.btnTara.TabIndex = 10;
            this.btnTara.Text = "Registrar TARA";
            this.btnTara.UseVisualStyleBackColor = false;
            this.btnTara.Visible = false;
            this.btnTara.Click += new System.EventHandler(this.btnTara_Click);
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.Location = new System.Drawing.Point(285, 139);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(16, 13);
            this.lblTara.TabIndex = 20;
            this.lblTara.Text = "...";
            // 
            // lblBruto
            // 
            this.lblBruto.AutoSize = true;
            this.lblBruto.Location = new System.Drawing.Point(44, 139);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(16, 13);
            this.lblBruto.TabIndex = 19;
            this.lblBruto.Text = "...";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(306, 96);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(16, 13);
            this.lblProducto.TabIndex = 18;
            this.lblProducto.Text = "...";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(51, 96);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(16, 13);
            this.lblCliente.TabIndex = 17;
            this.lblCliente.Text = "...";
            // 
            // lblChofer
            // 
            this.lblChofer.AutoSize = true;
            this.lblChofer.Location = new System.Drawing.Point(294, 53);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(16, 13);
            this.lblChofer.TabIndex = 16;
            this.lblChofer.Text = "...";
            // 
            // lblPatente
            // 
            this.lblPatente.AutoSize = true;
            this.lblPatente.Location = new System.Drawing.Point(56, 53);
            this.lblPatente.Name = "lblPatente";
            this.lblPatente.Size = new System.Drawing.Size(16, 13);
            this.lblPatente.TabIndex = 15;
            this.lblPatente.Text = "...";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(492, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(16, 13);
            this.lblHora.TabIndex = 14;
            this.lblHora.Text = "...";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(293, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(16, 13);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "...";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(97, 10);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(16, 13);
            this.lblid.TabIndex = 12;
            this.lblid.Text = "...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 182);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Humedad:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(453, 139);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Neto:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(247, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tara:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bruto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Producto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Chofer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nro. Movimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Patente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha:";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(908, 577);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Reportes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tbConfiguracion
            // 
            this.tbConfiguracion.BackColor = System.Drawing.Color.Silver;
            this.tbConfiguracion.Controls.Add(this.btnGuardarConfig);
            this.tbConfiguracion.Controls.Add(this.btnResetConfig);
            this.tbConfiguracion.Controls.Add(this.txtIpLan);
            this.tbConfiguracion.Controls.Add(this.txtBaudios);
            this.tbConfiguracion.Controls.Add(this.txtPuertoLan);
            this.tbConfiguracion.Controls.Add(this.txtPuertoCOM);
            this.tbConfiguracion.Controls.Add(this.label16);
            this.tbConfiguracion.Controls.Add(this.label15);
            this.tbConfiguracion.Controls.Add(this.label14);
            this.tbConfiguracion.Controls.Add(this.label6);
            this.tbConfiguracion.Location = new System.Drawing.Point(4, 22);
            this.tbConfiguracion.Name = "tbConfiguracion";
            this.tbConfiguracion.Padding = new System.Windows.Forms.Padding(3);
            this.tbConfiguracion.Size = new System.Drawing.Size(908, 577);
            this.tbConfiguracion.TabIndex = 2;
            this.tbConfiguracion.Text = "Configuration";
            // 
            // btnGuardarConfig
            // 
            this.btnGuardarConfig.Location = new System.Drawing.Point(10, 152);
            this.btnGuardarConfig.Name = "btnGuardarConfig";
            this.btnGuardarConfig.Size = new System.Drawing.Size(105, 23);
            this.btnGuardarConfig.TabIndex = 10;
            this.btnGuardarConfig.Text = "Guardar";
            this.btnGuardarConfig.UseVisualStyleBackColor = true;
            this.btnGuardarConfig.Click += new System.EventHandler(this.btnGuardarConfig_Click);
            // 
            // btnResetConfig
            // 
            this.btnResetConfig.Location = new System.Drawing.Point(137, 152);
            this.btnResetConfig.Name = "btnResetConfig";
            this.btnResetConfig.Size = new System.Drawing.Size(105, 23);
            this.btnResetConfig.TabIndex = 9;
            this.btnResetConfig.Text = "Restaurar";
            this.btnResetConfig.UseVisualStyleBackColor = true;
            this.btnResetConfig.Click += new System.EventHandler(this.btnResetConfig_Click);
            // 
            // txtIpLan
            // 
            this.txtIpLan.Location = new System.Drawing.Point(95, 88);
            this.txtIpLan.Name = "txtIpLan";
            this.txtIpLan.Size = new System.Drawing.Size(147, 20);
            this.txtIpLan.TabIndex = 7;
            // 
            // txtBaudios
            // 
            this.txtBaudios.Location = new System.Drawing.Point(95, 57);
            this.txtBaudios.Name = "txtBaudios";
            this.txtBaudios.Size = new System.Drawing.Size(147, 20);
            this.txtBaudios.TabIndex = 6;
            // 
            // txtPuertoLan
            // 
            this.txtPuertoLan.Location = new System.Drawing.Point(95, 119);
            this.txtPuertoLan.Name = "txtPuertoLan";
            this.txtPuertoLan.Size = new System.Drawing.Size(147, 20);
            this.txtPuertoLan.TabIndex = 5;
            // 
            // txtPuertoCOM
            // 
            this.txtPuertoCOM.Location = new System.Drawing.Point(95, 26);
            this.txtPuertoCOM.Name = "txtPuertoCOM";
            this.txtPuertoCOM.Size = new System.Drawing.Size(147, 20);
            this.txtPuertoCOM.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "PUERTO LAN:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "IP LAN:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "BAUDIOS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "PUERTO COM:";
            // 
            // tabHorarios
            // 
            this.tabHorarios.Controls.Add(this.dtgvRegistro);
            this.tabHorarios.Controls.Add(this.label18);
            this.tabHorarios.Controls.Add(this.cmbUsuarios);
            this.tabHorarios.Controls.Add(this.label17);
            this.tabHorarios.Controls.Add(this.txtIPControlador);
            this.tabHorarios.Controls.Add(this.button1);
            this.tabHorarios.Location = new System.Drawing.Point(4, 22);
            this.tabHorarios.Name = "tabHorarios";
            this.tabHorarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabHorarios.Size = new System.Drawing.Size(908, 577);
            this.tabHorarios.TabIndex = 4;
            this.tabHorarios.Text = "Empleados: Entrada y salidas";
            this.tabHorarios.UseVisualStyleBackColor = true;
            // 
            // dtgvRegistro
            // 
            this.dtgvRegistro.AllowUserToAddRows = false;
            this.dtgvRegistro.AllowUserToDeleteRows = false;
            this.dtgvRegistro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRegistro.Location = new System.Drawing.Point(12, 64);
            this.dtgvRegistro.Name = "dtgvRegistro";
            this.dtgvRegistro.ReadOnly = true;
            this.dtgvRegistro.RowHeadersVisible = false;
            this.dtgvRegistro.Size = new System.Drawing.Size(890, 231);
            this.dtgvRegistro.TabIndex = 5;
            this.dtgvRegistro.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgvRegistro_CellFormatting);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Filtrar por usuario:";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(105, 37);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(180, 21);
            this.cmbUsuarios.TabIndex = 3;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            this.cmbUsuarios.TextChanged += new System.EventHandler(this.cmbUsuarios_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 13);
            this.label17.TabIndex = 2;
            this.label17.Text = "IP DE CONTROLADOR:";
            // 
            // txtIPControlador
            // 
            this.txtIPControlador.Location = new System.Drawing.Point(136, 6);
            this.txtIPControlador.Name = "txtIPControlador";
            this.txtIPControlador.Size = new System.Drawing.Size(149, 20);
            this.txtIPControlador.TabIndex = 1;
            this.txtIPControlador.TextChanged += new System.EventHandler(this.txtIPControlador_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(273, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SIncronizar Control de Horarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimerServer
            // 
            this.TimerServer.Tick += new System.EventHandler(this.TimerServer_Tick);
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Location = new System.Drawing.Point(12, 659);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(16, 13);
            this.lblt.TabIndex = 3;
            this.lblt.Text = "...";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 681);
            this.Controls.Add(this.lblt);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtpeso);
            this.KeyPreview = true;
            this.Name = "Main";
            this.Text = "Balanza Migul";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvmovimientos)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.tbRegistros.ResumeLayout(false);
            this.tbBalanza.ResumeLayout(false);
            this.tbBalanza.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbConfiguracion.ResumeLayout(false);
            this.tbConfiguracion.PerformLayout();
            this.tabHorarios.ResumeLayout(false);
            this.tabHorarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRegistro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TimerReader;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoCamion;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnNuevoChofer;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.DataGridView dtgvmovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Camion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chofer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TTara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hum;
        private System.Windows.Forms.Button btnNuevoRegistro;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage tbRegistros;
        private System.Windows.Forms.TabPage tbBalanza;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.Button btnTara;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.Label lblBruto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblChofer;
        private System.Windows.Forms.Label lblPatente;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tbConfiguracion;
        private System.Windows.Forms.TextBox txtIpLan;
        private System.Windows.Forms.TextBox txtBaudios;
        private System.Windows.Forms.TextBox txtPuertoLan;
        private System.Windows.Forms.TextBox txtPuertoCOM;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarConfig;
        private System.Windows.Forms.Button btnResetConfig;
        private System.Windows.Forms.Timer TimerServer;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TabPage tabHorarios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIPControlador;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.DataGridView dtgvRegistro;
        private System.Windows.Forms.Label lblt;
    }
}

