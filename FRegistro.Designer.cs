namespace Proyecto_Final
{
    partial class FRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegistro));
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.btnClinica = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblTit = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPaciente
            // 
            this.btnPaciente.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.Location = new System.Drawing.Point(137, 176);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(82, 33);
            this.btnPaciente.TabIndex = 0;
            this.btnPaciente.Text = "Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Location = new System.Drawing.Point(137, 215);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(82, 33);
            this.btnMedico.TabIndex = 1;
            this.btnMedico.Text = "Medíco";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // btnClinica
            // 
            this.btnClinica.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClinica.Location = new System.Drawing.Point(137, 254);
            this.btnClinica.Name = "btnClinica";
            this.btnClinica.Size = new System.Drawing.Size(82, 33);
            this.btnClinica.TabIndex = 2;
            this.btnClinica.Text = "Clínica";
            this.btnClinica.UseVisualStyleBackColor = true;
            this.btnClinica.Click += new System.EventHandler(this.btnClinica_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(48, 385);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(103, 33);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Atrás";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.Font = new System.Drawing.Font("Segoe Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTit.Location = new System.Drawing.Point(287, 50);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(227, 33);
            this.lblTit.TabIndex = 5;
            this.lblTit.Text = "Módulo de Registro";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(650, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 38);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(239, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 447);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnClinica);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnPaciente);
            this.Name = "FRegistro";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedico;
        private System.Windows.Forms.Button btnClinica;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblTit;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}