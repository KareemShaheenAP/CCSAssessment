namespace Session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assessment-Factorial
            Console.WriteLine("Please enter a number to calculate its factorial");
            int entry = int.Parse(Console.ReadLine());
            int outPut = entry;
            for (int i = entry - 1; i >= 1; i--) 
            {
                //Console.WriteLine(i);
                entry *= i;
            }
            Console.WriteLine(outPut + "!=" + entry);
        }
    }
}
