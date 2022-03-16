using System;
using System.Text;


namespace PasswordGeneratorDemo
{
    class StrongPasswordGeneratorCommand : ICommand
    {
        ConsoleIO _ui;
        Random _rng = new Random();
        IRandomChar _letter = new RandomLetter();
        IRandomChar _number = new RandomNumber();
        IRandomChar _special = new RandomSpecialChar();
        int _length = 8;

        public StrongPasswordGeneratorCommand(ConsoleIO ui)
        {
            _ui = ui;
        }
        public bool Execute()
        {
            StringBuilder pwd = new StringBuilder();

            for (int i = 0; i < _length; i++)
            {
                switch(_rng.Next(1, 4))
                {
                    case 1:
                        pwd.Append(_letter.Next());
                        break;
                    case 2:
                        pwd.Append(_number.Next());
                        break;
                    case 3:
                        pwd.Append(_special.Next());
                        break;
                }
            }
            _ui.Display(pwd.ToString());


            return true;
        }

        public string Key()
        {
            return "S";
        }

        public string Label()
        {
            return "Strong Password";
        }
    }
}
