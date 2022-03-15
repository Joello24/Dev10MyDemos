using System;

namespace ClassDesignDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = new Task();
            t.Description = "This is a new task!"; //t.setDescription("This is a new Task!");
            t.IsComplete = false;

            Console.WriteLine(t.Description);  //t.getDescription();
            Console.WriteLine(t.IsComplete);
        }
    }
}
