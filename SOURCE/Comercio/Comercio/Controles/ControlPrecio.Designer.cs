namespace Comercio.Controles
{
    partial class ControlPrecio
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblLabelPrecio = new System.Windows.Forms.Label();
            this.lblPRECIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(4, 4);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(125, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "[Nombre forma pago]";
            // 
            // lblLabelPrecio
            // 
            this.lblLabelPrecio.AutoSize = true;
            this.lblLabelPrecio.Location = new System.Drawing.Point(4, 36);
            this.lblLabelPrecio.Name = "lblLabelPrecio";
            this.lblLabelPrecio.Size = new System.Drawing.Size(50, 13);
            this.lblLabelPrecio.TabIndex = 1;
            this.lblLabelPrecio.Text = "PRECIO:";
            // 
            // lblPRECIO
            // 
            this.lblPRECIO.AutoSize = true;
            this.lblPRECIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRECIO.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lblPRECIO.Location = new System.Drawing.Point(60, 31);
            this.lblPRECIO.Name = "lblPRECIO";
            this.lblPRECIO.Size = new System.Drawing.Size(84, 20);
            this.lblPRECIO.TabIndex = 2;
            this.lblPRECIO.Text = "$0000.00";
            // 
            // ControlPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.lblPRECIO);
            this.Controls.Add(this.lblLabelPrecio);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ControlPrecio";
            this.Size = new System.Drawing.Size(240, 60);
            this.Load += new System.EventHandler(this.ControlPrecio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblLabelPrecio;
        private System.Windows.Forms.Label lblPRECIO;
    }
}
