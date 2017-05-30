using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg22
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w =
                new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName |
                System.IO.NotifyFilters.Size;
            w.Changed += W_Changed;
            do { } while (true);

#pragma warning disable CS0162 // Unreachable code detected
            using (System.IO.StreamReader stream = System.IO.File.OpenText(@"c:\temp", "*.txt"))
#pragma warning restore CS0162 // Unreachable code detected
            {
                while (stream.Peek() != -1)
                {
                    var L = stream.ReadLine();
                    Console.WriteLine(L.ToUpper());

                }
            }
        }
        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
          
            Console.WriteLine(e.Name);
           

        }


    }
}

