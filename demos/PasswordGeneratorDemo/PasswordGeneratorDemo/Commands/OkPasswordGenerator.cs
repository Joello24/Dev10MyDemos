using System.Text;

namespace PasswordGeneratorDemo
{
    class OkPasswordGeneratorCommand : ICommand
    {
        IRandomChar _rng = new RandomLetter();
        int _length = 8;
        ConsoleIO _ui;
        public OkPasswordGeneratorCommand(ConsoleIO ui)
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
            return "O";
        }

        public string Label()
        {
            return "OK Password";
        }
    }
}
