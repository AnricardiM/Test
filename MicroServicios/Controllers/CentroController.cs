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
    public class CentroController : ApiController
    {
        private Model1 db = new Model1();

        // GET: api/Centro
        public IQueryable<testCentro> GetCentro()
        {
            return db.testCentro;
        }

        // GET: api/Centro/5
        [ResponseType(typeof(testCentro))]
        public IHttpActionResult GetCentro(int id)
        {
            testCentro testCentro = db.testCentro.Find(id);
            if (testCentro == null)
            {
                return NotFound();
            }

            return Ok(testCentro);
        }

        // PUT: api/Centro/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCentro(int id, testCentro testCentro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != testCentro.idCentro)
            {
                return BadRequest();
            }

            db.Entry(testCentro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CentroExists(id))
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

        // POST: api/Centro
        [ResponseType(typeof(testCentro))]
        public IHttpActionResult PostCentro(testCentro testCentro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.testCentro.Add(testCentro);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = testCentro.idCentro }, testCentro);
        }

        // DELETE: api/Centro/5
        [ResponseType(typeof(testCentro))]
        public IHttpActionResult DeleteCentro(int id)
        {
            testCentro testCentro = db.testCentro.Find(id);
            if (testCentro == null)
            {
                return NotFound();
            }

            db.testCentro.Remove(testCentro);
            db.SaveChanges();

            return Ok(testCentro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CentroExists(int id)
        {
            return db.testCentro.Count(e => e.idCentro == id) > 0;
        }
    }
}