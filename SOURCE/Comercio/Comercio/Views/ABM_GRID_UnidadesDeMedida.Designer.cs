namespace Comercio.Views
{
    partial class ABM_GRID_UnidadesDeMedida
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtunidadname = new System.Windows.Forms.TextBox();
            this.lblNuevaUnidad = new System.Windows.Forms.Label();
            this.btnGuardarUnidad = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Simbolo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblsimbolo = new System.Windows.Forms.Label();
            this.txtsimbolounidad = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Simbolo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(243, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtunidadname
            // 
            this.txtunidadname.Location = new System.Drawing.Point(97, 26);
            this.txtunidadname.Name = "txtunidadname";
            this.txtunidadname.Size = new System.Drawing.Size(158, 20);
            this.txtunidadname.TabIndex = 1;
            // 
            // lblNuevaUnidad
            // 
            this.lblNuevaUnidad.AutoSize = true;
            this.lblNuevaUnidad.Location = new System.Drawing.Point(12, 29);
            this.lblNuevaUnidad.Name = "lblNuevaUnidad";
            this.lblNuevaUnidad.Size = new System.Drawing.Size(79, 13);
            this.lblNuevaUnidad.TabIndex = 2;
            this.lblNuevaUnidad.Text = "Nueva Unidad:";
            // 
            // btnGuardarUnidad
            // 
            this.btnGuardarUnidad.Location = new System.Drawing.Point(12, 90);
            this.btnGuardarUnidad.Name = "btnGuardarUnidad";
            this.btnGuardarUnidad.Size = new System.Drawing.Size(243, 29);
            this.btnGuardarUnidad.TabIndex = 3;
            this.btnGuardarUnidad.Text = "Guardar unidad de medida";
            this.btnGuardarUnidad.UseVisualStyleBackColor = true;
            this.btnGuardarUnidad.Click += new System.EventHandler(this.btnGuardarUnidad_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Simbolo
            // 
            this.Simbolo.HeaderText = "Simbolo";
            this.Simbolo.Name = "Simbolo";
            this.Simbolo.ReadOnly = true;
            // 
            // lblsimbolo
            // 
            this.lblsimbolo.AutoSize = true;
            this.lblsimbolo.Location = new System.Drawing.Point(12, 59);
            this.lblsimbolo.Name = "lblsimbolo";
            this.lblsimbolo.Size = new System.Drawing.Size(84, 13);
            this.lblsimbolo.TabIndex = 5;
            this.lblsimbolo.Text = "Simbolo Unidad:";
            // 
            // txtsimbolounidad
            // 
            this.txtsimbolounidad.Location = new System.Drawing.Point(97, 56);
            this.txtsimbolounidad.Name = "txtsimbolounidad";
            this.txtsimbolounidad.Size = new System.Drawing.Size(158, 20);
            this.txtsimbolounidad.TabIndex = 4;
            // 
            // ABM_GRID_UnidadesDeMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 334);
            this.Controls.Add(this.lblsimbolo);
            this.Controls.Add(this.txtsimbolounidad);
            this.Controls.Add(this.btnGuardarUnidad);
            this.Controls.Add(this.lblNuevaUnidad);
            this.Controls.Add(this.txtunidadname);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABM_GRID_UnidadesDeMedida";
            this.Text = "Unidades de medida";
            this.Load += new System.EventHandler(this.ABM_GRID_UnidadesDeMedida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtunidadname;
        private System.Windows.Forms.Label lblNuevaUnidad;
        private System.Windows.Forms.Button btnGuardarUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Simbolo;
        private System.Windows.Forms.Label lblsimbolo;
        private System.Windows.Forms.TextBox txtsimbolounidad;
    }
}