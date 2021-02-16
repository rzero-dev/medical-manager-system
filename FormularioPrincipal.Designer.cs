namespace Proyecto_Final
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioPrincipal));
            this.lblTit = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCitas = new System.Windows.Forms.Button();
            this.btnConversor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.BackColor = System.Drawing.SystemColors.Control;
            this.lblTit.Font = new System.Drawing.Font("Segoe Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblTit.Location = new System.Drawing.Point(257, 26);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(283, 33);
            this.lblTit.TabIndex = 0;
            this.lblTit.Text = "Sistema de Citas Médicas";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnRegistro.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Location = new System.Drawing.Point(81, 372);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(103, 38);
            this.btnRegistro.TabIndex = 1;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnConsultas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(254, 372);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(103, 38);
            this.btnConsultas.TabIndex = 3;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(685, 54);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(254, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnCitas
            // 
            this.btnCitas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnCitas.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCitas.Location = new System.Drawing.Point(437, 372);
            this.btnCitas.Name = "btnCitas";
            this.btnCitas.Size = new System.Drawing.Size(103, 38);
            this.btnCitas.TabIndex = 7;
            this.btnCitas.Text = "Citas";
            this.btnCitas.UseVisualStyleBackColor = false;
            this.btnCitas.Click += new System.EventHandler(this.btnCitas_Click);
            // 
            // btnConversor
            // 
            this.btnConversor.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnConversor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConversor.Location = new System.Drawing.Point(614, 372);
            this.btnConversor.Name = "btnConversor";
            this.btnConversor.Size = new System.Drawing.Size(103, 38);
            this.btnConversor.TabIndex = 8;
            this.btnConversor.Text = "Conversor de Monedas";
            this.btnConversor.UseVisualStyleBackColor = false;
            this.btnConversor.Click += new System.EventHandler(this.btnConversor_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConversor);
            this.Controls.Add(this.btnCitas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblTit);
            this.Name = "FormularioPrincipal";
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCitas;
        private System.Windows.Forms.Button btnConversor;
    }
}

