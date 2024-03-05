using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap 'car' de thao tac voi car");
            Console.WriteLine("Nhap 'truck' de thao tac voi truck");
            string kt = Console.ReadLine();

            switch (kt)
            {
                case "car":
                   
                    List<Car> cars = new List<Car>();
                    int n;
                    Console.Write("Nhap so xe: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    
                    for (int i = 1; i <= n; i++)
                    {
                        Console.WriteLine("-----------");
                        Console.WriteLine("Nhap xe thu {0}: ", i);
                        Car car = new Car();
                        car.Input();
                        cars.Add(car);
                    }
                    
                    Console.WriteLine("---------------");
                    Console.WriteLine("Danh sach xe co gia trong khoan 100.000 -> 250.000");
                    var filteredCars = cars.Where(c => c.Price >= 100000 && c.Price <= 250000);
                    foreach (var car in filteredCars)
                    {
                        car.Output();
                    }
                    Console.WriteLine("---------------");

                    Console.WriteLine("Danh sach xe co nam san xuat > 1990");
                    var caryear = cars.Where(c => c.Year > 1990);
                    foreach(var car in caryear)
                    {
                        car.Output();

                    }
                    Console.WriteLine("---------------");

                    Console.WriteLine("Nhom xe theo hang va tinh tong gia tri");

                    var group = cars.GroupBy(c => c.Manufacturer).Select(g => new
                    {
                        Manufacturer = g.Key,
                        total = g.Sum(c => c.Price)

                    }) ;
                    foreach (var car in group)
                    {
                        Console.WriteLine($"Nhà sản xuất: {car.Manufacturer}, Tổng giá trị: {car.total}");
                    }

                    Console.ReadLine();

                    break;
                case "truck":
                    List<Truck> trucks = new List<Truck>();
                    int k;
                    Console.Write("Nhap so xe: ");
                    k = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i <= k; i++)
                    {
                        Console.WriteLine("-----------");
                        Console.WriteLine("Nhap xe thu {0}: ", i);
                        Truck truck = new Truck();
                        truck.Input();
                        trucks.Add(truck);
                    }
                    Console.WriteLine("---------------");
                    Console.WriteLine("Danh sach xe duoc sap xep theo nam");
                    var desc = trucks.OrderByDescending(p => p.Year);
                    foreach (var item in desc)
                    {
                        Console.WriteLine("-------");

                        item.Output();
                    }

                    Console.WriteLine("Danh sach cong ty chu quan: ");
                    var com = trucks.Select(p => new
                    {
                        Truck = p,
                        conty = p.Company
                    }) ;
                    Console.WriteLine("---------------");

                    foreach (var item in com)
                    {
                        Console.WriteLine($"Danh sach cong ty chu quan: {item.conty}");

                    }
                    break;

                    
            }
           

        }
    }
}
