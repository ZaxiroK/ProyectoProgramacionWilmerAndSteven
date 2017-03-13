using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class OrdenRepuestoE : CatalogoRepuestoE
    {
        private int idOrdenRepuesto;
        private OrdenTrabajoE idOrdenTrabajo;
        private int cantidad;

        public OrdenRepuestoE(int idOrdenRepuesto, OrdenTrabajoE idOrdenTrabajo, int pCantidad, int pIdCatalogoRepuesto, string pNombreDelRepuesto,
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

        public int IdOrdenRepuesto
        {
            get
            {
                return idOrdenRepuesto;
            }

            set
            {
                idOrdenRepuesto = value;
            }
        }

        public OrdenTrabajoE IdOrdenTrabajo
        {
            get
            {
                return idOrdenTrabajo;
            }

            set
            {
                idOrdenTrabajo = value;
            }
        }

        public override string ToString()
        {
            return (this.idOrdenRepuesto + "-"+ this.idOrdenTrabajo+ "-" + base.ToString() + "X" + this.cantidad);
        }
    }
}
