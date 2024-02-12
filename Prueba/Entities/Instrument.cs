
using Prueba.Interfaces;

namespace Prueba.Entities
{
    public abstract class Instrument : BaseObj, IInstrument
    {
        public abstract void Sound();
    }
}