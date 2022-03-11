using System;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            string coolified = BuildCoolString(input);

            Console.WriteLine(coolified);
        }

        static string BuildCoolString(string message)
        {
            string output = message == null ? "YOU SENT NULL" : message;

            return "I'm making this cool: " + output;
        }
    }
}
