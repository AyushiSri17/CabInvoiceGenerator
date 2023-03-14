using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]       
            public void Given_Distance_And_Time_Return_TotalFare()
            {
                //Arrange
                InvoiceGenerator invoice = new InvoiceGenerator();
                Ride ride = new Ride(5,7,RideType.PREMIUM);
                //Act
                double actual = invoice.CalculateFare(ride);
                //Assert
                Assert.AreEqual(actual,89);
            }

        [TestMethod]
            public void Given_Distance_And_Time_Return_TotalFare_MultipleRides()
            {
                //Arrange
                InvoiceGenerator invoice = new InvoiceGenerator();
                Ride[] rides = new Ride[]
                {
                    new Ride(4,6,RideType.NORMAL),//46
                    new Ride(5,7,RideType.PREMIUM),//89
                };
                //Act
                InvoiceSummary expected = new InvoiceSummary(rides.Length,135);
                InvoiceSummary actual = invoice.CalculateFare(rides);
                //Assert
                Assert.AreEqual(actual,expected);
            }

        [TestMethod]
            public void Given_UserID_Should_Return_ListofRides_Invoice()
            {
                InvoiceGenerator invoice = new InvoiceGenerator();
                Ride[] ride1 = new Ride[]
                {
                    new Ride(4, 6, RideType.NORMAL),
                    new Ride(5, 7, RideType.PREMIUM),
                };
                Ride[] ride2 = new Ride[]
                {
                    new Ride(5, 8, RideType.NORMAL),
                    new Ride(5, 10, RideType.PREMIUM),
                };
                invoice.AddRides("Ayushi", ride1);
                invoice.AddRides("Srivastava", ride2);
                InvoiceSummary actual1 = invoice.GetInvoiceSummary("Ayushi");
                InvoiceSummary actual2 = invoice.GetInvoiceSummary("Srivastava");
                Assert.AreEqual(actual1.totalFare,135);
                Assert.AreEqual(actual2.totalFare,153);
            }
    }
}
