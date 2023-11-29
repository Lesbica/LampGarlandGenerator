using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class LampFactory
    {
        private Dictionary<string, LampType> lampTypes = new Dictionary<string, LampType>();

        public void AddLampType(string name, string photoPath)
        {
            lampTypes[name] = new LampType(name, photoPath);
        }

        public LampType GetLampType(string name)
        {
            return lampTypes.ContainsKey(name) ? lampTypes[name] : null;
        }
    }
}
