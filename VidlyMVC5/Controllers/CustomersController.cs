using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;
using Microsoft.Ajax.Utilities;
using VidlyMVC5.Models;

namespace VidlyMVC5.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult CustomerList()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        // Get Customer Detail
        public ActionResult CustomerDetail(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var customer = GetCustomers().SingleOrDefault( c => c.Id == id );

            if (customer == null)
                return HttpNotFound();
           
            return View(customer);
        }

        private static IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer() { Id = 1, Name = "Johnny"},
                new Customer() { Id = 2, Name = "Jerry"}
            };
        }
    }
}


