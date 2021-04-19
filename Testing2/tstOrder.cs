using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingOrder
{
    [TestClass]
    public class tstOrder
    {
        //good test data
        //create some test data to pass the method
        string DateOrdered = DateTime.Now.Date.ToString();
        string DeliveryAddress = "40, Some Street, Leicester, LE1 1AB";

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

            String TestData = "40, Some Street, Leicester, LE1 1AB";

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
            if (AnOrder.DateOrdered != Convert.ToDateTime("09/03/2021"))
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
            if (AnOrder.Available != true)
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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMin()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "a"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "aa"; //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxLessOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DeliveryAddress = DeliveryAddress.PadRight(49, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DeliveryAddress = DeliveryAddress.PadRight(50, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DeliveryAddress = DeliveryAddress.PadRight(51, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMid()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DeliveryAddress = DeliveryAddress.PadRight(25, 'a'); //this should be ok
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            //create an instance of the class we want to create
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string DeliveryAddress = "";
            DeliveryAddress = DeliveryAddress.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMin()
        {
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateOrdered = TestDate.ToString();
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateOrderedInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            //set the DateOrdered to a non data value
            string DateOrdered = "This is not a date!";
            //invoke the method
            Error = AnOrder.Valid(DateOrdered, DeliveryAddress);
            //test to se that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
