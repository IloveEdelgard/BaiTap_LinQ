using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Vehicle
{
    class Car : Vehicle
    {
        public Car(String name, String brand, int price, int year) : base(name, brand, price, year) { }

        public override string ToString()
        {
            return string.Format("Ten: {0} - Hang: {1} - Gia thanh: {2} - NSX: {3}", name, brand, price, year);
        }

        public static IList<Car> cars
        {
            get
            {
                return new List<Car>
                {
                    new Car("Innova Cross", "Toyota", 115000, 1980),
                    new Car("BR-V", "Honda", 218000, 1995),
                    new Car("Explorer","Ford", 322000, 1998),
                    new Car("Chevrolet Trailblazer","Toyota", 120000, 1992),
                    new Car("X1 2021","BMW", 124000, 1987)
                };
            }
        }
    }
}
