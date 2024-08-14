using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment4
{
    class Class1
    {
        //method1 addition
        public int method1(int x)
        {
            int Add = x + 5; return Add;
        }
        //method2 that takes a decimal and subtracts it
        public decimal method2(decimal y)
        {
            decimal Dec = y - 5;
            return Dec;
        }
        //method 3 that takes a string, converts it to an integer, and adds it
        public int method3(string z)
        {
            int stringToInt = Convert.ToInt32(z);
            int product = stringToInt + 5; return product;
        }
    }


}
