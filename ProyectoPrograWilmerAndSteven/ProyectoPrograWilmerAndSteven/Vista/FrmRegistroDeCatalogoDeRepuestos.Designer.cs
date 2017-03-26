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
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.labelAño = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtNombreRepuesto = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(110, 195);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(66, 28);
            this.btnCerrar.TabIndex = 90;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.Location = new System.Drawing.Point(314, 195);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(67, 28);
            this.BtnRegistrar.TabIndex = 89;
            this.BtnRegistrar.Text = "Aceptar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.Location = new System.Drawing.Point(43, 96);
            this.labelAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(169, 17);
            this.labelAño.TabIndex = 88;
            this.labelAño.Text = "Año al que pertenece:";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(216, 90);
            this.txtAnio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnio.Multiline = true;
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(233, 23);
            this.txtAnio.TabIndex = 87;
            // 
            // txtNombreRepuesto
            // 
            this.txtNombreRepuesto.Location = new System.Drawing.Point(216, 52);
            this.txtNombreRepuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreRepuesto.Multiline = true;
            this.txtNombreRepuesto.Name = "txtNombreRepuesto";
            this.txtNombreRepuesto.Size = new System.Drawing.Size(233, 23);
            this.txtNombreRepuesto.TabIndex = 86;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(216, 132);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(233, 23);
            this.txtPrecio.TabIndex = 85;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(50, 58);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(165, 17);
            this.labelModelo.TabIndex = 84;
            this.labelModelo.Text = "Nombre del repuesto:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(50, 138);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(59, 17);
            this.labelMarca.TabIndex = 83;
            this.labelMarca.Text = "Precio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 91;
            this.label1.Text = "Id:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(216, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(233, 23);
            this.txtId.TabIndex = 92;
            // 
            // FrmRegistroDeCatalogoDeRepuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 249);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.txtNombreRepuesto);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRegistroDeCatalogoDeRepuestos";
            this.Text = "Registro de catalogo de repuestos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtNombreRepuesto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
    }
}