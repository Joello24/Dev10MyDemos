using System.Text;

namespace PasswordGeneratorDemo
{
    class WeakPasswordGeneratorCommand : ICommand
    {
        IRandomChar _rng = new RandomLowerCaseLetter();
        int _length = 8;
        ConsoleIO _ui;
        public WeakPasswordGeneratorCommand(ConsoleIO ui)
        {
            _ui = ui;
        }
        public bool Execute()
        {
            StringBuilder pwd = new StringBuilder();

            for (int i = 0; i < _length; i++)
            {
                pwd.Append(_rng.Next());
            }
            _ui.Display(pwd.ToString());


            return true;
        }

        public string Key()
        {
            return "W";
        }

        public string Label()
        {
            return "Weak Password";
        }
    }
}
