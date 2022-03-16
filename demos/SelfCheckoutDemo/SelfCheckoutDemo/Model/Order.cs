using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckoutDemo
{
    class Order
    {
        public List<LineItem> LineItems = new List<LineItem>();
        public decimal TotalCost {get; set;}
        public decimal SalesTax { get; set; }
        public decimal OrderTotal { get; set; }

        public void AddItem(LineItem li)
        {
            LineItems.Add(li);
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            string title = "   Receipt   ";
            string bars = new string('=', title.Length);

            str.AppendLine(bars);
            str.AppendLine(title);
            str.AppendLine(bars);

            foreach (LineItem li in LineItems)
            {
                str.AppendLine(li.ToString());
            }
            str.AppendLine($"Item Total: {TotalCost.ToString("C")}");
            str.AppendLine($"Sales Tax : {SalesTax.ToString("C")}");
            str.AppendLine($"     Total: {OrderTotal.ToString("C")}");

            return str.ToString();
        }
    }
}
