namespace MyCSharpApplication
{
    public class BankAccount
    {
        public int id;
        public decimal balance;
        public int Id { get; set; }
        public decimal Blance { get; set; }
        public static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");

            }
            else
            {
                BankAccount acc = new BankAccount();
                acc.Id = id;
                accounts.Add(id, acc);
            }
        }
        public static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");

            }
            else
            {
                accounts[id].Blance = amount;
            }
        }
        public static void Withdraw(string[]cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[2]);
            decimal amount = decimal.Parse(cmdArgs[2]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");

            }
            else if (amount> accounts[id].Blance)
            {
                Console.WriteLine("Insuddicient balance");

            }
            else
            {
                accounts[id].Blance = amount;
            }
        }
        public static void Print(string[]cmdArgs, Dictionary<int, BankAccount> accounts)
        {
            int id = int.Parse(cmdArgs[1]);
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");

            }
            else
            {
                Console.WriteLine($"Account ID{accounts[id].Id},balance {accounts[id].Blance:f2}");
            }
        }
    }
}