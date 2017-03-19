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
    //public class OrdenRepuestoD
    //{
    //    private AccesoDatosPostgre conexion;

    //    private bool error;
    //    public bool Error
    //    {
    //        get { return error; }
    //    }

    //    private string errorMsg;
    //    public string ErrorMsg
    //    {
    //        get { return errorMsg; }
    //    }

    //    public OrdenRepuestoD()
    //    {
    //        this.conexion = AccesoDatosPostgre.Instance;
    //        this.limpiarError();
    //    }

    //    public void limpiarError()
    //    {
    //        this.error = false;
    //       this.errorMsg = "";
    //    }

    //    public List<OrdenRepuestoE> obtenerOrdenesRepuestos(OrdenTrabajoE pOrdenDeTrabajo, CatalogoRepuestoE pCatalogoDeRepuesto)
    //    {

    //        this.limpiarError();
    //        List<OrdenRepuestoE> ordenesRepuesto = new List<OrdenRepuestoE>();
    //        DataSet dsetOrdenesRepuesto;
    //        string sql = "select r.id_orden_repuesto as IdCatalogoRepuesto  , r.cantidad_de_repuestos as cantidad, r.precio as precio," +
    //            //OrdenTrabajo
    //            "t.id_orden_de_trabajo as idOrdenDetrabajo , t.id_vehiculo as oVehiculo, t.id_empleado as oMecanicoResponsable,t.anio as anno," +
    //                         "t.fecha_de_ingreso_de_vehiculo as fechaDeIngreso, t.fecha_de_salida as fechaDeSalida, t.fecha_de_facturacion as fechaDeFacturacion, t.mecanico_responsable as deoMecanicoResponsablescripcion," +
    //                         " t.costo_total as costoTotal, t.estado as estado, t.factura_numero as facturaNumero," +

    //                           //CatalogoRepuesto
    //                           "c.id_catalogo_repuesto as idCatalogoRepuesto, c.nombre_del_repuesto as nombreDelRepuesto, " +
    //                    "c.anno_al_que_pertenece as annoAlQuePertenece, c.precio as precio" +
    //                           "from OrdenRepuesto r, OrdenDeTrabajo t, CatalogoRepuesto c" +
    //                           "where r.idOrdenDetrabajo = t.id_orden_de_trabajo and r.idCatalogoRepuesto = c.id_catalogo_repuesto";


    //        if (pOrdenDeTrabajo != null)
    //        {
    //           sql += "and t.pIdOrdenDetrabajo = @ordenDeTrabajo";
    //            Parametro oParametro = new Parametro();
    //            oParametro.agregarParametro("@ordenDeTrabajo", NpgsqlDbType.Varchar, pOrdenDeTrabajo.IdOrdenDetrabajo);
    //            dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql, "ordenRepuesto", oParametro.obtenerParametros());
    //        }
    //        else
    //        {
    //            dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql);
    //        }

    //        if (pCatalogoDeRepuesto != null)
    //        {
    //            sql += "and r.idCatalogoRepuesto = @catalogoRepuesto";
    //           Parametro oParametro = new Parametro();
    //            oParametro.agregarParametro("@catalogoRepuesto", NpgsqlDbType.Varchar, pCatalogoDeRepuesto.IdCatalogoRepuesto);
    //            dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql, "ordenRepuesto", oParametro.obtenerParametros());
    //        }
    //        else
    //        {
    //            dsetOrdenesRepuesto = this.conexion.ejecutarConsultaSQL(sql);
    //        }
    //        foreach (DataRow tupla in dsetOrdenesRepuesto.Tables[0].Rows)
    //        {
    //            OrdenTrabajoE oOrdenTrabajo = new OrdenTrabajoE(Convert.ToInt32(tupla["idOrdenDetrabajo"].ToString()), Convert.ToInt32(tupla["anno"].ToString()), Convert.ToDateTime(tupla["fechaDeIngreso"].ToString()),
    //               Convert.ToDateTime(tupla["fechaDeSalida"].ToString()), Convert.ToDateTime(tupla["fechaDeFacturacion"].ToString()), tupla["oMecanicoResponsable"].ToString(), tupla["oVehiculo"].ToString(),
    //                Convert.ToChar(tupla["estado"].ToString()), Convert.ToInt32(tupla["facturaNumero"].ToString()));


    //            CatalogoRepuestoE oCatalogRepuesto = new CatalogoRepuestoE(Convert.ToInt32(tupla["idCatalogoRepuesto"].ToString()), tupla["nombreDelRepuesto"].ToString(),
    //                tupla["cantidad"].ToString(), Convert.ToDouble(tupla["precio"].ToString()));

    //            OrdenRepuestoE oOrdenRepuesto = new OrdenRepuestoE();
 
    //       }
    //        return ordenesRepuesto;
    //    }
    //}
}
