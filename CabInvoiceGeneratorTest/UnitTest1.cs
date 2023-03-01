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
            double actual = invoice.CalculateFare(rides);
            //Assert
            Assert.AreEqual(actual,135);
        }

    }
}
