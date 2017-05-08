using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg09
{
    class Program
    {
        static void Main(string[] args)
        {

            KlasseTerning t1;
            t1 = new KlasseTerning();
            Console.WriteLine(t1.værdi);
            KlasseTerning t2;
            t2 = new KlasseTerning(2);
            Console.WriteLine(t2.værdi);
            t2 = t1;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);
            t1.værdi = 1;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);
            t2.værdi = 6;
            Console.WriteLine(t1.værdi);
            Console.WriteLine(t2.værdi);

        }
    }
}
