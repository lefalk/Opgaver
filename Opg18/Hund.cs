using System;

namespace Opg18
{
    class Hund : IComparable {

        public string navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {

            Hund h = obj as Hund;
            if (h.Alder > this.Alder)
                return - 1;
            if (h.Alder < this.Alder)
                return 1;
            return 0;

        }

    }



}




