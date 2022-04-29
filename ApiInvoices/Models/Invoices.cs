﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiInvoices.Models
{
    public class Invoices
    {
        [Key]
        public int id { get; set; }
        public string items { get ; set; }
        public double tax { get; set; }
        public double subtotal { get; set; }
        public double total { get; set; }
        public DateTime invoiceDate { get; set; }


    }
}

