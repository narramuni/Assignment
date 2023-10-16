using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLibrary
{
    public class Smartphone : IComparable<Smartphone>
    {
        public int IMEINumber { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public int CompareTo(Smartphone other)
        {
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }

        public Smartphone(int imei, string name, string model, decimal price)
        {
            IMEINumber = imei;
            Name = name;
            Model = model;
            Price = price;
        }



    }
}