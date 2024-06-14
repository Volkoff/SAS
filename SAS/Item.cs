using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAS
{
    public class Item
    {
        public string name;
        public int cost;

        public Item(string name, int cost)
        {
            this.name = name;
            this.cost = cost;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
