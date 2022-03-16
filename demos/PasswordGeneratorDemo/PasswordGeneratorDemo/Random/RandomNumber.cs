using System;

namespace PasswordGeneratorDemo
{
    class RandomNumber : IRandomChar
    {
        Random _rng = new Random();
        char[] _chars = { '1','2','3','4','5','6','7','8','9','0' };
        public char Next()
        {
            return _chars[_rng.Next(0, _chars.Length)];
        }
    }
}
