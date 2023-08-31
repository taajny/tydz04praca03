using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tydz04praca02
{
    internal class FizzBuzz
    {
        public string Play(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
                return "FizzBuzz";
            else if (number % 5 == 0)
                return "Buzz";
            else if (number % 3 == 0)
                return "Fizz";
            else
                return number.ToString();
        }
    }
}
