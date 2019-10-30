using System.Collections.Generic;
using System.Web.Mvc;
using MbmStore.Models;
namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            // create a new Movie object with instance name Customer, using the constructures in paranthesis
            List<Customer> customers = new List<Customer>();
            customers = Repository.Customers;
            ViewBag.Customers = customers;
            return View();
        }

    }
    }
