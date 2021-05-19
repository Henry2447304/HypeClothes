using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int ProductNo { get; set; }
        public int Cost { get; set; }
        public string ProductDescript { get; set; }
        public int StockNo { get; set; }
        public DateTime DateAdded { get; set; }
        public bool InStck { get; set; }
    }
}