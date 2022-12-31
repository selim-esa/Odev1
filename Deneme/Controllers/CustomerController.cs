using Deneme.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore;
using System;

namespace Deneme.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _context;
        private readonly CustomerRepository _customerRepository;

        Customer customer = new Customer();
        

        public CustomerController(AppDbContext context)
        {
            _context = context;
            _customerRepository = new CustomerRepository();
        }
        [HttpGet]
        public IActionResult Customer()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }
        [HttpPost]
        public IActionResult CustomerDetails()
        {
            var customers = _context.Customers.ToList();

            return View(customers);
        }

        [HttpPost]
    
        public IActionResult AddCustomer(Customer Customer)
        { 
            return View(customer);
        }

        [HttpPost]
        public IActionResult Save(Customer customer)
        {
            Customer newCustomer = new Customer()
            { CompanyName = customer.CompanyName, Address = customer.Address, City = customer.City, ContactName = customer.ContactName, ContactTitle = customer.ContactTitle, Country = customer.Country, CustomerId = customer.CustomerId, Fax = customer.Fax, Phone = customer.Phone, PostalCode = customer.PostalCode, Region = customer.Region };
            _context.Add(customer);
            _context.SaveChanges();
              

            return View();
        }
    }
}
