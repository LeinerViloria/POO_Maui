using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities
{
    internal class Drum : Instrument
    {
        public override void Sound()
        {
            Console.WriteLine("El tambor está sonando");
        }
    }
}
