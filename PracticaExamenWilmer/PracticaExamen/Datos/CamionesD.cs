using System;
using Datos;
using System.Data;
using PracticaExamen.Logica;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Datos
{
    public class CamionesD
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

        public CamionesD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<Camiones> obtenerCamiones()
        {

            this.limpiarError();
            List<Camiones> camiones = new List<Camiones>();
            DataSet dsetCamiones;
            string sql = "select c.cam_id , c.cam_modelo , c.com_id, "+ 
                "com.com_id, com.com_descripcion,  com.com_costo "+ 

                 " from public.Camiones c, public.combustible com "+ 

            "where c.cam_id = com.com_id ";





            dsetCamiones = this.conexion.ejecutarConsultaSQL(sql);

            foreach (DataRow tupla in dsetCamiones.Tables[0].Rows)
            {
                Combustible oCombustible = new Combustible(tupla[0].ToString(), tupla[1].ToString(), Convert.ToDouble(tupla[2].ToString()));
                Camiones oCamiones = new Camiones(tupla[0].ToString(), tupla[1].ToString(), oCombustible);
                camiones.Add(oCamiones);
            }
            return camiones;
        }
    }
}
