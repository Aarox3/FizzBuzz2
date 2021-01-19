using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{
    public class FizzBuzz
    {
        public void AnalyzeNumber(int userNumber)
        {

            if (userNumber % 5 == 0 && userNumber % 3 == 0)
            {

                Console.WriteLine("FizzBuzz");
            }
            else if (userNumber % 3 == 0)
            {

                Console.WriteLine("Fizz");
            }
            else if (userNumber % 5 == 0)
            {

                Console.WriteLine("Buzz");
            }

            else
            {
                Console.WriteLine(userNumber);
            }
        }

    }
}

