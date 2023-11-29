using System.Drawing;

namespace Flyweight
{
    public class LampType
    {
        public string Name { get; set; }
        public Image Photo { get; set; }

        public LampType(string name, string photoPath)
        {
            Name = name;
            Photo = Image.FromFile(photoPath);
        }
    }
}