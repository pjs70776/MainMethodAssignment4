using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment4
{
    class Class1
    {
        //method1 addition
        public static int method1(int x)
        {
            int Add = x + 5; return Add;
        }
        //method2 that takes a decimal and subtracts it
        public static decimal method1(decimal y)
        {
            decimal Dec = y - 5;
            int diff = Convert.ToInt32(Dec); return diff;
        }
        //method 3 that takes a string, converts it to an integer, and adds it
        public static int method1(string z)
        {
            string stringToInt = z + 5;
            int product = Convert.ToInt32(stringToInt); return product;
        }
    }


}
