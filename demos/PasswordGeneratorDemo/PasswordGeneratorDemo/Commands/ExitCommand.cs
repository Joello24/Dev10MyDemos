namespace PasswordGeneratorDemo
{
    class ExitCommand : ICommand
    {
        private ConsoleIO _ui;
        public ExitCommand(ConsoleIO ui)
        {
            _ui = ui;
        }
        public bool Execute()
        {
            _ui.Display("Goodbye!");
            return false;
        }

        public string Key()
        {
            return "X";
        }

        public string Label()
        {
            return "Exit";
        }
    }
}
