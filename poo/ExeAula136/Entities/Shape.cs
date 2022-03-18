using ExeAula145.Entities.Enums;

namespace ExeAula145.Entities
{
    abstract class Shape //indica classe base, não pode ser instanciada
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); //método base, será sobrescrito nas classes Rectangle e Circle
    }
}
