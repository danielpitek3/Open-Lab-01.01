using System;

namespace Open_Lab_01._01
{
    public class Exercise
    {
        public bool IsLessThan10(string input)
        {
            int tst = int.Parse(input);
            if (tst < 10)
            {
                return true;
            }
            else
                return false;
        }
    }
}
