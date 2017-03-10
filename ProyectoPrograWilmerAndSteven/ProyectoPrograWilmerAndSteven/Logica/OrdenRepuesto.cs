using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class OrdenRepuesto : CatalogoRepuestoE
    {
        private int cantidad;

        public OrdenRepuesto(int pCantidad, int pIdCatalogoRepuesto, string pNombreDelRepuesto,
            string pAnnoAlQuePertenece, double pPrecio) :
            base(pIdCatalogoRepuesto, pNombreDelRepuesto, pAnnoAlQuePertenece, pPrecio)
        {
            this.Cantidad = pCantidad;
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public override string ToString()
        {
            return (base.ToString() + "X" + this.cantidad);
        }
    }
}
