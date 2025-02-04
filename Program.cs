using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yildizlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Altalta yildiz olusturan program
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 5; i >= -1; i--) {
                for (int j = 0; j < i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
