using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp16
{
    public class LuggageItem
    {
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Value { get; set; }

        public LuggageItem(string name, int weight, int value)
        {
            Name = name;
            Weight = weight;
            Value = value;
        }
    }

}
