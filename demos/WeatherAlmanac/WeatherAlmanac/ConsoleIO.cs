using System;
using WeatherAlmanac.Core.DTO;

namespace WeatherAlmanac.UI
{
    class ConsoleIO
    {

        public int GetInt(string prompt)
        {
            int result = -1;
            bool valid = false;
            while (!valid)
            {
                Console.Write($"{prompt}: ");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write("~ ");
                if (!int.TryParse(Console.ReadLine(), out result))
                {
                    Error("Please input a proper integer\n\n");
                }
                else
                {
                    valid = true;
                }
            }
            Console.ResetColor();
            return result;
        }
        public string GetString(string prompt)
        {
            string result = "";
            bool valid = false;
            while (!valid)
            {
                Console.Write($"{prompt}: ");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write("~ ");
                result = Console.ReadLine();
                if (string.IsNullOrEmpty(result))
                {
                    Error("Please input a proper string\n\n");
                }
                else
                {
                    valid = true;
                }
            }
            Console.ResetColor();
            return result;
        }
        public DateRecord GetRecord(string prompt)
        {
            bool valid = false;
            DateRecord record = new DateRecord();
            while (!valid)
            {
                record.Description = GetString("Enter Description: ");
                record.Date = GetDate("Enter Date: ");
                record.HighTemp = GetInt("Enter HighTemp: ");
                record.LowTemp = GetInt("Enter LowTemp: ");
                record.Humidity = GetInt("Enter Humidity: ");
                valid = true;
            }
            return record;
        }
        public DateRecord EditRecord(DateRecord record)
        {
            bool valid = false;
            DateRecord ret = new DateRecord();
            while (!valid)
            {
                record.HighTemp = GetInt($"High {record.HighTemp}: ");
                record.LowTemp = GetInt($"Low {record.HighTemp}: ");
                record.Humidity = GetInt($"Humidity {record.Humidity}: ");
                Display($"Old Description: {record.Description}");
                Display($"New Description: ");
                record.Description = Console.ReadLine();
                
                valid = true;
            }
            return record;
        }
        public DateTime GetDate(string prompt)
        {
            while (true)
            {
                Console.Write($"{prompt}: ");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write("~ ");
                if (!DateTime.TryParse(Console.ReadLine(), out DateTime result))
                {
                    Error("Please input a proper date\n\n");
                }
                else
                {
                    Console.ResetColor();
                    return result;
                }
            }
        }
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Display(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void Warn(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Display(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
