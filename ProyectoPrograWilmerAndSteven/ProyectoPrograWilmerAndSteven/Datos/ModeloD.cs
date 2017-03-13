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

        public List<ModeloE> obtenerEmpleados(MarcaE pMarca)
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
    }
}
