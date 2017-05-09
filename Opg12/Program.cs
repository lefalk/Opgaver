using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg12
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person();
            p.Efternavn = "Mikkel";
            p.Efternavn = "Cronberg";
            Console.WriteLine(p.FuldtNavn());

        }
            
            }




}
