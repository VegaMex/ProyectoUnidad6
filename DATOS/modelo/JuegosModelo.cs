using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS.modelo {
    public class JuegosModelo {

        public int idjuego { get; set; }
        public String nombre { get; set; }
        public String genero { get; set; }
        public DateTime fechalanzamiento { get; set; }
        public String desarrollador { get; set; }
        public String clasificacion { get; set; }
        public decimal precio { get; set; }
        public decimal rating { get; set; }
        public String publicador { get; set; }
        public byte[] imagen { get; set; }

    }
}
