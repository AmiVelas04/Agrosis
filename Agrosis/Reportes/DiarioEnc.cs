using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosis.Reportes
{
    class DiarioEnc
    {
        public string fecha { get; set; }
       public string F2 { get; set; }
        public decimal descuento { get; set; }
        public List<DiarioDet> Detalle = new List<DiarioDet>();
        public List<Diezmas> Diez = new List<Diezmas>();
        public List<EtiquetaImp> Etiqueta = new List<EtiquetaImp>();
    }
}
