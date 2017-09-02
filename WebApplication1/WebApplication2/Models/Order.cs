using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Order
    {
        public int Order_Id { get; set; }

        public int Item_Id { get; set; }
        public int  Table_Id { get; set; }

        public int Invoice_Id { get; set; }

        public int Staff_Id { get; set; }
        public DateTime Date { get; set; }
        public int Qty { get; set; }
        public string Remark { get; set; }

    }
}