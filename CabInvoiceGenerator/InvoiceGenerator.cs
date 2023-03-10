using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        RideRepository rideRepo = new RideRepository();
        public double CalculateFare(Ride ride)
        {
            double totalFare=0;
            if (ride.distance <= 0)
                throw new CabInvoiceCustomException(CabInvoiceCustomException.ExceptionType.INVALID_DISTANCE, "Distance should not be zero or less than zero");
            else if (ride.time <= 0)
                throw new CabInvoiceCustomException(CabInvoiceCustomException.ExceptionType.INVALID_TIME, "Time should not be less than zero or zero");
            else
            {
                totalFare = ride.distance * ride.COST_PER_KM + ride.time * ride.COST_PER_MINUTE;
            }
            return Math.Max(totalFare, ride.MINIMUM_FARE);
        }
        public InvoiceSummary CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            foreach (Ride ride in rides)
            {
                totalFare += CalculateFare(ride); 
            }
            //return totalFare;
            return new InvoiceSummary(rides.Length, totalFare);
        }
        public void AddRides(string userId, Ride[] rides)
        {
            rideRepo.AddRide(userId, rides);
        }
        public InvoiceSummary GetInvoiceSummary(string userId)
        {
            Console.WriteLine("\nUserId =", userId);
            return this.CalculateFare(rideRepo.GetRides(userId));
        }

    }
}
