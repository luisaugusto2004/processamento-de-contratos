using System.Globalization;

namespace ContractProcessing.Entities
{
    class Installment
    {
        public DateTime dueDate { get; set; }
        public double amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            this.dueDate = dueDate;
            this.amount = amount;
        }

        public override string ToString()
        {
            return dueDate.ToString("dd/MM/yyy") + " - R$" + amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
