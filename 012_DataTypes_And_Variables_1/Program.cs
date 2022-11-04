using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_DataTypes_And_Variables_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int_num = 2;
            Console.WriteLine("Int_Num = " + int_num);

            int_num = 5;

            Console.WriteLine("Int_Num = " + int_num);

            double double_num = 0.0d;
            float float_num = 0.0f;
            decimal decimal_num = 0.0m;

            double_num = 9.8d;
            float_num = 5.5f;
            decimal_num = 100.250m;

            Console.WriteLine("double_num = " + double_num);
            Console.WriteLine("float_num = " + float_num);
            Console.WriteLine("decimal_num = " + decimal_num);


        }
    }
}
