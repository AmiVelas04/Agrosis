using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agrosis.Reportes
{
    class CompraEnc
    {

        public string Fechai { get; set; }
        public string Fechaf { get; set; }
        public List<CompraDet> Deta = new List<CompraDet>();
        
    }
}
