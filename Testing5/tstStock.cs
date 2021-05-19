using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of  the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnStock.ProductNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductNo, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 120;
            //assign the data to the property
            AnStock.Cost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Cost, TestData);
        }

        [TestMethod]
        public void ProductDescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Black NOCTA Hoodie";
            //assign the data to the property
            AnStock.ProductDescript = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductDescript, TestData);
        }

        [TestMethod]
        public void StockQuantityOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 50;
            //assign the data to the property
            AnStock.StockNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockNo, TestData);
        }

        [TestMethod]
        public void StockDateOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.InStck = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.InStck, TestData);
        }
    }
}