using Exercicios45.Entities;

namespace Exercicios45
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client("Gabriel", "gabriel@gmail.com");

            Client b = new Client("Matthew", "matthew@gmail.com");

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
        }
    }
}