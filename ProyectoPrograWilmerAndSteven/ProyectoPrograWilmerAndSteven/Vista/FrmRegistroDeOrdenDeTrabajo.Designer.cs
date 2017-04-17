namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmRegistroDeOrdenDeTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegistroDeOrdenDeTrabajo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizar = new System.Windows.Forms.ToolStripButton();
            this.btnFacturar = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DTGreparaciones = new System.Windows.Forms.DataGridView();
            this.idReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaTotalReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoReparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedulaEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAgregarReparacion = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarReparacion = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DTGrepuestos = new System.Windows.Forms.DataGridView();
            this.idRepuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrdenTrabajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOrdenRepuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarRepuestos = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGreparaciones)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGrepuestos)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnFinalizar,
            this.btnFacturar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(738, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 35);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
            this.btnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(54, 35);
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.Image")));
            this.btnFacturar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(54, 35);
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vehiculo:";
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(92, 55);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(277, 21);
            this.cmbCliente.TabIndex = 4;
            this.cmbCliente.SelectionChangeCommitted += new System.EventHandler(this.cmbCliente_SelectionChangeCommitted);
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(92, 92);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(277, 21);
            this.cmbVehiculo.TabIndex = 5;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(0, 180);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(738, 306);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DTGreparaciones);
            this.tabPage1.Controls.Add(this.toolStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(730, 280);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reparaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DTGreparaciones
            // 
            this.DTGreparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGreparaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReparacion,
            this.descripcion,
            this.horaTotalReparacion,
            this.costoReparacion,
            this.cedulaEmpleado});
            this.DTGreparaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGreparaciones.Location = new System.Drawing.Point(3, 41);
            this.DTGreparaciones.Name = "DTGreparaciones";
            this.DTGreparaciones.Size = new System.Drawing.Size(724, 236);
            this.DTGreparaciones.TabIndex = 1;
            // 
            // idReparacion
            // 
            this.idReparacion.HeaderText = "Id reparación";
            this.idReparacion.Name = "idReparacion";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Nombre";
            this.descripcion.Name = "descripcion";
            // 
            // horaTotalReparacion
            // 
            this.horaTotalReparacion.HeaderText = "Horas";
            this.horaTotalReparacion.Name = "horaTotalReparacion";
            // 
            // costoReparacion
            // 
            this.costoReparacion.HeaderText = "Costo";
            this.costoReparacion.Name = "costoReparacion";
            // 
            // cedulaEmpleado
            // 
            this.cedulaEmpleado.HeaderText = "Encargado";
            this.cedulaEmpleado.Name = "cedulaEmpleado";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregarReparacion,
            this.btnEliminarReparacion});
            this.toolStrip2.Location = new System.Drawing.Point(3, 3);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(724, 38);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAgregarReparacion
            // 
            this.btnAgregarReparacion.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarReparacion.Image")));
            this.btnAgregarReparacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregarReparacion.Name = "btnAgregarReparacion";
            this.btnAgregarReparacion.Size = new System.Drawing.Size(56, 35);
            this.btnAgregarReparacion.Text = " Agregar";
            this.btnAgregarReparacion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregarReparacion.Click += new System.EventHandler(this.btnAgregarReparacion_Click);
            // 
            // btnEliminarReparacion
            // 
            this.btnEliminarReparacion.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarReparacion.Image")));
            this.btnEliminarReparacion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarReparacion.Name = "btnEliminarReparacion";
            this.btnEliminarReparacion.Size = new System.Drawing.Size(54, 35);
            this.btnEliminarReparacion.Text = "Eliminar";
            this.btnEliminarReparacion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEliminarReparacion.Click += new System.EventHandler(this.btnEliminarReparacion_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DTGrepuestos);
            this.tabPage2.Controls.Add(this.toolStrip3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(730, 280);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Repuestos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DTGrepuestos
            // 
            this.DTGrepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGrepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idRepuesto,
            this.nombre,
            this.anno,
            this.precio,
            this.cantidad,
            this.idOrdenTrabajo,
            this.idOrdenRepuesto});
            this.DTGrepuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGrepuestos.Location = new System.Drawing.Point(3, 41);
            this.DTGrepuestos.Name = "DTGrepuestos";
            this.DTGrepuestos.Size = new System.Drawing.Size(724, 236);
            this.DTGrepuestos.TabIndex = 1;
            // 
            // idRepuesto
            // 
            this.idRepuesto.DataPropertyName = "IdCatalogoRepuesto";
            this.idRepuesto.HeaderText = "Id repuesto";
            this.idRepuesto.Name = "idRepuesto";
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "NombreDelRepuesto";
            this.nombre.HeaderText = "Nombre Repuesto";
            this.nombre.Name = "nombre";
            // 
            // anno
            // 
            this.anno.DataPropertyName = "AnnoAlQuePertenece";
            this.anno.HeaderText = "Año";
            this.anno.Name = "anno";
            // 
            // precio
            // 
            this.precio.DataPropertyName = "Precio";
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.DataPropertyName = "Cantidad";
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // idOrdenTrabajo
            // 
            this.idOrdenTrabajo.DataPropertyName = "IdOrdenTrabajo";
            this.idOrdenTrabajo.HeaderText = "N° orden trabajo";
            this.idOrdenTrabajo.Name = "idOrdenTrabajo";
            this.idOrdenTrabajo.Visible = false;
            // 
            // idOrdenRepuesto
            // 
            this.idOrdenRepuesto.DataPropertyName = "IdOrdenRepuesto";
            this.idOrdenRepuesto.HeaderText = "N° orden repuesto";
            this.idOrdenRepuesto.Name = "idOrdenRepuesto";
            this.idOrdenRepuesto.Visible = false;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnEliminarRepuestos,
            this.btnEditar});
            this.toolStrip3.Location = new System.Drawing.Point(3, 3);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(724, 38);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(53, 35);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminarRepuestos
            // 
            this.btnEliminarRepuestos.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarRepuestos.Image")));
            this.btnEliminarRepuestos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarRepuestos.Name = "btnEliminarRepuestos";
            this.btnEliminarRepuestos.Size = new System.Drawing.Size(54, 35);
            this.btnEliminarRepuestos.Text = "Eliminar";
            this.btnEliminarRepuestos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEliminarRepuestos.Click += new System.EventHandler(this.btnEliminarRepuestos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Empleado:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(92, 136);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(277, 21);
            this.cmbEmpleado.TabIndex = 9;
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
            // FrmRegistroDeOrdenDeTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 486);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmRegistroDeOrdenDeTrabajo";
            this.Text = "Registro orden trabajo";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGreparaciones)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGrepuestos)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnFinalizar;
        private System.Windows.Forms.ToolStripButton btnFacturar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DTGreparaciones;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnAgregarReparacion;
        private System.Windows.Forms.ToolStripButton btnEliminarReparacion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DTGrepuestos;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnEliminarRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRepuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdenTrabajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrdenRepuesto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaTotalReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaEmpleado;
        private System.Windows.Forms.ToolStripButton btnEditar;
    }
}