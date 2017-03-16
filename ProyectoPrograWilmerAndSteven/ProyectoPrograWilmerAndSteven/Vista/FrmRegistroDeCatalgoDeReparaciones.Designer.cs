namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmRegistroDeCatalgoDeReparaciones
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
            this.txtHorasReparacion = new System.Windows.Forms.TextBox();
            this.txtDescripcionReparacion = new System.Windows.Forms.TextBox();
            this.txtCostoReparacion = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(268, 189);
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
            this.btnnRegistrar.Location = new System.Drawing.Point(417, 189);
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
            this.labelAño.Location = new System.Drawing.Point(74, 89);
            this.labelAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(157, 17);
            this.labelAño.TabIndex = 96;
            this.labelAño.Text = "Horas de reparación";
            // 
            // txtHorasReparacion
            // 
            this.txtHorasReparacion.Location = new System.Drawing.Point(277, 83);
            this.txtHorasReparacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHorasReparacion.Multiline = true;
            this.txtHorasReparacion.Name = "txtHorasReparacion";
            this.txtHorasReparacion.Size = new System.Drawing.Size(233, 23);
            this.txtHorasReparacion.TabIndex = 95;
            // 
            // txtDescripcionReparacion
            // 
            this.txtDescripcionReparacion.Location = new System.Drawing.Point(277, 44);
            this.txtDescripcionReparacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcionReparacion.Multiline = true;
            this.txtDescripcionReparacion.Name = "txtDescripcionReparacion";
            this.txtDescripcionReparacion.Size = new System.Drawing.Size(233, 23);
            this.txtDescripcionReparacion.TabIndex = 94;
            // 
            // txtCostoReparacion
            // 
            this.txtCostoReparacion.Location = new System.Drawing.Point(277, 125);
            this.txtCostoReparacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCostoReparacion.Multiline = true;
            this.txtCostoReparacion.Name = "txtCostoReparacion";
            this.txtCostoReparacion.Size = new System.Drawing.Size(233, 23);
            this.txtCostoReparacion.TabIndex = 93;
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(74, 50);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(199, 17);
            this.labelModelo.TabIndex = 92;
            this.labelModelo.Text = "Descripcion de reparación";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(74, 125);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(155, 17);
            this.labelMarca.TabIndex = 91;
            this.labelMarca.Text = "Costo de reparación";
            // 
            // FrmRegistroDeCatalgoDeReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 251);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnnRegistrar);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.txtHorasReparacion);
            this.Controls.Add(this.txtDescripcionReparacion);
            this.Controls.Add(this.txtCostoReparacion);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRegistroDeCatalgoDeReparaciones";
            this.Text = "Registro de catalgo de reparaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnnRegistrar;
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.TextBox txtHorasReparacion;
        private System.Windows.Forms.TextBox txtDescripcionReparacion;
        private System.Windows.Forms.TextBox txtCostoReparacion;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
    }
}