using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5_Task1_GasStation
{
    internal class Product
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public override string ToString() => Name;
    }
}