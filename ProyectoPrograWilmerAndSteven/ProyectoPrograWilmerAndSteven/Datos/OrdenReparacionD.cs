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
    public class OrdenReparacionD
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

        public OrdenReparacionD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<OrdenReparacionE> obtenerOredenesReaparaciones()
        {

            this.limpiarError();
            List<OrdenReparacionE> ordenesReparaciones = new List<OrdenReparacionE>();
            DataSet dsetOredenesReparaciones;
            

        string sql = "select o.id_orden_reparacion  as idOrdenReparacion, o.id_orden_de_trabajo  as idOrdenReparacion, o.id_empleado  as cedulaEmpleado" +
                        "c.id_catalogo_reparacion as id_catalogoReparacion, c.horas   as horasTotalReparacion, c.costo   as costoReparacion" +
                        //catalogo de reparacion

              //ordenDeTrabajo         

              //empleado         
                         "from OrdenReparacion o, CatalogoReparacion c where o.id_orden_reparacion = id_catalogo_reparacion ";

            dsetOredenesReparaciones = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetOredenesReparaciones.Tables[0].Rows)
            {

                OrdenReparacionE oOredenesReparaciones = new OrdenReparacionE();
                ordenesReparaciones.Add(oOredenesReparaciones);
            }
            return ordenesReparaciones;
        }
    }
}
