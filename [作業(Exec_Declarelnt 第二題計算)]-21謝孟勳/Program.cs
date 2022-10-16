using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _作業_Exec_Declarelnt_第二題計算___21謝孟勳
{
    //求120/7的商以及餘數各是多少
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 120;
            int Quotient = number / 7;
            int Remainder = number % 7;
            Console.WriteLine("商是: " + Quotient);
            Console.WriteLine("餘數是: " + Remainder); 
        }
    }
}
