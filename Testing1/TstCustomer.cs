using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        string Dob = DateTime.Now.Date.ToString();
        string Address = "1, A Street, Leicester, LE1 1AA";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Int32 TestData = 1;
            AnCustomer.CustomerId = TestData;
            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void ValidOK()
        {

            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            int TestData = mCustomerId;
            Error = ACustomer.Valid(mCustomerId);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void AddressOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the date to the property
            AnCustomer.DateOrdered = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DateOrdered, TestData);
        }

        [TestMethod]
        public void DobOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Int32 TestData = 1;

            AnCustomer.CustomerId = TestData;

            Assert.AreEqual(AnCustomer.CustomerId, TestData);
        }

        [TestMethod]
        public void PostcodeOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Int32 TestData = 1;

            AnCustomer.TotalItem = TestData;

            Assert.AreEqual(AnCustomer.TotalItem, TestData);
        }

        [TestMethod]
        public void GdprOK()
        {
            clsCustomer AnCustomer = new clsCustomer();

            Double TestData = 15.00;

            AnCustomer.TotalPrice = TestData;

            Assert.AreEqual(AnCustomer.TotalPrice, TestData);
        }
        
    }
}