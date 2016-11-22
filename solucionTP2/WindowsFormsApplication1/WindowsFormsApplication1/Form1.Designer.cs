namespace WindowsFormsApplication1
{
    partial class tpDos
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
            this.btnRecAlambre = new System.Windows.Forms.Button();
            this.btnCirAlambre = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.lblLargo = new System.Windows.Forms.Label();
            this.txtLargo = new System.Windows.Forms.TextBox();
            this.lblAncho = new System.Windows.Forms.Label();
            this.txtAncho = new System.Windows.Forms.TextBox();
            this.lblCirculo = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRecAlambre
            // 
            this.btnRecAlambre.Location = new System.Drawing.Point(81, 167);
            this.btnRecAlambre.Name = "btnRecAlambre";
            this.btnRecAlambre.Size = new System.Drawing.Size(135, 23);
            this.btnRecAlambre.TabIndex = 0;
            this.btnRecAlambre.Text = "Rectangulo de alambre";
            this.btnRecAlambre.UseVisualStyleBackColor = true;
            this.btnRecAlambre.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCirAlambre
            // 
            this.btnCirAlambre.Location = new System.Drawing.Point(81, 196);
            this.btnCirAlambre.Name = "btnCirAlambre";
            this.btnCirAlambre.Size = new System.Drawing.Size(135, 23);
            this.btnCirAlambre.TabIndex = 1;
            this.btnCirAlambre.Text = "Circulo de alambre";
            this.btnCirAlambre.UseVisualStyleBackColor = true;
            this.btnCirAlambre.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.Location = new System.Drawing.Point(81, 225);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(135, 23);
            this.btnMateriales.TabIndex = 2;
            this.btnMateriales.Text = "Materiales de contrapiso";
            this.btnMateriales.UseVisualStyleBackColor = true;
            this.btnMateriales.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblLargo
            // 
            this.lblLargo.AutoSize = true;
            this.lblLargo.Location = new System.Drawing.Point(13, 13);
            this.lblLargo.Name = "lblLargo";
            this.lblLargo.Size = new System.Drawing.Size(90, 13);
            this.lblLargo.TabIndex = 3;
            this.lblLargo.Text = "Largo del terreno:";
            this.lblLargo.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtLargo
            // 
            this.txtLargo.Location = new System.Drawing.Point(16, 30);
            this.txtLargo.Name = "txtLargo";
            this.txtLargo.Size = new System.Drawing.Size(100, 20);
            this.txtLargo.TabIndex = 4;
            // 
            // lblAncho
            // 
            this.lblAncho.AutoSize = true;
            this.lblAncho.Location = new System.Drawing.Point(13, 58);
            this.lblAncho.Name = "lblAncho";
            this.lblAncho.Size = new System.Drawing.Size(94, 13);
            this.lblAncho.TabIndex = 5;
            this.lblAncho.Text = "Ancho del terreno:";
            // 
            // txtAncho
            // 
            this.txtAncho.Location = new System.Drawing.Point(16, 78);
            this.txtAncho.Name = "txtAncho";
            this.txtAncho.Size = new System.Drawing.Size(100, 20);
            this.txtAncho.TabIndex = 6;
            // 
            // lblCirculo
            // 
            this.lblCirculo.AutoSize = true;
            this.lblCirculo.Location = new System.Drawing.Point(13, 110);
            this.lblCirculo.Name = "lblCirculo";
            this.lblCirculo.Size = new System.Drawing.Size(91, 13);
            this.lblCirculo.TabIndex = 7;
            this.lblCirculo.Text = "Radio del terreno:";
            this.lblCirculo.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(16, 127);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 8;
            this.txtRadio.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tpDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 278);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblCirculo);
            this.Controls.Add(this.txtAncho);
            this.Controls.Add(this.lblAncho);
            this.Controls.Add(this.txtLargo);
            this.Controls.Add(this.lblLargo);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.btnCirAlambre);
            this.Controls.Add(this.btnRecAlambre);
            this.Name = "tpDos";
            this.Text = "Departamento de Construccion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRecAlambre;
        private System.Windows.Forms.Button btnCirAlambre;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Label lblLargo;
        private System.Windows.Forms.TextBox txtLargo;
        private System.Windows.Forms.Label lblAncho;
        private System.Windows.Forms.TextBox txtAncho;
        private System.Windows.Forms.Label lblCirculo;
        private System.Windows.Forms.TextBox txtRadio;
    }
}

