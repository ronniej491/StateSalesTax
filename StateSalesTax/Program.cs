using System;
using System.Collections.Generic;
using System.Linq;

namespace StateSalesTax
{
    public class Program
    {


        static void Main(string[] args)
        {


            //Query and buld a new list of items and group together items with matcjing items
            List<InvoiceItems> invoice = new List<InvoiceItems>();
            var invoiceItems = InvoiceItems.GetInvoice()
                .Where(i => i.InvoiceId == 105942)
                .GroupBy(i => new { i.InvoiceId, i.Item })
                .Select(n => new InvoiceItems()
                {
                    InvoiceId = 105942,
                    Qty = n.Sum(c => c.Qty),
                    Item = n.Select(x => x.Item).FirstOrDefault().ToString(),
                    Price = n.Sum(c => c.Price),
                    Ext = n.Sum(c => c.Ext),


                }).ToList();


            //foreach grouped product build a new list of group matching items
            foreach (var items in invoiceItems)
            {
                invoice.Add(new InvoiceItems()
                {
                    InvoiceId = items.InvoiceId,
                    Qty = items.Qty,
                    Item = items.Item,
                    Price = (items.Price / items.Qty),
                    Ext = items.Ext


                }

            );

            }


            //Write to the console table heading
            Console.WriteLine($"" +
           $" Invoice# | " +
           $" Qty |" +
           $" Item      |" +
           $" Price |" +
           $" Ext   |" +
           $" Sales Taxes |" +
           $" Total | ");
            Console.WriteLine("====================================================================");


            //Loop through all grouped items and add to comsole
            foreach (var items in invoice)
            {



                Console.WriteLine($"" +
                  $" {items.InvoiceId + 1 }   | " +
                  $" {items.Qty }   |" +
                  $" {items.Item} |" +
                  $" {(items.Price)}  |" +
                  $" {(items.Ext) } |" +
                  $"             |" +
                  $" {items.Ext} | "


              );
                Console.WriteLine("===================================================================="


           );

            }

            //Loop add total values to get accurate price for items to be paid
            Console.WriteLine($"" +
              $" Total    |" +
              $"  {invoice.Sum(c => c.Qty) }" +
              $"             " +
              $"           " +
              $" {invoice.Sum(c => c.Ext) } " +
              $"    {invoice.Sum(c => c.Ext) * 0.06m:N}" +
              $"        {invoice.Sum(c => c.Ext) + invoice.Sum(c => c.Ext) * 0.06m:N} ");

        }
    }
}

