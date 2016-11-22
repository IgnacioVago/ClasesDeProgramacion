namespace solucionTP6
{
    partial class adivinaNumero2
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
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblIntentos = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtIntentos = new System.Windows.Forms.TextBox();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(10, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(83, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Ingrese numero:";
            // 
            // lblIntentos
            // 
            this.lblIntentos.AutoSize = true;
            this.lblIntentos.Location = new System.Drawing.Point(9, 57);
            this.lblIntentos.Name = "lblIntentos";
            this.lblIntentos.Size = new System.Drawing.Size(48, 13);
            this.lblIntentos.TabIndex = 1;
            this.lblIntentos.Text = "Intentos:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(12, 29);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 2;
            this.txtNumero.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtIntentos
            // 
            this.txtIntentos.Location = new System.Drawing.Point(13, 73);
            this.txtIntentos.Name = "txtIntentos";
            this.txtIntentos.ReadOnly = true;
            this.txtIntentos.Size = new System.Drawing.Size(100, 20);
            this.txtIntentos.TabIndex = 3;
            this.txtIntentos.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Location = new System.Drawing.Point(13, 166);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(75, 23);
            this.btnComenzar.TabIndex = 4;
            this.btnComenzar.Text = "Comenzar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(12, 196);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 5;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // adivinaNumero2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.txtIntentos);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblIntentos);
            this.Controls.Add(this.lblNumero);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Name = "adivinaNumero2";
            this.Text = "Adivina el numero V2.0";
            this.Load += new System.EventHandler(this.adivinaNumero2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblIntentos;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtIntentos;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Button btnVerificar;
    }
}

