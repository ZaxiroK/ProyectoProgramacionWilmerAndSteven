namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmRegistroDerechosUsuarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.checkBoxAdministrador = new System.Windows.Forms.CheckBox();
            this.checkBoxSistema = new System.Windows.Forms.CheckBox();
            this.checkBoxAdministracionDeOrdenes = new System.Windows.Forms.CheckBox();
            this.checkBoxParametros = new System.Windows.Forms.CheckBox();
            this.checkBoxGestionGerencial = new System.Windows.Forms.CheckBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Login";
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(107, 54);
            this.txtContrasenia.Margin = new System.Windows.Forms.Padding(2);
            this.txtContrasenia.Multiline = true;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(233, 23);
            this.txtContrasenia.TabIndex = 74;
            this.txtContrasenia.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContrasenia_KeyDown);
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(107, 15);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Multiline = true;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(233, 23);
            this.txtLogin.TabIndex = 73;
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLogin_KeyDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(13, 60);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(91, 17);
            this.label.TabIndex = 72;
            this.label.Text = "Contraseña";
            // 
            // checkBoxAdministrador
            // 
            this.checkBoxAdministrador.AutoSize = true;
            this.checkBoxAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdministrador.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxAdministrador.Location = new System.Drawing.Point(107, 98);
            this.checkBoxAdministrador.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAdministrador.Name = "checkBoxAdministrador";
            this.checkBoxAdministrador.Size = new System.Drawing.Size(127, 21);
            this.checkBoxAdministrador.TabIndex = 76;
            this.checkBoxAdministrador.Text = "Administrador";
            this.checkBoxAdministrador.UseVisualStyleBackColor = true;
            // 
            // checkBoxSistema
            // 
            this.checkBoxSistema.AutoSize = true;
            this.checkBoxSistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSistema.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxSistema.Location = new System.Drawing.Point(107, 129);
            this.checkBoxSistema.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSistema.Name = "checkBoxSistema";
            this.checkBoxSistema.Size = new System.Drawing.Size(84, 21);
            this.checkBoxSistema.TabIndex = 77;
            this.checkBoxSistema.Text = "Sistema";
            this.checkBoxSistema.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdministracionDeOrdenes
            // 
            this.checkBoxAdministracionDeOrdenes.AutoSize = true;
            this.checkBoxAdministracionDeOrdenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdministracionDeOrdenes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxAdministracionDeOrdenes.Location = new System.Drawing.Point(107, 193);
            this.checkBoxAdministracionDeOrdenes.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAdministracionDeOrdenes.Name = "checkBoxAdministracionDeOrdenes";
            this.checkBoxAdministracionDeOrdenes.Size = new System.Drawing.Size(220, 21);
            this.checkBoxAdministracionDeOrdenes.TabIndex = 79;
            this.checkBoxAdministracionDeOrdenes.Text = "Administración de ordenes";
            this.checkBoxAdministracionDeOrdenes.UseVisualStyleBackColor = true;
            // 
            // checkBoxParametros
            // 
            this.checkBoxParametros.AutoSize = true;
            this.checkBoxParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxParametros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxParametros.Location = new System.Drawing.Point(107, 161);
            this.checkBoxParametros.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxParametros.Name = "checkBoxParametros";
            this.checkBoxParametros.Size = new System.Drawing.Size(110, 21);
            this.checkBoxParametros.TabIndex = 78;
            this.checkBoxParametros.Text = "Parametros";
            this.checkBoxParametros.UseVisualStyleBackColor = true;
            // 
            // checkBoxGestionGerencial
            // 
            this.checkBoxGestionGerencial.AutoSize = true;
            this.checkBoxGestionGerencial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxGestionGerencial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBoxGestionGerencial.Location = new System.Drawing.Point(107, 225);
            this.checkBoxGestionGerencial.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxGestionGerencial.Name = "checkBoxGestionGerencial";
            this.checkBoxGestionGerencial.Size = new System.Drawing.Size(155, 21);
            this.checkBoxGestionGerencial.TabIndex = 80;
            this.checkBoxGestionGerencial.Text = "Gestión gerencial";
            this.checkBoxGestionGerencial.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(93, 280);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(66, 28);
            this.btnCerrar.TabIndex = 84;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(263, 280);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(67, 28);
            this.btnRegistrar.TabIndex = 83;
            this.btnRegistrar.Text = "Aceptar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmRegistroDerechosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 345);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.checkBoxGestionGerencial);
            this.Controls.Add(this.checkBoxAdministracionDeOrdenes);
            this.Controls.Add(this.checkBoxParametros);
            this.Controls.Add(this.checkBoxSistema);
            this.Controls.Add(this.checkBoxAdministrador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRegistroDerechosUsuarios";
            this.Text = "Registro de derechos de usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.CheckBox checkBoxAdministrador;
        private System.Windows.Forms.CheckBox checkBoxSistema;
        private System.Windows.Forms.CheckBox checkBoxAdministracionDeOrdenes;
        private System.Windows.Forms.CheckBox checkBoxParametros;
        private System.Windows.Forms.CheckBox checkBoxGestionGerencial;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistrar;
    }
}