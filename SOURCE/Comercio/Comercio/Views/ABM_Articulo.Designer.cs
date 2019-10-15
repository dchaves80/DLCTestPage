namespace Comercio.Views
{
    partial class abm_articulos
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
            this.pnlFormasDePago = new System.Windows.Forms.Panel();
            this.lblLabelNombreArticulo = new System.Windows.Forms.Label();
            this.lblLabelCodigoArticulo = new System.Windows.Forms.Label();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblLabelProveedor = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.lblLabelUnidad = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBruto = new System.Windows.Forms.TextBox();
            this.lblLabelBruto = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.lblNeto = new System.Windows.Forms.Label();
            this.txtGanancia = new System.Windows.Forms.TextBox();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLabelSinIvaBruto = new System.Windows.Forms.Label();
            this.lblLabelSinIvaNeto = new System.Windows.Forms.Label();
            this.lblLabelSinIvaGanancia = new System.Windows.Forms.Label();
            this.lblLabelSinIvaFinal = new System.Windows.Forms.Label();
            this.txtSinIvaBruto = new System.Windows.Forms.TextBox();
            this.txtSinIvaNeto = new System.Windows.Forms.TextBox();
            this.txtSinIvaGanancia = new System.Windows.Forms.TextBox();
            this.txtSinIvaFinal = new System.Windows.Forms.TextBox();
            this.lblLabelDiferenciaPrecioFinalIVAFinalSinIva = new System.Windows.Forms.Label();
            this.txtDiferencia = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFormasDePago
            // 
            this.pnlFormasDePago.AutoScroll = true;
            this.pnlFormasDePago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFormasDePago.Location = new System.Drawing.Point(12, 235);
            this.pnlFormasDePago.Name = "pnlFormasDePago";
            this.pnlFormasDePago.Size = new System.Drawing.Size(710, 203);
            this.pnlFormasDePago.TabIndex = 0;
            // 
            // lblLabelNombreArticulo
            // 
            this.lblLabelNombreArticulo.AutoSize = true;
            this.lblLabelNombreArticulo.Location = new System.Drawing.Point(9, 9);
            this.lblLabelNombreArticulo.Name = "lblLabelNombreArticulo";
            this.lblLabelNombreArticulo.Size = new System.Drawing.Size(84, 13);
            this.lblLabelNombreArticulo.TabIndex = 1;
            this.lblLabelNombreArticulo.Text = "Nombre articulo:";
            // 
            // lblLabelCodigoArticulo
            // 
            this.lblLabelCodigoArticulo.AutoSize = true;
            this.lblLabelCodigoArticulo.Location = new System.Drawing.Point(50, 47);
            this.lblLabelCodigoArticulo.Name = "lblLabelCodigoArticulo";
            this.lblLabelCodigoArticulo.Size = new System.Drawing.Size(43, 13);
            this.lblLabelCodigoArticulo.TabIndex = 2;
            this.lblLabelCodigoArticulo.Text = "Codigo:";
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Location = new System.Drawing.Point(99, 6);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(623, 20);
            this.txtNombreArticulo.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(99, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(196, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblLabelProveedor
            // 
            this.lblLabelProveedor.AutoSize = true;
            this.lblLabelProveedor.Location = new System.Drawing.Point(34, 86);
            this.lblLabelProveedor.Name = "lblLabelProveedor";
            this.lblLabelProveedor.Size = new System.Drawing.Size(59, 13);
            this.lblLabelProveedor.TabIndex = 5;
            this.lblLabelProveedor.Text = "Proveedor:";
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.DisplayMember = "NAME";
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Location = new System.Drawing.Point(99, 83);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(196, 21);
            this.cmbProveedores.TabIndex = 6;
            this.cmbProveedores.ValueMember = "VALUE";
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.DisplayMember = "NAME";
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(99, 121);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(196, 21);
            this.cmbUnidad.TabIndex = 8;
            this.cmbUnidad.ValueMember = "VALUE";
            // 
            // lblLabelUnidad
            // 
            this.lblLabelUnidad.AutoSize = true;
            this.lblLabelUnidad.Location = new System.Drawing.Point(49, 124);
            this.lblLabelUnidad.Name = "lblLabelUnidad";
            this.lblLabelUnidad.Size = new System.Drawing.Size(44, 13);
            this.lblLabelUnidad.TabIndex = 7;
            this.lblLabelUnidad.Text = "Unidad:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(13, 445);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(338, 23);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(384, 444);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(338, 23);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBruto
            // 
            this.txtBruto.Location = new System.Drawing.Point(77, 26);
            this.txtBruto.Name = "txtBruto";
            this.txtBruto.Size = new System.Drawing.Size(83, 20);
            this.txtBruto.TabIndex = 12;
            this.txtBruto.Text = "0";
            this.txtBruto.TextChanged += new System.EventHandler(this.txtBruto_TextChanged);
            // 
            // lblLabelBruto
            // 
            this.lblLabelBruto.AutoSize = true;
            this.lblLabelBruto.Location = new System.Drawing.Point(36, 29);
            this.lblLabelBruto.Name = "lblLabelBruto";
            this.lblLabelBruto.Size = new System.Drawing.Size(35, 13);
            this.lblLabelBruto.TabIndex = 11;
            this.lblLabelBruto.Text = "Bruto:";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(77, 52);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(83, 20);
            this.txtIva.TabIndex = 14;
            this.txtIva.Text = "0";
            this.txtIva.TextChanged += new System.EventHandler(this.txtIva_TextChanged);
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Location = new System.Drawing.Point(46, 55);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(25, 13);
            this.lblIva.TabIndex = 13;
            this.lblIva.Text = "Iva:";
            // 
            // txtNeto
            // 
            this.txtNeto.Enabled = false;
            this.txtNeto.Location = new System.Drawing.Point(77, 78);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(83, 20);
            this.txtNeto.TabIndex = 16;
            this.txtNeto.Text = "0";
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Location = new System.Drawing.Point(38, 81);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(33, 13);
            this.lblNeto.TabIndex = 15;
            this.lblNeto.Text = "Neto:";
            // 
            // txtGanancia
            // 
            this.txtGanancia.Location = new System.Drawing.Point(77, 106);
            this.txtGanancia.Name = "txtGanancia";
            this.txtGanancia.Size = new System.Drawing.Size(83, 20);
            this.txtGanancia.TabIndex = 18;
            this.txtGanancia.Text = "0";
            this.txtGanancia.TextChanged += new System.EventHandler(this.txtGanancia_TextChanged);
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Location = new System.Drawing.Point(15, 109);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(56, 13);
            this.lblGanancia.TabIndex = 17;
            this.lblGanancia.Text = "Ganancia:";
            // 
            // txtFinal
            // 
            this.txtFinal.Enabled = false;
            this.txtFinal.Location = new System.Drawing.Point(77, 135);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(83, 20);
            this.txtFinal.TabIndex = 20;
            this.txtFinal.Text = "0";
            this.txtFinal.TextChanged += new System.EventHandler(this.txtFinal_TextChanged);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(39, 138);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(32, 13);
            this.lblFinal.TabIndex = 19;
            this.lblFinal.Text = "Final:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIva);
            this.groupBox1.Controls.Add(this.txtFinal);
            this.groupBox1.Controls.Add(this.lblLabelBruto);
            this.groupBox1.Controls.Add(this.lblFinal);
            this.groupBox1.Controls.Add(this.txtBruto);
            this.groupBox1.Controls.Add(this.txtGanancia);
            this.groupBox1.Controls.Add(this.lblIva);
            this.groupBox1.Controls.Add(this.lblGanancia);
            this.groupBox1.Controls.Add(this.lblNeto);
            this.groupBox1.Controls.Add(this.txtNeto);
            this.groupBox1.Location = new System.Drawing.Point(357, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 171);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios y recargos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSinIvaFinal);
            this.groupBox2.Controls.Add(this.txtSinIvaGanancia);
            this.groupBox2.Controls.Add(this.txtSinIvaNeto);
            this.groupBox2.Controls.Add(this.txtSinIvaBruto);
            this.groupBox2.Controls.Add(this.lblLabelSinIvaFinal);
            this.groupBox2.Controls.Add(this.lblLabelSinIvaGanancia);
            this.groupBox2.Controls.Add(this.lblLabelSinIvaNeto);
            this.groupBox2.Controls.Add(this.lblLabelSinIvaBruto);
            this.groupBox2.Location = new System.Drawing.Point(548, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 171);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precios y recargos (SIN IVA)";
            // 
            // lblLabelSinIvaBruto
            // 
            this.lblLabelSinIvaBruto.AutoSize = true;
            this.lblLabelSinIvaBruto.Location = new System.Drawing.Point(27, 29);
            this.lblLabelSinIvaBruto.Name = "lblLabelSinIvaBruto";
            this.lblLabelSinIvaBruto.Size = new System.Drawing.Size(35, 13);
            this.lblLabelSinIvaBruto.TabIndex = 0;
            this.lblLabelSinIvaBruto.Text = "Bruto:";
            // 
            // lblLabelSinIvaNeto
            // 
            this.lblLabelSinIvaNeto.AutoSize = true;
            this.lblLabelSinIvaNeto.Location = new System.Drawing.Point(27, 81);
            this.lblLabelSinIvaNeto.Name = "lblLabelSinIvaNeto";
            this.lblLabelSinIvaNeto.Size = new System.Drawing.Size(33, 13);
            this.lblLabelSinIvaNeto.TabIndex = 1;
            this.lblLabelSinIvaNeto.Text = "Neto:";
            // 
            // lblLabelSinIvaGanancia
            // 
            this.lblLabelSinIvaGanancia.AutoSize = true;
            this.lblLabelSinIvaGanancia.Location = new System.Drawing.Point(6, 109);
            this.lblLabelSinIvaGanancia.Name = "lblLabelSinIvaGanancia";
            this.lblLabelSinIvaGanancia.Size = new System.Drawing.Size(56, 13);
            this.lblLabelSinIvaGanancia.TabIndex = 2;
            this.lblLabelSinIvaGanancia.Text = "Ganancia:";
            // 
            // lblLabelSinIvaFinal
            // 
            this.lblLabelSinIvaFinal.AutoSize = true;
            this.lblLabelSinIvaFinal.Location = new System.Drawing.Point(30, 138);
            this.lblLabelSinIvaFinal.Name = "lblLabelSinIvaFinal";
            this.lblLabelSinIvaFinal.Size = new System.Drawing.Size(32, 13);
            this.lblLabelSinIvaFinal.TabIndex = 3;
            this.lblLabelSinIvaFinal.Text = "Final:";
            // 
            // txtSinIvaBruto
            // 
            this.txtSinIvaBruto.Enabled = false;
            this.txtSinIvaBruto.Location = new System.Drawing.Point(68, 26);
            this.txtSinIvaBruto.Name = "txtSinIvaBruto";
            this.txtSinIvaBruto.Size = new System.Drawing.Size(83, 20);
            this.txtSinIvaBruto.TabIndex = 21;
            this.txtSinIvaBruto.Text = "0";
            // 
            // txtSinIvaNeto
            // 
            this.txtSinIvaNeto.Enabled = false;
            this.txtSinIvaNeto.Location = new System.Drawing.Point(68, 78);
            this.txtSinIvaNeto.Name = "txtSinIvaNeto";
            this.txtSinIvaNeto.Size = new System.Drawing.Size(83, 20);
            this.txtSinIvaNeto.TabIndex = 22;
            this.txtSinIvaNeto.Text = "0";
            // 
            // txtSinIvaGanancia
            // 
            this.txtSinIvaGanancia.Enabled = false;
            this.txtSinIvaGanancia.Location = new System.Drawing.Point(68, 107);
            this.txtSinIvaGanancia.Name = "txtSinIvaGanancia";
            this.txtSinIvaGanancia.Size = new System.Drawing.Size(83, 20);
            this.txtSinIvaGanancia.TabIndex = 23;
            this.txtSinIvaGanancia.Text = "0";
            // 
            // txtSinIvaFinal
            // 
            this.txtSinIvaFinal.Enabled = false;
            this.txtSinIvaFinal.Location = new System.Drawing.Point(68, 136);
            this.txtSinIvaFinal.Name = "txtSinIvaFinal";
            this.txtSinIvaFinal.Size = new System.Drawing.Size(83, 20);
            this.txtSinIvaFinal.TabIndex = 24;
            this.txtSinIvaFinal.Text = "0";
            // 
            // lblLabelDiferenciaPrecioFinalIVAFinalSinIva
            // 
            this.lblLabelDiferenciaPrecioFinalIVAFinalSinIva.AutoSize = true;
            this.lblLabelDiferenciaPrecioFinalIVAFinalSinIva.Location = new System.Drawing.Point(357, 213);
            this.lblLabelDiferenciaPrecioFinalIVAFinalSinIva.Name = "lblLabelDiferenciaPrecioFinalIVAFinalSinIva";
            this.lblLabelDiferenciaPrecioFinalIVAFinalSinIva.Size = new System.Drawing.Size(203, 13);
            this.lblLabelDiferenciaPrecioFinalIVAFinalSinIva.TabIndex = 23;
            this.lblLabelDiferenciaPrecioFinalIVAFinalSinIva.Text = "Diferencia: Final(Con IVA) - Final(Sin IVA):";
            // 
            // txtDiferencia
            // 
            this.txtDiferencia.Enabled = false;
            this.txtDiferencia.Location = new System.Drawing.Point(566, 210);
            this.txtDiferencia.Name = "txtDiferencia";
            this.txtDiferencia.Size = new System.Drawing.Size(133, 20);
            this.txtDiferencia.TabIndex = 24;
            this.txtDiferencia.Text = "0";
            // 
            // abm_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 484);
            this.ControlBox = false;
            this.Controls.Add(this.txtDiferencia);
            this.Controls.Add(this.lblLabelDiferenciaPrecioFinalIVAFinalSinIva);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbUnidad);
            this.Controls.Add(this.lblLabelUnidad);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.lblLabelProveedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.lblLabelCodigoArticulo);
            this.Controls.Add(this.lblLabelNombreArticulo);
            this.Controls.Add(this.pnlFormasDePago);
            this.Name = "abm_articulos";
            this.Text = "ABM_Articulo";
            this.Load += new System.EventHandler(this.ABM_Articulo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFormasDePago;
        private System.Windows.Forms.Label lblLabelNombreArticulo;
        private System.Windows.Forms.Label lblLabelCodigoArticulo;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblLabelProveedor;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label lblLabelUnidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBruto;
        private System.Windows.Forms.Label lblLabelBruto;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Label lblNeto;
        private System.Windows.Forms.TextBox txtGanancia;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSinIvaFinal;
        private System.Windows.Forms.TextBox txtSinIvaGanancia;
        private System.Windows.Forms.TextBox txtSinIvaNeto;
        private System.Windows.Forms.TextBox txtSinIvaBruto;
        private System.Windows.Forms.Label lblLabelSinIvaFinal;
        private System.Windows.Forms.Label lblLabelSinIvaGanancia;
        private System.Windows.Forms.Label lblLabelSinIvaNeto;
        private System.Windows.Forms.Label lblLabelSinIvaBruto;
        private System.Windows.Forms.Label lblLabelDiferenciaPrecioFinalIVAFinalSinIva;
        private System.Windows.Forms.TextBox txtDiferencia;
    }
}