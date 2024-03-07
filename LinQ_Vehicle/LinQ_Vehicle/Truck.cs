using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Vehicle
{
    class Truck : Vehicle
    {
        public string company { get; set; }
        public Truck(String name, String brand, int price, int year, String company) : base(name, brand, price, year)
        {
            this.company = company;
        }

        public override string ToString()
        {
            return string.Format("Ten: {0} - Hang: {1} - Gia thanh: {2} - NSX: {3} - Cong ty: {4}", name, brand, price, year, company);
        }

        public static IList<Truck> trucks
        {
            get
            {
                return new List<Truck>
                {
                    new Truck("FH16", "Volvo", 2000000, 2005, "Company A"),
                    new Truck("F-150", "Ford", 2100000, 2010, "Company B"),
                    new Truck("VNL64T780", "Volvo", 1050000, 2015, "Company C")
                };
            }
        }
    }
}
