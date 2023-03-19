using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumenty
{
    class Trabka : Instrument
    {
        public override void Graj()
        {
            Console.WriteLine("Tra ta ta ta");
        }
        public override string Opis
        {
            get
            {
                return "Trąbka jest to instrument dęty...";
            }
        }
        public override string ToString()
        {
            return "trąbka";
        }
    }
}
