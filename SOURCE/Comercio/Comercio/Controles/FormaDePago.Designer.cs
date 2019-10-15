namespace Comercio.Controles
{
    partial class FormaDePago
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
            this.chkBoxEnabled = new System.Windows.Forms.CheckBox();
            this.rdProcentage = new System.Windows.Forms.RadioButton();
            this.rdPrecioFinal = new System.Windows.Forms.RadioButton();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblLabelPrecioFinal = new System.Windows.Forms.Label();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkBoxEnabled
            // 
            this.chkBoxEnabled.AutoSize = true;
            this.chkBoxEnabled.Location = new System.Drawing.Point(14, 15);
            this.chkBoxEnabled.Name = "chkBoxEnabled";
            this.chkBoxEnabled.Size = new System.Drawing.Size(123, 17);
            this.chkBoxEnabled.TabIndex = 1;
            this.chkBoxEnabled.Text = "[NombreFormaPago]";
            this.chkBoxEnabled.UseVisualStyleBackColor = true;
            this.chkBoxEnabled.CheckedChanged += new System.EventHandler(this.chkBoxEnabled_CheckedChanged);
            // 
            // rdProcentage
            // 
            this.rdProcentage.AutoSize = true;
            this.rdProcentage.Checked = true;
            this.rdProcentage.Location = new System.Drawing.Point(352, 3);
            this.rdProcentage.Name = "rdProcentage";
            this.rdProcentage.Size = new System.Drawing.Size(80, 17);
            this.rdProcentage.TabIndex = 2;
            this.rdProcentage.TabStop = true;
            this.rdProcentage.Text = "Porcentage";
            this.rdProcentage.UseVisualStyleBackColor = true;
            // 
            // rdPrecioFinal
            // 
            this.rdPrecioFinal.AutoSize = true;
            this.rdPrecioFinal.Location = new System.Drawing.Point(352, 26);
            this.rdPrecioFinal.Name = "rdPrecioFinal";
            this.rdPrecioFinal.Size = new System.Drawing.Size(77, 17);
            this.rdPrecioFinal.TabIndex = 3;
            this.rdPrecioFinal.Text = "Precio final";
            this.rdPrecioFinal.UseVisualStyleBackColor = true;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(435, 13);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(69, 20);
            this.txtValue.TabIndex = 4;
            // 
            // lblLabelPrecioFinal
            // 
            this.lblLabelPrecioFinal.AutoSize = true;
            this.lblLabelPrecioFinal.Location = new System.Drawing.Point(516, 17);
            this.lblLabelPrecioFinal.Name = "lblLabelPrecioFinal";
            this.lblLabelPrecioFinal.Size = new System.Drawing.Size(62, 13);
            this.lblLabelPrecioFinal.TabIndex = 5;
            this.lblLabelPrecioFinal.Text = "PrecioFinal:";
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(584, 17);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(65, 13);
            this.lblPrecioFinal.TabIndex = 6;
            this.lblPrecioFinal.Text = "[PrecioFinal]";
            // 
            // FormaDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.lblLabelPrecioFinal);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.rdPrecioFinal);
            this.Controls.Add(this.rdProcentage);
            this.Controls.Add(this.chkBoxEnabled);
            this.Name = "FormaDePago";
            this.Size = new System.Drawing.Size(676, 45);
            this.Load += new System.EventHandler(this.FormaDePago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLabelPrecioFinal;
        public System.Windows.Forms.CheckBox chkBoxEnabled;
        public System.Windows.Forms.RadioButton rdProcentage;
        public System.Windows.Forms.RadioButton rdPrecioFinal;
        public System.Windows.Forms.TextBox txtValue;
        public System.Windows.Forms.Label lblPrecioFinal;
    }
}
