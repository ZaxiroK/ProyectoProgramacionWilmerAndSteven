using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class OrdenReparacionE : CatalogoReparacionE
    {
        private int idOrdenReparacion;
        private int cedulaEmpleado;
        private int horasTotalReparacion;
        private OrdenTrabajoE oOrdenTrabajo;
        //preguntar al profe si es necesario un indicador, si la orden ya se realizo????
        public OrdenReparacionE(int pIdOrdenReparacion, int pCedulaEmpleado,
                int pHorasTotalReparacion, OrdenTrabajoE pOrdenTrabajo, int pIdCatalogoReparacion, string pDescripcion,
                int pHorasReparacion, double pCostoReparacion) :
                base(pIdCatalogoReparacion, pDescripcion, pHorasReparacion, pCostoReparacion)
        {
            this.IdOrdenReparacion = pIdOrdenReparacion;
            this.CedulaEmpleado = pCedulaEmpleado;
            this.HorasTotalReparacion = pHorasTotalReparacion;
            this.OOrdenTrabajo = pOrdenTrabajo;
        }

        public OrdenReparacionE( int pCedulaEmpleado,int pHorasTotalReparacion, int pIdCatalogoReparacion, string pDescripcion,
                int pHorasReparacion, double pCostoReparacion) :
                base(pIdCatalogoReparacion, pDescripcion, pHorasReparacion, pCostoReparacion)
        {
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

        public int CedulaEmpleado
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

        public OrdenTrabajoE OOrdenTrabajo
        {
            get
            {
                return oOrdenTrabajo;
            }

            set
            {
                oOrdenTrabajo = value;
            }
        }

        public override string ToString()
        {
            return (this.idOrdenReparacion +"-"+ this.oOrdenTrabajo +"-"+ this.cedulaEmpleado +":"+ this.descripcion + "\n" +
                    base.ToString());
        }
    }
}
