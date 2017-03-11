using Datos;
using Logica;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrograWilmerAndSteven.Datos
{
    public class EmpleadoD
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

        public EmpleadoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<EmpleadoE> obtenerEmpleados(PuestoE pPuesto)
        {

            this.limpiarError();
            List<EmpleadoE> empleados = new List<EmpleadoE>();
            DataSet dsetEmpleados;
            string sql = "select e.cedula as cedula, e.nombre as nombre," +
                            "e.apellido1 as apellido1, e.apellido2 as apellido2," +
                             "e.direccion as direccion, e.telefono1 as telefono1, e.telefono2 as telefono2,e.telefono3 as telefono3," +
                              "p.id_puesto as id_puesto, p.salario as salario, p.puesto as puesto, p.descripcion as descripcion" +
                               "from Empleado e, Puesto p where e.cedula = p.id_puesto";
            if (pPuesto != null)
            {
                sql += "and p.idPuesto = @puesto";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@puesto", NpgsqlDbType.Varchar, pPuesto.IdPuesto);
                dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql, "empleado", oParametro.obtenerParametros());
            }
            else
            {
                dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql);
            }
            foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
            {
                PuestoE oPuesto = new PuestoE(Int32.Parse(tupla["id_puesto"].ToString()), Convert.ToDouble(tupla["salario"].ToString())
                    , Convert.ToChar(tupla["puesto"].ToString()), tupla["descripcion"].ToString());
                EmpleadoE oEmpleado = new EmpleadoE(tupla["cedula"].ToString(), tupla["nombre"].ToString(), tupla["apellido1"].ToString()
                    , tupla["apellido2"].ToString(), tupla["direccion"].ToString(), oPuesto, tupla["telefono1"].ToString(), tupla["telefono2"].ToString()
                    , tupla["telefono3"].ToString());
                empleados.Add(oEmpleado);
            }
            return empleados;
        }
    }
}
