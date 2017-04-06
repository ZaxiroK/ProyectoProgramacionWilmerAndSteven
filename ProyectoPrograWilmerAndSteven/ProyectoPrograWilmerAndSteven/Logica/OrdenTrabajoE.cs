using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class OrdenTrabajoE
    {
        private int idOrdenDetrabajo;
        private List<OrdenRepuestoE> ordenRepuesto;
        private List<OrdenReparacionE> ordenReparacion;
        private DateTime fechaDeIngreso;
        private DateTime fechaDeSalida;
        private DateTime fechaDeFacturacion;
        private EmpleadoE oMecanicoResponsable;
        private VehiculoE oVehiculo;
        private char estado;
        private int facturaNumero;
        public OrdenTrabajoE(int pIdOrdenDetrabajo,  DateTime pFechaDeIngreso,
            DateTime pFechaDeSalida, DateTime pFechaDeFacturacion, EmpleadoE pOMecanicoResponsable,VehiculoE pOVehiculo,
            char pEstado, int pFacturaNumero)
        {
            this.IdOrdenDetrabajo = pIdOrdenDetrabajo;
            this.FechaDeIngreso = pFechaDeIngreso;
            this.FechaDeSalida = pFechaDeSalida;
            this.FechaDeFacturacion = pFechaDeFacturacion;
            this.OMecanicoResponsable = pOMecanicoResponsable;
            this.OVehiculo = pOVehiculo;
            this.Estado = pEstado;
            this.FacturaNumero = pFacturaNumero;
        }

        public OrdenTrabajoE(DateTime pFechaDeIngreso,
            DateTime pFechaDeSalida, DateTime pFechaDeFacturacion, EmpleadoE pOMecanicoResponsable, /*Double pCostoTotal,*/ VehiculoE pOVehiculo,
            char pEstado, int pFacturaNumero, List<OrdenRepuestoE> pOrdenRepuesto,
            List<OrdenReparacionE> pOrdenReparacion)
        {
            this.FechaDeIngreso = pFechaDeIngreso;
            this.FechaDeSalida = pFechaDeSalida;
            this.FechaDeFacturacion = pFechaDeFacturacion;
            this.OMecanicoResponsable = pOMecanicoResponsable;
            /*this.CostoTotal = pCostoTotal;*/
            this.OVehiculo = pOVehiculo;
            this.Estado = pEstado;
            this.FacturaNumero = pFacturaNumero;
            this.OrdenRepuesto = pOrdenRepuesto;
            this.OrdenReparacion = pOrdenReparacion;
        }

        public double CalculoCostoTotal()
        {
            return (CostoTotalOrdenReparacion() + CostoTotalRepuestos());
        }

        private double CostoTotalRepuestos()
        {
            double total = 0;

            foreach (OrdenRepuestoE oRepuesto in OrdenRepuesto)
            {
                total += oRepuesto.Precio * oRepuesto.Cantidad;
            }

            return total;
        }

        private double CostoTotalOrdenReparacion()
        {
            double total = 0;

            foreach (OrdenReparacionE oReparacion in OrdenReparacion)
            {
                total += oReparacion.CostoReparacion;
            }

            return total;
        }

        public DateTime CalculoFecha()
        {
            TimeSpan diferencia = this.FechaDeSalida - this.FechaDeIngreso;
            return (Convert.ToDateTime(diferencia.ToString()));
        }

        public void AgregarOrdenReparacion(OrdenReparacionE oOrdenReparacion)
        {
            this.ordenReparacion.Add(oOrdenReparacion);
        }

        public void AgregarOrdenRepuesto(OrdenRepuestoE oOrdenRepuesto)
        {
            this.OrdenRepuesto.Add(oOrdenRepuesto);
        }
        public int IdOrdenDetrabajo
        {
            get
            {
                return idOrdenDetrabajo;
            }

            set
            {
                idOrdenDetrabajo = value;
            }
        }

        internal List<OrdenRepuestoE> OrdenRepuesto
        {
            get
            {
                return ordenRepuesto;
            }

            set
            {
                ordenRepuesto = value;
            }
        }

        internal List<OrdenReparacionE> OrdenReparacion
        {
            get
            {
                return ordenReparacion;
            }

            set
            {
                ordenReparacion = value;
            }
        }


        public DateTime FechaDeIngreso
        {
            get
            {
                return fechaDeIngreso;
            }

            set
            {
                fechaDeIngreso = value;
            }
        }

        public DateTime FechaDeSalida
        {
            get
            {
                return fechaDeSalida;
            }

            set
            {
                fechaDeSalida = value;
            }
        }

        internal EmpleadoE OMecanicoResponsable
        {
            get
            {
                return oMecanicoResponsable;
            }

            set
            {
                oMecanicoResponsable = value;
            }
        }

        internal VehiculoE OVehiculo
        {
            get
            {
                return oVehiculo;
            }

            set
            {
                oVehiculo = value;
            }
        }

        public char Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public int FacturaNumero
        {
            get
            {
                return facturaNumero;
            }

            set
            {
                facturaNumero = value;
            }
        }

        public DateTime FechaDeFacturacion
        {
            get
            {
                return fechaDeFacturacion;
            }

            set
            {
                fechaDeFacturacion = value;
            }
        }

       /* public double CostoTotal
        {
            get
            {
                return costoTotal;
            }

            set
            {
                costoTotal = value;
            }
        }
        */
        public override string ToString()
        {
            return (
                "Numero de factura: " + this.facturaNumero + "\n" +
                "Fecha de ingreso: " + this.fechaDeIngreso.ToString() + "\n" +
                "Fecha de salida: " + this.fechaDeSalida.ToString() + "\n" +
                "Fecha de facturacion: " + this.fechaDeFacturacion.ToString() + "\n" +
                "Dias totales de reparación: " + this.CalculoFecha().ToString() + "\n" +
                "Encargado: " + this.oMecanicoResponsable.ToString() + "\n" +
                "Vehiculo: " + this.oVehiculo.ToString() + "\n" +
                "Costo total de repuestos: " + this.CostoTotalRepuestos() + "\n" +
                "Costo total de reparaciones: " + this.CostoTotalOrdenReparacion() + "\n" +
                "Costo total: " + this.CalculoCostoTotal()
                );
        }
    }
}
