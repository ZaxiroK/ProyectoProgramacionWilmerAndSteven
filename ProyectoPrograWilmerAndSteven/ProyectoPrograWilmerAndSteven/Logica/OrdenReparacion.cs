using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class OrdenReparacion : CatalogoReparacionE
    {
        private int idOrdenReparacion;
        private string cedulaEmpleado;
        private int horasTotalReparacion;
        //preguntar al profe si es necesario un indicador, si la orden ya se realizo????
        public OrdenReparacion(int pIdOrdenReparacion, string pCedulaEmpleado,
                int pHorasTotalReparacion, int pIdCatalogoReparacion, string pDescripcion,
                int pHorasReparacion, double pCostoReparacion) :
                base(pIdCatalogoReparacion, pDescripcion, pHorasReparacion, pCostoReparacion)
        {
            this.IdOrdenReparacion = pIdOrdenReparacion;
            this.CedulaEmpleado = pCedulaEmpleado;
            this.HorasTotalReparacion = pHorasTotalReparacion;
        }
        public int IdOrdenReparacion
        {
            get
            {
                return idOrdenReparacion;
            }

            set
            {
                idOrdenReparacion = value;
            }
        }

        public string CedulaEmpleado
        {
            get
            {
                return cedulaEmpleado;
            }

            set
            {
                cedulaEmpleado = value;
            }
        }

        public int HorasTotalReparacion
        {
            get
            {
                return horasTotalReparacion;
            }

            set
            {
                horasTotalReparacion = value;
            }
        }

        public override string ToString()
        {
            return (this.idOrdenReparacion +"-"+ this.cedulaEmpleado +":"+ this.descripcion + "\n" +
                    base.ToString());
        }
    }
}
