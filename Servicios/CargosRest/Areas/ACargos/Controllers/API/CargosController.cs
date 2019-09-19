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
using EF.Cargos;
using System.Web.Http.Cors;
using CargosRest.Filters;

namespace CargosRest.Areas.ACargos.Controllers.API
{
    //[MyCorsPolicy]
    //[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class CargosController : ApiController
    {
        private comisionesEntities db = new comisionesEntities();

        // GET: api/Cargos
        public IQueryable<Cargos> GetCargos()
        {
            return db.Cargos;
        }

        // GET: api/Cargos/5
        [ResponseType(typeof(Cargos))]
        public IHttpActionResult GetCargos(int id)
        {
            Cargos cargos = db.Cargos.Find(id);
            if (cargos == null)
            {
                return NotFound();
            }

            return Ok(cargos);
        }

        // PUT: api/Cargos/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCargos(int id, Cargos cargos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != cargos.IdCargo)
            {
                return BadRequest();
            }

            db.Entry(cargos).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CargosExists(id))
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

        // POST: api/Cargos
        [ResponseType(typeof(Cargos))]
        public IHttpActionResult PostCargos(Cargos cargos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cargos.Add(cargos);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = cargos.IdCargo }, cargos);
        }

        // DELETE: api/Cargos/5
        [DisableCors()]
        //[ResponseType(typeof(Cargos))]
        public IHttpActionResult DeleteCargos(int id)
        {
            Cargos cargos = db.Cargos.Find(id);
            if (cargos == null)
            {
                return NotFound();
            }

            db.Cargos.Remove(cargos);
            db.SaveChanges();

            return Ok(cargos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CargosExists(int id)
        {
            return db.Cargos.Count(e => e.IdCargo == id) > 0;
        }
    }
}