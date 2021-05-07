using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Test_Framework
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.ItemAvailable = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "1, A Street, LE1 5AB, Leicester";
            TestItem.DateOrdered = DateTime.Now.Date;

            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.ItemAvailable = true;
            TestOrder.OrderID = 1234;
            TestOrder.TotalItem = 10;
            TestOrder.TotalPrice = 15.55;
            TestOrder.DeliveryAddress = "1, A Street, LE1 5AB, Leicester";
            TestOrder.DateOrdered = DateTime.Now.Date;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.ItemAvailable = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "1, A Street, LE1 5AB, Leicester";
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
            TestItem.ItemAvailable = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "1, A Street, LE1 5AB, Leicester";
            TestItem.DateOrdered = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.ItemAvailable = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "1, A Street, LE1 5AB, Leicester";
            TestItem.DateOrdered = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;

            TestItem.ItemAvailable = false;
            TestItem.OrderID = 4567;
            TestItem.TotalItem = 15;
            TestItem.TotalPrice = 17.99;
            TestItem.DeliveryAddress = "2, B Street, LE1 5AB, Leicester";
            TestItem.DateOrdered = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.ItemAvailable = true;
            TestItem.OrderID = 1234;
            TestItem.TotalItem = 10;
            TestItem.TotalPrice = 15.55;
            TestItem.DeliveryAddress = "1, A Street, LE1 5AB, Leicester";
            TestItem.DateOrdered = DateTime.Now.Date;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }
    }
}