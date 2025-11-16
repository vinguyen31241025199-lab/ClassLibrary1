using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
        {
            public int AccountID { get; set; }
            public string Adress { get; set; }
            public DateTime Birthday { get; set; }
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

            // Methods
            public Customer() { }

            public void FindInfo()
            {
                // Some logic here
            }

            public void FindName()
            {
                // Some logic here
            }

            public void GetCustomers()
            {
                // Some logic here
            }

            public void Update()
            {
                // Some logic here
            }
        }
}
