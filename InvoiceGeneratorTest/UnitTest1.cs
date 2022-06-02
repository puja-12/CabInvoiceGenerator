using Microsoft.VisualStudio.TestTools.UnitTesting;
using CabinInvoiceGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinInvoiceGenerator.Test
{
    [TestClass()]
    public class InvoiceGeneratorTests
    {
        [TestMethod()]
        public void TotalFareTest()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double Fare = invoiceGenerator.TotalFare(20, 3);
            Assert.AreEqual(203, Fare);
        }

        [TestMethod()]
        public void TotalFareTest1()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double Fare = invoiceGenerator.TotalFare(0.3, 2);
            Assert.AreEqual(5, Fare);
        }
    }
}