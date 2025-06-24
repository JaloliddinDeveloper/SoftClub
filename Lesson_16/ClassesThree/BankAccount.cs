namespace Lesson_16.ClassesThree
{
    internal class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string Owner { get; set; }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BankAccount(string accountNumber, string owner, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.Owner = owner;
            this.Balance = balance;
        }

        public void TopUp(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance == 0)
            {
                Console.WriteLine("Balance null");
            }

            Balance -= amount;

            Console.Write("Thank you");
        }

        public void PrintStatement()
        {
            string show = $" Your balance: {this.Balance} " +
                          $" Your name is {this.Owner} "+
                          $" Your AccountNumber: {this.AccountNumber}";

            Console.WriteLine(show);
        }
    }
}
