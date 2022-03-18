using RoomCalculator.Services;
using RoomCalculator.Views;
using RoomCalculator.Workflows;
using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleIO ui = new ConsoleIO();
            WallpaperService service = new WallpaperService();

            ui.Display("Room Calculator");
            ui.Display("Running tests...");
            TestCases tc = new TestCases();
            if (tc.Run())
            {
                ui.Display("All tests passed.  Proceeding.");
            } else
            {
                ui.Error("Failed tests.  Aborting.");
                Environment.Exit(-1);
            }

            Workflow w = new Workflow(ui, service);
            w.Run();
        }
    }
}
