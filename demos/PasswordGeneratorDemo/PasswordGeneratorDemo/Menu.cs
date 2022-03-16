using System.Collections.Generic;

namespace PasswordGeneratorDemo
{
    class Menu
    {
        private static char HARD_RULE = '=';
        private List<ICommand> _commands = new List<ICommand>();
        private ConsoleIO _ui;
        private string _name;

        public Menu(string name, ConsoleIO ui)
        {
            _name = name;
            _ui = ui;
        }
        public void AddCommand(ICommand c)
        {
            _commands.Add(c);
        }

        public void Run()
        {
            bool running = true;
            while(running) { 
                DisplayMenu();
                string input = _ui.GetString(":");
                bool commandFound = false;
                foreach (ICommand c in _commands)
                {
                    if (c.Key() == input)
                    {
                        running = c.Execute();
                        commandFound = true;
                        break;
                    }
                }

                if (!commandFound)
                {
                    _ui.Error("Invalid command");
                }
            }
        }
        
        private void DisplayMenu()
        {
            _ui.Display("");
            _ui.Display(_name);
            _ui.Display(new string(HARD_RULE, _name.Length));
            _ui.Display("");
            foreach (ICommand c in _commands)
            {
                _ui.Display($"{c.Key()} - {c.Label()}");
            }
            _ui.Display("");
        }
    }
}
