using System;
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
            string Name = "";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Name = "a";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusone()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Name = "aa";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Name = "";
            Name = Name.PadLeft(49, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Name = "";
            Name = Name.PadLeft(50, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Name = "";
            Name = Name.PadLeft(51, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Name = "";
            Name = Name.PadLeft(25, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Name = "";
            Name = Name.PadLeft(300, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void AddressExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(300, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(50, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(49, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(51, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "";
            Address = Address.PadLeft(25, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "a";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMinPlusone()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Address = "aa";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PostcodeExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Postcode = "";
            Postcode = Postcode.PadLeft(300, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void AddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CustomerAddress = "";
            CustomerAddress = CustomerAddress.PadLeft(50, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Postcode = "";
            Postcode = Postcode.PadLeft(49, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Postcode = "";
            Postcode = Postcode.PadLeft(51, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Postcode = "";
            Postcode = Postcode.PadLeft(25, '*');
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Postcode = "a";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Postcode = "";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeMinPlusone()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Postcode = "aa";
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(Error, "");
        }
    }
}