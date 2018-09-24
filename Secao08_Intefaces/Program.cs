using Secao08_Intefaces.Entities;
using Secao08_Intefaces.Service;
using System;
using System.Globalization;

namespace Secao08_Intefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter rental data");
                Console.Write("Car model: ");
                string model = Console.ReadLine();

                Console.Write("Pickup (dd/MM/yyyy hh:mm):");
                DateTime pichkup = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);
                Console.Write("Return (dd/MM/yyyy hh:mm):");
                DateTime Return = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

                Console.Write("Enter price per hour: ");
                double PerHora = double.Parse(Console.ReadLine());


                Console.Write("Enter price per day: ");
                double PerDay = double.Parse(Console.ReadLine());


                CarRental carRental = new CarRental(pichkup, Return, new Vehicle(model));


                RentalService rentalService = new RentalService(PerHora, PerDay, new BrazilTaxService());

                rentalService.ProcessInvoice(carRental);

                Console.WriteLine("INCOICE");
                Console.WriteLine(carRental.Invoice);


                

                Console.WriteLine();

                Console.WriteLine("Pressione qualquer tecla para continuar.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Retornou um erro inesperado" + e.Message); 
            }
        }
    }
}
