using Microsoft.VisualStudio.TestTools.UnitTesting;
using PricingEngineApp;

namespace PricingEngineTests
{
    [TestClass]
    public class PricingEngineTests
    {
        [TestMethod]
        public void CalculateUnitPrice_BelowMinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 0.50m);
            // assert
            Assert.AreEqual(unitPrice, 0.50m);

        }

        [TestMethod]
        public void CalculateUnitPrice_MinPrice()
        {
            // arrange
            PricingEngine engine = new PricingEngine(false);
            // act
            decimal unitPrice = engine.CalculateUnitPrice(10, 1.00m);
            // assert
            Assert.AreEqual(unitPrice, 1.000m);
        }

        [TestMethod]
        public void CalculateUnitPrice_BelowMinQty()
        {
            // arrange

            // act

            // assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyLower()
        {
            // arrange

            // act

            // assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateUnitPrice_MinQtyUpper()
        {
            // arrange

            // act

            // assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateUnitPrice_QtyGT20()
        {
            // arrange

            // act

            // assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinPrice()
        {
            // arrange

            // act

            // assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinTotal()
        {
            // arrange

            // act

            // assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayBelowMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold

            // arrange

            // act

            // assert
            Assert.Fail();
        }

        [TestMethod]
        public void CalculateUnitPrice_HolidayMinQty()
        {
            // Test the discount for holiday and quantity = 10 and total
            // discounted amount is above the holiday threshold

            // arrange

            // act

            // assert
            Assert.Fail();
        }
    }
}
