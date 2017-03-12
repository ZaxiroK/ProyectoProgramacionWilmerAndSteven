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
    public class CatalogoReparacionD { 
    
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

        public CatalogoReparacionD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<CatalogoReparacionE> obtenerCatalogoReaparaciones()
        {

            this.limpiarError();
            List<CatalogoReparacionE> catalogoReparaciones = new List<CatalogoReparacionE>();
            DataSet dsetCatalogoReparaciones;
            
            string sql = "select c.id_catalogo_reparacion as id_catalogo_reparacion, c.descripcion as descripcion, " +
                        "c.horas_reparacion as horasReparacion, c.costo_reparacion as costoReparacion" +
                         "from CatalogoReparacion c";

            dsetCatalogoReparaciones = this.conexion.ejecutarConsultaSQL(sql);
            foreach (DataRow tupla in dsetCatalogoReparaciones.Tables[0].Rows)
            {

            CatalogoReparacionE oCatalogoReparacion = new CatalogoReparacionE(Convert.ToInt32(tupla["id_catalogo_reparacion"].ToString()),tupla["descripcion"].ToString(),
                    Convert.ToInt32(tupla["horasReparacion"].ToString()),Convert.ToDouble(tupla["costoReparacion"].ToString()));
                catalogoReparaciones.Add(oCatalogoReparacion);
            }
            return catalogoReparaciones;
        }
    }
}
