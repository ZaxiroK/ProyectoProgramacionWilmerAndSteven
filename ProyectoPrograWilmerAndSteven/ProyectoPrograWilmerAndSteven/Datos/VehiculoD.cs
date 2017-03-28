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

        public List<VehiculoE> obtenerVehiculos()
        {
            this.limpiarError();
            List<VehiculoE> vehiculos = new List<VehiculoE>();
            DataSet dsetVehiculos;
            string sql = "select v.id_vehiculo as idVehiculo, v.placa as placa, v.clase_de_vehiculo as claseVehiculo, " +
                "v.capacidad_de_personas as capacidadPersonas, v.numero_de_motor as numeroMotor, v.numero_de_chasis as numeroChasis, " +
                "v.combustible as combustible," +
                "c.cedula as cedula, c.nombre as nombre," +
                "c.apellido1 as apellido1, c.apellido2 as apellido2," +
                "c.direccion as direccion, c.telefono1 as telefono1, c.telefono2 as telefono2,c.telefono3 as telefono3," +
                "mo.id_modelo  as idModelo, mo.descripcion  as descripcion, mo.anio as anno," +
                "m.id_marca as idMarca, m.descripcion as descripcion" +
                " from schtaller.Vehiculo v, schtaller.Cliente c, schtaller.Modelo mo, schtaller.Marca m" +
                " where c.cedula = v.id_cliente and v.id_modelo = mo.id_modelo and m.id_marca = mo.id_marca;";

            //if (pCliente != null)
            //{
            //    sql += "and c.cedula = @cliente";
            //    Parametro oParametro = new Parametro();
            //    oParametro.agregarParametro("@cliente", NpgsqlDbType.Varchar, pCliente.Cedula);
            //    dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql, "vehiculo", oParametro.obtenerParametros());
            //}
            //else
            //{
                dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql);
            //}
            //if (pModelo != null)
            ////{
            //    sql += "and mo.idModelo = @modelo";
            //    Parametro oParametro = new Parametro();
            //    oParametro.agregarParametro("@modelo", NpgsqlDbType.Varchar, pCliente.Cedula);
            //    dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql, "vehiculo", oParametro.obtenerParametros());
            //}
            //else
            //{
            //    dsetVehiculos = this.conexion.ejecutarConsultaSQL(sql);
            //}
            foreach (DataRow tupla in dsetVehiculos.Tables[0].Rows)
            {
                ClienteE oCliente = new ClienteE(Convert.ToInt32(tupla[7].ToString()), tupla[8].ToString(),
                    tupla[9].ToString(), tupla[10].ToString(), tupla[11].ToString(), tupla[12].ToString(),
                    tupla[13].ToString(), tupla[14].ToString());

                MarcaE oMarca = new MarcaE(Convert.ToInt32(tupla[18].ToString()), tupla[19].ToString());

                ModeloE oModelo = new ModeloE(Convert.ToInt32(tupla[15].ToString()), tupla[16].ToString(), oMarca, Convert.ToInt32(tupla[17].ToString()));

                VehiculoE oVehiculo = new VehiculoE(Convert.ToInt32(tupla[0].ToString()), tupla[1].ToString(), tupla[2].ToString()
                    , Convert.ToInt32(tupla[3].ToString()), oCliente, oModelo, tupla[4].ToString(), tupla[5].ToString()
                    , tupla[6].ToString());
                vehiculos.Add(oVehiculo);
            }
            return vehiculos;
        }


        public bool agregarVehiculo(VehiculoE pVehiculo)
        {
            this.limpiarError();
            bool estado = true;
            try
            {
                string sql = "INSERT INTO schtaller.vehiculo(" +
            "id_vehiculo, id_cliente, id_modelo, placa, clase_de_vehiculo," +
            "capacidad_de_personas, numero_de_motor, numero_de_chasis, combustible)"+
             "VALUES(@id_vehiculo, @id_cliente, @id_modelo, @placa, @clase_de_vehiculo," +
            "@capacidad_de_personas, @numero_de_motor, @numero_de_chasis, @combustible);"; 

                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_vehiculo", NpgsqlDbType.Integer, pVehiculo.IdVehiculo);
                oP.agregarParametro("@id_cliente", NpgsqlDbType.Integer, pVehiculo.OClienteE.Cedula);
                oP.agregarParametro("@id_modelo", NpgsqlDbType.Integer, pVehiculo.OModeloE.IdModelo);
                oP.agregarParametro("@placa", NpgsqlDbType.Varchar, pVehiculo.Placa);
                oP.agregarParametro("@clase_de_vehiculo", NpgsqlDbType.Varchar, pVehiculo.ClaseVehiculo);
                oP.agregarParametro("@capacidad_de_personas", NpgsqlDbType.Integer, pVehiculo.CapacidadPersonas);
                oP.agregarParametro("@numero_de_motor", NpgsqlDbType.Varchar, pVehiculo.NumeroMotor);
                oP.agregarParametro("@numero_de_chasis", NpgsqlDbType.Varchar, pVehiculo.NumeroChasis);
                oP.agregarParametro("@combustible", NpgsqlDbType.Varchar, pVehiculo.Combustible);

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
        public bool borrarVehiculo(VehiculoE pVehiculo)
        {
            bool estado = true;
            try
            {
                string sql = "delete from schtaller.vehiculo where id_vehiculo = @id_vehiculo";

                NpgsqlParameter[] parametros = new NpgsqlParameter[1];

                parametros[0] = new NpgsqlParameter();
                parametros[0].NpgsqlDbType = NpgsqlDbType.Integer;
                parametros[0].ParameterName = "@id_vehiculo";
                parametros[0].Value = pVehiculo.IdVehiculo;

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
        public bool modificarVehiculo(VehiculoE pVehiculo, int id)
        {
            bool estado = true;
            
            try
            {
                string sql = "UPDATE schtaller.vehiculo " +
     "SET id_vehiculo = @id_vehiculo, id_cliente = @id_cliente, id_modelo = @id_modelo, placa = @placa, clase_de_vehiculo = @clase_de_vehiculo," +
         "capacidad_de_personas = @capacidad_de_personas, numero_de_motor = @numero_de_motor, numero_de_chasis = @numero_de_chasis," +
        "combustible = @combustible" +
        " WHERE id_vehiculo = @vehiculo";
                NpgsqlParameter oParametro = new NpgsqlParameter();
                Parametro oP = new Parametro();
                oP.agregarParametro("@id_vehiculo", NpgsqlDbType.Integer, pVehiculo.IdVehiculo);
                oP.agregarParametro("@id_cliente", NpgsqlDbType.Integer, pVehiculo.OClienteE.Cedula);
                oP.agregarParametro("@id_modelo", NpgsqlDbType.Integer, pVehiculo.OModeloE.IdModelo);
                oP.agregarParametro("@placa", NpgsqlDbType.Varchar, pVehiculo.Placa);
                oP.agregarParametro("@clase_de_vehiculo", NpgsqlDbType.Varchar, pVehiculo.ClaseVehiculo);
                oP.agregarParametro("@capacidad_de_personas", NpgsqlDbType.Integer, pVehiculo.CapacidadPersonas);
                oP.agregarParametro("@numero_de_motor", NpgsqlDbType.Varchar, pVehiculo.NumeroMotor);
                oP.agregarParametro("@numero_de_chasis", NpgsqlDbType.Varchar, pVehiculo.NumeroChasis);
                oP.agregarParametro("@combustible", NpgsqlDbType.Varchar, pVehiculo.Combustible);
                oP.agregarParametro("@vehiculo", NpgsqlDbType.Integer, id);
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

