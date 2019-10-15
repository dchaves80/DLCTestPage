namespace Comercio.Views
{
    partial class ABM_GRID_FormaDePago
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
            this.txtFormaDePago = new System.Windows.Forms.TextBox();
            this.lblFormaDePago = new System.Windows.Forms.Label();
            this.btnFormaDePago = new System.Windows.Forms.Button();
            this.dtgvFormaDePago = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormaDePago)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFormaDePago
            // 
            this.txtFormaDePago.Location = new System.Drawing.Point(131, 12);
            this.txtFormaDePago.Name = "txtFormaDePago";
            this.txtFormaDePago.Size = new System.Drawing.Size(286, 20);
            this.txtFormaDePago.TabIndex = 0;
            // 
            // lblFormaDePago
            // 
            this.lblFormaDePago.AutoSize = true;
            this.lblFormaDePago.Location = new System.Drawing.Point(12, 15);
            this.lblFormaDePago.Name = "lblFormaDePago";
            this.lblFormaDePago.Size = new System.Drawing.Size(113, 13);
            this.lblFormaDePago.TabIndex = 1;
            this.lblFormaDePago.Text = "Nueva forma de pago:";
            // 
            // btnFormaDePago
            // 
            this.btnFormaDePago.Location = new System.Drawing.Point(15, 47);
            this.btnFormaDePago.Name = "btnFormaDePago";
            this.btnFormaDePago.Size = new System.Drawing.Size(402, 23);
            this.btnFormaDePago.TabIndex = 2;
            this.btnFormaDePago.Text = "Guardar forma de pago";
            this.btnFormaDePago.UseVisualStyleBackColor = true;
            this.btnFormaDePago.Click += new System.EventHandler(this.btnFormaDePago_Click);
            // 
            // dtgvFormaDePago
            // 
            this.dtgvFormaDePago.AllowUserToAddRows = false;
            this.dtgvFormaDePago.AllowUserToDeleteRows = false;
            this.dtgvFormaDePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFormaDePago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.dtgvFormaDePago.Location = new System.Drawing.Point(15, 77);
            this.dtgvFormaDePago.Name = "dtgvFormaDePago";
            this.dtgvFormaDePago.ReadOnly = true;
            this.dtgvFormaDePago.RowHeadersVisible = false;
            this.dtgvFormaDePago.Size = new System.Drawing.Size(402, 249);
            this.dtgvFormaDePago.TabIndex = 3;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre forma de pago";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ABM_GRID_FormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 338);
            this.Controls.Add(this.dtgvFormaDePago);
            this.Controls.Add(this.btnFormaDePago);
            this.Controls.Add(this.lblFormaDePago);
            this.Controls.Add(this.txtFormaDePago);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_GRID_FormaDePago";
            this.Text = "Formas de pago";
            this.Load += new System.EventHandler(this.ABM_GRID_FormaDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFormaDePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFormaDePago;
        private System.Windows.Forms.Label lblFormaDePago;
        private System.Windows.Forms.Button btnFormaDePago;
        private System.Windows.Forms.DataGridView dtgvFormaDePago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}