using Datos;
using System.Data;
using PracticaExamen.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Datos
{
    public class CalculoD
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

        public CalculoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<Calculo> obtenerCalculos()
        {

            this.limpiarError();
            List<Calculo> calculos = new List<Calculo>();
            DataSet dsetCalculos;
            string sql = "select cal.cam_id, cal.chof_id , cal.cal_fecha , cal.cal_monto ,cal.cal_kilometros , cal.cal_tipo_camino, " +

                 "c.cam_id , c.cam_modelo , c.com_id,  " +
                 " cho.chof_id  , cho.chof_nombre " +

                " from public.Calculo cal, public.camiones c, public.choferes cho " +

           " where cal.cam_id = c.cam_id and cal.chof_id = cho.chof_id ";


            dsetCalculos = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetCalculos.Tables[0].Rows)
            {
                Combustible oCombustible = new Combustible(tupla[0].ToString(), tupla[1].ToString(), Convert.ToDouble(tupla[2].ToString()));
                Camiones oCamiones = new Camiones(tupla[0].ToString(), tupla[1].ToString(), oCombustible);
                Choferes oChoferes = new Choferes(tupla[0].ToString(), tupla[1].ToString());
                Calculo oCalculo = new Calculo(oCamiones, oChoferes,Convert.ToDateTime(tupla[2].ToString()), Convert.ToDouble(tupla[3].ToString()), Convert.ToDouble(tupla[4].ToString()), tupla[3].ToString());
                calculos.Add(oCalculo);
            }
            return calculos;
        }
    }
}
