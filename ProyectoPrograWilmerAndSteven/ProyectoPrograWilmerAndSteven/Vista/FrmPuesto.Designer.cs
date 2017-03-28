namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmPuesto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPuesto));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.Editar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.dGVMarcas = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mecanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.Editar,
            this.btnBorrar,
            this.btnActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(616, 47);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(67, 44);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Editar
            // 
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(52, 44);
            this.Editar.Text = "Editar";
            this.Editar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(54, 44);
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 44);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // dGVMarcas
            // 
            this.dGVMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Salario,
            this.Mecanico,
            this.Marca});
            this.dGVMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVMarcas.Location = new System.Drawing.Point(0, 47);
            this.dGVMarcas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGVMarcas.Name = "dGVMarcas";
            this.dGVMarcas.Size = new System.Drawing.Size(616, 328);
            this.dGVMarcas.TabIndex = 17;
            // 
            // Código
            // 
            this.Código.DataPropertyName = "idPuesto";
            this.Código.HeaderText = "Id puesto";
            this.Código.Name = "Código";
            this.Código.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            // 
            // Mecanico
            // 
            this.Mecanico.DataPropertyName = "puesto";
            this.Mecanico.HeaderText = "Mecanico";
            this.Mecanico.Name = "Mecanico";
            // 
            // Marca
            // 
            this.Marca.DataPropertyName = "descripcion";
            this.Marca.HeaderText = "Descripción";
            this.Marca.Name = "Marca";
            // 
            // FrmPuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 375);
            this.Controls.Add(this.dGVMarcas);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPuesto";
            this.Text = "Puestos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton Editar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.DataGridView dGVMarcas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mecanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
    }
}