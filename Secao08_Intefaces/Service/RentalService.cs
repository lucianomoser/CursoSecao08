using Secao08_Intefaces.Entities;
using System;

namespace Secao08_Intefaces.Service
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();
        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            
            TimeSpan duration =  carRental.Finish.Subtract(carRental.Start);
            double basicPagamenty = 0;

            if (duration.TotalHours <= 12 )
            {
                basicPagamenty = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPagamenty = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _brazilTaxService.Tax(basicPagamenty);

            carRental.Invoice = new Invoice(basicPagamenty, tax);
        }
    }
}
