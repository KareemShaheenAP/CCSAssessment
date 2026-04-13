using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Session_3
{
    enum Correspondingday
    {
        Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
    }
    internal class SwitchStatementUSeEnums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number from 1 to 7");
            int entryInt = int.Parse(Console.ReadLine());
            if (entryInt <= 7 && entryInt != 0)
            {
                // Through Auto get by index in enum
                var output = (Correspondingday)entryInt - 1;
                Console.WriteLine(output);

                // Using Switch
                switch (entryInt)
                {
                    case 1:
                        Console.WriteLine(Correspondingday.Saturday);
                        break;
                    case 2:
                        Console.WriteLine(Correspondingday.Sunday);
                        break;
                    case 3:
                        Console.WriteLine(Correspondingday.Monday);
                        break;
                    case 4:
                        Console.WriteLine(Correspondingday.Tuesday);
                        break;
                    case 5:
                        Console.WriteLine(Correspondingday.Wednesday);
                        break;
                    case 6:
                        Console.WriteLine(Correspondingday.Thursday);
                        break;
                    case 7:
                        Console.WriteLine(Correspondingday.Friday);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }
            }

        }
    }
}
