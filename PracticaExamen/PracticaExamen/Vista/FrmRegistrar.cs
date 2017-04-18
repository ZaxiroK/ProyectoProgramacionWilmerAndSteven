using PracticaExamen.Datos;
using PracticaExamen.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
            llenarComboCamion();
        }

        public void llenarComboCamion()
        {
            this.cmbCamiones.Items.Clear();
            CamionesD oCamionesD = new CamionesD();
            List<Camiones> camiones = oCamionesD.obtenerCamiones();

            foreach (Camiones oCamiones in camiones)
            {
                this.cmbChoferes.Items.Add(oCamiones);
                this.cmbChoferes.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbChoferes.SelectedIndex = cmbChoferes.Items.Count - 1;

            }
        }
        //public void llenarComboChofer()
        //{
        //    this.comboBoxMarcas.Items.Clear();
        //    MarcaD oMarcaD = new MarcaD();
        //    List<MarcaE> marcas = oMarcaD.obtenerMarcas();

        //    foreach (MarcaE oMarcaE in marcas)
        //    {
        //        this.comboBoxMarcas.Items.Add(oMarcaE);
        //        this.comboBoxMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        //        comboBoxMarcas.SelectedIndex = comboBoxMarcas.Items.Count - 1;

        //    }
        //}
        //public void llenarComboRuta()
        //{
        //    this.comboBoxMarcas.Items.Clear();
        //    MarcaD oMarcaD = new MarcaD();
        //    List<MarcaE> marcas = oMarcaD.obtenerMarcas();

        //    foreach (MarcaE oMarcaE in marcas)
        //    {
        //        this.comboBoxMarcas.Items.Add(oMarcaE);
        //        this.comboBoxMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        //        comboBoxMarcas.SelectedIndex = comboBoxMarcas.Items.Count - 1;

        //    }
        //}

        //public void llenarComboKilometros()
        //{
        //    this.comboBoxMarcas.Items.Clear();
        //    MarcaD oMarcaD = new MarcaD();
        //    List<MarcaE> marcas = oMarcaD.obtenerMarcas();

        //    foreach (MarcaE oMarcaE in marcas)
        //    {
        //        this.comboBoxMarcas.Items.Add(oMarcaE);
        //        this.comboBoxMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        //        comboBoxMarcas.SelectedIndex = comboBoxMarcas.Items.Count - 1;

        //    }
        //}


        //public void llenarComboFecha()
        //{
        //    this.comboBoxMarcas.Items.Clear();
        //    MarcaD oMarcaD = new MarcaD();
        //    List<MarcaE> marcas = oMarcaD.obtenerMarcas();

        //    foreach (MarcaE oMarcaE in marcas)
        //    {
        //        this.comboBoxMarcas.Items.Add(oMarcaE);
        //        this.comboBoxMarcas.DropDownStyle = ComboBoxStyle.DropDownList;
        //        comboBoxMarcas.SelectedIndex = comboBoxMarcas.Items.Count - 1;

        //    }
        //}
    }
}
