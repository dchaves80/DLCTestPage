namespace Comercio.Views
{
    partial class ListaArticulos
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oculto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlArticulo = new System.Windows.Forms.Panel();
            this.lblListaDePrecios = new System.Windows.Forms.Label();
            this.pnlListaPrecios = new System.Windows.Forms.Panel();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblLabelProveedor = new System.Windows.Forms.Label();
            this.lblNombreArticulo = new System.Windows.Forms.Label();
            this.lblLabelNombreArticulo = new System.Windows.Forms.Label();
            this.btnNuevoArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(61, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(759, 20);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(12, 15);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(43, 13);
            this.lblBuscar.TabIndex = 1;
            this.lblBuscar.Text = "Buscar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo,
            this.Detalle,
            this.Stock,
            this.Oculto});
            this.dataGridView1.Location = new System.Drawing.Point(15, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(530, 388);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Detalle
            // 
            this.Detalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // Oculto
            // 
            this.Oculto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Oculto.HeaderText = "Oculto";
            this.Oculto.Name = "Oculto";
            this.Oculto.ReadOnly = true;
            this.Oculto.Visible = false;
            // 
            // pnlArticulo
            // 
            this.pnlArticulo.Controls.Add(this.lblListaDePrecios);
            this.pnlArticulo.Controls.Add(this.pnlListaPrecios);
            this.pnlArticulo.Controls.Add(this.lblProveedor);
            this.pnlArticulo.Controls.Add(this.lblLabelProveedor);
            this.pnlArticulo.Controls.Add(this.lblNombreArticulo);
            this.pnlArticulo.Controls.Add(this.lblLabelNombreArticulo);
            this.pnlArticulo.Location = new System.Drawing.Point(551, 50);
            this.pnlArticulo.Name = "pnlArticulo";
            this.pnlArticulo.Size = new System.Drawing.Size(269, 388);
            this.pnlArticulo.TabIndex = 3;
            // 
            // lblListaDePrecios
            // 
            this.lblListaDePrecios.AutoSize = true;
            this.lblListaDePrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaDePrecios.Location = new System.Drawing.Point(38, 83);
            this.lblListaDePrecios.Name = "lblListaDePrecios";
            this.lblListaDePrecios.Size = new System.Drawing.Size(101, 13);
            this.lblListaDePrecios.TabIndex = 5;
            this.lblListaDePrecios.Text = "Lista de precios:";
            // 
            // pnlListaPrecios
            // 
            this.pnlListaPrecios.AutoScroll = true;
            this.pnlListaPrecios.Location = new System.Drawing.Point(3, 99);
            this.pnlListaPrecios.Name = "pnlListaPrecios";
            this.pnlListaPrecios.Size = new System.Drawing.Size(263, 286);
            this.pnlListaPrecios.TabIndex = 4;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(79, 26);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(62, 13);
            this.lblProveedor.TabIndex = 3;
            this.lblProveedor.Text = "[Proveedor]";
            // 
            // lblLabelProveedor
            // 
            this.lblLabelProveedor.AutoSize = true;
            this.lblLabelProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelProveedor.Location = new System.Drawing.Point(4, 26);
            this.lblLabelProveedor.Name = "lblLabelProveedor";
            this.lblLabelProveedor.Size = new System.Drawing.Size(69, 13);
            this.lblLabelProveedor.TabIndex = 2;
            this.lblLabelProveedor.Text = "Proveedor:";
            // 
            // lblNombreArticulo
            // 
            this.lblNombreArticulo.AutoSize = true;
            this.lblNombreArticulo.Location = new System.Drawing.Point(79, 4);
            this.lblNombreArticulo.Name = "lblNombreArticulo";
            this.lblNombreArticulo.Size = new System.Drawing.Size(46, 13);
            this.lblNombreArticulo.TabIndex = 1;
            this.lblNombreArticulo.Text = "[Detalle]";
            // 
            // lblLabelNombreArticulo
            // 
            this.lblLabelNombreArticulo.AutoSize = true;
            this.lblLabelNombreArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelNombreArticulo.Location = new System.Drawing.Point(22, 4);
            this.lblLabelNombreArticulo.Name = "lblLabelNombreArticulo";
            this.lblLabelNombreArticulo.Size = new System.Drawing.Size(51, 13);
            this.lblLabelNombreArticulo.TabIndex = 0;
            this.lblLabelNombreArticulo.Text = "Detalle:";
            // 
            // btnNuevoArticulo
            // 
            this.btnNuevoArticulo.Location = new System.Drawing.Point(15, 444);
            this.btnNuevoArticulo.Name = "btnNuevoArticulo";
            this.btnNuevoArticulo.Size = new System.Drawing.Size(530, 23);
            this.btnNuevoArticulo.TabIndex = 4;
            this.btnNuevoArticulo.Text = "Nuevo Articulo";
            this.btnNuevoArticulo.UseVisualStyleBackColor = true;
            this.btnNuevoArticulo.Click += new System.EventHandler(this.btnNuevoArticulo_Click);
            // 
            // ListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 479);
            this.Controls.Add(this.btnNuevoArticulo);
            this.Controls.Add(this.pnlArticulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Name = "ListaArticulos";
            this.Text = "ListaArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlArticulo.ResumeLayout(false);
            this.pnlArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnlArticulo;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblLabelProveedor;
        private System.Windows.Forms.Label lblNombreArticulo;
        private System.Windows.Forms.Label lblLabelNombreArticulo;
        private System.Windows.Forms.Label lblListaDePrecios;
        private System.Windows.Forms.Panel pnlListaPrecios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Oculto;
        private System.Windows.Forms.Button btnNuevoArticulo;
    }
}