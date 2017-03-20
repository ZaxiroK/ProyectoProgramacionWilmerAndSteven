namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmCatalogoDeReparaciones2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalogoDeReparaciones2));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.BtnEditar = new System.Windows.Forms.ToolStripButton();
            this.BtnBorrar = new System.Windows.Forms.ToolStripButton();
            this.BtnActualizar = new System.Windows.Forms.ToolStripButton();
            this.dGVCatalogoRepuestos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reparacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCatalogoRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAgregar,
            this.BtnEditar,
            this.BtnBorrar,
            this.BtnActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(573, 42);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(53, 39);
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEditar.Image")));
            this.BtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(41, 39);
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnBorrar.Image")));
            this.BtnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(43, 39);
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnActualizar.Image")));
            this.BtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(63, 39);
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // dGVCatalogoRepuestos
            // 
            this.dGVCatalogoRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVCatalogoRepuestos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Reparacion,
            this.Anio,
            this.Precio});
            this.dGVCatalogoRepuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVCatalogoRepuestos.Location = new System.Drawing.Point(0, 42);
            this.dGVCatalogoRepuestos.Name = "dGVCatalogoRepuestos";
            this.dGVCatalogoRepuestos.Size = new System.Drawing.Size(573, 219);
            this.dGVCatalogoRepuestos.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id_catalogoReparacion";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Reparacion
            // 
            this.Reparacion.DataPropertyName = "descripcion";
            this.Reparacion.HeaderText = "Reparacion";
            this.Reparacion.Name = "Reparacion";
            // 
            // Anio
            // 
            this.Anio.DataPropertyName = "horasReparacion";
            this.Anio.HeaderText = "Horas";
            this.Anio.Name = "Anio";
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "costoReparacion";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // FrmCatalogoDeReparaciones2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 261);
            this.Controls.Add(this.dGVCatalogoRepuestos);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmCatalogoDeReparaciones2";
            this.Text = "Catalogo de Reparaciones";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVCatalogoRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnAgregar;
        private System.Windows.Forms.ToolStripButton BtnEditar;
        private System.Windows.Forms.ToolStripButton BtnBorrar;
        private System.Windows.Forms.ToolStripButton BtnActualizar;
        private System.Windows.Forms.DataGridView dGVCatalogoRepuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}