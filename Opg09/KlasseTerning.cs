using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg09
{
    class KlasseTerning
    {

        public int værdi;
        public KlasseTerning()

        {

            this.værdi = new Random().Next(1, 7);

        }

        public KlasseTerning(int værdi)

        {

            this.værdi = værdi;

        }

    }
}
