using Datos;
using Logica;
using Npgsql;
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
                sql += "and p.IdPuesto = @puesto";
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
                EmpleadoE oEmpleado = new EmpleadoE(Convert.ToInt32(tupla["cedula"].ToString()), tupla["nombre"].ToString(), tupla["apellido1"].ToString()
                    , tupla["apellido2"].ToString(), tupla["direccion"].ToString(), oPuesto, tupla["telefono1"].ToString(), tupla["telefono2"].ToString()
                    , tupla["telefono3"].ToString());
                empleados.Add(oEmpleado);
            }
            return empleados;
        }
        public bool agregarEmpleado(EmpleadoE pEmpleado)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.cliente(" +
            "cedula, nombre, apellido1, apellido2,  direccion, puesto, telefono1, telefono2, telefono3); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@cedula", NpgsqlDbType.Integer, pEmpleado.Cedula);
                oP.agregarParametro("@nombre", NpgsqlDbType.Integer, pEmpleado.Nombre);
                oP.agregarParametro("@apellido1", NpgsqlDbType.Integer, pEmpleado.Apellido1);
                oP.agregarParametro("@apellido2", NpgsqlDbType.Integer, pEmpleado.Apellido2);
                oP.agregarParametro("@direccion", NpgsqlDbType.Integer, pEmpleado.Direccion);
                oP.agregarParametro("@puesto", NpgsqlDbType.Integer, pEmpleado.OPuestoE);
                oP.agregarParametro("@telefono1", NpgsqlDbType.Integer, pEmpleado.Telefono1);
                oP.agregarParametro("@telefono2", NpgsqlDbType.Integer, pEmpleado.Telefono2);
                oP.agregarParametro("@telefono3", NpgsqlDbType.Integer, pEmpleado.Telefono3);
                this.conexion.ejecutarSQL(sql, oP.obtenerParametros());
                if (this.conexion.IsError)
                {

                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }

            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }
        public bool borrarEmpleado(EmpleadoE pEmpleado)
        {
            bool estado = true;
            try
            {
                string sql = "delete from empleado where cedula = @cedula";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@cedula";
                parametros[0].Value = pEmpleado.Cedula;

                this.conexion.ejecutarSQL(sql, parametros);
                if (this.conexion.IsError)
                {
                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }
        public bool modificarEmpleado(EmpleadoE pEmpleado)
        {
            bool estado = true;

            try
            {

                string sql = "update cliente set cedula = @cedula , descripcion = @descripcion, apellido1 = @apellido1, apellido2 = @apellido2," +
                    "direccion = @ direccion, puesto = @puesto telefono1 = @telefono1, telefono2 = telefono2, telefono3 = telefono3 where cliente = @cliente";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@cedula", NpgsqlDbType.Integer, pEmpleado.Cedula);
                oP.agregarParametro("@nombre", NpgsqlDbType.Integer, pEmpleado.Nombre);
                oP.agregarParametro("@apellido1", NpgsqlDbType.Integer, pEmpleado.Apellido1);
                oP.agregarParametro("@apellido2", NpgsqlDbType.Integer, pEmpleado.Apellido2);
                oP.agregarParametro("@direccion", NpgsqlDbType.Integer, pEmpleado.Direccion);
                oP.agregarParametro("@puesto", NpgsqlDbType.Integer, pEmpleado.OPuestoE);
                oP.agregarParametro("@telefono1", NpgsqlDbType.Integer, pEmpleado.Telefono1);
                oP.agregarParametro("@telefono2", NpgsqlDbType.Integer, pEmpleado.Telefono2);
                oP.agregarParametro("@telefono3", NpgsqlDbType.Integer, pEmpleado.Telefono3);

                this.conexion.ejecutarSQL(sql, oP.obtenerParametros());
                if (this.conexion.IsError)
                {

                    estado = false;
                    this.errorMsg = this.conexion.ErrorDescripcion;
                }

            }
            catch (Exception e)
            {
                estado = false;
                this.errorMsg = e.Message;
            }
            return estado;
        }
    }
}