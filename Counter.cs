using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyBaseCounter
{
    public class Counter
    {
        List<Digit> _number;
        int _base;
        int _numOfDigits;
        public Counter(int basenum, int numOfDigits = 1)
        {
            _number = new List<Digit>();
            _base = basenum;
            for (int i=0; i < numOfDigits; i++)
            {
                Digit newdigit0 = new Digit(_base);
                _number.Add(newdigit0);
            }
        }
        public void Increment(int i = 0)
        {
                if (_number[i].Increment())
                {
                    if (_number[i] == _number.Last())
                    {
                        Digit newdigit = new Digit(_base);
                        _number.Add(newdigit);
                    }
                Increment(i + 1);
                }
        }
        public string Number()
        {
            string temp = "";
            foreach (Digit dig in _number)
            {
                temp += dig.GetDigit();
            }
            temp = Reverse(temp);
            return temp;
        }
        private static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
