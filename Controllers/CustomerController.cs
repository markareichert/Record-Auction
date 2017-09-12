using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecordAuction.Models;
using RecordAuction.ViewModels;
using RecordAuction.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace RecordAuction.Controllers
{
    public class CustomerController : Controller
    {
        private RecordDbContext context;

        public CustomerController(RecordDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IList<Customer> customers = context.Customers.ToList();
            return View(customers);
        }

        public IActionResult Add()
        {
            AddCustomerViewModel addCustomerViewModel = new AddCustomerViewModel();
            return View(addCustomerViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCustomerViewModel addCustomerViewModel)
        {
            if (ModelState.IsValid)
            {
                // Add the new customer to my existing customer
                Customer newCustomer = new Customer
                {
                    FirstName = addCustomerViewModel.FirstName,
                    LastName = addCustomerViewModel.LastName,
                    Address1 = addCustomerViewModel.Address1,
                    Address2 = addCustomerViewModel.Address2,
                    Address3 = addCustomerViewModel.Address3,
                    City = addCustomerViewModel.City,
                    State = addCustomerViewModel.State,
                    ZIPCode = addCustomerViewModel.ZipCode,
                    Country = addCustomerViewModel.Country
                 };

                context.Customers.Add(newCustomer);
                context.SaveChanges();

                return Redirect("/Customer");
            }

            return View(addCustomerViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Customers";
            ViewBag.customers = context.Records.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Remove(int[] customerIds)
        {
            foreach (int customerId in customerIds)
            {
                Customer theCustomer = context.Customers.Single(c => c.ID == customerId);
                context.Customers.Remove(theCustomer);
            }

            context.SaveChanges();

            return Redirect("/");
        }
    }
}
