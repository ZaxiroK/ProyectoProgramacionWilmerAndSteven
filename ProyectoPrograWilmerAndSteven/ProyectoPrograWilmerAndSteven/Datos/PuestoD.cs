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
    public class PuestoD
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

        public PuestoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<PuestoE> obtenerPuestos()
        {

            this.limpiarError();
            List<PuestoE> puestos = new List<PuestoE>();
            DataSet dsetPuestos;
            string sql = "select p.id_puesto as id_puesto, p.salario as salario, " +
                        "p.puesto as puesto, p.descripcion as descripcion"+
                         " from schtaller.Puesto p";

            dsetPuestos = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetPuestos.Tables[0].Rows)
            {
                PuestoE oPuesto = new PuestoE(Convert.ToInt32(tupla[0].ToString()), Convert.ToDouble(tupla[1].ToString()),
                    Convert.ToChar(tupla[2].ToString()), tupla[3].ToString());
                puestos.Add(oPuesto);
            }
            return puestos;
        }
         public bool agregarPuesto(PuestoE pPuesto)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO puesto("+
            "id_puesto, salario, puesto, descripcion)"+
            "VALUES(@id_puesto, @salario, @puesto, @descripcion); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_puesto", NpgsqlDbType.Integer, pPuesto.IdPuesto);
                oP.agregarParametro("@salario", NpgsqlDbType.Double, pPuesto.Salario);
                oP.agregarParametro("@puesto", NpgsqlDbType.Char, pPuesto.Puesto);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Varchar, pPuesto.Descripcion);
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
        public bool borrarPuesto(PuestoE pPuesto)
        {
            bool estado = true;
            try
            {
                string sql = "delete from puesto where id_puesto = @id_puesto";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_puesto";
                parametros[0].Value = pPuesto.IdPuesto;

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
        public bool modificarPuesto(PuestoE pPuesto, int puesto)
        {
            bool estado = true;

            try
            {
                string sql = "update puesto set id_puesto = @id_puesto, salario = @salario, puesto = @puesto, descripcion = @descripcion where id_puesto = @antiguoId";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_puesto", NpgsqlDbType.Integer, pPuesto.IdPuesto);
                oP.agregarParametro("@salario", NpgsqlDbType.Double, pPuesto.Salario);
                oP.agregarParametro("@puesto", NpgsqlDbType.Char, pPuesto.Puesto);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Varchar, pPuesto.Descripcion);
                oP.agregarParametro("@antiguoId", NpgsqlDbType.Integer, puesto);

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
