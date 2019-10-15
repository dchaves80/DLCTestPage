namespace Anto2._0
{
    partial class Form1
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
            this.cldstart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cldend = new System.Windows.Forms.DateTimePicker();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dtgvFacturas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FacturaNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvDetalle = new System.Windows.Forms.DataGridView();
            this.IdP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnCierre = new System.Windows.Forms.Button();
            this.dtgvClientes = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsumidorFinal = new System.Windows.Forms.Button();
            this.btnCierreZ = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // cldstart
            // 
            this.cldstart.Location = new System.Drawing.Point(90, 6);
            this.cldstart.Name = "cldstart";
            this.cldstart.Size = new System.Drawing.Size(200, 20);
            this.cldstart.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha hasta:";
            // 
            // cldend
            // 
            this.cldend.Location = new System.Drawing.Point(90, 32);
            this.cldend.Name = "cldend";
            this.cldend.Size = new System.Drawing.Size(200, 20);
            this.cldend.TabIndex = 2;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(308, 7);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(520, 44);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dtgvFacturas
            // 
            this.dtgvFacturas.AllowUserToAddRows = false;
            this.dtgvFacturas.AllowUserToDeleteRows = false;
            this.dtgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FacturaNumero,
            this.Fecha});
            this.dtgvFacturas.Location = new System.Drawing.Point(15, 55);
            this.dtgvFacturas.Name = "dtgvFacturas";
            this.dtgvFacturas.ReadOnly = true;
            this.dtgvFacturas.RowHeadersVisible = false;
            this.dtgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFacturas.Size = new System.Drawing.Size(368, 297);
            this.dtgvFacturas.TabIndex = 5;
            this.dtgvFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFacturas_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // FacturaNumero
            // 
            this.FacturaNumero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FacturaNumero.HeaderText = "Factura Nro.";
            this.FacturaNumero.Name = "FacturaNumero";
            this.FacturaNumero.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // dtgvDetalle
            // 
            this.dtgvDetalle.AllowUserToAddRows = false;
            this.dtgvDetalle.AllowUserToDeleteRows = false;
            this.dtgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdP,
            this.Detalle,
            this.Codigo,
            this.Cantidad,
            this.Total});
            this.dtgvDetalle.Location = new System.Drawing.Point(390, 58);
            this.dtgvDetalle.Name = "dtgvDetalle";
            this.dtgvDetalle.ReadOnly = true;
            this.dtgvDetalle.RowHeadersVisible = false;
            this.dtgvDetalle.Size = new System.Drawing.Size(438, 294);
            this.dtgvDetalle.TabIndex = 6;
            // 
            // IdP
            // 
            this.IdP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdP.HeaderText = "IdP";
            this.IdP.Name = "IdP";
            this.IdP.ReadOnly = true;
            this.IdP.Visible = false;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.HeaderText = "Precio";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(15, 525);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(138, 23);
            this.btnTicket.TabIndex = 7;
            this.btnTicket.Text = "Imprimir Factura A";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnCierre
            // 
            this.btnCierre.Location = new System.Drawing.Point(690, 525);
            this.btnCierre.Name = "btnCierre";
            this.btnCierre.Size = new System.Drawing.Size(138, 23);
            this.btnCierre.TabIndex = 8;
            this.btnCierre.Text = "CierreZ";
            this.btnCierre.UseVisualStyleBackColor = true;
            // 
            // dtgvClientes
            // 
            this.dtgvClientes.AllowUserToAddRows = false;
            this.dtgvClientes.AllowUserToDeleteRows = false;
            this.dtgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCliente,
            this.NombreCliente,
            this.DNI,
            this.DireccionCliente});
            this.dtgvClientes.Location = new System.Drawing.Point(15, 358);
            this.dtgvClientes.Name = "dtgvClientes";
            this.dtgvClientes.ReadOnly = true;
            this.dtgvClientes.RowHeadersVisible = false;
            this.dtgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvClientes.Size = new System.Drawing.Size(813, 150);
            this.dtgvClientes.TabIndex = 9;
            // 
            // IdCliente
            // 
            this.IdCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdCliente.HeaderText = "Id";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
            // 
            // NombreCliente
            // 
            this.NombreCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DNI.HeaderText = "DNI/CUIT/CUIL";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // DireccionCliente
            // 
            this.DireccionCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DireccionCliente.HeaderText = "Direccion";
            this.DireccionCliente.Name = "DireccionCliente";
            this.DireccionCliente.ReadOnly = true;
            // 
            // btnConsumidorFinal
            // 
            this.btnConsumidorFinal.Location = new System.Drawing.Point(303, 525);
            this.btnConsumidorFinal.Name = "btnConsumidorFinal";
            this.btnConsumidorFinal.Size = new System.Drawing.Size(138, 23);
            this.btnConsumidorFinal.TabIndex = 10;
            this.btnConsumidorFinal.Text = "Imprimir Ticket";
            this.btnConsumidorFinal.UseVisualStyleBackColor = true;
            this.btnConsumidorFinal.Click += new System.EventHandler(this.btnConsumidorFinal_Click);
            // 
            // btnCierreZ
            // 
            this.btnCierreZ.Location = new System.Drawing.Point(447, 525);
            this.btnCierreZ.Name = "btnCierreZ";
            this.btnCierreZ.Size = new System.Drawing.Size(138, 23);
            this.btnCierreZ.TabIndex = 11;
            this.btnCierreZ.Text = "CIERRE Z";
            this.btnCierreZ.UseVisualStyleBackColor = true;
            this.btnCierreZ.Click += new System.EventHandler(this.btnCierreZ_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 525);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Imprimir Factura B";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCierreZ);
            this.Controls.Add(this.btnConsumidorFinal);
            this.Controls.Add(this.dtgvClientes);
            this.Controls.Add(this.btnCierre);
            this.Controls.Add(this.btnTicket);
            this.Controls.Add(this.dtgvDetalle);
            this.Controls.Add(this.dtgvFacturas);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cldend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cldstart);
            this.Name = "Form1";
            this.Text = "Impresion de facturas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFacturas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker cldstart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker cldend;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dtgvFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FacturaNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridView dtgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnCierre;
        private System.Windows.Forms.DataGridView dtgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionCliente;
        private System.Windows.Forms.Button btnConsumidorFinal;
        private System.Windows.Forms.Button btnCierreZ;
        private System.Windows.Forms.Button button1;
    }
}

