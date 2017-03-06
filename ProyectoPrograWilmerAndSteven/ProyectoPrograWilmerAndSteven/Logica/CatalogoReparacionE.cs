using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    class CatalogoReparacionE
    {
        protected int idCatalogoReparacion;
        protected string descripcion;
        protected int horasReparacion;
        protected double costoReparacion;

        public CatalogoReparacionE(int pIdCatalogoReparacion, string pDescripcion, int pHorasReparacion,
                double pCostoReparacion)
        {
            this.IdCatalogoReparacion = pIdCatalogoReparacion;
            this.Descripcion = pDescripcion;
            this.HorasReparacion = pHorasReparacion;
            this.CostoReparacion = pCostoReparacion;
        }
        public int IdCatalogoReparacion
        {
            get
            {
                return idCatalogoReparacion;
            }

            set
            {
                idCatalogoReparacion = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public int HorasReparacion
        {
            get
            {
                return horasReparacion;
            }

            set
            {
                horasReparacion = value;
            }
        }

        public double CostoReparacion
        {
            get
            {
                return costoReparacion;
            }

            set
            {
                costoReparacion = value;
            }
        }

        public override string ToString()
        {
            return (this.idCatalogoReparacion +"-"+ this.descripcion + "= ₡" + this.costoReparacion);
        }
    }
}
