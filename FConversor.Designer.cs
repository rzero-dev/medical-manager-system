namespace Proyecto_Final
{
    partial class FConversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConversor));
            this.lblOrigen = new System.Windows.Forms.Label();
            this.comboMonedaOrigen = new System.Windows.Forms.ComboBox();
            this.comboMonedaDestino = new System.Windows.Forms.ComboBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrigen
            // 
            this.lblOrigen.AutoSize = true;
            this.lblOrigen.Location = new System.Drawing.Point(148, 279);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(38, 13);
            this.lblOrigen.TabIndex = 1;
            this.lblOrigen.Text = "Origen";
            // 
            // comboMonedaOrigen
            // 
            this.comboMonedaOrigen.FormattingEnabled = true;
            this.comboMonedaOrigen.Location = new System.Drawing.Point(192, 276);
            this.comboMonedaOrigen.Name = "comboMonedaOrigen";
            this.comboMonedaOrigen.Size = new System.Drawing.Size(143, 21);
            this.comboMonedaOrigen.TabIndex = 2;
            this.comboMonedaOrigen.SelectedIndexChanged += new System.EventHandler(this.comboMonedaOrigen_SelectedIndexChanged);
            // 
            // comboMonedaDestino
            // 
            this.comboMonedaDestino.FormattingEnabled = true;
            this.comboMonedaDestino.Location = new System.Drawing.Point(405, 276);
            this.comboMonedaDestino.Name = "comboMonedaDestino";
            this.comboMonedaDestino.Size = new System.Drawing.Size(143, 21);
            this.comboMonedaDestino.TabIndex = 3;
            this.comboMonedaDestino.SelectedIndexChanged += new System.EventHandler(this.comboMonedaDestino_SelectedIndexChanged);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(554, 271);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(81, 29);
            this.btnConvertir.TabIndex = 4;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(303, 397);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(81, 29);
            this.btnAtras.TabIndex = 5;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(390, 397);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 29);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(359, 208);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(58, 28);
            this.txtCantidad.TabIndex = 7;
            // 
            // lblDestino
            // 
            this.lblDestino.AutoSize = true;
            this.lblDestino.Location = new System.Drawing.Point(356, 279);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(43, 13);
            this.lblDestino.TabIndex = 8;
            this.lblDestino.Text = "Destino";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(657, 279);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(13, 13);
            this.lblResultado.TabIndex = 10;
            this.lblResultado.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.Font = new System.Drawing.Font("Segoe Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTit.Location = new System.Drawing.Point(236, 20);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(338, 33);
            this.lblTit.TabIndex = 12;
            this.lblTit.Text = "Modulo Conversion de Divisas";
            // 
            // FConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDestino);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.comboMonedaDestino);
            this.Controls.Add(this.comboMonedaOrigen);
            this.Controls.Add(this.lblOrigen);
            this.Name = "FConversor";
            this.Text = "FConversor";
            this.Load += new System.EventHandler(this.FConversor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.ComboBox comboMonedaOrigen;
        private System.Windows.Forms.ComboBox comboMonedaDestino;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTit;
    }
}