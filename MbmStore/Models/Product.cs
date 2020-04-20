﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models {

    public class Product {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public string Category { get; set; }


        // constructor
        public Product() { }

        // constructor
        public Product(int ProductId, string title, decimal price) {
            ProductId = ProductId;
            Title = title;
            Price = price;
        }
    }
}