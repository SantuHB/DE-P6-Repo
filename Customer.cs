using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Demo2
{
    class Customer
    {
        int CustomerId;
        string CustomerName;
        double Payment;
        long ContactNumber;

        Customer[] CustomerArray;    // Customer Array Declaration 
        public void GetCustomerDetails()
        {
            Console.WriteLine("Enter Customer Count");
            int customerCount = int.Parse(Console.ReadLine());

            CustomerArray = new Customer[customerCount]; //Customer Array Initialization 

            for (int i = 0; i < CustomerArray.Length; i++)
            {
                //Store Customer Object -> CustomerArray
                CustomerArray[i] = new Customer();
                Console.WriteLine("Id");
                CustomerArray[i].CustomerId = int.Parse(Console.ReadLine());
                Console.WriteLine("Name");
                CustomerArray[i].CustomerName = Console.ReadLine();

                Console.WriteLine("Payment");
                CustomerArray[i].Payment = double.Parse(Console.ReadLine());
                Console.WriteLine("Contact");
                CustomerArray[i].ContactNumber = long.Parse(Console.ReadLine());
            }
        }
        public void PrintCustomerDetails()
        {
            for (int i = 0; i < CustomerArray.Length; i++)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}", CustomerArray[i].CustomerId, CustomerArray[i].CustomerName, 
                CustomerArray[i].Payment, CustomerArray[i].ContactNumber);
            }
        }
    }
}
