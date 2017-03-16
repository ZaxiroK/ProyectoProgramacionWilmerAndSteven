namespace ProyectoPrograWilmerAndSteven
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtContraseniaNueva = new System.Windows.Forms.TextBox();
            this.lblContraseniaNueva = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseniaActual = new System.Windows.Forms.TextBox();
            this.lblContraseniaActual = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(160, 191);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 28);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(283, 191);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(73, 28);
            this.btnModificar.TabIndex = 22;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtContraseniaNueva
            // 
            this.txtContraseniaNueva.Location = new System.Drawing.Point(194, 135);
            this.txtContraseniaNueva.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseniaNueva.Multiline = true;
            this.txtContraseniaNueva.Name = "txtContraseniaNueva";
            this.txtContraseniaNueva.Size = new System.Drawing.Size(233, 27);
            this.txtContraseniaNueva.TabIndex = 21;
            // 
            // lblContraseniaNueva
            // 
            this.lblContraseniaNueva.AutoSize = true;
            this.lblContraseniaNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaNueva.Location = new System.Drawing.Point(32, 145);
            this.lblContraseniaNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseniaNueva.Name = "lblContraseniaNueva";
            this.lblContraseniaNueva.Size = new System.Drawing.Size(148, 17);
            this.lblContraseniaNueva.TabIndex = 20;
            this.lblContraseniaNueva.Text = "Constraseña nueva";
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(194, 47);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.textUsuario.Multiline = true;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(233, 27);
            this.textUsuario.TabIndex = 19;
            // 
            // txtContraseniaActual
            // 
            this.txtContraseniaActual.Location = new System.Drawing.Point(194, 88);
            this.txtContraseniaActual.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseniaActual.Multiline = true;
            this.txtContraseniaActual.Name = "txtContraseniaActual";
            this.txtContraseniaActual.Size = new System.Drawing.Size(233, 27);
            this.txtContraseniaActual.TabIndex = 18;
            // 
            // lblContraseniaActual
            // 
            this.lblContraseniaActual.AutoSize = true;
            this.lblContraseniaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaActual.Location = new System.Drawing.Point(32, 98);
            this.lblContraseniaActual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseniaActual.Name = "lblContraseniaActual";
            this.lblContraseniaActual.Size = new System.Drawing.Size(148, 17);
            this.lblContraseniaActual.TabIndex = 17;
            this.lblContraseniaActual.Text = "Constraseña actual";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(32, 47);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 17);
            this.labelUsuario.TabIndex = 16;
            this.labelUsuario.Text = "Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 230);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtContraseniaNueva);
            this.Controls.Add(this.lblContraseniaNueva);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.txtContraseniaActual);
            this.Controls.Add(this.lblContraseniaActual);
            this.Controls.Add(this.labelUsuario);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Cambio de contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtContraseniaNueva;
        private System.Windows.Forms.Label lblContraseniaNueva;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox txtContraseniaActual;
        private System.Windows.Forms.Label lblContraseniaActual;
        private System.Windows.Forms.Label labelUsuario;
    }
}

