using System;

namespace FizzBuzzHarjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on FizzBuzz-ohjelma");
            Console.WriteLine("Anna luku 1-100.");
            int käyttäjänsyöte = int.Parse(Console.ReadLine());

            var fizzBuzz = new FizzBuzz();
            var vastaus = fizzBuzz.Luku(käyttäjänsyöte);

            Console.WriteLine();
            Console.WriteLine(vastaus);


            Console.ReadKey();
        }
    }
}
