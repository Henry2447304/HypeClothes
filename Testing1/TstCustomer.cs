using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        private int mCustomerId = 2;
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
           
            clsCustomer ACustomer = new clsCustomer();
            int TestData = mCustomerId;
            ACustomer.CustomerId = TestData;
            Assert.AreEqual(ACustomer.CustomerId, TestData);
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
        public void MinLessOne()
        {

            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            int TestData = 0;
            Error = ACustomer.Valid(TestData);
            Assert.AreNotEqual(Error, "");
        }
    }
}