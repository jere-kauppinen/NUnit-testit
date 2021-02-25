using FizzBuzzHarjoitus;
using NUnit.Framework;

namespace FizzBuzzTests
{
    public class FizzBuzzTests
    {
        FizzBuzz _fizzBuzz = null;

        [SetUp]
        public void Setup()
        {
            _fizzBuzz = new FizzBuzz();
        }

        [Test]
        public void LuodaanFizzBuzzLuokka()
        {
            Assert.IsInstanceOf<FizzBuzz>(_fizzBuzz);
        }

        [Test]
        public void TulostaSy�tteen�AnnettuYksi()
        {
            string vastaus = _fizzBuzz.Luku(1);
            Assert.AreEqual("1", vastaus);
        }

        [Test]
        public void TulostaSy�tteen�AnnettuKaksi()
        {
            string vastaus = _fizzBuzz.Luku(2);
            Assert.AreEqual("2", vastaus);
        }

        [Test]
        public void FizzJaollinenKolmella()
        {
            string vastaus = _fizzBuzz.Luku(3);
            Assert.AreEqual("Fizz", vastaus);
        }

        [Test]
        public void BuzzJaollinenViidell�()
        {
            string vastaus = _fizzBuzz.Luku(5);
            Assert.AreEqual("Buzz", vastaus);
        }

        [Test]
        public void TulostaSy�tteen�AnnettuKuusi()
        {
            string vastaus = _fizzBuzz.Luku(6);
            Assert.AreEqual("Fizz", vastaus);
        }

        [Test]
        public void FizzBuzzJaollinenViidell�JaKolmella()
        {
            string vastaus = _fizzBuzz.Luku(15);
            Assert.AreEqual("FizzBuzz", vastaus);
        }

    }
}