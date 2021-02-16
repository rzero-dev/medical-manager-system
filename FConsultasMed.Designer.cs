namespace Proyecto_Final
{
    partial class FConsultasMed
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dataGridViewConsultaPac = new System.Windows.Forms.DataGridView();
            this.lblTit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaPac)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(678, 107);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(103, 19);
            this.btnLimpiar.TabIndex = 93;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Location = new System.Drawing.Point(358, 390);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(104, 30);
            this.btnInicio.TabIndex = 92;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(573, 107);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(99, 19);
            this.btnMostrarTodos.TabIndex = 91;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 90;
            this.label2.Text = "Ingrese el Nombre o el Exequátur del médico:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(238, 106);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(215, 20);
            this.txtBuscar.TabIndex = 89;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(459, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(108, 19);
            this.btnBuscar.TabIndex = 88;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(29, 390);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(104, 30);
            this.btnAtras.TabIndex = 87;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(683, 390);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 30);
            this.btnSalir.TabIndex = 86;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dataGridViewConsultaPac
            // 
            this.dataGridViewConsultaPac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultaPac.Location = new System.Drawing.Point(17, 131);
            this.dataGridViewConsultaPac.Name = "dataGridViewConsultaPac";
            this.dataGridViewConsultaPac.Size = new System.Drawing.Size(764, 202);
            this.dataGridViewConsultaPac.TabIndex = 85;
            // 
            // lblTit
            // 
            this.lblTit.AutoSize = true;
            this.lblTit.Font = new System.Drawing.Font("Segoe Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTit.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblTit.Location = new System.Drawing.Point(232, 29);
            this.lblTit.Name = "lblTit";
            this.lblTit.Size = new System.Drawing.Size(369, 33);
            this.lblTit.TabIndex = 94;
            this.lblTit.Text = "Consulta de Medicos Registrados";
            // 
            // FConsultasMed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTit);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dataGridViewConsultaPac);
            this.Name = "FConsultasMed";
            this.Text = "FConsultasMed";
            this.Load += new System.EventHandler(this.FConsultasMed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultaPac)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dataGridViewConsultaPac;
        private System.Windows.Forms.Label lblTit;
    }
}