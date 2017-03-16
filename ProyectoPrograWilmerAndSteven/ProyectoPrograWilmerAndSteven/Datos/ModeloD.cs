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
    public class ModeloD
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

        public ModeloD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<ModeloE> obtenerMarca(MarcaE pMarca)
        {

            this.limpiarError();
            List<ModeloE> modelos = new List<ModeloE>();
            DataSet dsetMarcas;
            string sql = "select mo.id_modelo  as idModelo, mo.descripcion  as descripcion, mo.anio as anno," +
                            "m.id_marca as idMarca, m.descripcion as descripcion" +
                               "from Modelo mo, marca m where mo.id_modelo = m.id_marca";
            if (pMarca != null)
            {
                sql += "and m.IdMarca = @marca";
                Parametro oParametro = new Parametro();
                oParametro.agregarParametro("@marca", NpgsqlDbType.Varchar, pMarca.IdMarca);
                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql, "modelo", oParametro.obtenerParametros());
            }
            else
            {
                dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
            }
            foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
            {
                MarcaE oMarca = new MarcaE(Convert.ToInt32(tupla["idMarca"].ToString()), tupla["descripcion"].ToString());
                ModeloE oModelo = new ModeloE(Convert.ToInt32(tupla["idModelo"].ToString()), tupla["descripcion"].ToString(), oMarca, Convert.ToInt32(tupla["anio"].ToString()));
                modelos.Add(oModelo);
            }
            return modelos;
        }
        public bool agregarModelo(ModeloE pModelo)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.modelo(" +
            "id_modelo, descripcion, anio,id_marca ); ";

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_modelo", NpgsqlDbType.Integer, pModelo.IdModelo);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Integer, pModelo.Descripcion);
                oP.agregarParametro("@anio", NpgsqlDbType.Integer, pModelo.Anno);
                oP.agregarParametro("@id_marca", NpgsqlDbType.Integer, pModelo.OMarca);
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
        public bool borrarModelo(ModeloE pModelo)
        {
            bool estado = true;
            try
            {
                string sql = "delete from modelo where id_modelo = @id_modelo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Varchar;
                parametros[0].ParameterName = "@id_modelo";
                parametros[0].Value = pModelo.IdModelo;

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
        public bool modificarModelo(ModeloE pModelo)
        {
            bool estado = true;

            try
            {
                string sql = "update modelo set id_modelo = @id_modelo , descripcion = @descripcion, id_marca = @id_marca where marca = @marca";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_modelo", NpgsqlDbType.Integer, pModelo.IdModelo);
                oP.agregarParametro("@descripcion", NpgsqlDbType.Integer, pModelo.Descripcion);
                oP.agregarParametro("@id_marca", NpgsqlDbType.Integer, pModelo.OMarca);
                this.conexion.ejecutarSQL(sql, oP.obtenerParametros());

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

