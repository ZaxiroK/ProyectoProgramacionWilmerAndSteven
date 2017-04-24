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
        /// <summary>
        /// obtiene un EmpleadoE de la bd
        /// </summary>
        /// <returns>una lista de EmpleadoE </returns>
        public List<EmpleadoE> obtenerEmpleados()
        {

            this.limpiarError();
            List<EmpleadoE> empleados = new List<EmpleadoE>();
            DataSet dsetEmpleados;
            string sql = "select e.cedula as cedula, e.nombre as nombre," +
                            "e.apellido1 as apellido1, e.apellido2 as apellido2," +
                             "e.direccion as direccion, e.telefono1 as telefono1, e.telefono2 as telefono2,e.telefono3 as telefono3," +
                              "p.id_puesto as id_puesto, p.salario as salario, p.puesto as puesto, p.descripcion as descripcion" +
                               " from schtaller.Empleado e, schtaller.Puesto p where e.id_puesto = p.id_puesto";
            //if (pPuesto != null)
            //{
            //    sql += "and p.IdPuesto = @puesto";
            //    Parametro oParametro = new Parametro();
            //    oParametro.agregarParametro("@puesto", NpgsqlDbType.Varchar, pPuesto.IdPuesto);
            //    dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql, "empleado", oParametro.obtenerParametros());
            //}
            //else
            //{
                dsetEmpleados = this.conexion.ejecutarConsultaSQL(sql);
            //}
            foreach (DataRow tupla in dsetEmpleados.Tables[0].Rows)
            {
                PuestoE oPuesto = new PuestoE(Int32.Parse(tupla[8].ToString()), Convert.ToDouble(tupla[9].ToString())
                    , Convert.ToChar(tupla[10].ToString()), tupla[11].ToString());
                EmpleadoE oEmpleado = new EmpleadoE(Convert.ToInt32(tupla[0].ToString()), tupla[1].ToString(), tupla[2].ToString()
                    , tupla[3].ToString(), tupla[4].ToString(), oPuesto, tupla[5].ToString(), tupla[6].ToString()
                    , tupla[7].ToString());
                empleados.Add(oEmpleado);
            }
            return empleados;
        }
        /// <summary>
        /// agrega un EmpleadoE a la bd
        /// </summary>
        /// <param name="pEmpleado"> un EmpleadoE llamado pEmpleado</param>
        /// <returns>retorna un boleano dando a conocer si se agrego en la bd o no </returns>
        public bool agregarEmpleado(EmpleadoE pEmpleado)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.empleado(" +
            "cedula, nombre, apellido1, apellido2, direccion, id_puesto, telefono1,"+ 
            "telefono2, telefono3)"+
            "VALUES(@cedula, @nombre, @apellido1, @apellido2, @direccion, @puesto, @telefono1," +
            "@telefono2, @telefono3);";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@cedula", NpgsqlDbType.Integer, pEmpleado.Cedula);
                oP.agregarParametro("@nombre", NpgsqlDbType.Varchar, pEmpleado.Nombre);
                oP.agregarParametro("@apellido1", NpgsqlDbType.Varchar, pEmpleado.Apellido1);
                oP.agregarParametro("@apellido2", NpgsqlDbType.Varchar, pEmpleado.Apellido2);
                oP.agregarParametro("@direccion", NpgsqlDbType.Varchar, pEmpleado.Direccion);
                oP.agregarParametro("@puesto", NpgsqlDbType.Integer, pEmpleado.OPuestoE.IdPuesto);
                oP.agregarParametro("@telefono1", NpgsqlDbType.Varchar, pEmpleado.Telefono1);
                oP.agregarParametro("@telefono2", NpgsqlDbType.Varchar, pEmpleado.Telefono2);
                oP.agregarParametro("@telefono3", NpgsqlDbType.Varchar, pEmpleado.Telefono3);
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
        /// <summary>
        /// borra un EmpleadoE de la bd
        /// </summary>
        /// <param name="pEmpleado"> un Empleado llamado p Empleado</param>
        /// <returns>retorna un boleano dando a conocer si se borro de la bd o no</returns>
        public bool borrarEmpleado(EmpleadoE pEmpleado)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.empleado where cedula = @cedula";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
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
        /// <summary>
        /// modifica un EmpleadoE de la bd
        /// </summary>
        /// <param name="pEmpleado">un EmpleadoE llamado pEmpleado</param>
        /// <param name="cedula">un integer llamdo cedula refiriendose al id</param>
        /// <returns>retorna un boleano dando a conocer si se modifico en la bd o no</returns>
        public bool modificarEmpleado(EmpleadoE pEmpleado, int cedula)
        {
            bool estado = true;

            try
            {

                string sql = "update schtaller.empleado set cedula = @cedula , nombre = @nombre, apellido1 = @apellido1, apellido2 = @apellido2," +
                    "direccion = @direccion, id_puesto = @puesto, telefono1 = @telefono1, telefono2 = telefono2, telefono3 = @telefono3 where cedula = @cedulaVieja";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@cedula", NpgsqlDbType.Integer, pEmpleado.Cedula);
                oP.agregarParametro("@nombre", NpgsqlDbType.Varchar, pEmpleado.Nombre);
                oP.agregarParametro("@apellido1", NpgsqlDbType.Varchar, pEmpleado.Apellido1);
                oP.agregarParametro("@apellido2", NpgsqlDbType.Varchar, pEmpleado.Apellido2);
                oP.agregarParametro("@direccion", NpgsqlDbType.Varchar, pEmpleado.Direccion);
                oP.agregarParametro("@puesto", NpgsqlDbType.Integer, pEmpleado.OPuestoE.IdPuesto);
                oP.agregarParametro("@telefono1", NpgsqlDbType.Varchar, pEmpleado.Telefono1);
                oP.agregarParametro("@telefono2", NpgsqlDbType.Varchar, pEmpleado.Telefono2);
                oP.agregarParametro("@telefono3", NpgsqlDbType.Varchar, pEmpleado.Telefono3);
                oP.agregarParametro("@cedulaVieja", NpgsqlDbType.Integer, cedula);

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