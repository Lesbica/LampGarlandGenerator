using System.Drawing;

namespace Flyweight
{
    public class Lamp
    {
        public LampType Type { get; }
        public Point Location { get; }

        public Lamp(LampType type, Point location)
        {
            Type = type;
            Location = location;
        }
    }
}
