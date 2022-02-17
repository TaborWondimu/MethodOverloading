using System;
namespace MethodOverloading
{
 class program
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y,bool isTrue)
        {
           var sum = x + y;

            if (isTrue == true && sum == 1) 
            {
                return sum + " Dollar ";
            }
           else if (isTrue == true && sum > 1)
            {
                return sum + " Dollars ";
            }
            else if (isTrue == true  && sum < 1)
            {
                return sum + " Dollars ";
            }
            else
            {
                return sum.ToString();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 5));
            Console.WriteLine(Add(45.52m, 60.35m));
            Console.WriteLine(Add(0, 1, true));
            Console.WriteLine(Add(1, 2, false));

        }
    }
}