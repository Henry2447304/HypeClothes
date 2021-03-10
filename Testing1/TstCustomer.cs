using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
    }

    [TestMethod]
    public void CustomerIdOK()
    {
        //
        clsCustomer ACustomer = new clsCustomer();
        int TestData = 2;
        ACustomer.CustomerId = TestData;
        //
        Assert.AreEqual(ACustomer.CustomerId,TestData);
    }
}