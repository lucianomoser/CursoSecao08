using System.Globalization;
namespace Secao08_Intefaces.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            this.BasicPayment = basicPayment;
            this.Tax = tax;
        }
        public double TotalPayment
        { get
            {
                return BasicPayment + Tax;
            }
        }

        public override string ToString()
        {
            return "INVOICE: " +
                " Basic payment: "+ BasicPayment.ToString("F2", CultureInfo.InvariantCulture) +
                " Tax: " + Tax.ToString("F2",  CultureInfo.InvariantCulture) +
                " Total payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
