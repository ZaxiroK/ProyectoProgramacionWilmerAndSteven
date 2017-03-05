namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmPrincipal
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
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textContrasenna = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.labelContrasenna = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(361, 212);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(79, 35);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(252, 60);
            this.textUsuario.Multiline = true;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(309, 32);
            this.textUsuario.TabIndex = 13;
            // 
            // textContrasenna
            // 
            this.textContrasenna.Location = new System.Drawing.Point(252, 122);
            this.textContrasenna.Multiline = true;
            this.textContrasenna.Name = "textContrasenna";
            this.textContrasenna.Size = new System.Drawing.Size(309, 32);
            this.textContrasenna.TabIndex = 12;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(486, 212);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(79, 35);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // labelContrasenna
            // 
            this.labelContrasenna.AutoSize = true;
            this.labelContrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenna.Location = new System.Drawing.Point(120, 122);
            this.labelContrasenna.Name = "labelContrasenna";
            this.labelContrasenna.Size = new System.Drawing.Size(115, 20);
            this.labelContrasenna.TabIndex = 10;
            this.labelContrasenna.Text = "Constraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(120, 60);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(74, 20);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Usuario";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 363);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textContrasenna);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelContrasenna);
            this.Controls.Add(this.labelUsuario);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textContrasenna;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label labelContrasenna;
        private System.Windows.Forms.Label labelUsuario;
    }
}