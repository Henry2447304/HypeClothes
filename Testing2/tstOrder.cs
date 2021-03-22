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

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 OrderID = 1234;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 OrderID = 1234;
            //invoke the method
            Found = AnOrder.Find(OrderID);
            //check the order id
            if (AnOrder.OrderID != 1234)
            {
                OK = false;
            }
            //test to se that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateOrderedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1234;
            Found = AnOrder.Find(OrderID);
            if(AnOrder.DateOrdered != Convert.ToDateTime("09/03/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAvailableFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1234;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.Available != true )
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalItemFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1234;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.TotalItem != Convert.ToInt32(10))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalPriceFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1234;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.TotalPrice != Convert.ToDouble(15.55))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1234;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.DeliveryAddress != "40, Some Street, Leicester, LE1 1AB")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
