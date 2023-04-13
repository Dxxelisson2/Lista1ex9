using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_1_ex_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;
            double D;


            Console.Write("Digite o diametro do circulo: ");

            D = double.Parse(Console.ReadLine());

            A = 3.14 * D;

            Console.WriteLine("AREA DO CIRCULO É: "+ A);
        }
    }
}
