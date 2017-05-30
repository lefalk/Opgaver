using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg19
{
    class Person { 

        public int Id { get; set; }
        public string Navn { get; set; }

    
        static void Main(string[] args)
        {
            List<Person> Lst1 = new List<Person>();
            Lst1.Add(new Person() { Id = 1, Navn = "M" });
            Lst1.Add(new Person() { Id = 2, Navn = "T" });
            Lst1.Add(new Person() { Id = 3, Navn = "P" });
            foreach (var item in Lst1)
            {
                Console.WriteLine(item.Id);
            }
          

        Dictionary < int, Person > Lst2 = new Dictionary<int, Person>();
        Lst2.Add(1, new Person() { Id = 1, Navn = "M" });
        Lst2.Add(2, new Person() { Id = 2, Navn = "T" });
        Lst2.Add(3, new Person() { Id = 3, Navn = "P" });
        var p = Lst2[3];
        Console.WriteLine(p.Navn);


        }
    }
    }

