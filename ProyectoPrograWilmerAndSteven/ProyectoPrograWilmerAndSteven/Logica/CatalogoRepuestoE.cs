using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CatalogoRepuestoE
    {
        protected int idCatalogoRepuesto;
        protected string nombreDelRepuesto;
        protected int annoAlQuePertenece;
        protected List<ModeloE> modelo;
        protected double precio;
       public CatalogoRepuestoE(int pIdCatalogoRepuesto, string pNombreDelRepuesto,
            int pAnnoAlQuePertenece, double pPrecio)
        {
            this.IdCatalogoRepuesto = pIdCatalogoRepuesto;
            this.NombreDelRepuesto = pNombreDelRepuesto;
            this.AnnoAlQuePertenece = pAnnoAlQuePertenece;
            this.Precio = pPrecio;
        }

        public CatalogoRepuestoE(int pIdCatalogoRepuesto, string pNombreDelRepuesto,
            int pAnnoAlQuePertenece, double pPrecio, List<ModeloE> pModelo)
        {
            this.IdCatalogoRepuesto = pIdCatalogoRepuesto;
            this.NombreDelRepuesto = pNombreDelRepuesto;
            this.AnnoAlQuePertenece = pAnnoAlQuePertenece;
            this.Precio = pPrecio;
            this.modelo = pModelo;
            //este constructor es para cuando se realice la consulta desde las clase
            //"CatalogoRepuestoD" cargar la lista de "modelo" directamente. 
        }
        public void agregarModelo(ModeloE oModeloE)
        {
            this.modelo.Add(oModeloE);
        }
        public int IdCatalogoRepuesto
        {
            get
            {
                return idCatalogoRepuesto;
            }

            set
            {
                idCatalogoRepuesto = value;
            }
        }

        public string NombreDelRepuesto
        {
            get
            {
                return nombreDelRepuesto;
            }

            set
            {
                nombreDelRepuesto = value;
            }
        }

        public int AnnoAlQuePertenece
        {
            get
            {
                return annoAlQuePertenece;
            }

            set
            {
                annoAlQuePertenece = value;
            }
        }

        public double Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public List<ModeloE> Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public override string ToString()
        {
            return (this.nombreDelRepuesto +"-"+ this.annoAlQuePertenece + "= ₡" + this.precio);
        }
    }
}
