using System;

namespace DieRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleIO io = new ConsoleIO();
            DieService ds = new DieService(new Random());

            DieController controller = new DieController(io, ds);

            controller.run();
        }
    }
}
