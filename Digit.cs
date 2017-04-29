using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyBaseCounter
{
    public class Digit
    {
        private int _base;
        private int _digit;


        public Digit(int basenum)
        {
            if (basenum > 10){ _base = 64 + (basenum - 10); }
            else { _base = 47 + basenum;}
            _digit = 48; 
            //(char)48 = '0'
            //(char)65 = 'A' (char)97 = 'a'
        }
        public bool Increment()
        {
            _digit++;
            if (_digit == (_base + 1))
            {
                Reset();
                return true;
            }
            if (_digit == 58)
            {
                _digit = 65;
            }
            return false;
        }
        public void Reset()
        {
            _digit = 48;
        }
        public char GetDigit()
        {
            return (char)(_digit);
        }
    }

}
