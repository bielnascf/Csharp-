using System.Globalization;

namespace Exercicios20
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(2022, 08, 31);
            DateTime date3 = DateTime.Today;
            DateTime date4 = DateTime.UtcNow;

            DateTime date5 = DateTime.Parse("2024-01-20");
            DateTime date6 = DateTime.Parse("2000-08-15 14:06:30");
            DateTime date7 = DateTime.Parse("31/08/2002");

            DateTime date8 = DateTime.ParseExact("31-08-2022", "dd-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);
            Console.WriteLine(date5);
            Console.WriteLine(date6);
            Console.WriteLine(date7);
            Console.WriteLine(date8);
        }
    }
}