namespace Vista
{
    partial class FrmRegistrar
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
            this.cmbCamiones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbChoferes = new System.Windows.Forms.ComboBox();
            this.cmbRutas = new System.Windows.Forms.ComboBox();
            this.cmbKilometros = new System.Windows.Forms.ComboBox();
            this.cmbFechas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbCamiones
            // 
            this.cmbCamiones.FormattingEnabled = true;
            this.cmbCamiones.Location = new System.Drawing.Point(151, 42);
            this.cmbCamiones.Name = "cmbCamiones";
            this.cmbCamiones.Size = new System.Drawing.Size(281, 24);
            this.cmbCamiones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chofer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ruta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kilometros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fecha";
            // 
            // cmbChoferes
            // 
            this.cmbChoferes.FormattingEnabled = true;
            this.cmbChoferes.Location = new System.Drawing.Point(151, 86);
            this.cmbChoferes.Name = "cmbChoferes";
            this.cmbChoferes.Size = new System.Drawing.Size(281, 24);
            this.cmbChoferes.TabIndex = 6;
            // 
            // cmbRutas
            // 
            this.cmbRutas.FormattingEnabled = true;
            this.cmbRutas.Location = new System.Drawing.Point(151, 129);
            this.cmbRutas.Name = "cmbRutas";
            this.cmbRutas.Size = new System.Drawing.Size(281, 24);
            this.cmbRutas.TabIndex = 7;
            // 
            // cmbKilometros
            // 
            this.cmbKilometros.FormattingEnabled = true;
            this.cmbKilometros.Location = new System.Drawing.Point(151, 168);
            this.cmbKilometros.Name = "cmbKilometros";
            this.cmbKilometros.Size = new System.Drawing.Size(281, 24);
            this.cmbKilometros.TabIndex = 8;
            // 
            // cmbFechas
            // 
            this.cmbFechas.FormattingEnabled = true;
            this.cmbFechas.Location = new System.Drawing.Point(151, 213);
            this.cmbFechas.Name = "cmbFechas";
            this.cmbFechas.Size = new System.Drawing.Size(281, 24);
            this.cmbFechas.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(344, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 392);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbFechas);
            this.Controls.Add(this.cmbKilometros);
            this.Controls.Add(this.cmbRutas);
            this.Controls.Add(this.cmbChoferes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCamiones);
            this.Name = "FrmRegistrar";
            this.Text = "FrmRegistrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCamiones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbChoferes;
        private System.Windows.Forms.ComboBox cmbRutas;
        private System.Windows.Forms.ComboBox cmbKilometros;
        private System.Windows.Forms.ComboBox cmbFechas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}