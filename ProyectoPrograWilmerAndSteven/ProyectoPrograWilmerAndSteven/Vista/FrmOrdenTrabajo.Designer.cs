namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmOrdenTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdenTrabajo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.DTGOrdenTrabajos = new System.Windows.Forms.DataGridView();
            this.IdOrden = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFacturacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGOrdenTrabajos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(848, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 35);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 35);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // DTGOrdenTrabajos
            // 
            this.DTGOrdenTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGOrdenTrabajos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdOrden,
            this.Vehiculo,
            this.Empleado,
            this.FechaIngreso,
            this.FechaSalida,
            this.FechaFacturacion,
            this.Costo,
            this.Estado});
            this.DTGOrdenTrabajos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGOrdenTrabajos.Location = new System.Drawing.Point(0, 38);
            this.DTGOrdenTrabajos.Name = "DTGOrdenTrabajos";
            this.DTGOrdenTrabajos.Size = new System.Drawing.Size(848, 298);
            this.DTGOrdenTrabajos.TabIndex = 1;
            // 
            // IdOrden
            // 
            this.IdOrden.HeaderText = "Id orden";
            this.IdOrden.Name = "IdOrden";
            // 
            // Vehiculo
            // 
            this.Vehiculo.HeaderText = "Vehiculo";
            this.Vehiculo.Name = "Vehiculo";
            // 
            // Empleado
            // 
            this.Empleado.HeaderText = "Empleado";
            this.Empleado.Name = "Empleado";
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.HeaderText = "Fecha ingreso";
            this.FechaIngreso.Name = "FechaIngreso";
            // 
            // FechaSalida
            // 
            this.FechaSalida.HeaderText = "Fecha salida";
            this.FechaSalida.Name = "FechaSalida";
            // 
            // FechaFacturacion
            // 
            this.FechaFacturacion.HeaderText = "Fecha facturación";
            this.FechaFacturacion.Name = "FechaFacturacion";
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.Name = "Costo";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // FrmOrdenTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 336);
            this.Controls.Add(this.DTGOrdenTrabajos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmOrdenTrabajo";
            this.Text = "Orden de trabajo";
            this.Load += new System.EventHandler(this.FrmOrdenTrabajo_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGOrdenTrabajos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView DTGOrdenTrabajos;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFacturacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}