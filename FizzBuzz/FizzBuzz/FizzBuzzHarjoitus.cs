using System;

namespace FizzBuzzHarjoitus
{
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string Luku(int syöte)
        {
            if (JaollinenKOlmellaJaViidellä(syöte))
            {
                return "FizzBuzz";
            }
            if (JaollinenKolmella(syöte))
            {
                return "Fizz";
            }

            if (JaollinenViidellä(syöte))
            {
                return "Buzz";
            }

            return syöte.ToString();
        }

        private bool JaollinenKOlmellaJaViidellä(int syöte)
        {
            return JaollinenKolmella(syöte) && JaollinenViidellä(syöte);
        }

        private bool JaollinenKolmella(int syöte)
        {
            return syöte % 3 == 0;
        }

        private bool JaollinenViidellä(int syöte)
        {
            return syöte % 5 == 0;
        }
    }
}