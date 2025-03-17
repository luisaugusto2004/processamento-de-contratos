namespace ContractProcessing.Services
{
    class PayPalService : IPaymentService
    {

        public double Interest(double amount, int months)
        {
            return amount * 0.01 * months;
        }

        public double Fees(double amount)
        {
            return amount * 0.02;
        }
    }
}
