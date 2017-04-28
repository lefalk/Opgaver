using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg02
{
    class Program
    {
        static void Main(string[] args)
        {

            int heltal = 10;
            heltal++;
            heltal--;
            heltal+= 20;
            Console.WriteLine(heltal);
            
            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            Filtyper ft = Filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString("ddMMyy"));
            Console.WriteLine(dateTime.ToLongTimeString());
            Console.WriteLine(dateTime.ToString("d-m-y"));

            Person p;
            p.ID = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.ID +" "+ p.Navn);








        }
    }

    public struct Person

    {

      public int ID;
      public string Navn;
    }
    enum Filtyper

    {

        pdf,
        txt,
        csv
    }
}
