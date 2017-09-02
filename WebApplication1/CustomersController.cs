//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.Entity;
//using System.Data.Entity.Infrastructure;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Http.Description;
//using WebApplication1.Models;

//namespace WebApplication1.Controllers
//{
//    public class CustomersController : ApiController
//    {
//        private ShopEntities db = new ShopEntities();

//        // GET: api/Customers
//        public IEnumerable<Customer> GetCustomers()
//        {

//            string[] abc = new string[] { "abcd", "efg", "hij", "klm" };
//            List<Customer> cs = new List<Customer>()
//            {
//                  new Customer(){ Id = "abc", Name="abc", Address="eed", Credit=12},
//                  new Customer(){ Id = "cd", Name="ff", Address="eed", Credit=11},
//                  new Customer(){ Id = "ef", Name="dd", Address="ced", Credit=1}

//            };

//            return cs;

//        }

//        // GET: api/Customers/5
//        [ResponseType(typeof(Customer))]
//        public IHttpActionResult GetCustomer(string id)
//        {
//           // Customer customer = db.Customers.Find(id);
//            //if (customer == null)
//            //{
//            //    return NotFound();
//            //}

//            return Ok(customer);
//        }

//        // PUT: api/Customers/5
//        [ResponseType(typeof(void))]
//        public IHttpActionResult PutCustomer(string id, Customer customer)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            if (id != customer.Id)
//            {
//                return BadRequest();
//            }

//            db.Entry(customer).State = EntityState.Modified;

//            try
//            {
//                db.SaveChanges();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!CustomerExists(id))
//                {
//                    return NotFound();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return StatusCode(HttpStatusCode.NoContent);
//        }

//        // POST: api/Customers
//        [ResponseType(typeof(Customer))]
//        public IHttpActionResult PostCustomer(Customer customer)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }

//            db.Customers.Add(customer);

//            try
//            {
//                db.SaveChanges();
//            }
//            catch (DbUpdateException)
//            {
//                if (CustomerExists(customer.Id))
//                {
//                    return Conflict();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return CreatedAtRoute("DefaultApi", new { id = customer.Id }, customer);
//        }

//        // DELETE: api/Customers/5
//        [ResponseType(typeof(Customer))]
//        public IHttpActionResult DeleteCustomer(string id)
//        {
//            Customer customer = db.Customers.Find(id);
//            if (customer == null)
//            {
//                return NotFound();
//            }

//            db.Customers.Remove(customer);
//            db.SaveChanges();

//            return Ok(customer);
//        }

//        protected override void Dispose(bool disposing)
//        {
//            if (disposing)
//            {
//                db.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        private bool CustomerExists(string id)
//        {
//            return db.Customers.Count(e => e.Id == id) > 0;
//        }
//    }
//}