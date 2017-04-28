using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg04
{
    class Program
    {
        static void Main(string[] args)
        {
            String fornavn = ("Mikkel");
            String efternavn = ("Cronberg");

            String navn = (fornavn +" " + efternavn);
            String stortnavn = navn.ToUpper();
            String lillenavn = navn.ToLower();
            String delnavn = lillenavn.Substring(7,4);

            String[] navne = navn.Split(' ');
            foreach (var item in navn)
       

            Console.WriteLine(navn);
            Console.WriteLine(stortnavn);
            Console.WriteLine(lillenavn);
            Console.WriteLine(delnavn);
          





        }
    }
}
