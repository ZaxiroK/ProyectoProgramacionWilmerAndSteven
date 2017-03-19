﻿using Logica;
using ProyectoPrograWilmerAndSteven.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPrograWilmerAndSteven.Vista
{
    public partial class FrmRegistroModelo : Form
    {
        public bool aceptar;
        public ModeloE oModelo;
        public FrmRegistroModelo()
        {
            InitializeComponent();
            this.llenarComboMarcas();//
        }
        

        public FrmRegistroModelo(ModeloE pModelo)
        {
            InitializeComponent();
            this.llenarComboMarcas();
            this.oModelo = pModelo;
            this.comboBoxMarcas.SelectedItem = pModelo.OMarca.ToString();// 
            this.txtDescripcion.Text = pModelo.Descripcion.ToString();
            this.txtAnio.Text = pModelo.Anno.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!(this.txtDescripcion.Text == "") && !(this.txtAnio.Text == ""))
            {

                
               // this.oModelo = new ModeloE(/*id,*/this.txtDescripcion.Text, /*Marca,*/ Convert.ToInt32(this.txtAnio.Text));
                this.aceptar = true;
                this.Visible = false;
            }
        }

        public void llenarComboMarcas()
        {
            this.comboBoxMarcas.Items.Clear(); 
            MarcaD oMarcaD = new MarcaD();
            List<MarcaE> marcas = oMarcaD.obtenerMarcas();

            foreach (MarcaE oMarcaE in marcas)
            {
                this.comboBoxMarcas.Items.Add(oMarcaE);
            }
        }
    }
}