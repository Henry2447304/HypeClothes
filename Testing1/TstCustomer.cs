﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class TstCustomer
    {
        //good test data
        string Name = "John";
        string Dob = DateTime.Now.Date.ToString();
        string Address = "1, A Street, Leicester";
        string Postcode = "LE1 1AA";

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
        public void CustomerNameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = Name;
            AnCustomer.Name = TestData;
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void ValidOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = Address;
            AnCustomer.Address = TestData;
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void DobOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the date to the property
            AnCustomer.Dob = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Dob, TestData);
        }

        [TestMethod]
        public void PostcodeOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = Postcode;
            AnCustomer.Postcode = TestData;
            Assert.AreEqual(AnCustomer.Postcode, TestData);
        }

        [TestMethod]
        public void GdprOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.Gdpr = TestData;
            Assert.AreEqual(AnCustomer.Gdpr, TestData);
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "a";
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusone()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "aa";
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(49, '*');
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(50, '*');
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(51, '*');
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerDateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(25, '*');
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerDateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerName = "";
            CustomerName = CustomerName.PadLeft(300, '*');
            Error = ACustomer.Valid(CustomerName, CustomerAddress, CustomerPhoneNumber, CustomerDateAdded);
            Assert.AreNotEqual(Error, "");

        }
}