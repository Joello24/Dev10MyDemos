using System;

namespace PasswordGeneratorDemo
{
    class RandomSpecialChar : IRandomChar
    {
        Random _rng = new Random();
        char[] _chars = { '!','@','#','$','%','^','&','*','(',')','-','=' };
        public char Next()
        {
            return _chars[_rng.Next(0, _chars.Length)];
        }
    }
}
