﻿namespace ProyectoPrograWilmerAndSteven.Vista
{
    partial class FrmTallerMecanico
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCambioContrasenia = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRegistroEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRegistroPuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemDerechosUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemRegistroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRegistroMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemRegistroVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.itemRegistroCatalogoRepuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemRegistroCatalogoReparaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemRegistroDeModelo = new System.Windows.Forms.ToolStripMenuItem();
            this.administracíonYÓrdenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOrdenTrabajo = new System.Windows.Forms.ToolStripMenuItem();
            this.gestíonGerencialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRepuestos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.parametrosToolStripMenuItem,
            this.administracíonYÓrdenesToolStripMenuItem,
            this.gestíonGerencialToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(897, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCambioContrasenia,
            this.itemRegistroEmpleados,
            this.itemRegistroPuestos,
            this.itemDerechosUsuarios,
            this.itemSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            this.sistemaToolStripMenuItem.Click += new System.EventHandler(this.sistemaToolStripMenuItem_Click);
            // 
            // itemCambioContrasenia
            // 
            this.itemCambioContrasenia.Name = "itemCambioContrasenia";
            this.itemCambioContrasenia.Size = new System.Drawing.Size(238, 26);
            this.itemCambioContrasenia.Text = "Cambio de contraseña";
            this.itemCambioContrasenia.Click += new System.EventHandler(this.itemCambioContrasenia_Click);
            // 
            // itemRegistroEmpleados
            // 
            this.itemRegistroEmpleados.Name = "itemRegistroEmpleados";
            this.itemRegistroEmpleados.Size = new System.Drawing.Size(238, 26);
            this.itemRegistroEmpleados.Text = "Registro de empleados";
            this.itemRegistroEmpleados.Click += new System.EventHandler(this.ItemRegistroEmpleados);
            // 
            // itemRegistroPuestos
            // 
            this.itemRegistroPuestos.Name = "itemRegistroPuestos";
            this.itemRegistroPuestos.Size = new System.Drawing.Size(238, 26);
            this.itemRegistroPuestos.Text = "Registro de puestos";
            this.itemRegistroPuestos.Click += new System.EventHandler(this.itemRegistroPuestos_Click);
            // 
            // itemDerechosUsuarios
            // 
            this.itemDerechosUsuarios.Name = "itemDerechosUsuarios";
            this.itemDerechosUsuarios.Size = new System.Drawing.Size(238, 26);
            this.itemDerechosUsuarios.Text = "Derechos por usuarios";
            this.itemDerechosUsuarios.Click += new System.EventHandler(this.itemDerechosUsuarios_Click);
            // 
            // itemSalir
            // 
            this.itemSalir.Name = "itemSalir";
            this.itemSalir.Size = new System.Drawing.Size(238, 26);
            this.itemSalir.Text = "Salir";
            // 
            // parametrosToolStripMenuItem
            // 
            this.parametrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemRegistroClientes,
            this.itemRegistroMarcas,
            this.ItemRegistroVehiculos,
            this.itemRegistroCatalogoRepuestos,
            this.ItemRegistroCatalogoReparaciones,
            this.ItemRegistroDeModelo});
            this.parametrosToolStripMenuItem.Name = "parametrosToolStripMenuItem";
            this.parametrosToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.parametrosToolStripMenuItem.Text = "Parámetros";
            // 
            // ItemRegistroClientes
            // 
            this.ItemRegistroClientes.Name = "ItemRegistroClientes";
            this.ItemRegistroClientes.Size = new System.Drawing.Size(333, 26);
            this.ItemRegistroClientes.Text = "Registro de clientes";
            this.ItemRegistroClientes.Click += new System.EventHandler(this.ItemRegistroClientes_Click);
            // 
            // itemRegistroMarcas
            // 
            this.itemRegistroMarcas.Name = "itemRegistroMarcas";
            this.itemRegistroMarcas.Size = new System.Drawing.Size(333, 26);
            this.itemRegistroMarcas.Text = "Registro de marcas";
            this.itemRegistroMarcas.Click += new System.EventHandler(this.itemRegistroMarcas_Click);
            // 
            // ItemRegistroVehiculos
            // 
            this.ItemRegistroVehiculos.Name = "ItemRegistroVehiculos";
            this.ItemRegistroVehiculos.Size = new System.Drawing.Size(333, 26);
            this.ItemRegistroVehiculos.Text = "Registro de vehículos";
            this.ItemRegistroVehiculos.Click += new System.EventHandler(this.ItemRegistroVehiculos_Click);
            // 
            // itemRegistroCatalogoRepuestos
            // 
            this.itemRegistroCatalogoRepuestos.Name = "itemRegistroCatalogoRepuestos";
            this.itemRegistroCatalogoRepuestos.Size = new System.Drawing.Size(333, 26);
            this.itemRegistroCatalogoRepuestos.Text = "Registro de catálogo de repuestos";
            this.itemRegistroCatalogoRepuestos.Click += new System.EventHandler(this.itemRegistroCatalogoRepuestos_Click);
            // 
            // ItemRegistroCatalogoReparaciones
            // 
            this.ItemRegistroCatalogoReparaciones.Name = "ItemRegistroCatalogoReparaciones";
            this.ItemRegistroCatalogoReparaciones.Size = new System.Drawing.Size(333, 26);
            this.ItemRegistroCatalogoReparaciones.Text = "Registro de catálogo de reparaciónes";
            this.ItemRegistroCatalogoReparaciones.Click += new System.EventHandler(this.ItemRegistroCatalogoReparaciones_Click);
            // 
            // ItemRegistroDeModelo
            // 
            this.ItemRegistroDeModelo.Name = "ItemRegistroDeModelo";
            this.ItemRegistroDeModelo.Size = new System.Drawing.Size(333, 26);
            this.ItemRegistroDeModelo.Text = "Registro de modelos";
            this.ItemRegistroDeModelo.Click += new System.EventHandler(this.ItemRegistroDeModelo_Click);
            // 
            // administracíonYÓrdenesToolStripMenuItem
            // 
            this.administracíonYÓrdenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOrdenTrabajo});
            this.administracíonYÓrdenesToolStripMenuItem.Name = "administracíonYÓrdenesToolStripMenuItem";
            this.administracíonYÓrdenesToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.administracíonYÓrdenesToolStripMenuItem.Text = "Administracíon y órdenes";
            // 
            // menuItemOrdenTrabajo
            // 
            this.menuItemOrdenTrabajo.Name = "menuItemOrdenTrabajo";
            this.menuItemOrdenTrabajo.Size = new System.Drawing.Size(198, 26);
            this.menuItemOrdenTrabajo.Text = "Orden de trabajo";
            this.menuItemOrdenTrabajo.Click += new System.EventHandler(this.menuItemOrdenTrabajo_Click);
            // 
            // gestíonGerencialToolStripMenuItem
            // 
            this.gestíonGerencialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.btnRepuestos});
            this.gestíonGerencialToolStripMenuItem.Name = "gestíonGerencialToolStripMenuItem";
            this.gestíonGerencialToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.gestíonGerencialToolStripMenuItem.Text = "Gestíon gerencial";
            this.gestíonGerencialToolStripMenuItem.Click += new System.EventHandler(this.gestíonGerencialToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(315, 26);
            this.toolStripMenuItem1.Text = "Ordenes finalizadas";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(315, 26);
            this.toolStripMenuItem2.Text = "Ordenes sin finalizar";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(315, 26);
            this.toolStripMenuItem3.Text = "Reparaciones atendidas por fechas";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // btnRepuestos
            // 
            this.btnRepuestos.Name = "btnRepuestos";
            this.btnRepuestos.Size = new System.Drawing.Size(315, 26);
            this.btnRepuestos.Text = "Repuestos Informacion";
            this.btnRepuestos.Click += new System.EventHandler(this.btnRepuestos_Click);
            // 
            // FrmTallerMecanico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 289);
            this.Controls.Add(this.menuStrip2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmTallerMecanico";
            this.Text = "Taller Mecanico";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem itemCambioContrasenia;
        private System.Windows.Forms.ToolStripMenuItem itemRegistroEmpleados;
        private System.Windows.Forms.ToolStripMenuItem itemRegistroPuestos;
        private System.Windows.Forms.ToolStripMenuItem itemDerechosUsuarios;
        private System.Windows.Forms.ToolStripMenuItem itemSalir;
        private System.Windows.Forms.ToolStripMenuItem ItemRegistroClientes;
        private System.Windows.Forms.ToolStripMenuItem itemRegistroMarcas;
        private System.Windows.Forms.ToolStripMenuItem ItemRegistroVehiculos;
        private System.Windows.Forms.ToolStripMenuItem itemRegistroCatalogoRepuestos;
        private System.Windows.Forms.ToolStripMenuItem ItemRegistroCatalogoReparaciones;
        private System.Windows.Forms.ToolStripMenuItem ItemRegistroDeModelo;
        public System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem parametrosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem administracíonYÓrdenesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem gestíonGerencialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemOrdenTrabajo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem btnRepuestos;
    }
}