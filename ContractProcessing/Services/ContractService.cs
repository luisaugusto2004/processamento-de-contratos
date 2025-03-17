using ContractProcessing.Entities;

namespace ContractProcessing.Services
{
    class ContractService
    {
        public IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double installmentValue = 0.0;

            installmentValue = contract.TotalValue / months;

            for (int i = 1; i <= months; i++)
            {
                double interest = _paymentService.Interest(installmentValue, i);
                double installmentWithInterest = installmentValue + interest;
                double fees = _paymentService.Fees(installmentWithInterest);
                double totalValue = installmentWithInterest + fees;

                contract.Installments.Add(new Installment(contract.Date.AddMonths(i), totalValue));
            }
        }
    }
}
