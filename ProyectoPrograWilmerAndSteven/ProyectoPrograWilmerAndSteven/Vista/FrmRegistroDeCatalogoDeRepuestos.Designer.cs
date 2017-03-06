namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmRegistroDeCatalogoDeRepuestos
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
            this.btnnRegistrar = new System.Windows.Forms.Button();
            this.labelAño = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtNobreRepuesto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(288, 290);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 35);
            this.btnCerrar.TabIndex = 90;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnnRegistrar
            // 
            this.btnnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnRegistrar.Location = new System.Drawing.Point(517, 290);
            this.btnnRegistrar.Name = "btnnRegistrar";
            this.btnnRegistrar.Size = new System.Drawing.Size(89, 35);
            this.btnnRegistrar.TabIndex = 89;
            this.btnnRegistrar.Text = "Registrar";
            this.btnnRegistrar.UseVisualStyleBackColor = true;
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.Location = new System.Drawing.Point(67, 118);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(187, 20);
            this.labelAño.TabIndex = 88;
            this.labelAño.Text = "Año al que pertenece";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(288, 111);
            this.txtAnio.Multiline = true;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(309, 27);
            this.txtAnio.TabIndex = 87;
            this.txtAnio.TextChanged += new System.EventHandler(this.textAño_TextChanged);
            // 
            // txtNobreRepuesto
            // 
            this.txtNobreRepuesto.Location = new System.Drawing.Point(288, 64);
            this.txtNobreRepuesto.Multiline = true;
            this.txtNobreRepuesto.Name = "txtNobreRepuesto";
            this.txtNobreRepuesto.Size = new System.Drawing.Size(309, 27);
            this.txtNobreRepuesto.TabIndex = 86;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(288, 163);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(309, 27);
            this.txtPrecio.TabIndex = 85;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(67, 71);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(184, 20);
            this.labelModelo.TabIndex = 84;
            this.labelModelo.Text = "Nombre del repuesto";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(67, 170);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(63, 20);
            this.labelMarca.TabIndex = 83;
            this.labelMarca.Text = "Precio";
            // 
            // FrmRegistroDeCatalogoDeRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 434);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnnRegistrar);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtNobreRepuesto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Name = "FrmRegistroDeCatalogoDeRepuestos";
            this.Text = "Registro de catalogo de repuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnnRegistrar;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtNobreRepuesto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
    }
}