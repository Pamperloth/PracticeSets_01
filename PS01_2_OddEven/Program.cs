using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS01_2_OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >0)
            {
                Console.WriteLine("The Number" + num + "is Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("The Number" + num + "is Negative");
            }
            else
            {
                Console.Write("Number is 0.");
            }
        }
    }
}
