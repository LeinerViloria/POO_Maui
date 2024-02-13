
using Prueba.Interfaces;

namespace Prueba.Entities
{
    public abstract class Instrument : BaseObj, IInstrument, ISound
    {
        public string Image { get; set; }
        public abstract void Sound();
    }
}