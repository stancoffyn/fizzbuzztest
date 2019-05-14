using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzztest
{
    class Program
    {
        static void Main(string[] args)
        {
            //this was originally designed to be fizzBuzz in as few lines as possible as an experiment
            //i've made a small conversion for readability, however the original two line option may
            //be used from below
            var fizzBuzz = Enumerable.Range(1, 100)
                .Select(i => {
                    var isFizz = i % 3 == 0;
                    var isBuzz = i % 5 == 0;
                    return $"{(!isFizz && !isBuzz ? i.ToString() : "")}{(isFizz ? "Fizz" : "")}{(isBuzz ? "Buzz" : "")}";
                });

            Console.WriteLine(String.Join("\r\n", fizzBuzz.ToArray()));
            //ShortenedFizzBuzz();
        }

        public static void ShortenedFizzBuzz()
        {
            var fizzBuzz = Enumerable.Range(1, 100).Select(i => { var isFizz = i % 3 == 0; var isBuzz = i % 5 == 0; return $"{(!isFizz && !isBuzz ? i.ToString() : "")}{(isFizz ? "Fizz" : "")}{(isBuzz ? "Buzz" : "")}";});
            Console.WriteLine(String.Join("\r\n", fizzBuzz.ToArray()));
        }
    }
}
