using System;

namespace PasswordGeneratorDemo
{
    class RandomLetter : IRandomChar
    {
        Random _rng = new Random();
        char[] _chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public char Next()
        {
            bool upper = _rng.Next(1, 3) == 2 ? true : false;
            char result = _chars[_rng.Next(0, _chars.Length)];
            if (upper)
            {
                result = result.ToString().ToUpper()[0];
            }
            return result ;
        }
    }
}
