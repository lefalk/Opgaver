using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg20
{
    class Program
    {
        static void Main(string[] args)
        {

            using (StreamReader stream = System.IO.File.OpenText("dyrenavne.txt"))
                while (stream.Peek() != -1)
                {
                    var L = stream.ReadLine();
                    Console.WriteLine(L.ToUpper());

                }
            
    }
    }
}

