using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;
        public readonly int MINIMUM_FARE;
        public readonly int COST_PER_KM;
        public readonly int COST_PER_MINUTE;
        public Ride(double distance, int time)
        {
            this.distance = distance;
            this.time = time;
            MINIMUM_FARE = 5;
            COST_PER_KM = 10;
            COST_PER_MINUTE = 1;

        }
    }
}
