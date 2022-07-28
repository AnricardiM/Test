using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Model
{
    class Venta
    {
        public int idVenta { get; set; }

        public int? idAuto { get; set; }

        public int? idCentro { get; set; }

         public string descripcionVenta { get; set; }
    }
}
