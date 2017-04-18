using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;
using PracticaExamen.Logica;

namespace PracticaExamen.Datos
{
    public class ChoferesD
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

        public ChoferesD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<Choferes> obtenerChoferes()
        {

            this.limpiarError();
            List<Choferes> choferes = new List<Choferes>();
            DataSet dsetChoferes;
            string sql = "select * from public.choferes ";

            dsetChoferes = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetChoferes.Tables[0].Rows)
            {

                Choferes oChoferes = new Choferes(tupla[0].ToString(), tupla[1].ToString());
                choferes.Add(oChoferes);
            }
            return choferes;
        }
    }
}
