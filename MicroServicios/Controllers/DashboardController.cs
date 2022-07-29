using MicroServicios.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MicroServicios.Controllers
{ 
   public class rVenta
    {
       public string Vehiculo { get; set; }
        public string CentroDeVenta { get; set; }
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public int idCentro { get; set; }
        public int idVehiculo { get; set; }
    }
    public class DashboardController : ApiController
    {
        private Model1 db = new Model1();

       [HttpGet]
        public IQueryable<rVenta> Venta() {

            var resultado = db.testVenta
                .Select(x => new rVenta(){
                Vehiculo = db.testAuto.FirstOrDefault(y => y.idAuto == x.idAuto).descripcionAuto,
                CentroDeVenta = db.testCentro.FirstOrDefault(y => y.idCentro == x.idCentro).descripcionCentro,
                Descripcion = x.descripcionVenta,
                Monto = (decimal)db.testAuto.FirstOrDefault(y => y.idAuto == x.idAuto).costoAuto,
                idCentro = (int)x.idCentro,
                idVehiculo = (int)x.idAuto
            }).AsQueryable<rVenta>();

            return resultado;

        }

      
    }
}
