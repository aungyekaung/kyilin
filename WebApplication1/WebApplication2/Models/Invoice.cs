using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Invoice
    {
        public int Invoice_Id { get; set; }

        public double Total_Price { get; set; }
        public DateTime Date { get; set; }

        public int Staff_Id { get; set; }
        
    }
}