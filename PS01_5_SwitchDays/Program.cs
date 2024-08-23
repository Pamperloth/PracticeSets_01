using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_5_SwitchDays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Letter Choice(A,P or X): ");
            string letter = Console.ReadLine();

            switch (letter)
            {
                case "A":
                    Console.WriteLine("Enter Radius: ");
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine((num * num) * 3.14);
                    break;
                case "P":
                    Console.WriteLine("Enter Radius: ");
                    int numn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(numn * (3.14 * 2));
                    break;
                case "X": Console.WriteLine("Exiting the Application..."); break;
                default: Console.WriteLine("Invalid Input"); break;
            }
        }
    }
}
