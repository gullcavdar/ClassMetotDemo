using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + customer.CustomerProfession + " bilgileri olan müşteri eklendi");
        }


        public void DeleteCostumer(Customer customer)
        {
            Console.WriteLine("{0} {1} müşteri silindi", customer.CustomerName, customer.CustomerSurname);
        }


        public void CustomerList(Customer[] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname + " " + customer.CustomerProfession);
            }
        }
    }
}
