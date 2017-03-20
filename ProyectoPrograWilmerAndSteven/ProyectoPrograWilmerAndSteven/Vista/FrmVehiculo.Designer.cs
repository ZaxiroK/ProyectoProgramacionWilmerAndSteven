namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehiculo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.dGVVehiculos = new System.Windows.Forms.DataGridView();
            this.idModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaseVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidadPersonas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroMotor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroChasis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combustible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEditar,
            this.btnBorrar,
            this.btnActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(942, 42);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 39);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 39);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(43, 39);
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(63, 39);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dGVVehiculos
            // 
            this.dGVVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVVehiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idModelo,
            this.Dueño,
            this.Modelo,
            this.placa,
            this.ClaseVehiculo,
            this.CapacidadPersonas,
            this.NumeroMotor,
            this.NumeroChasis,
            this.combustible});
            this.dGVVehiculos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVVehiculos.Location = new System.Drawing.Point(0, 42);
            this.dGVVehiculos.Name = "dGVVehiculos";
            this.dGVVehiculos.Size = new System.Drawing.Size(942, 232);
            this.dGVVehiculos.TabIndex = 2;
            // 
            // idModelo
            // 
            this.idModelo.DataPropertyName = "idVehiculo";
            this.idModelo.HeaderText = "ID";
            this.idModelo.Name = "idModelo";
            // 
            // Dueño
            // 
            this.Dueño.DataPropertyName = "oClienteE";
            this.Dueño.HeaderText = "Dueño";
            this.Dueño.Name = "Dueño";
            // 
            // Modelo
            // 
            this.Modelo.DataPropertyName = "oModeloE";
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            // 
            // placa
            // 
            this.placa.DataPropertyName = "placa";
            this.placa.HeaderText = "Placa";
            this.placa.Name = "placa";
            // 
            // ClaseVehiculo
            // 
            this.ClaseVehiculo.DataPropertyName = "claseVehiculo";
            this.ClaseVehiculo.HeaderText = "Clase de vehiculo";
            this.ClaseVehiculo.Name = "ClaseVehiculo";
            // 
            // CapacidadPersonas
            // 
            this.CapacidadPersonas.DataPropertyName = "capacidadPersonas";
            this.CapacidadPersonas.HeaderText = "Capacidad de personas";
            this.CapacidadPersonas.Name = "CapacidadPersonas";
            // 
            // NumeroMotor
            // 
            this.NumeroMotor.DataPropertyName = "numeroMotor";
            this.NumeroMotor.HeaderText = "Número de motor";
            this.NumeroMotor.Name = "NumeroMotor";
            // 
            // NumeroChasis
            // 
            this.NumeroChasis.DataPropertyName = "numeroChasis";
            this.NumeroChasis.HeaderText = "Número de chasis";
            this.NumeroChasis.Name = "NumeroChasis";
            // 
            // combustible
            // 
            this.combustible.DataPropertyName = "combustible";
            this.combustible.HeaderText = "Combustible";
            this.combustible.Name = "combustible";
            // 
            // FrmVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 274);
            this.Controls.Add(this.dGVVehiculos);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVehiculo";
            this.Text = "FrmVehiculo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVVehiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.DataGridView dGVVehiculos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaseVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidadPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroMotor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroChasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn combustible;
    }
}