using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestingCustomer
{

    [TestClass]
    public class tstCustomerCollection
    {
        List<clsCustomer> CustomerList = new List<clsCustomer>();
        Int32 Count = 0;
        clsCustomer ThisCustomer = new clsCustomer();


        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> CustomerList = new List<clsCustomer>();
            //create the test customer
            clsCustomer TestCustomer = new clsCustomer();
            //set properties
            TestCustomer.CustomerId = 1;
            TestCustomer.Name = "John Snow";
            TestCustomer.Address = "1 Kings Landing";
            TestCustomer.Postcode = "KL01 1QL";
            TestCustomer.DoB = DateTime.Now.Date;
            TestCustomer.GdprRequest = false;
            //add TestCustomer to the CustomerList
            CustomerList.Add(TestCustomer);
            AllCustomers.CustomerList = CustomerList;
            Assert.AreEqual(AllCustomers.CustomerList, CustomerList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the test customer
            clsCustomer TestCustomer = new clsCustomer();
            //set properties
            TestCustomer.CustomerId = 10;
            TestCustomer.Name = "Ten";
            TestCustomer.Address = "Ten";
            TestCustomer.Postcode = "Post";
            TestCustomer.DoB = DateTime.Now.Date;
            TestCustomer.GdprRequest = true;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> CustomerList = new List<clsCustomer>();
            //create the test customer
            clsCustomer TestCustomer = new clsCustomer();
            //set properties
            TestCustomer.CustomerId = 2;
            TestCustomer.Name = "a";
            TestCustomer.Address = "ad";
            TestCustomer.Postcode = "PP112DD";
            TestCustomer.DoB = DateTime.Now.Date;
            TestCustomer.GdprRequest = false;
            //add TestCustomer to the CustomerList
            CustomerList.Add(TestCustomer);
            AllCustomers.CustomerList = CustomerList;
            Assert.AreEqual(AllCustomers.Count, CustomerList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the test customer
            clsCustomer TestCustomer = new clsCustomer();
            Int32 PrimaryKey = 0;
            //set properties
            TestCustomer.CustomerId = 5;
            TestCustomer.Name = "Bruce Lee";
            TestCustomer.Address = "Turbo Road";
            TestCustomer.Postcode = "PE10 1AB";
            TestCustomer.DoB = DateTime.Now.Date;
            TestCustomer.GdprRequest = true;
            AllCustomers.ThisCustomer = TestCustomer;
            //add customer to key
            PrimaryKey = AllCustomers.Add();
            //set key
            TestCustomer.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the test customer
            clsCustomer TestCustomer = new clsCustomer();
            Int32 PrimaryKey = 0;
            //set properties            
            TestCustomer.Name = "a";
            TestCustomer.Address = "ad";
            TestCustomer.Postcode = "AA111BB";
            TestCustomer.DoB = DateTime.Now.Date;
            TestCustomer.GdprRequest = true;
            AllCustomers.ThisCustomer = TestCustomer;
            //add customer to key
            PrimaryKey = AllCustomers.Add();
            //set key
            TestCustomer.CustomerId = PrimaryKey;
            //update test customer
            TestCustomer.Name = "Test Son";
            TestCustomer.Address = "Some Road";
            TestCustomer.Postcode = "LE101NN";
            TestCustomer.DoB = DateTime.Now.Date;
            TestCustomer.GdprRequest = false;
            //set customer with new data
            AllCustomers.ThisCustomer = TestCustomer;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the test customer
            clsCustomer TestCustomer = new clsCustomer();
            Int32 PrimaryKey = 0;
            //set properties
            TestCustomer.Name = "John Barry";
            TestCustomer.Address = "The Road";
            TestCustomer.Postcode = "N111FF";
            TestCustomer.DoB = DateTime.Now.Date;
            TestCustomer.GdprRequest = false;
            AllCustomers.ThisCustomer = TestCustomer;
            //add customer to key
            PrimaryKey = AllCustomers.Add();
            TestCustomer.CustomerId = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(found);
        }
        [TestMethod]
        public void ReportByNameOK()
        {
            //normal instance
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //filtered data instance
            clsCustomerCollection FilteredNames = new clsCustomerCollection();
            //empty filtered name
            FilteredNames.ReportByName("");
            Assert.AreEqual(AllCustomers.Count, FilteredNames.Count);
        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            //filtered data instance
            clsCustomerCollection FilteredNames = new clsCustomerCollection();
            //apply a name that does not exist
            FilteredNames.ReportByName("abc");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredNames.Count);
        }

        [TestMethod]
        public void ReportByNameDataFound()
        {
            //filtered data instance
            clsCustomerCollection FilteredNames = new clsCustomerCollection();
            Boolean OK = true;
            //apply a name from the list
            FilteredNames.ReportByName("Bruce Lee");
            if (FilteredNames.Count == 2)
            {
                //ID of customer is 5
                if (FilteredNames.CustomerList[0].CustomerId != 5)
                {
                    OK = false;
                }

                //ID of customer is 10 
                if (FilteredNames.CustomerList[1].CustomerId != 10)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}
