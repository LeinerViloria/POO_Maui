
using Prueba.Entities;

namespace Prueba.Utils
{
    public static class Utils
    {
        public static IList<Instrument> GetDemoData() =>
            new List<Instrument>()
            {
                new Piano(){Name = "Piano yamaha", Description="Piano de alta calidad", Image="piano.jpeg"},
                new Violin(){Name = "Violin 1", Description="Violín de alta calidad", Image="violin.jpeg"},
                new Drum(){Name = "Tambor", Description="Tambor de altasima calidad", Image="drum.jpeg"},
                new Accordion(){Name = "Acordeon yamaha", Description="acordeon de alta calidad", Image="acordeon.jpeg"}
            };
    }
}