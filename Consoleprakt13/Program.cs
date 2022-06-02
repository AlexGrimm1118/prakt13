using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleprakt13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            while (true)
            {
                Console.WriteLine("\n1-Ввести А\n2-Ввести В\n3-Вычесть\n4-Сложить\n5-Умножить\n6-Делить");
                int ch = int.Parse(Console.ReadLine());

                if(ch == 4)
                {
                    Console.WriteLine(a+b);
                }






















































                Console.ReadKey();
                Console.Clear();

            }



        }
    }
}
