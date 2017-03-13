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
    public class MarcaD
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

        public MarcaD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<MarcaE> obtenerMarcas()
        {

            this.limpiarError();
            List<MarcaE> marcas = new List<MarcaE>();
            DataSet dsetMarcas;
            string sql = "select m.id_marca  as idMarca, m.descripcion  as descripcion" +
                         "from marca m";

            dsetMarcas = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetMarcas.Tables[0].Rows)
            {
                MarcaE oMarca = new MarcaE(Convert.ToInt32(tupla["idMarca"].ToString()),tupla["descripcion"].ToString());
                marcas.Add(oMarca);
            }
            return marcas;
        }
    }
}
