using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing1
{
    [TestClass]
    public class TstCustomer
    {
        //good test data
        string Name = "Bruce Lee";
        string Dob = DateTime.Now.Date.ToString();
        string Address = "Turbo Road";
        string Postcode = "PE10 1AB";

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
        public void NameOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String TestData = Name;
            AnCustomer.Name = TestData;
            Assert.AreEqual(AnCustomer.Name, TestData);
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
            AnCustomer.DoB = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.DoB, TestData);
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
        public void GdprRequestOK()
        {
            clsCustomer AnCustomer = new clsCustomer();
            Boolean TestData = true;
            AnCustomer.GdprRequest = TestData;
            Assert.AreEqual(AnCustomer.GdprRequest, TestData);
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
        public void PostcodeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string Postcode = "";
            Postcode = Postcode.PadLeft(50, '*');
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
        

     //   [TestMethod]

        //public void DoBExtremeMin()
     //   {
            //create an instance of the class we want to create
         //   clsCustomer ACustomer = new clsCustomer();
            //string variable to store any Error message
         //   String Error = "";
            //create a variable to store the test date data
         //   DateTime TestDate;
            //set the date totodays date
         //   TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
          // TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
         //   string DoB = TestDate.ToString();
            //invoke the method
          //  Error = ACustomer.Valid(Name, Address, Postcode, DoB);
            //test to see that the result is correct
          //  Assert.AreNotEqual(Error, "");
   //     }

       // [TestMethod]
       // public void DoBMinLessOne()
      //  {
            //create an instance of the class we want to create
          //  clsCustomer ACustomer = new clsCustomer();
            //string variable to store any Error message
          //  String Error = "";
            //create a variable to store the test date data
          //  DateTime TestDate;
            //set the date to todays date
          //  TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
          //  TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
         //   string DoB = TestDate.ToString();
            //invoke the method
           // Error = ACustomer.Valid(Name, Address, Postcode, DoB);
            //test to see that the result is correct
          //  Assert.AreNotEqual(Error, "");
      //  }

        [TestMethod]
        public void DobMin()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any Error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string Dob = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DobMinPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any Error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string Dob = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DobExtremeMax()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any Error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string Dob = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DobInvalidData()
        {
            //create an instance of the clas we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any Error message
            String Error = "";
            //set the DateAdded to a non date value
            string Dob = "this is not a date";
            //invoke the method
            Error = ACustomer.Valid(Name, Address, Postcode, Dob);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void TestCustomerIdFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 50;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the customerId
            if (ACustomer.CustomerId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the property
            if (ACustomer.Name != "Bruce Lee")
            {
                OK = false;
            }
            //test is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the address
            if (ACustomer.Address != "Turbo Road")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the postcode
            if (ACustomer.Postcode != "PE10 1AB")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDobFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if date
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerId = 5;
            //invoke the method
            Found = ACustomer.Find(CustomerId);
            //check the date
            if (ACustomer.DoB != Convert.ToDateTime("10/04/1998"))
            {
                OK = false;
            }
            //test result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOk()
        {
            clsCustomer AnCustomer = new clsCustomer();
            String error = "";
            error = AnCustomer.Valid(Name, Address, Postcode, Dob);
            Assert.AreEqual(error, "");
        }

    }
}