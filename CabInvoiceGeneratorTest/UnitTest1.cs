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

                Ride ride = new Ride(4,6);
                //Act
                double actual = invoice.CalculateFare(ride);

                //Assert
                Assert.AreEqual(actual, 46);
            }
        
    }
}
