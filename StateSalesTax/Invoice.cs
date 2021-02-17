using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StateSalesTax
{
    //Class to handale total invoice calculations for all items
    public class Invoice
    {
        public int InvoiceId { get; set; }

        public decimal Ext  { get; set; }
        public decimal SalesTaxes { get; set; }
        public decimal Total { get; set; }
        public int Qty { get; set; }
        public InvoiceItems InvoiceItems { get; set; }

    }

    //Class to handlw items being addes to a list of items
    public class InvoiceItems
    {
        [Key]
        public int InvoiceId { get; set; }
        public int Qty { get; set; }
        public string Item { get; set; }
        public decimal Price { get; set; }

        public decimal Ext { get; set; }
        public decimal SalesTaxes { get; set; }

        public decimal Total { get; set; }

      

        public static List<InvoiceItems> GetInvoice()
        {

            //Add example data to list 
            List<InvoiceItems> denominations = new List<InvoiceItems>()
                {
                  new InvoiceItems() {InvoiceId = 105942, Qty = 1, Item = "Blue Pens", 
                      Price = 1.75m, Ext = 1.75m, SalesTaxes = 0.11m, Total = 1.86m },
                  new InvoiceItems() {InvoiceId = 105942, Qty = 1, Item = "Blue Pens", 
                      Price = 1.75m, Ext = 1.75m, SalesTaxes = 0.11m, Total = 1.86m },
                  new InvoiceItems() {InvoiceId = 105942, Qty = 1, Item = "Blue Pens", 
                      Price = 1.75m, Ext = 1.75m, SalesTaxes = 0.11m, Total = 1.86m },
                  new InvoiceItems() {InvoiceId = 105942, Qty = 1, Item = "Blue Pens", 
                      Price = 1.75m, Ext = 1.75m, SalesTaxes = 0.11m, Total = 1.86m },
                  new InvoiceItems() {InvoiceId = 105942, Qty = 1, Item = "Blue Pens", 
                      Price = 1.75m, Ext = 1.75m, SalesTaxes = 0.11m, Total = 1.86m },
                  new InvoiceItems() {InvoiceId = 105942, Qty = 1, Item = "Blue Pens", 
                      Price = 1.75m, Ext = 1.75m, SalesTaxes = 0.11m, Total = 1.86m },

                  




                };

            return denominations;
        }
      }
    }
