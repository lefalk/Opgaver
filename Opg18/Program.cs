using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg18
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, navn = "Lady" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {

                Console.WriteLine(item.navn);

            }

        }
    }



}




