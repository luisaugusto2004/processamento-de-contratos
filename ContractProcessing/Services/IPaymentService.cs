namespace ContractProcessing.Services
{
    interface IPaymentService
    {
        public double Interest(double amount, int months);
        public double Fees(double amount);
    }
}
