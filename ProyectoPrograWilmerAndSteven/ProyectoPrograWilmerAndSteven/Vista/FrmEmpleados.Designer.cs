namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmEmpleados
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
            this.btnRegistrarEmpleado = new System.Windows.Forms.Button();
            this.btnVerPerfilEmpleado = new System.Windows.Forms.Button();
            this.labelListaEmpleados = new System.Windows.Forms.Label();
            this.dataGridViewEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(715, 435);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(180, 35);
            this.btnCerrar.TabIndex = 23;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarEmpleado
            // 
            this.btnRegistrarEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarEmpleado.Location = new System.Drawing.Point(325, 435);
            this.btnRegistrarEmpleado.Name = "btnRegistrarEmpleado";
            this.btnRegistrarEmpleado.Size = new System.Drawing.Size(180, 35);
            this.btnRegistrarEmpleado.TabIndex = 22;
            this.btnRegistrarEmpleado.Text = "Registrar empleado";
            this.btnRegistrarEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnVerPerfilEmpleado
            // 
            this.btnVerPerfilEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPerfilEmpleado.Location = new System.Drawing.Point(520, 435);
            this.btnVerPerfilEmpleado.Name = "btnVerPerfilEmpleado";
            this.btnVerPerfilEmpleado.Size = new System.Drawing.Size(180, 35);
            this.btnVerPerfilEmpleado.TabIndex = 21;
            this.btnVerPerfilEmpleado.Text = "Ver perfil empleado";
            this.btnVerPerfilEmpleado.UseVisualStyleBackColor = true;
            // 
            // labelListaEmpleados
            // 
            this.labelListaEmpleados.AutoSize = true;
            this.labelListaEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelListaEmpleados.Location = new System.Drawing.Point(527, 55);
            this.labelListaEmpleados.Name = "labelListaEmpleados";
            this.labelListaEmpleados.Size = new System.Drawing.Size(173, 20);
            this.labelListaEmpleados.TabIndex = 20;
            this.labelListaEmpleados.Text = "Lista de empleados";
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(87, 93);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowTemplate.Height = 24;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(1050, 316);
            this.dataGridViewEmpleados.TabIndex = 19;
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 553);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnRegistrarEmpleado);
            this.Controls.Add(this.btnVerPerfilEmpleado);
            this.Controls.Add(this.labelListaEmpleados);
            this.Controls.Add(this.dataGridViewEmpleados);
            this.Name = "FrmEmpleados";
            this.Text = "Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnRegistrarEmpleado;
        private System.Windows.Forms.Button btnVerPerfilEmpleado;
        private System.Windows.Forms.Label labelListaEmpleados;
        private System.Windows.Forms.DataGridView dataGridViewEmpleados;
    }
}