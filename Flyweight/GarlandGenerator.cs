using System.Drawing;

namespace Flyweight
{
    public class GarlandGenerator
    {
        private List<Lamp> lamps = new List<Lamp>();
        private LampFactory lampFactory = new LampFactory();

        public void AddLampType(string name, string photoPath)
        {
            lampFactory.AddLampType(name, photoPath);
        }

        public void GenerateLamp(Point location, string lampTypeName)
        {
            LampType type = lampFactory.GetLampType(lampTypeName);
            if (type != null)
            {
                lamps.Add(new Lamp(type, location));
            }
        }

        public List<Lamp> GetLamps()
        {
            return new List<Lamp>(lamps);
        }
    }
}
