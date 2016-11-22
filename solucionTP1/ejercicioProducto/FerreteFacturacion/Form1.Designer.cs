namespace FerreteFacturacion
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
            this.lblNroUno = new System.Windows.Forms.Label();
            this.lblNroDos = new System.Windows.Forms.Label();
            this.lblNroTres = new System.Windows.Forms.Label();
            this.txtNumeroTres = new System.Windows.Forms.TextBox();
            this.txtNumeroDos = new System.Windows.Forms.TextBox();
            this.txtNumeroUno = new System.Windows.Forms.TextBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.btnPrecioIva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNroUno
            // 
            this.lblNroUno.AutoSize = true;
            this.lblNroUno.Location = new System.Drawing.Point(19, 9);
            this.lblNroUno.Name = "lblNroUno";
            this.lblNroUno.Size = new System.Drawing.Size(77, 13);
            this.lblNroUno.TabIndex = 0;
            this.lblNroUno.Text = "Primer numero:";
            this.lblNroUno.Click += new System.EventHandler(this.lblNroUno_Click);
            // 
            // lblNroDos
            // 
            this.lblNroDos.AutoSize = true;
            this.lblNroDos.Location = new System.Drawing.Point(19, 58);
            this.lblNroDos.Name = "lblNroDos";
            this.lblNroDos.Size = new System.Drawing.Size(91, 13);
            this.lblNroDos.TabIndex = 1;
            this.lblNroDos.Text = "Segundo numero:";
            this.lblNroDos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNroTres
            // 
            this.lblNroTres.AutoSize = true;
            this.lblNroTres.Location = new System.Drawing.Point(19, 108);
            this.lblNroTres.Name = "lblNroTres";
            this.lblNroTres.Size = new System.Drawing.Size(79, 13);
            this.lblNroTres.TabIndex = 2;
            this.lblNroTres.Text = "Tercer numero:";
            this.lblNroTres.Click += new System.EventHandler(this.lblNroTres_Click);
            // 
            // txtNumeroTres
            // 
            this.txtNumeroTres.Location = new System.Drawing.Point(22, 124);
            this.txtNumeroTres.Name = "txtNumeroTres";
            this.txtNumeroTres.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroTres.TabIndex = 3;
            this.txtNumeroTres.TextChanged += new System.EventHandler(this.txtNumero_TextChanged);
            // 
            // txtNumeroDos
            // 
            this.txtNumeroDos.Location = new System.Drawing.Point(22, 74);
            this.txtNumeroDos.Name = "txtNumeroDos";
            this.txtNumeroDos.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroDos.TabIndex = 4;
            this.txtNumeroDos.TextChanged += new System.EventHandler(this.txtNumeroDos_TextChanged);
            // 
            // txtNumeroUno
            // 
            this.txtNumeroUno.Location = new System.Drawing.Point(22, 26);
            this.txtNumeroUno.Name = "txtNumeroUno";
            this.txtNumeroUno.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroUno.TabIndex = 5;
            this.txtNumeroUno.TextChanged += new System.EventHandler(this.txtNumeroUno_TextChanged);
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(35, 171);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(75, 23);
            this.btnSumar.TabIndex = 6;
            this.btnSumar.Text = "Sumar";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(35, 214);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(75, 23);
            this.btnPromedio.TabIndex = 7;
            this.btnPromedio.Text = "Promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnPrecioIva
            // 
            this.btnPrecioIva.Location = new System.Drawing.Point(35, 256);
            this.btnPrecioIva.Name = "btnPrecioIva";
            this.btnPrecioIva.Size = new System.Drawing.Size(75, 23);
            this.btnPrecioIva.TabIndex = 8;
            this.btnPrecioIva.Text = "Precio final";
            this.btnPrecioIva.UseVisualStyleBackColor = true;
            this.btnPrecioIva.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(520, 304);
            this.Controls.Add(this.btnPrecioIva);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.txtNumeroUno);
            this.Controls.Add(this.txtNumeroDos);
            this.Controls.Add(this.txtNumeroTres);
            this.Controls.Add(this.lblNroTres);
            this.Controls.Add(this.lblNroDos);
            this.Controls.Add(this.lblNroUno);
            this.Name = "Form1";
            this.Text = "Ferrete Facturacion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroUno;
        private System.Windows.Forms.Label lblNroDos;
        private System.Windows.Forms.Label lblNroTres;
        private System.Windows.Forms.TextBox txtNumeroTres;
        private System.Windows.Forms.TextBox txtNumeroDos;
        private System.Windows.Forms.TextBox txtNumeroUno;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Button btnPrecioIva;
    }
}

