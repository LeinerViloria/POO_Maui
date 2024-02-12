
namespace Prueba.Entities
{
    public abstract class BaseObj
    {
        public string Name {get; set;}
        public string Description {get; set;}

        public virtual string ToString() => $"{Name} {Description}";
    }
}