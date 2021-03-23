﻿using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test_FrameWork
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //test to see that it exists
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            //create an instance of the class we want to create
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsOrder> TestList = new List<clsOrder>();
            //add an item to the list
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //set its properties
            TestItem.Available = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "40, Some Street, Leicester, LE1 1AB";
            TestItem.DateOrdered = DateTime.Now.Date;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllOrders.OrderList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            TestItem.Available = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "40, Some Street, Leicester, LE1 1AB";
            TestItem.DateOrdered = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Available = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "40, Some Street, Leicester, LE1 1AB";
            TestItem.DateOrdered = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "40, Some Street, Leicester, LE1 1AB";
            TestItem.DateOrdered = DateTime.Now.Date;
            //set thisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderID = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Available = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "40, Some Street, Leicester, LE1 1AB";
            TestItem.DateOrdered = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            //modify the test data
            TestItem.Available = false;
            TestItem.OrderID = 7894;
            TestItem.TotalItem = 5;
            TestItem.TotalPrice = 20.65;
            TestItem.DeliveryAddress = "80, Some Street, Leicester, LE1 1AB";
            TestItem.DateOrdered = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
