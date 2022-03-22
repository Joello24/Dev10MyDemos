using DiceStatsDemo.Controller;
using DiceStatsDemo.Service;
using DieStatsDemo.View;
using System;

namespace DiceStatsDemo
{
    class Program
    {
        const int DiceSides = 6;
        const int NumDicePerResult = 2;
        const int NumResults = 100;

        static void Main(string[] args)
        {
            ConsoleIO ui = new ConsoleIO();
            DiceStatsService svc = new DiceStatsService(DiceSides);
            DiceStatsController controller = 
                new DiceStatsController(DiceSides, NumDicePerResult, 
                                        NumResults, ui, svc);

            controller.Run();
        }
    }
}
