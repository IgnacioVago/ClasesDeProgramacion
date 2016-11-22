namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrecio = new System.Windows.Forms.Button();
            this.lblLamparitas = new System.Windows.Forms.Label();
            this.txtLamparitas = new System.Windows.Forms.TextBox();
            this.cmbMarcaLamparas = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPrecio
            // 
            this.btnPrecio.Location = new System.Drawing.Point(63, 141);
            this.btnPrecio.Name = "btnPrecio";
            this.btnPrecio.Size = new System.Drawing.Size(146, 37);
            this.btnPrecio.TabIndex = 0;
            this.btnPrecio.Text = "Calcular precio";
            this.btnPrecio.UseVisualStyleBackColor = true;
            this.btnPrecio.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLamparitas
            // 
            this.lblLamparitas.AutoSize = true;
            this.lblLamparitas.Location = new System.Drawing.Point(82, 9);
            this.lblLamparitas.Name = "lblLamparitas";
            this.lblLamparitas.Size = new System.Drawing.Size(112, 13);
            this.lblLamparitas.TabIndex = 1;
            this.lblLamparitas.Text = "Cantidad de lamparas:";
            // 
            // txtLamparitas
            // 
            this.txtLamparitas.Location = new System.Drawing.Point(85, 25);
            this.txtLamparitas.Name = "txtLamparitas";
            this.txtLamparitas.Size = new System.Drawing.Size(100, 20);
            this.txtLamparitas.TabIndex = 2;
            this.txtLamparitas.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbMarcaLamparas
            // 
            this.cmbMarcaLamparas.FormattingEnabled = true;
            this.cmbMarcaLamparas.Items.AddRange(new object[] {
            "ArgentinaLuz",
            "FelipeLamparas",
            "JeLuz",
            "HazIluminacion",
            "Osram"});
            this.cmbMarcaLamparas.Location = new System.Drawing.Point(73, 60);
            this.cmbMarcaLamparas.Name = "cmbMarcaLamparas";
            this.cmbMarcaLamparas.Size = new System.Drawing.Size(121, 21);
            this.cmbMarcaLamparas.TabIndex = 3;
            this.cmbMarcaLamparas.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbMarcaLamparas);
            this.Controls.Add(this.txtLamparitas);
            this.Controls.Add(this.lblLamparitas);
            this.Controls.Add(this.btnPrecio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrecio;
        private System.Windows.Forms.Label lblLamparitas;
        private System.Windows.Forms.TextBox txtLamparitas;
        private System.Windows.Forms.ComboBox cmbMarcaLamparas;
    }
}

