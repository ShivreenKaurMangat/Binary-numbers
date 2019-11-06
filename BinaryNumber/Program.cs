using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertToBinary(18));
            Console.ReadLine();
        }

        static string ConvertToBinary(int n)
        {
            string result = "";
            while (n > 0)
            {
                int reminder = n % 2;
                result = reminder + result;
                n = n / 2;
            }
            return result;
        }
    }
}
