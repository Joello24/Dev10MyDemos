using DiceStatsDemo.Model;
using DiceStatsDemo.Service;
using DieStatsDemo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceStatsDemo.Controller
{
    class DiceStatsController
    {
        int DiceSides { get; set; }
        int NumDicePerResult { get; set; }
        int NumResults { get; set; }

        ConsoleIO _ui;
        DiceStatsService _service;

        List<DieRollResult> _results;

        public DiceStatsController(int diceSides, int numDicePerResult, int numResults,
                                  ConsoleIO ui, DiceStatsService service)
        {
            DiceSides = diceSides;
            NumDicePerResult = numDicePerResult;
            NumResults = numResults;
            _ui = ui;
            _service = service;
        }

        public void Run()
        {
            _ui.Display("Dice Stats initializing...");
            _ui.Display($"Rolling {NumDicePerResult} {DiceSides} sided dice, {NumResults} times");
            _results = _service.Roll(NumDicePerResult, NumResults);
            _ui.Display("Ready");
            _ui.Display("");

            bool running = true;

            while(running)
            {
                switch(GetMenuChoice())
                {
                    case 1:
                        ViewAllRolls();
                        break;
                    case 2:
                        ViewTopRollStat();
                        break;
                    case 3:
                        ViewRollFrequencies();
                        break;
                    case 4:
                        RemoveARoll();
                        break;
                    case 5: 
                        running = false; // time to quit
                        break;
                    default:
                        _ui.Error("Invalid choice.");
                        break;
                }
            }

        }

        private void RemoveARoll()
        {
            int index = _ui.GetInt("Which roll? ");
            if (index < 0 || index >= _results.Count)
            {
                _ui.Error("Invalid index");
                return;
            }

            _results.RemoveAt(index);
        }

        void ViewAllRolls()
        {
            for (int i = 0; i < _results.Count; i++)
            {
                _ui.Display($"{i}: {_results[i].Sum}");
            }
        }

        void ViewTopRollStat()
        {
            Dictionary<int, int> stats = _service.GetRollStats(_results);
            int mostCommon = _service.FindMostCommonRoll(stats);
            _ui.Display($"The most common die roll was {mostCommon}");
            _ui.Display($"It was rolled {stats[mostCommon]} times");
        }

        void ViewRollFrequencies()
        {
            Dictionary<int, int> stats = _service.GetRollStats(_results);
            List<int> keys = new List<int>(stats.Keys);
            keys.Sort();

            _ui.Display("");

            foreach (int key in keys)
            {
                string bar = new string('=', stats[key]);
                _ui.Display($"{key:D2}:  {bar}");
            }

            _ui.Display("");
        }

        public int GetMenuChoice()
        {
            DisplayMenu();
            return _ui.GetInt("");
        }

        public void DisplayMenu()
        {
            _ui.Display("1. View Rolls");
            _ui.Display("2. View Top Roll Stat");
            _ui.Display("3. Roll Frequencies");
            _ui.Display("4. Remove A Roll");
            _ui.Display("5. Quit");
        }
            
    }
}
