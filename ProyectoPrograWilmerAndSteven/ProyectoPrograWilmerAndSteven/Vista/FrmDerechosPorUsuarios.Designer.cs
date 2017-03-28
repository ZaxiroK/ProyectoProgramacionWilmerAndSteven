namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmDerechosPorUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDerechosPorUsuarios));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegistrar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.dGVUsuarios = new System.Windows.Forms.DataGridView();
            this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrasenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sistema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdministracionDeOrdenes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionGerencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrar,
            this.btnEditar,
            this.btnBorrar,
            this.btnActualizar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1003, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
            this.btnRegistrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(72, 44);
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(52, 44);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrar.Image")));
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(54, 44);
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(79, 44);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click_1);
            // 
            // dGVUsuarios
            // 
            this.dGVUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.login,
            this.Contrasenia,
            this.administrador,
            this.sistema,
            this.parametros,
            this.AdministracionDeOrdenes,
            this.gestionGerencial});
            this.dGVUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVUsuarios.Location = new System.Drawing.Point(0, 47);
            this.dGVUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGVUsuarios.Name = "dGVUsuarios";
            this.dGVUsuarios.Size = new System.Drawing.Size(1003, 410);
            this.dGVUsuarios.TabIndex = 3;
            // 
            // login
            // 
            this.login.DataPropertyName = "login";
            this.login.HeaderText = "Usuario";
            this.login.Name = "login";
            // 
            // Contrasenia
            // 
            this.Contrasenia.DataPropertyName = "contrasenia";
            this.Contrasenia.HeaderText = "Contraseña";
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.ReadOnly = true;
            this.Contrasenia.Visible = false;
            // 
            // administrador
            // 
            this.administrador.DataPropertyName = "administrador";
            this.administrador.HeaderText = "Administrador";
            this.administrador.Name = "administrador";
            // 
            // sistema
            // 
            this.sistema.DataPropertyName = "sistema";
            this.sistema.HeaderText = "Sistema";
            this.sistema.Name = "sistema";
            // 
            // parametros
            // 
            this.parametros.DataPropertyName = "parametros";
            this.parametros.HeaderText = "Parámetros";
            this.parametros.Name = "parametros";
            // 
            // AdministracionDeOrdenes
            // 
            this.AdministracionDeOrdenes.DataPropertyName = "AdministracionDeOrdenes";
            this.AdministracionDeOrdenes.HeaderText = "Administración de ordenes";
            this.AdministracionDeOrdenes.Name = "AdministracionDeOrdenes";
            // 
            // gestionGerencial
            // 
            this.gestionGerencial.DataPropertyName = "gestionGerencial";
            this.gestionGerencial.HeaderText = "Gestión gerencial";
            this.gestionGerencial.Name = "gestionGerencial";
            // 
            // FrmDerechosPorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 457);
            this.Controls.Add(this.dGVUsuarios);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDerechosPorUsuarios";
            this.Text = "Derechos por usuarios";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRegistrar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnActualizar;
        internal System.Windows.Forms.DataGridView dGVUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrasenia;
        private System.Windows.Forms.DataGridViewTextBoxColumn administrador;
        private System.Windows.Forms.DataGridViewTextBoxColumn sistema;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametros;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdministracionDeOrdenes;
        private System.Windows.Forms.DataGridViewTextBoxColumn gestionGerencial;
    }
}