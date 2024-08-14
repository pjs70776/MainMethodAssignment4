using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            //method 1
            Console.WriteLine("What number do you want to select to do the math operation?");
            Console.WriteLine("Enter a number to be added to 5");
            int additon = Convert.ToInt32(Console.ReadLine());
            int sum = c1.method1(additon);
            Console.WriteLine(sum + " is the answer.");

            //method 2 with decimal (float)
            Console.WriteLine("enter a decimal up to 6 decimal digits to be subtracted by 5");
            decimal subtract = Convert.ToDecimal(Console.ReadLine());
            decimal diff = c1.method2(subtract);
            Console.WriteLine(diff + " is the answer.");

            //method 3 that takes a string, converts it to an integer
            Console.WriteLine("Enter a string (Unicode), that will be converted to an integer, to be added by 5");
            string mult = Convert.ToString(Console.ReadLine());  //converting string to intiger
            int prod = c1.method3(mult);
            Console.WriteLine(prod + " is the answer.");
            Console.ReadLine();
        }
    }
    

}


