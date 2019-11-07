using System.Runtime.InteropServices;

namespace quicktestproject
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            var result = x + y;
            return result;
        }

        public int Subtract(int x, int y)
        {
            var result = x - y;
            return result;
        }
    }
}