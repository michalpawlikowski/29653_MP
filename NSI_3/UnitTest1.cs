using Xunit;
using HelloWorld;

namespace Testy
{
    public class UnitTest1
    {
        [Fact]
        public void TestMaksZ2Zliczb2i4Wynik4()
        {
            Dzialania d1 = new Dzialania();
            double wynik = d1.MaksZ2(2, 4);
            Assert.Equal(4, wynik);
        }
        [Fact]
        public void TestMaksZ2Licz2i5Wynik5()
        {
            Dzialania d2 = new Dzialania();
            double wynik2 = d2.MaksZ2(2, 5);
            Assert.Equal(3, wynik2);
        }
        [Fact]
        public void DodawnieLiczb10i3Wynik13()
        {
            Dzialania d3 = new Dzialania();
            double wynik3 = d3.Dodawanie(10, 3);
            Assert.Equal(13, wynik3);
        }
        [Fact]
        public void DodawnieLiczb2i3Wynik5()
        {
            Dzialania d4 = new Dzialania();
            double wynik4 = d4.Dodawanie(2, 3);
            Assert.Equal(4, wynik4);
        }

    }

}