﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHandWebShop.Models
{
    public class Clothing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountedPrice { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Gender { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public int StockBalance { get; set; }
        public string Weather { get; set; }
        public int SoldMerch { get; set; }

        public Clothing()
        {
            Date = DateTime.Now;
        }

    }
}
