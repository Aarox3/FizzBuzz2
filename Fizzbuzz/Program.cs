using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizzbuzz
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            while (true)
            {


                try
                {
                    Console.WriteLine("Zagrajmy w grę. Grę o nazwie FizzBuzz. Wpisz proszę dowolną liczbę");

                    var userNumber = int.Parse(Console.ReadLine());

                    var fizzbuzz = new FizzBuzz();

                    fizzbuzz.AnalyzeNumber(userNumber);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Podana wartość jest nieprawidłowa, spróbuj jeszcze raz.");
                }
            }
        }
    }
}

