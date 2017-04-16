using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class VehiculoE
    {
        private int idVehiculo;
        private string placa;
        private string claseVehiculo;
        private int capacidadPersonas;
        private ClienteE oClienteE;
        private ModeloE oModeloE;
        private string numeroMotor;
        private string numeroChasis;
        private string combustible;
        public VehiculoE(int pIdVehiculo, string pPlaca, string pClaseVehiculo,
            int pCapacidadPersonas, ClienteE pOClienteE, ModeloE pOModeloE,
            string pNumeroMotor, string pNumeroChasis, string pCombustible)
        {
            this.IdVehiculo = pIdVehiculo;
            this.Placa = pPlaca;
            this.ClaseVehiculo = pClaseVehiculo;
            this.CapacidadPersonas = pCapacidadPersonas;
            this.OClienteE = pOClienteE;
            this.OModeloE = pOModeloE;
            this.NumeroMotor = pNumeroMotor;
            this.NumeroChasis = pNumeroChasis;
            this.Combustible = pCombustible;
        }

        public VehiculoE()
        {
        }

        public int IdVehiculo
        {
            get
            {
                return idVehiculo;
            }

            set
            {
                idVehiculo = value;
            }
        }

        public string Placa
        {
            get
            {
                return placa;
            }

            set
            {
                placa = value;
            }
        }

        public string ClaseVehiculo
        {
            get
            {
                return claseVehiculo;
            }

            set
            {
                claseVehiculo = value;
            }
        }

        public int CapacidadPersonas
        {
            get
            {
                return capacidadPersonas;
            }

            set
            {
                capacidadPersonas = value;
            }
        }

        internal ClienteE OClienteE
        {
            get
            {
                return oClienteE;
            }

            set
            {
                oClienteE = value;
            }
        }

        internal ModeloE OModeloE
        {
            get
            {
                return oModeloE;
            }

            set
            {
                oModeloE = value;
            }
        }

        public string NumeroMotor
        {
            get
            {
                return numeroMotor;
            }

            set
            {
                numeroMotor = value;
            }
        }

        public string NumeroChasis
        {
            get
            {
                return numeroChasis;
            }

            set
            {
                numeroChasis = value;
            }
        }

        public string Combustible
        {
            get
            {
                return combustible;
            }

            set
            {
                combustible = value;
            }
        }

        public override string ToString()
        {
            return ("Dueño: "+this.oClienteE.Nombre+" "+ this.oClienteE.Apellido1 +" Placa:"+ this.placa +" Clase:"+this.claseVehiculo);
        }
    }
}
