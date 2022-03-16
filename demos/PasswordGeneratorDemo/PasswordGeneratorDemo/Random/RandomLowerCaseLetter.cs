using System;

namespace PasswordGeneratorDemo
{
    class RandomLowerCaseLetter : IRandomChar
    {
        Random _rng = new Random();
        char[] _chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public char Next()
        {
            return _chars[_rng.Next(0, _chars.Length)];
        }
    }
}
