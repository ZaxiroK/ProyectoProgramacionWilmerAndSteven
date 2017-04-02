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
            this.labelAño = new System.Windows.Forms.Label();
            this.txtHorasReparacion = new System.Windows.Forms.TextBox();
            this.txtDescripcionReparacion = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCostoReparacion = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAño
            // 
            this.labelAño.AutoSize = true;
            this.labelAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAño.Location = new System.Drawing.Point(74, 89);
            this.labelAño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAño.Name = "labelAño";
            this.labelAño.Size = new System.Drawing.Size(162, 17);
            this.labelAño.TabIndex = 96;
            this.labelAño.Text = "Horas de reparación:";
            // 
            // txtHorasReparacion
            // 
            this.txtHorasReparacion.Location = new System.Drawing.Point(277, 83);
            this.txtHorasReparacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorasReparacion.Multiline = true;
            this.txtHorasReparacion.Name = "txtHorasReparacion";
            this.txtHorasReparacion.Size = new System.Drawing.Size(233, 23);
            this.txtHorasReparacion.TabIndex = 95;
            this.txtHorasReparacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHorasReparacion_KeyDown);
            // 
            // txtDescripcionReparacion
            // 
            this.txtDescripcionReparacion.Location = new System.Drawing.Point(277, 45);
            this.txtDescripcionReparacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionReparacion.Multiline = true;
            this.txtDescripcionReparacion.Name = "txtDescripcionReparacion";
            this.txtDescripcionReparacion.Size = new System.Drawing.Size(233, 23);
            this.txtDescripcionReparacion.TabIndex = 94;
            this.txtDescripcionReparacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcionReparacion_KeyDown);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(277, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(233, 23);
            this.txtId.TabIndex = 93;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(74, 50);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(204, 17);
            this.labelModelo.TabIndex = 92;
            this.labelModelo.Text = "Descripcion de reparación:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarca.Location = new System.Drawing.Point(74, 125);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(160, 17);
            this.labelMarca.TabIndex = 91;
            this.labelMarca.Text = "Costo de reparación:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 99;
            this.label1.Text = "Id:";
            // 
            // txtCostoReparacion
            // 
            this.txtCostoReparacion.Location = new System.Drawing.Point(277, 119);
            this.txtCostoReparacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtCostoReparacion.Multiline = true;
            this.txtCostoReparacion.Name = "txtCostoReparacion";
            this.txtCostoReparacion.Size = new System.Drawing.Size(233, 23);
            this.txtCostoReparacion.TabIndex = 100;
            this.txtCostoReparacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCostoReparacion_KeyDown);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(424, 189);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 28);
            this.BtnAceptar.TabIndex = 101;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.CausesValidation = false;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(277, 189);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(66, 28);
            this.btnCancelar.TabIndex = 102;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmRegistroDeCatalgoDeReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 251);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.txtCostoReparacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAño);
            this.Controls.Add(this.txtHorasReparacion);
            this.Controls.Add(this.txtDescripcionReparacion);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistroDeCatalgoDeReparaciones";
            this.Text = "Registro de catalgo de reparaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelAño;
        private System.Windows.Forms.TextBox txtHorasReparacion;
        private System.Windows.Forms.TextBox txtDescripcionReparacion;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCostoReparacion;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}