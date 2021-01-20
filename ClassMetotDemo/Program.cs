using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.CustomerName = "Gül";
            customer1.CustomerSurname = "Çavdar";
            customer1.CustomerProfession = "Mühendis";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.CustomerName = "Esmanur";
            customer2.CustomerSurname = "Çavdar";
            customer2.CustomerProfession = "Öğrenci";


            Customer[] customers = new Customer[] { customer1,customer2 };

            CustomerManager customerManager = new CustomerManager();

            Console.WriteLine("Ekle");
            customerManager.AddCustomer(customer1);
            Console.WriteLine("Sil");

            customerManager.DeleteCostumer(customer2);
            Console.WriteLine("Liste");

            customerManager.CustomerList(customers);
           

        }
    }
    
}
