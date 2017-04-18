using Datos;
using PracticaExamen.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Datos
{
    public class CombustibleD
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

        public CombustibleD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<Combustible> obtenerCombustibles()
        {

            this.limpiarError();
            List<Combustible> combustibles = new List<Combustible>();
            DataSet dsetCombustibles;
            string sql = "select * from public.Combustible ";

            dsetCombustibles = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetCombustibles.Tables[0].Rows)
            {
                Combustible oCombustible = new Combustible(tupla[0].ToString(), tupla[1].ToString(),Convert.ToDouble(tupla[2].ToString()));
                combustibles.Add(oCombustible);
            }
            return combustibles;
        }
    }
}
