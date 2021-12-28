using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numeros = { 5, 6, 8, 9, 2, 1, 3, 6, 9 };

            var Mayor = (from x in Numeros
                        select x).Max() ;

            Console.WriteLine("Mayor es : {0}", Mayor);
            Console.ReadLine();
        }
    }
}
