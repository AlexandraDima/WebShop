using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MbmStore.Models;


namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        private IEnumerable<Invoice> invoices;
        //Get the Invoices 
        public ActionResult Index()
        {
            // List of customers 
            List<SelectListItem> customers = new List<SelectListItem>();

            // Foreach loop that generates the dropdown list 
            // For each invoice in the Incoices repository, add the selected customer to the text box field
            foreach (Invoice invoice in Repository.Invoices)
            {
               customers.Add(new SelectListItem { Text = invoice.Customer.Firstname + " " + 
               invoice.Customer.Lastname, Value = invoice.Customer.CustomerId.ToString() });
            }

            // Customer can have more than one order - we need to remove duplicate entries with same ID from the list
            // Using Linq and Group the list by value of customer 
            // select the first element in each group and order based on the text specified in the foreach  loop 

            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            //send the list of Invoices from Repository to the ViewBag.Invoices and assign the property CustomerId to the list of customers
            ViewBag.CustomerId = customers;
            ViewBag.Invoices = Repository.Invoices;
            return View();
        }

        //Post action method - read the value of the selected Customer ID 
        [HttpPost]
        public ActionResult Index(int? CustomerId)
        {
            // declare the list 
            List<SelectListItem> customers = new List<SelectListItem>();
            foreach (Invoice invoice in Repository.Invoices)
            {
                //declares a SelectListItem List and populates it with customers data from the Invoice List that is generated in the Repository class. 
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname,
                    Value = invoice.Customer.CustomerId.ToString()
                });
            }

            invoices = Repository.Invoices;

            //filter the invoices based on the selected CustomerId
            if (CustomerId != null)
            { // using Linq to select invoices from the repository based on the Customer Id  
               invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == CustomerId);
            }
            ViewBag.Invoices = invoices;
         
            ViewBag.CustomerId = customers;
            return View();

        }
     
    }
}