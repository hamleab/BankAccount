namespace Classes
{
    public class GiftCardAccount : BankAccount
    {
        public GiftCardAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
        }

        private readonly decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                Deposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}