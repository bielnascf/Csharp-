using Exercicios39.Entities;
using Exercicios39.Services;
using System.Globalization;

namespace Exercicios39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");

            Console.Write("Car model: ");
            string model = Console.ReadLine();

            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return (dd/MM/yyyy): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Price per Hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Price Per Day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay);

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("Invoice");
            Console.WriteLine(carRental.Invoice);

        }
    }
}