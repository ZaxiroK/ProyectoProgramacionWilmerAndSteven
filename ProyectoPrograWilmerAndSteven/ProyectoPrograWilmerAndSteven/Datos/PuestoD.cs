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
                         "from Puesto p";

            dsetPuestos = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetPuestos.Tables[0].Rows)
            {
                PuestoE oPuesto = new PuestoE(Convert.ToInt32(tupla["id_puesto"].ToString()), Convert.ToDouble(tupla["salario"].ToString()),
                    Convert.ToChar(tupla["puesto"].ToString()), tupla["descripcion"].ToString());
                puestos.Add(oPuesto);
            }
            return puestos;
        }
    }
}
