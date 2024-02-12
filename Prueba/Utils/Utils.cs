
using Prueba.Entities;

namespace Prueba.Utils
{
    public static class Utils
    {
        public static IList<Instrument> GetDemoData() =>
            new List<Instrument>()
            {
                new Piano(){Name = "Piano yamaha", Description="Piano de alta calidad"},
                new Violin(){Name = "Violin 1", Description="Violín de alta calidad"},
                new Piano(){Name = "Piano Kawai", Description="Piano de altasima calidad"},
                new Accordion(){Name = "Acordeon yamaha", Description="acordeon de alta calidad"}
            };
    }
}