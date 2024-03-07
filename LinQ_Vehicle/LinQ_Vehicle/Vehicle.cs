using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Vehicle
{
    class Vehicle
    {
        public string name { get; set; }
        public string brand { get; set; }
        public int price { get; set; }
        public int year { get; set; }
        public Vehicle(String name, String brand, int price, int year)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
            this.year = year;
        }
    }
}
