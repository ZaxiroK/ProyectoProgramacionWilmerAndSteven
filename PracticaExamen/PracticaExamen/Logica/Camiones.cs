using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen.Logica
{
    public class Camiones
    {
        private string cam_id;
        private string cam_modelo;
        private Combustible combus;

        public Camiones(string pcam_id, string pcam_modelo, Combustible pcombus)
        {
            this.cam_id = pcam_id;
            this.cam_modelo = pcam_modelo;
            this.combus = pcombus;
        }

        public string Cam_id
        {
            get
            {
                return cam_id;
            }

            set
            {
                cam_id = value;
            }
        }

        public string Cam_modelo
        {
            get
            {
                return cam_modelo;
            }

            set
            {
                cam_modelo = value;
            }
        }

        public Combustible Combus
        {
            get
            {
                return combus;
            }

            set
            {
                combus = value;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
