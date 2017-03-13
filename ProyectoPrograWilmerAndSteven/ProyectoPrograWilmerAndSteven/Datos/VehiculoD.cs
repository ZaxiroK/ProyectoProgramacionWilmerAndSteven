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
    public class VehiculoD
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

        public VehiculoD()
        {
            this.conexion = AccesoDatosPostgre.Instance;
            this.limpiarError();
        }

        public void limpiarError()
        {
            this.error = false;
            this.errorMsg = "";
        }

        public List<VehiculoE> obtenerVehiculos(ClienteE pCliente)
        {

            this.limpiarError();
            List<VehiculoE> vehiculos = new List<VehiculoE>();
            DataSet dsetVehiculos;
            string sql = "select v.id_vehiculo as idVehiculo,
            
        }
    }
}
