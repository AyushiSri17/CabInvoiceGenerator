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

            Ride ride = new Ride(4,6);
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double fare=invoiceGenerator.CalculateFare(ride);
            Console.WriteLine(fare);//46
            Console.ReadLine();
        }
    }
}
