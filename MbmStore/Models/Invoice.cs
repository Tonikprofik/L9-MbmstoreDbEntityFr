﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MbmStore.Models
{
    public class Invoice
    {
        private decimal totalPrice;
        public int InvoiceId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime OrderDate { get; set; }

        public decimal TotalPrice
        {
            get
            {
                totalPrice = 0;
                foreach (OrderItem orderItem in OrderItems)
                {
                    totalPrice += orderItem.TotalPrice;
                }
                return totalPrice;
            }
        }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; } = new List<OrderItem>();

        public Invoice()
        {
        }

        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceId;
            OrderDate = orderDate;
            Customer = customer;
        }

        public void AddOrderItem(Product product, int quantity)
        {
            OrderItems.Add(new OrderItem(product, quantity));
        }
    }
}