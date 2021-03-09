using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstOrder
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ItemAvailablePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the order
            Boolean TestData = true;
            //assign the data to the order
            AnOrder.Available = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Available, TestData);
        }

        [TestMethod]
        public void DateOrderedPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the date to the property
            AnOrder.DateOrdered = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.DateOrdered, TestData);
        }

        [TestMethod]
        public void OrderIDPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.OrderID = TestData;

            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void TotalItemPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();

            Int32 TestData = 1;

            AnOrder.TotalItem = TestData;

            Assert.AreEqual(AnOrder.TotalItem, TestData);
        }

        [TestMethod]
        public void TotalPricePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();

            Double TestData = 15.00;

            AnOrder.TotalPrice = TestData;

            Assert.AreEqual(AnOrder.TotalPrice, TestData);
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();

            String TestData = "40, Some Street, Leicester, LE1 6AB";

            AnOrder.DeliveryAddress = TestData;

            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);
        }
    }
}
