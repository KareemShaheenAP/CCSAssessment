namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Assessment
            //Assessment-simple Calculator
            Console.WriteLine("Assessment-simple Calculator");
            Console.WriteLine("============================");
            double FirstEntryInt, SecondEntryInt;
            Console.WriteLine("Please enter first number");
            var FirstEntry = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            var SecondEntry = Console.ReadLine();
            Console.WriteLine("Please enter mathermatical operation");
            string MathOperation;
            MathOperation = Console.ReadLine();

            switch (MathOperation)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    break;
                default:
                    Console.WriteLine("Please enter a valid mathermatical operator");
                    return;
            }

            if (FirstEntry != null && FirstEntry != string.Empty && double.TryParse(FirstEntry, out FirstEntryInt) && SecondEntry != null && SecondEntry != string.Empty && double.TryParse(SecondEntry, out SecondEntryInt))
            {
                if (SecondEntryInt == 0)
                {
                    Console.WriteLine("Cannot divided by zero");
                }
                if (MathOperation == "+")
                {
                    Console.WriteLine(FirstEntryInt + SecondEntryInt);
                }
                else if (MathOperation == "-")
                {
                    Console.WriteLine(FirstEntryInt - SecondEntryInt);
                }
                else if (MathOperation == "*")
                {
                    Console.WriteLine(FirstEntryInt * SecondEntryInt);
                }
                else if (MathOperation == "/")
                {
                    Console.WriteLine(FirstEntryInt / SecondEntryInt);
                }
                else
                {
                    Console.WriteLine("Only numbers are allowed");
                }
            }


            //Assessment-NumberisEvenOrOdd
            Console.WriteLine("Assessment-NumberisEvenOrOdd");
            Console.WriteLine("============================");
            Console.WriteLine("Please enter your number");
            int NumberEntry = int.Parse(Console.ReadLine());
            if (NumberEntry % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }


            //Assessment-Max
            Console.WriteLine("Assessment-Max");
            Console.WriteLine("==============");
            Console.WriteLine("Please enter first number");
            NumberEntry = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int NumberEntry2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Max number is {Math.Max(NumberEntry, NumberEntry2)}");
            // Or
            int[] numberArray = new int[2];
            Console.WriteLine("Please enter first number");
            NumberEntry = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            NumberEntry2 = int.Parse(Console.ReadLine());
            numberArray[0] = NumberEntry;
            numberArray[1] = NumberEntry2;
            Console.WriteLine($"Max number is {numberArray.Max()}");


            //Assessment-IsValid
            Console.WriteLine("Assessment-IsValid");
            Console.WriteLine("==================");
            Console.WriteLine("Please enter number between 1 to 10 only");
            NumberEntry = int.Parse(Console.ReadLine());
            if (NumberEntry <= 10 && NumberEntry > 0)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }


            //Assessment-SwitchStatement
            Console.WriteLine("Assessment-SwitchStatement");
            Console.WriteLine("==========================");
            Console.WriteLine("Please enter number between 1 to 7 only");
            NumberEntry = int.Parse(Console.ReadLine());
            switch (NumberEntry)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
            #endregion
        }
    }
}
