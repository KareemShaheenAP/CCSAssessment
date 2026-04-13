using System.ComponentModel;
using System.Security.Principal;
using System.Text;

namespace ATM_Banking_System
{
    internal class Program
    {
        enum AtmMainMenu
        {
            [Description("Create Account")] CreateAccount,
            Login
        }
        enum AtmSecondMenu
        {
            Deposit,
            [Description("Withdraw Money")] WithdrawMoney,
            [Description("Check Balance")] CheckBalance,
            [Description("View Transaction History")] ViewTransactionHistory,
            Exit
        }
        static double DepositeMoney(ref double accBalance, double amount)
        {
            accBalance += amount;
            return accBalance;
        }
        static double WithdrawMoney(ref double accBalance, double amount)
        {
            accBalance -= amount;
            return accBalance;
        }
        static bool LoginValidation(Dictionary<string, int> userAccount, string userAccNum)
        {
            if (userAccount.ContainsKey(userAccNum))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            var myEnumMemberCount = Enum.GetNames(typeof(AtmMainMenu)).Length;
            var myEnumMemberCount2 = Enum.GetNames(typeof(AtmSecondMenu)).Length;
            var userAccount = new Dictionary<string, int>();
            double accBalance = 0;
            StringBuilder stringBuilder = new StringBuilder();
            while (true)
            {
                for (int i = 0; i < myEnumMemberCount; i++)
                {
                    Console.WriteLine($"{i + 1}- {(AtmMainMenu)i}");
                }
                Console.WriteLine("===========================");
                Console.WriteLine("Please enter your choise");

                int userEnrty = int.Parse(Console.ReadLine());
                string? userAccNum;
                
                switch (userEnrty)
                {
                    case 1:
                        Random randomAccNum = new Random();
                        userAccNum = randomAccNum.Next(1, 1000000000).ToString("D10");
                        Console.WriteLine("Please enter 4 digit pin");
                        int accPin = int.Parse(Console.ReadLine());
                        userAccount[userAccNum] = accPin;
                        Console.WriteLine($"Account generated \t Account number is {userAccNum} \t Pin code is {accPin}");
                        Console.WriteLine("===========================");
                        break;
                    case 2:
                        Console.WriteLine("Please enter account number");
                        userAccNum = Console.ReadLine();

                        if (!LoginValidation(userAccount, userAccNum) == true)
                        {
                            Console.WriteLine("Invalid Account Number");
                            Console.WriteLine("===========================");
                            continue;
                        }

                        Console.WriteLine("Please enter 4 digit pin code");
                        Console.WriteLine("===========================");
                        accPin = int.Parse(Console.ReadLine());
                        if (userAccount[userAccNum] != accPin)
                        {
                            Console.WriteLine("Invalid Pin code");
                            Console.WriteLine("===========================");
                            continue;
                        }

                        for (int i = 0; i < myEnumMemberCount2; i++)
                        {
                            Console.WriteLine($"{i + 1}- {(AtmSecondMenu)i}");
                        }

                        Console.WriteLine("Please enter your choise");
                        Console.WriteLine("===========================");
                        userEnrty = int.Parse(Console.ReadLine());
                        double transactionMoney = 0;
                        
                        switch (userEnrty)
                        {
                            case 1: //Deposite
                                Console.WriteLine("Please enter your amount");
                                transactionMoney = int.Parse(Console.ReadLine());
                                if (transactionMoney > 0)
                                {
                                    DepositeMoney(ref accBalance, transactionMoney);
                                    Console.WriteLine($"Transaction added by {transactionMoney} \t Account Balance is {accBalance}");
                                    Console.WriteLine("===========================");
                                    stringBuilder.AppendLine($"Deposite amount with {transactionMoney} On {DateTime.Now}");
                                }
                                break;
                            case 2: // Withdraw
                                Console.WriteLine("Please enter your amount");
                                transactionMoney = int.Parse(Console.ReadLine());
                                if (transactionMoney > 0 && accBalance > transactionMoney)
                                {
                                    WithdrawMoney(ref accBalance, transactionMoney);
                                    Console.WriteLine($"Transaction added by -{transactionMoney} \t Account Balance is {accBalance}");
                                    Console.WriteLine("===========================");
                                    stringBuilder.AppendLine($"Withdraw amount with {transactionMoney} On {DateTime.Now}");
                                }
                                break;
                            case 3: // Check Balance
                                Console.WriteLine($"Account balance now is {accBalance}");
                                Console.WriteLine("===========================");
                                break;
                            case 4: // Transaction history
                                Console.WriteLine(stringBuilder.ToString());
                                Console.WriteLine("===========================");
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
