namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmClientes
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVerPerfilCliente = new System.Windows.Forms.Button();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.labelListaClientes = new System.Windows.Forms.Label();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(655, 405);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(139, 35);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnVerPerfilCliente
            // 
            this.btnVerPerfilCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPerfilCliente.Location = new System.Drawing.Point(500, 405);
            this.btnVerPerfilCliente.Name = "btnVerPerfilCliente";
            this.btnVerPerfilCliente.Size = new System.Drawing.Size(139, 35);
            this.btnVerPerfilCliente.TabIndex = 16;
            this.btnVerPerfilCliente.Text = "Ver perfil cliente";
            this.btnVerPerfilCliente.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCliente.Location = new System.Drawing.Point(339, 405);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(139, 35);
            this.btnRegistrarCliente.TabIndex = 15;
            this.btnRegistrarCliente.Text = "Registrar cliente";
            this.btnRegistrarCliente.UseVisualStyleBackColor = true;
            // 
            // labelListaClientes
            // 
            this.labelListaClientes.AutoSize = true;
            this.labelListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaClientes.Location = new System.Drawing.Point(492, 25);
            this.labelListaClientes.Name = "labelListaClientes";
            this.labelListaClientes.Size = new System.Drawing.Size(149, 20);
            this.labelListaClientes.TabIndex = 14;
            this.labelListaClientes.Text = "Lista de clientes";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(58, 60);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowTemplate.Height = 24;
            this.dataGridViewClientes.Size = new System.Drawing.Size(1050, 316);
            this.dataGridViewClientes.TabIndex = 13;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 495);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnVerPerfilCliente);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(this.labelListaClientes);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "FrmClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVerPerfilCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label labelListaClientes;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
    }
}