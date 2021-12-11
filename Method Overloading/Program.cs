using System;

namespace Method_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x,  decimal y)
        {
            return (int)x + y;
        }
        public static string Add(int x, int y, bool drink)
        {
            if (drink && x + y != 1)
            {
                return $"{x + y} dollars";
            }
            else if (drink && x + y == 1) ; 
            {
                return $"{x + y} dollar";
            }
            else

            { return x + y.ToString(); 

            }

            
            } 
        }
}
