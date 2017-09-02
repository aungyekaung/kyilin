using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Item
    {
        public int Item_Id { get; set; }

        public string Item_Name { get; set; }
        public double Price { get; set; }

        public byte Photo { get; set; }
        public int Category_Id { get; set; }
        public int Promotion_Id { get; set; }

    }
}