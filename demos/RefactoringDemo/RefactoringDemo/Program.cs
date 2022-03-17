using System;

namespace RefactoringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============");
            Console.WriteLine("Tip Calculator");
            Console.WriteLine("==============");
            Console.WriteLine();

            if (!TestTipCalulation())
            {
                Console.WriteLine("Aborting, fix your code!!");
                Environment.Exit(0);
            }

            Console.Write("How much was your bill without tax? ");
            decimal bill = decimal.Parse(Console.ReadLine());
            Console.WriteLine("How good was the service?");
            Console.WriteLine("A - Incredible");
            Console.WriteLine("B - Good");
            Console.WriteLine("C - OK");
            Console.WriteLine("D - Bad");
            Console.WriteLine("F - Terrible");
            Console.Write(":");
            string input = Console.ReadLine();
            decimal tip = 0;
            if (input == "A")
            {
                tip = .30m;
            }

            if (input == "B")
            {
                tip = .20m;
            }

            if (input == "C")
            {
                tip = .15m;
            }

            if (input == "D")
            {
                tip = .10m;
            }

            if (input == "F")
            {
                tip = .05m;
            }

            if (tip == 0)
            {
                Console.WriteLine("You didn't enter a valid selection");
            }
            else
            {
                Console.WriteLine($"Tip: {bill * tip}");
                Console.WriteLine($"Total: {bill + tip}");
            }

        }

        public static decimal GetTip(decimal bill, decimal tipPtc)
        {
            return bill * tipPtc;
        }

        public static bool TestTipCalulation()
        {
            bool result = false;

            decimal testBill = 100.00m;
            decimal testTipPct = .10m;
            decimal expectedTip = 10.00m;
            decimal actual = GetTip(testBill, testTipPct);
            if ( actual == expectedTip)
            {
                Console.WriteLine("TestTip:  Passed");
                result = true;
            } else
            {
                Console.WriteLine($"TestTip:  FAILED: Expected {expectedTip}, got {actual}");
                result = false;
            }

            return result;

        }
    }
}
