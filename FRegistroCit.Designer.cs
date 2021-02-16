namespace Proyecto_Final
{
    partial class FRegistroCitas
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
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblClinica = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtClinica = new System.Windows.Forms.TextBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridViewCit = new System.Windows.Forms.DataGridView();
            this.txtCausa = new System.Windows.Forms.TextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblCausa = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblExequatur = new System.Windows.Forms.Label();
            this.txtExequatur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(44, 170);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(51, 198);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            // 
            // lblClinica
            // 
            this.lblClinica.AutoSize = true;
            this.lblClinica.Location = new System.Drawing.Point(41, 227);
            this.lblClinica.Name = "lblClinica";
            this.lblClinica.Size = new System.Drawing.Size(40, 13);
            this.lblClinica.TabIndex = 3;
            this.lblClinica.Text = "Clínica";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(32, 141);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 4;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(39, 112);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(42, 13);
            this.lblMedico.TabIndex = 5;
            this.lblMedico.Text = "Médico";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(87, 167);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(138, 20);
            this.txtFecha.TabIndex = 6;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(87, 195);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(138, 20);
            this.txtHora.TabIndex = 7;
            // 
            // txtClinica
            // 
            this.txtClinica.Location = new System.Drawing.Point(87, 224);
            this.txtClinica.Name = "txtClinica";
            this.txtClinica.Size = new System.Drawing.Size(138, 20);
            this.txtClinica.TabIndex = 8;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(87, 138);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(138, 20);
            this.txtPaciente.TabIndex = 9;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(87, 109);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(138, 20);
            this.txtMedico.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(231, 78);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(596, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(86, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dataGridViewCit
            // 
            this.dataGridViewCit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCit.Location = new System.Drawing.Point(333, 78);
            this.dataGridViewCit.Name = "dataGridViewCit";
            this.dataGridViewCit.Size = new System.Drawing.Size(441, 166);
            this.dataGridViewCit.TabIndex = 16;
            // 
            // txtCausa
            // 
            this.txtCausa.Location = new System.Drawing.Point(35, 323);
            this.txtCausa.Multiline = true;
            this.txtCausa.Name = "txtCausa";
            this.txtCausa.Size = new System.Drawing.Size(271, 115);
            this.txtCausa.TabIndex = 18;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(688, 49);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(86, 23);
            this.btnMostrarTodos.TabIndex = 19;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(231, 222);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 42;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(231, 170);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 41;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(231, 122);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 40;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(560, 375);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(104, 30);
            this.btnAtras.TabIndex = 73;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(670, 375);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 30);
            this.btnSalir.TabIndex = 72;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblCausa
            // 
            this.lblCausa.AutoSize = true;
            this.lblCausa.Location = new System.Drawing.Point(32, 300);
            this.lblCausa.Name = "lblCausa";
            this.lblCausa.Size = new System.Drawing.Size(37, 13);
            this.lblCausa.TabIndex = 74;
            this.lblCausa.Text = "Causa";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(333, 51);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(257, 20);
            this.txtBuscar.TabIndex = 75;
            // 
            // lblExequatur
            // 
            this.lblExequatur.AutoSize = true;
            this.lblExequatur.Location = new System.Drawing.Point(26, 83);
            this.lblExequatur.Name = "lblExequatur";
            this.lblExequatur.Size = new System.Drawing.Size(55, 13);
            this.lblExequatur.TabIndex = 80;
            this.lblExequatur.Text = "Exequatur";
            // 
            // txtExequatur
            // 
            this.txtExequatur.Location = new System.Drawing.Point(87, 80);
            this.txtExequatur.Name = "txtExequatur";
            this.txtExequatur.Size = new System.Drawing.Size(138, 20);
            this.txtExequatur.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "Nombre del Medico o Exequatur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Pro Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(81, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 33);
            this.label2.TabIndex = 83;
            this.label2.Text = "Registrar Cita";
            // 
            // FRegistroCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExequatur);
            this.Controls.Add(this.lblExequatur);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblCausa);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.txtCausa);
            this.Controls.Add(this.dataGridViewCit);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtMedico);
            this.Controls.Add(this.txtPaciente);
            this.Controls.Add(this.txtClinica);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lblClinica);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Name = "FRegistroCitas";
            this.Text = "FCitas";
            this.Load += new System.EventHandler(this.FRegistroCitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblClinica;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtClinica;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridViewCit;
        private System.Windows.Forms.TextBox txtCausa;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCausa;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblExequatur;
        private System.Windows.Forms.TextBox txtExequatur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}