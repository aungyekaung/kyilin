using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Promotion
    {
        public int ID { get; set; }

        public double Price { get; set; }
        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }
    }
}