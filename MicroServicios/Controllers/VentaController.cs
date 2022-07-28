using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using MicroServicios.Models;

namespace MicroServicios.Controllers
{
    public class VentaController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Venta
        /// <summary>
        /// Obtener venta
        /// </summary>
        public IQueryable<testVenta> GetVenta()
        {
            return db.testVenta;
        }

        // GET: api/Venta/5
        [ResponseType(typeof(testVenta))]
        public IHttpActionResult GetVenta(int id)
        {
            testVenta testVenta = db.testVenta.Find(id);
            if (testVenta == null)
            {
                return NotFound();
            }

            return Ok(testVenta);
        }

        // PUT: api/Venta/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutVenta(int id, testVenta testVenta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != testVenta.idVenta)
            {
                return BadRequest();
            }

            db.Entry(testVenta).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Venta
        [ResponseType(typeof(testVenta))]
        public IHttpActionResult PostVenta(testVenta testVenta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.testVenta.Add(testVenta);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = testVenta.idVenta }, testVenta);
        }

        // DELETE: api/Venta/5
        [ResponseType(typeof(testVenta))]
        public IHttpActionResult DeleteVenta(int id)
        {
            testVenta testVenta = db.testVenta.Find(id);
            if (testVenta == null)
            {
                return NotFound();
            }

            db.testVenta.Remove(testVenta);
            db.SaveChanges();

            return Ok(testVenta);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VentaExists(int id)
        {
            return db.testVenta.Count(e => e.idVenta == id) > 0;
        }
    }
}