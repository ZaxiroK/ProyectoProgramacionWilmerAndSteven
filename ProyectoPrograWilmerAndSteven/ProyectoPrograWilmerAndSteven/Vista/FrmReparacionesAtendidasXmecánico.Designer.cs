﻿namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmReparacionesAtendidasXmecánico
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
            this.fechaInicio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInforme = new System.Windows.Forms.Button();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fechaInicio
            // 
            this.fechaInicio.AutoSize = true;
            this.fechaInicio.Location = new System.Drawing.Point(41, 60);
            this.fechaInicio.Name = "fechaInicio";
            this.fechaInicio.Size = new System.Drawing.Size(103, 17);
            this.fechaInicio.TabIndex = 0;
            this.fechaInicio.Text = "Fecha de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de fin";
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.Location = new System.Drawing.Point(150, 60);
            this.fechaEntrada.Name = "fechaEntrada";
            this.fechaEntrada.Size = new System.Drawing.Size(281, 22);
            this.fechaEntrada.TabIndex = 14;
            // 
            // FechaSalida
            // 
            this.FechaSalida.Location = new System.Drawing.Point(150, 115);
            this.FechaSalida.Name = "FechaSalida";
            this.FechaSalida.Size = new System.Drawing.Size(281, 22);
            this.FechaSalida.TabIndex = 15;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(175, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnInforme
            // 
            this.btnInforme.Location = new System.Drawing.Point(335, 205);
            this.btnInforme.Name = "btnInforme";
            this.btnInforme.Size = new System.Drawing.Size(75, 23);
            this.btnInforme.TabIndex = 17;
            this.btnInforme.Text = "Informe";
            this.btnInforme.UseVisualStyleBackColor = true;
            this.btnInforme.Click += new System.EventHandler(this.btnInforme_Click);
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(150, 156);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(281, 24);
            this.cmbEmpleado.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Empleado";
            // 
            // FrmReparacionesAtendidasXmecánico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 253);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.btnInforme);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.FechaSalida);
            this.Controls.Add(this.fechaEntrada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fechaInicio);
            this.Name = "FrmReparacionesAtendidasXmecánico";
            this.Text = "FrmReparacionesAtendidasXmecánico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaEntrada;
        private System.Windows.Forms.DateTimePicker FechaSalida;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnInforme;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label1;
    }
}