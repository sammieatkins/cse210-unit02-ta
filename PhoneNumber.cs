using System;

namespace Cse210_Unit02_Ta
{
    public class PhoneNumber
    {
        public int _areaCode;
        public int _prefix;
        public int _suffix;

        public void DisplayNumber()
        {
            Console.WriteLine($"({_areaCode}) {_prefix}-{_suffix}");
        }

    }
}
