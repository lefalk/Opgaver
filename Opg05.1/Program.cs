using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg05._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            var res = BeregnOgSorterArray(test);

        }

        public static MitArray BeregnOgSorterArray(int[] a)
        { 
            MitArray r;
            r.sum = 0;
            
            foreach (var item in a)

            {
            
            r.sum += item;
            
            }

    r.gennemsnit = r.sum / a.Length;
        Array.Sort(a);
        return r;

    }
}

struct MitArray
{


public double sum;
public double gennemsnit;

        
    }
}
