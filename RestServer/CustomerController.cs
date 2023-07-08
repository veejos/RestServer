using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestServer
{
    public class CustomerController : ApiController
    {
        private static List<Customer> Customers = new List<Customer>();
        private IEnumerable<Customer> newCustomers;

        //POST/api/Customers
        public IHttpActionResult postCustomers(List<Customer> customers)
        {
            try
            {
                //Add new customers to the list
                customers.AddRange(newCustomers);
                return Created(Request.RequestUri, newCustomers);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);

            }
        }
    }
}




       