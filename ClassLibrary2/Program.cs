
namespace MyCSharpApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] commands = Console.ReadLine()
                .Split("", StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.ToLower())
                .ToArray();
            Dictionary<int, BankAccount> account = new Dictionary<int, BankAccount>();
            while (commands[0] != "end")
            {
                if (commands[0] == "create")
                {
                    BankAccount.Create(commands, account);
                }
                else if (commands[0] == "deposit")
                {
                    BankAccount.Deposit(commands, account);

                }
                else if (commands[0] == "Withdraw")
                {
                    BankAccount.Withdraw(commands, account);
                }
                else if (commands[0] == "print")
                {
                    BankAccount.Print(commands, account);
                }
                commands = Console.ReadLine()
                    .Split("", StringSplitOptions.RemoveEmptyEntries)
                    .Select(e => e.ToLower())
                    .ToArray();
            }

        }
    }
}
