
namespace SelfCheckoutDemo
{
    class Controller
    {
        ConsoleIO _ui;
        Configuration _config;

        public Controller(ConsoleIO ui, Configuration config)
        {
            _ui = ui;
            _config = config;
        }

        public void Run() 
        {
            bool running = true;
            while(running)
            {
                Order order = new Order();
                running = CollectLineItems(order);
                
                if (running)
                {
                    FinalizeOrder(order);
                    _ui.Display(order.ToString());
                }
            }
        }

        bool CollectLineItems(Order order)
        {
            bool collecting = true;

            while (collecting)
            {
                string input = _ui.GetString("Enter Price (or 0 to quit collecting, or Q to quit app)");
                if (input.ToUpper() == "Q")
                {
                    return false;
                }

                decimal price;
                if (!decimal.TryParse(input, out price)) {
                    _ui.Error("Price must be a valid decimal");
                    continue;
                }

                if (price == 0)
                {
                    return true;
                }

                int quantity = _ui.GetInt("Enter Quantity");
                LineItem li = new LineItem();
                li.Price = price;
                li.Quantity = quantity;

                order.AddItem(li);
            }

            return true;
        }

        private void FinalizeOrder(Order order)
        {
            decimal total = 0m;
            foreach (LineItem li in order.LineItems)
            {
                total += li.Price * li.Quantity;
            }
            order.TotalCost = total;
            order.SalesTax = total * _config.SalesTax;
            order.OrderTotal = total + order.SalesTax;
        }
    }
}
