using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalCompany
{
    public class Customer
    {
        private string firstname, lastname, email, phonenum;
        private List<Customer> customers;
        public static void Main(String args)
        {

        }
        public Customer(string firstname, string lastname, string email, string phonenum)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.phonenum = phonenum;
        }

        public void AddToCustomerList(Customer cust)
        {
            customers.Add(cust);
        }

        public List<Customer> GetCustomerList()
        {
            return customers;
        }

        public void PrintCustomers(List<Customer> cust)
        {
            int size = cust.Count;

            for(int i = 0; i < size; i++)
            {
                Console.WriteLine(cust.ElementAt(i));
            }
        }

    }


}
