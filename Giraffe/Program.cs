using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {

            int numResult = GetMax(5, 2);

            Console.WriteLine(numResult);

            Console.ReadLine();

        }

      static int GetMax(int num1, int num2)
        {
            int result = 0;

            if (num1 > num2)
            {
                result = num1;
            } else if (num1 < num2)
            {
                result = num2;
            }

            return result;
        }

    }
}
