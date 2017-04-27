using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();
            Console.WriteLine("Indtast efternavn");
            string efternavn = Console.ReadLine();
            string stortNavn = navn + " " +efternavn.ToUpper();
            Console.WriteLine("Velkommen " + stortNavn);
            Console.WriteLine("Tryk på en tast for at fortsætte");
            Console.ReadKey();

        }
    }
}
