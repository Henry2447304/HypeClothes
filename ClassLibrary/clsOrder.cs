using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public bool Available { get; set; }
        public DateTime DateOrdered { get; set; }
        public int OrderID { get; set; }
        public int TotalItem { get; set; }
        public double TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
    }
}