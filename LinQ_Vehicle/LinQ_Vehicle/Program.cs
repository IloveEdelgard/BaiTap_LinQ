using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = Car.cars;
            Console.WriteLine("Danh sach cac Car: ");
            printList(cars);
            Console.WriteLine("");

            Console.WriteLine("a. Nhung xe co gia trong khoang 100.000 den 250.000: ");
            listPrice(cars);
            Console.WriteLine("");

            Console.WriteLine("b. Nhung xe co nam san xuat >= 1990: ");
            listNSX(cars);
            Console.WriteLine("");

            Console.WriteLine("c. Gom cac xe theo hang, tinh tong gia tri theo nhom: ");
            listGroup(cars);
            Console.WriteLine("");

            var trucks = Truck.trucks;
            Console.WriteLine("Danh sach cac Truck: ");
            printList(trucks);
            Console.WriteLine("");

            Console.WriteLine("a. Danh sach truck theo thu tu nam san xuat moi nhat: ");
            listNewest(trucks);
            Console.WriteLine("");

            Console.WriteLine("b. Ten cong ty chu quan cua truck: ");
            foreach (var item in trucks)
            {
                Console.WriteLine($"Name: {item.name} - Company: {item.company}");
            }

            Console.ReadKey();
        }

        static void printList<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void listPrice<T>(IEnumerable<T> list)
        {
            var cars = Car.cars;
            var listPrice = cars.Where(f => f.price >= 100000 && f.price <= 250000);
            printList(listPrice);
        }

        static void listNSX<T>(IEnumerable<T> list)
        {
            var cars = Car.cars;
            var listNSX = cars.Where(f => f.year > 1990);
            printList(listNSX);
        }

        static void listGroup<T>(IEnumerable<T> list)
        {
            var cars = Car.cars;
            var listGroup = cars.GroupBy(car => car.brand).ToDictionary(g => g.Key, g => g.Sum(car => car.price));
            foreach (var item in listGroup)
            {
                Console.WriteLine($"Brand: {item.Key}, Total Price: {item.Value}");
            }
        }

        static void listNewest<T>(IEnumerable<T> list)
        {
            var trucks = Truck.trucks;
            var listNewest = trucks.OrderByDescending(t => t.year);
            printList(listNewest);
        }
    }
}
