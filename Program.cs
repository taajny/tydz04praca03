using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tydz04praca02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzObject = new FizzBuzz();
            int number = 0;
            string choise = "";
            char character;

            Console.WriteLine("Witaj w grze Fizz Buzz. Zaczynamy");
            
            while (true)
            {
                number = GetNumber();
                Console.WriteLine($"\nWynik naszej gry to: {fizzBuzzObject.Play(number)}");

                while (true)
                {
                    
                    Console.WriteLine("\nCzy chcesz zagrać jeszcze raz [T/N]");
                    if (string.IsNullOrWhiteSpace(choise = Console.ReadLine()))
                    {
                        Console.WriteLine("\nPodałeś niepoprawne dane.");
                        continue;
                    }
                    choise = choise.ToUpper();
                    character = (char)choise[0];

                    if (character != 'T' && character != 'N')
                    {
                        Console.WriteLine("\nPodałeś niepoprawne dane.");
                        continue;
                    }
                    else
                        break;
                }
                if (character == 'N')
                    break;
            }
            Console.ReadLine();
        }
        private static int GetNumber()
        {
            while (true)
            {
                Console.WriteLine("\nPodaj proszę liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out var number))
                {
                    Console.WriteLine("\nPodałeś niepoprawne dane. Podaj proszę liczbę.");
                    continue;
                }
                else
                    return number;
            }
            
        }
    }
}
