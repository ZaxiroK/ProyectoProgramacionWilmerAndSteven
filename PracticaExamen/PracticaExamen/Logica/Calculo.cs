using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Logica
{
    public class Calculo
    {
       private Camiones camion;
       private Choferes chofer;
        private DateTime cal_fecha;
        private double cal_monto;
        private double cal_kilometros;
        private string cal_tipo_camino;

        public Calculo(Camiones pcamion, Choferes pchofer, DateTime pcal_fecha, double pcal_monto, double pcal_kilometros, string pcal_tipo_camino)
        {
            this.camion = pcamion;
            this.chofer = pchofer;
            this.cal_fecha = pcal_fecha;
            this.cal_monto = pcal_monto;
            this.cal_kilometros = pcal_kilometros;
            this.cal_tipo_camino = pcal_tipo_camino;
        }

        public Camiones Camion
        {
            get
            {
                return camion;
            }

            set
            {
                camion = value;
            }
        }

        public Choferes Chofer
        {
            get
            {
                return chofer;
            }

            set
            {
                chofer = value;
            }
        }

        public DateTime Cal_fecha
        {
            get
            {
                return cal_fecha;
            }

            set
            {
                cal_fecha = value;
            }
        }

        public double Cal_monto
        {
            get
            {
                return cal_monto;
            }

            set
            {
                cal_monto = value;
            }
        }

        public double Cal_kilometros
        {
            get
            {
                return cal_kilometros;
            }

            set
            {
                cal_kilometros = value;
            }
        }

        public string Cal_tipo_camino
        {
            get
            {
                return cal_tipo_camino;
            }

            set
            {
                cal_tipo_camino = value;
            }
        }



        public override string ToString()
        {
            return base.ToString();
        }
    }
}
