﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using PeopleSearch.Data;
using PeopleSearch.Models;

namespace PeopleSearch.Controllers
{
    public class PeopleController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/People
        public IQueryable<Person> GetPersons(string searchString="")
        {
            Random random = new Random();
            System.Threading.Thread.Sleep(random.Next(1, 3000));
            switch (searchString)
            {
                case "":
                    return db.Persons;
                default:
                    return db.Persons.Where(p => p.Name.Contains(searchString));
            }
             
        }

        // GET: api/People/5
        [ResponseType(typeof(Person))]
        public async Task<IHttpActionResult> GetPerson(int id)
        {
            Person person = await db.Persons.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            return Ok(person);
        }

        // PUT: api/People/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPerson(int id, Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != person.Id)
            {
                return BadRequest();
            }

            db.Entry(person).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(id))
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

        // POST: api/People
        [ResponseType(typeof(Person))]
        public async Task<IHttpActionResult> PostPerson(Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Persons.Add(person);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = person.Id }, person);
        }

        // DELETE: api/People/5
        [ResponseType(typeof(Person))]
        public async Task<IHttpActionResult> DeletePerson(int id)
        {
            Person person = await db.Persons.FindAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            db.Persons.Remove(person);
            await db.SaveChangesAsync();

            return Ok(person);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PersonExists(int id)
        {
            return db.Persons.Count(e => e.Id == id) > 0;
        }
    }
}