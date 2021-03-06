﻿namespace MbmStore.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int InvoiceId { get; set; }

        public decimal TotalPrice { get { return Quantity * Product.Price; } }

        public OrderItem()
        {
        }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}