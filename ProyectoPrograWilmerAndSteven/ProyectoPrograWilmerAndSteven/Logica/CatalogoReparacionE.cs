using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CatalogoReparacionE
    {
        protected int id_catalogoReparacion;
        protected string descripcion;
        protected int horasReparacion;
        protected double costoReparacion;

        public CatalogoReparacionE(int pId_catalogoReparacion, string pDescripcion, int pHorasReparacion,
                double pCostoReparacion)
        {
            this.Id_catalogoReparacion = pId_catalogoReparacion;
            this.Descripcion = pDescripcion;
            this.HorasReparacion = pHorasReparacion;
            this.CostoReparacion = pCostoReparacion;
        }
        public int Id_catalogoReparacion
        {
            get
            {
                return id_catalogoReparacion;
            }

            set
            {
                id_catalogoReparacion = value;
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
            return (this.id_catalogoReparacion +"-"+ this.descripcion + "= ₡" + this.costoReparacion);
        }
    }
}
