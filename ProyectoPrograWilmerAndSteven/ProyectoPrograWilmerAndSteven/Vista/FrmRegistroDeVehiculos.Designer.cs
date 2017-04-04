namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmRegistroDeVehiculos
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.textCombustible = new System.Windows.Forms.TextBox();
            this.labelCombustible = new System.Windows.Forms.Label();
            this.textNumeroDeChasis = new System.Windows.Forms.TextBox();
            this.textNumeroDeMotor = new System.Windows.Forms.TextBox();
            this.labelNumeroDeChasis = new System.Windows.Forms.Label();
            this.labelNumeroDeMotor = new System.Windows.Forms.Label();
            this.textCapacidadDePersonas = new System.Windows.Forms.TextBox();
            this.textClaseDeVehiculo = new System.Windows.Forms.TextBox();
            this.labelCapacidadDePersonas = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelPlaca = new System.Windows.Forms.Label();
            this.labelClaseDeVehiculo = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.comboBoxModelos = new System.Windows.Forms.ComboBox();
            this.comboBoxClientes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(159, 482);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(88, 34);
            this.btnCerrar.TabIndex = 82;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click_1);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(535, 482);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(89, 34);
            this.btnRegistrar.TabIndex = 81;
            this.btnRegistrar.Text = "Aceptar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // textCombustible
            // 
            this.textCombustible.Location = new System.Drawing.Point(313, 430);
            this.textCombustible.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCombustible.Multiline = true;
            this.textCombustible.Name = "textCombustible";
            this.textCombustible.Size = new System.Drawing.Size(309, 27);
            this.textCombustible.TabIndex = 6;
            // 
            // labelCombustible
            // 
            this.labelCombustible.AutoSize = true;
            this.labelCombustible.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCombustible.Location = new System.Drawing.Point(125, 438);
            this.labelCombustible.Name = "labelCombustible";
            this.labelCombustible.Size = new System.Drawing.Size(113, 20);
            this.labelCombustible.TabIndex = 79;
            this.labelCombustible.Text = "Combustible";
            // 
            // textNumeroDeChasis
            // 
            this.textNumeroDeChasis.Location = new System.Drawing.Point(313, 382);
            this.textNumeroDeChasis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNumeroDeChasis.Multiline = true;
            this.textNumeroDeChasis.Name = "textNumeroDeChasis";
            this.textNumeroDeChasis.Size = new System.Drawing.Size(309, 27);
            this.textNumeroDeChasis.TabIndex = 5;
            // 
            // textNumeroDeMotor
            // 
            this.textNumeroDeMotor.Location = new System.Drawing.Point(313, 334);
            this.textNumeroDeMotor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNumeroDeMotor.Multiline = true;
            this.textNumeroDeMotor.Name = "textNumeroDeMotor";
            this.textNumeroDeMotor.Size = new System.Drawing.Size(309, 27);
            this.textNumeroDeMotor.TabIndex = 4;
            // 
            // labelNumeroDeChasis
            // 
            this.labelNumeroDeChasis.AutoSize = true;
            this.labelNumeroDeChasis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeChasis.Location = new System.Drawing.Point(81, 390);
            this.labelNumeroDeChasis.Name = "labelNumeroDeChasis";
            this.labelNumeroDeChasis.Size = new System.Drawing.Size(161, 20);
            this.labelNumeroDeChasis.TabIndex = 76;
            this.labelNumeroDeChasis.Text = "Número de chasis";
            // 
            // labelNumeroDeMotor
            // 
            this.labelNumeroDeMotor.AutoSize = true;
            this.labelNumeroDeMotor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroDeMotor.Location = new System.Drawing.Point(88, 342);
            this.labelNumeroDeMotor.Name = "labelNumeroDeMotor";
            this.labelNumeroDeMotor.Size = new System.Drawing.Size(154, 20);
            this.labelNumeroDeMotor.TabIndex = 75;
            this.labelNumeroDeMotor.Text = "Número de motor";
            // 
            // textCapacidadDePersonas
            // 
            this.textCapacidadDePersonas.Location = new System.Drawing.Point(313, 281);
            this.textCapacidadDePersonas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textCapacidadDePersonas.Multiline = true;
            this.textCapacidadDePersonas.Name = "textCapacidadDePersonas";
            this.textCapacidadDePersonas.Size = new System.Drawing.Size(309, 27);
            this.textCapacidadDePersonas.TabIndex = 3;
            // 
            // textClaseDeVehiculo
            // 
            this.textClaseDeVehiculo.Location = new System.Drawing.Point(313, 231);
            this.textClaseDeVehiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textClaseDeVehiculo.Multiline = true;
            this.textClaseDeVehiculo.Name = "textClaseDeVehiculo";
            this.textClaseDeVehiculo.Size = new System.Drawing.Size(309, 27);
            this.textClaseDeVehiculo.TabIndex = 2;
            // 
            // labelCapacidadDePersonas
            // 
            this.labelCapacidadDePersonas.AutoSize = true;
            this.labelCapacidadDePersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapacidadDePersonas.Location = new System.Drawing.Point(27, 287);
            this.labelCapacidadDePersonas.Name = "labelCapacidadDePersonas";
            this.labelCapacidadDePersonas.Size = new System.Drawing.Size(206, 20);
            this.labelCapacidadDePersonas.TabIndex = 72;
            this.labelCapacidadDePersonas.Text = "Capacidad de personas";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(313, 45);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(309, 27);
            this.txtId.TabIndex = 0;
            this.txtId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyDown);
            // 
            // labelPlaca
            // 
            this.labelPlaca.AutoSize = true;
            this.labelPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlaca.Location = new System.Drawing.Point(180, 184);
            this.labelPlaca.Name = "labelPlaca";
            this.labelPlaca.Size = new System.Drawing.Size(56, 20);
            this.labelPlaca.TabIndex = 68;
            this.labelPlaca.Text = "Placa";
            // 
            // labelClaseDeVehiculo
            // 
            this.labelClaseDeVehiculo.AutoSize = true;
            this.labelClaseDeVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClaseDeVehiculo.Location = new System.Drawing.Point(84, 238);
            this.labelClaseDeVehiculo.Name = "labelClaseDeVehiculo";
            this.labelClaseDeVehiculo.Size = new System.Drawing.Size(158, 20);
            this.labelClaseDeVehiculo.TabIndex = 67;
            this.labelClaseDeVehiculo.Text = "Clase de vehiculo";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModelo.Location = new System.Drawing.Point(173, 94);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(69, 20);
            this.labelModelo.TabIndex = 64;
            this.labelModelo.Text = "Modelo";
            // 
            // comboBoxModelos
            // 
            this.comboBoxModelos.FormattingEnabled = true;
            this.comboBoxModelos.Location = new System.Drawing.Point(313, 89);
            this.comboBoxModelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxModelos.Name = "comboBoxModelos";
            this.comboBoxModelos.Size = new System.Drawing.Size(309, 24);
            this.comboBoxModelos.TabIndex = 84;
            // 
            // comboBoxClientes
            // 
            this.comboBoxClientes.FormattingEnabled = true;
            this.comboBoxClientes.Location = new System.Drawing.Point(313, 139);
            this.comboBoxClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClientes.Name = "comboBoxClientes";
            this.comboBoxClientes.Size = new System.Drawing.Size(309, 24);
            this.comboBoxClientes.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Dueño";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Id vehiculo";
            // 
            // textPlaca
            // 
            this.textPlaca.Location = new System.Drawing.Point(313, 184);
            this.textPlaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textPlaca.Multiline = true;
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(309, 27);
            this.textPlaca.TabIndex = 1;
            // 
            // FrmRegistroDeVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 587);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxClientes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxModelos);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.textCombustible);
            this.Controls.Add(this.labelCombustible);
            this.Controls.Add(this.textNumeroDeChasis);
            this.Controls.Add(this.textNumeroDeMotor);
            this.Controls.Add(this.labelNumeroDeChasis);
            this.Controls.Add(this.labelNumeroDeMotor);
            this.Controls.Add(this.textCapacidadDePersonas);
            this.Controls.Add(this.textClaseDeVehiculo);
            this.Controls.Add(this.labelCapacidadDePersonas);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelPlaca);
            this.Controls.Add(this.labelClaseDeVehiculo);
            this.Controls.Add(this.labelModelo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistroDeVehiculos";
            this.Text = "Registro de vehiculos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox textCombustible;
        private System.Windows.Forms.Label labelCombustible;
        private System.Windows.Forms.TextBox textNumeroDeChasis;
        private System.Windows.Forms.TextBox textNumeroDeMotor;
        private System.Windows.Forms.Label labelNumeroDeChasis;
        private System.Windows.Forms.Label labelNumeroDeMotor;
        private System.Windows.Forms.TextBox textCapacidadDePersonas;
        private System.Windows.Forms.TextBox textClaseDeVehiculo;
        private System.Windows.Forms.Label labelCapacidadDePersonas;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label labelPlaca;
        private System.Windows.Forms.Label labelClaseDeVehiculo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.ComboBox comboBoxModelos;
        private System.Windows.Forms.ComboBox comboBoxClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPlaca;
    }
}