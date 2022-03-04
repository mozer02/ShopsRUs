﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopsRUs.Models
{
    public class Invoice:Entity
    {
        public string InvoiceNumber { get; private set; }
        public string Description { get; private set; }
        public decimal TotalPrice { get; private set; }
        public Discount Discount { get; private set;}

        public Invoice(string description)
        {
            Id = Guid.NewGuid().ToString();
            OnCreatedDate = DateTime.Now;
            Description = description;            
        }
        public void SetInvoiceNumber(int invoiceCount)
        {
            InvoiceNumber = ("TR"+DateTime.Now.ToString("yyyy") + "0000" + invoiceCount);
        }
        public void SetDiscount(Discount discount)
        {
            Discount = discount;
        }
    }
}