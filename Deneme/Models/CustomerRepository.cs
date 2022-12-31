using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Deneme.Models
{
    public class CustomerRepository
    {
        protected readonly AppDbContext _context;
        private List<Customer> _customers = new List<Customer>();
       
        


        

        public void Add(Customer Customer)
            
        {
          _customers.Add(Customer);
            //var hasCustomer = _customers.FirstOrDefault( x => x.CustomerId == x.CustomerId);
            //hasCustomer.CustomerId=customer.CustomerId;
            
        }

       //public void Remove(int id) 
       // {
       //     var hasCustomer = _customers.FirstOrDefault(x=>x.CustomerId == x.CustomerId);
         
       //     if (hasCustomer != null)
       //     {
       //         throw new Exception($"bu id ({id})ye sahip ürün bulunmamakta");
       //     }
       //     _customers.Remove(hasCustomer);
       // }

        //public void Update(Customer customer)
        //{

        //    var hasCustomer = _customers.FirstOrDefault(x=>x.CustomerId == x.CustomerId);
        //    if (hasCustomer != null)
        //    {
        //        throw new Exception($"bu id ({customer.CustomerId})ye sahip ürün bulunmamakta");
        //    }
            
        //    hasCustomer.CompanyName = customer.CompanyName;
        //    hasCustomer.City = customer.City;
        //    hasCustomer.Country = customer.CompanyName;
        //    hasCustomer.ContactName = customer.ContactName;
            
        //    var index = _customers.FindIndex(x=>x.CustomerId==customer.CustomerId);
        //    _customers[index] = hasCustomer;

        //}


    }
}
