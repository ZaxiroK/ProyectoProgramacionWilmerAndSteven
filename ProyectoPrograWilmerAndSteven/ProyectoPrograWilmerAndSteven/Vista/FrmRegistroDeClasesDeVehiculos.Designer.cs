namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmRegistroDeClasesDeVehiculos
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
            this.txtNombreRepuesto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(232, 247);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(66, 28);
            this.btnCerrar.TabIndex = 98;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnnRegistrar
            // 
            this.btnnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnRegistrar.Location = new System.Drawing.Point(404, 247);
            this.btnnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnnRegistrar.Name = "btnnRegistrar";
            this.btnnRegistrar.Size = new System.Drawing.Size(67, 28);
            this.btnnRegistrar.TabIndex = 97;
            this.btnnRegistrar.Text = "Registrar";
            this.btnnRegistrar.UseVisualStyleBackColor = true;
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.Location = new System.Drawing.Point(66, 107);
            this.labelAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(164, 17);
            this.labelAño.TabIndex = 96;
            this.labelAño.Text = "Año al que pertenece";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(232, 102);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnio.Multiline = true;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(233, 23);
            this.txtAnio.TabIndex = 95;
            // 
            // txtNombreRepuesto
            // 
            this.txtNombreRepuesto.Location = new System.Drawing.Point(232, 63);
            this.txtNombreRepuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreRepuesto.Multiline = true;
            this.txtNombreRepuesto.Name = "txtNombreRepuesto";
            this.txtNombreRepuesto.Size = new System.Drawing.Size(233, 23);
            this.txtNombreRepuesto.TabIndex = 94;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(232, 144);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(233, 23);
            this.txtPrecio.TabIndex = 93;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(66, 69);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(160, 17);
            this.labelModelo.TabIndex = 92;
            this.labelModelo.Text = "Nombre del repuesto";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(66, 150);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(54, 17);
            this.labelMarca.TabIndex = 91;
            this.labelMarca.Text = "Precio";
            // 
            // FrmRegistroDeClasesDeVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 290);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnnRegistrar);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtNombreRepuesto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRegistroDeClasesDeVehiculos";
            this.Text = "Registro de clases de vehículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnnRegistrar;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtNombreRepuesto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
    }
}