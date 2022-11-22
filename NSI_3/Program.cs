using System; 
namespace HelloWorld
{
    public class Dzialania
    {
        public double MaksZ2(double a, double b)
        {
            if (a > b)
            {
                return a;
            }
            else if (b > a)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        public double Dodawanie(double a, double b)
        {
            return a + b;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Michał Pawlikowski");
        }
    }
}