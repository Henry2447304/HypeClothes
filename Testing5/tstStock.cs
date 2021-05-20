using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing5
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
        string ProductDescript = "Black NOCTA Hoodie";
        string Cost = "120";
        string StockNo = "42";
        string DateAdded = DateTime.Now.ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of  the class we want to create
            clsStock AnStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AnStock);
        }

        [TestMethod]
        public void ProductIDOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 2;
            //assign the data to the property
            AnStock.ProductID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductID, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 120;
            //assign the data to the property
            AnStock.Cost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.Cost, TestData);
        }

        [TestMethod]
        public void ProductDescriptionOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Black NOCTA Hoodie";
            //assign the data to the property
            AnStock.ProductDescript = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.ProductDescript, TestData);
        }

        [TestMethod]
        public void StockQuantityOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 50;
            //assign the data to the property
            AnStock.StockNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.StockNo, TestData);
        }

        [TestMethod]
        public void StockDateOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.DateAdded, TestData);
        }

        [TestMethod]
        public void InStockOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStock.InStck = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStock.InStck, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 ProductNo = 32;
            //invoke the method
            Found = AnStock.Find(ProductNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestProductNoFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to record if data is OK
            Boolean Found = false;
            Boolean OK = true;
            Int32 ProductNo = 2;
            Found = AnStock.Find(ProductNo);
            if (AnStock.ProductID != 2)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK
            Boolean OK = true;
            //create some test data to use with the method
            Int32 ProductNo = 2;
            //invoke the method
            Found = AnStock.Find(ProductNo);
            //check
            if (AnStock.DateAdded != Convert.ToDateTime("16/9/2021"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockNoFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StockNo = 42;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //check the address no
            if (AnStock.StockNo != 42)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCostFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int Cost = 120;
            //invoke the method
            Found = AnStock.Find(Cost);
            //check the property
            if (AnStock.Cost != 120)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestProductDescriptionFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            string ProductDescript = "Black NOCTA Hoodie";
            //invoke the method
            Found = AnStock.Find(ProductDescript);
            //check the property
            if (AnStock.ProductDescript != "Black NOCTA HoodieL")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestInStockFound()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 StockNo = 50;
            //invoke the method
            Found = AnStock.Find(StockNo);
            //check the property
            if (AnStock.InStck != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = AnStock.Valid(ProductDescript,Cost,StockNo,DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMinLessOne()
        {
            //create and instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = ""; //this should trigger an error
            //invoke  the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        public void ProductDescriptMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "Black NOCTA Hoodie"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = ""; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "Black NOCTA Hoodie"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "Black NOCTA Hoodie"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = "aaaa"; //this should be ok
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ProductDescriptExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ProductDescript = ""; //this should be ok
            ProductDescript = ProductDescript.PadRight(500, 'a'); //this should fail
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            DateTime TestDate;
            //set the date to today's date
            TestDate = DateTime.Now.Date;
            //change the data to whatever the date is less than 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            //set the DateAdded to a non date value
            string DateAdded = "this is not a date";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Cost = "";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "a";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Cost = "aaaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




        [TestMethod]
        public void StockNoMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockNo = "";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMin()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "a";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "aa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMaxLessOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "aaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMax()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "aaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string StockNo = "aaaaaaaaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StockNoMid()
        {
            //create an instance of the class we want to create
            clsStock AnStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string StockNo = "aaaa";
            //invoke the method
            Error = AnStock.Valid(ProductDescript, Cost, StockNo, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


    }
}