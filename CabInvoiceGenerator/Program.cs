using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cab Invoice Generator Problem");

            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            //Ride ride = new Ride(5,7);            
            //double fare=invoiceGenerator.CalculateFare(ride);          
            //Console.WriteLine(fare);//46//57
            Ride[] rides=new Ride[]
            {
                new Ride(4,6),
                new Ride(5,7),
            };
            double totalFare = invoiceGenerator.CalculateFare(rides);
            Console.WriteLine(totalFare);
            Console.ReadLine();
        }
    }
}
