using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charp_egitim_3
{
    //public class NullOperatorler
    //{
    //    public void Kontrol()
    //    {
    //        NullConditional person = null;
    //        if (person == null)
    //        {
    //            NullConditional person1 = new();
    //            Console.WriteLine(person?.Name);
    //        }
    //        Console.WriteLine("devam et");
    //    }
    //}

    public class NullCoalescing
    {
        public NullCoalescing()
        {
            Console.WriteLine("ctor tetiklendi");
        }

        public void Kontrol()
        {
            NullCoalescing nullCoalescing = null;
            nullCoalescing ??= new();

            int? v = null;
            Console.WriteLine(v);
            v ??= 15;
            Console.WriteLine(v);
        }
    }
    public class NullConditional
    {
        public int ID { get; set; }
        public string Name { get; set; } = "Akif";

        public void Kontrol()
        {
            NullConditional person = null;
            if (person == null)
            {
                NullConditional person1 = new();
                Console.WriteLine(person1?.Name);
            }
            Console.WriteLine("devam et");
        }
    }

    public class IsOpetator
    {
        public int Yas { get; set; }
        public void Kontrol()
        {
            if ( Yas is int)
                Console.WriteLine("türü int");

            IsOpetator ısOpetator = new IsOpetator();
            if (ısOpetator is { Yas: 15 })
            {
                Console.WriteLine("doğru");
            }
        }
    }
}
