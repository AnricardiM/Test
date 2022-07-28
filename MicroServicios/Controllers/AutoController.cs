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
    public class AutoController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Auto
        public IQueryable<testAuto> GetAuto()
        {
            return db.testAuto;
        }

        // GET: api/Auto/5
        [ResponseType(typeof(testAuto))]
        public IHttpActionResult GetAuto(int id)
        {
            testAuto testAuto = db.testAuto.Find(id);
            if (testAuto == null)
            {
                return NotFound();
            }

            return Ok(testAuto);
        }

        // PUT: api/Auto/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAuto(int id, testAuto testAuto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != testAuto.idAuto)
            {
                return BadRequest();
            }

            db.Entry(testAuto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AutoExists(id))
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

        // POST: api/Auto
        [ResponseType(typeof(testAuto))]
        public IHttpActionResult PostAuto(testAuto testAuto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.testAuto.Add(testAuto);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = testAuto.idAuto }, testAuto);
        }

        // DELETE: api/Auto/5
        [ResponseType(typeof(testAuto))]
        public IHttpActionResult DeleteAuto(int id)
        {
            testAuto testAuto = db.testAuto.Find(id);
            if (testAuto == null)
            {
                return NotFound();
            }

            db.testAuto.Remove(testAuto);
            db.SaveChanges();

            return Ok(testAuto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AutoExists(int id)
        {
            return db.testAuto.Count(e => e.idAuto == id) > 0;
        }
    }
}