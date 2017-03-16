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
            this.btnCerrar.Location = new System.Drawing.Point(120, 172);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(59, 28);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(189, 49);
            this.textUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textUsuario.Multiline = true;
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(233, 27);
            this.textUsuario.TabIndex = 13;
            // 
            // textContrasenna
            // 
            this.textContrasenna.Location = new System.Drawing.Point(189, 99);
            this.textContrasenna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textContrasenna.Multiline = true;
            this.textContrasenna.Name = "textContrasenna";
            this.textContrasenna.Size = new System.Drawing.Size(233, 27);
            this.textContrasenna.TabIndex = 12;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(305, 172);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(65, 28);
            this.btnIngresar.TabIndex = 11;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // labelContrasenna
            // 
            this.labelContrasenna.AutoSize = true;
            this.labelContrasenna.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContrasenna.Location = new System.Drawing.Point(90, 99);
            this.labelContrasenna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContrasenna.Name = "labelContrasenna";
            this.labelContrasenna.Size = new System.Drawing.Size(99, 17);
            this.labelContrasenna.TabIndex = 10;
            this.labelContrasenna.Text = "Constraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.Location = new System.Drawing.Point(90, 49);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(64, 17);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "Usuario";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 218);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.textContrasenna);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.labelContrasenna);
            this.Controls.Add(this.labelUsuario);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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