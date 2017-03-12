using Datos;
using Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograWilmerAndSteven.Datos
{
    public class OrdenDeTrabajoD
    {
        private AccesoDatosPostgre conexion;

        private bool error;
        public bool Error
        {
            get { return error; }
        }

        private string errorMsg;
        public string ErrorMsg
        {
            get { return errorMsg; }
        }

        public OrdenDeTrabajoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<OrdenTrabajoE> obtenerOrdenTrabajos(VehiculoE pVehiculo, EmpleadoE pEmpleado)
        {

            this.limpiarError();
            List<OrdenTrabajoE> ordenesTrabajos = new List<OrdenTrabajoE>();
            DataSet dsetOrdenTrabajos;



            string sql = "select t.id_orden_de_trabajo  as idOrdenDetrabajo, t.anio   as anno, " +
                            "t.fecha_de_ingreso_de_vehiculo  as fechaDeIngreso, t.fecha_de_salida  as fechaDeSalida" +
                            "t.fecha_de_facturacion   as fechaDeFacturacion," +/*" t.costo_total   as costoTotal" +*/
                            "t.estado    as estado, t.factura_numero    as facturaNumero" +


                                /*empleado    "e. as cedula , e. as nombre, e. as apellido1, e. as apellido2," +
                               "e. as direccion, e. as telefono1, e. as telefono2, e. as telefono3,"+
                               p.id_puesto as id_puesto, p.salario as salario, " +
                               "p.puesto as puesto, p.descripcion as descripcion"+*/


                                /*vehiculo  "v. as idVehiculo, v. as placa, v. as claseVehiculo, v. as capacidadPersonas,"+
                                   * "v. as numeroMotor, v. as numeroChasis, v. as combustible,"+
                                   * //cliente
                                   * //modelo
                                   */
                                "from OrdenDeTrabajo t, empleado e, cliente c, modelo m,puesto p, vehiculo v,  " +
                                "where t.cedula = e.cedula and t.id_puesto = p.id_puesto and t.idVehiculo = v.idVehiculo and t.cedula = c.cedula and t.idModelo = m.idModelo";
                          

            dsetOrdenTrabajos = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetOrdenTrabajos.Tables[0].Rows)
            {

                OrdenTrabajoE oOrdenTrabajo = new OrdenTrabajoE();
                ordenesTrabajos.Add(oOrdenTrabajo);
            }
            return ordenesTrabajos;
        }
    }
}
