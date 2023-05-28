using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1, Name = "Nguyen Cao"},
                new Customer {Id = 2, Name = "Quang Huy"},
                new Customer {Id = 3, Name = "Phuong Trinh"},
                new Customer {Id = 4, Name = "Chaitanya Annepu"},
                new Customer {Id = 5, Name = "Long"},
            };
        }
    }
}