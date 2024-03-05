using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public string Company { get; set; }
        public Vehicle()
        {
        }

        public Vehicle(string manufacturer, string model, double price, int year, string color, double weight, string company)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Year = year;
            this.Color = color;
            this.Weight = weight;
            this.Company = company;
        }

        public virtual void Input()
        {
            Console.Write("Nhap hang san xuat: ");
            this.Manufacturer = Console.ReadLine();
            Console.Write("Nhap mau xe: ");
            this.Model = Console.ReadLine();
            Console.Write("Nhap gia xe: ");
            this.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap nam san xuat xe: ");
            this.Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap mau xe: ");
            this.Color = Console.ReadLine();
            Console.Write("Nhap trong luong xe: ");
            this.Weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap cong ty: ");
            this.Company = Console.ReadLine();
        }

        public virtual void Output()
        {
            Console.WriteLine("Hang san xuat: {0}", this.Manufacturer);
            Console.WriteLine("Mau xe: {0}", this.Model);
            Console.WriteLine("Gia xe: {0}", this.Price);
            Console.WriteLine("Nam san xuat: {0}", this.Year);
            Console.WriteLine("Mau xe: {0}", this.Color);
            Console.WriteLine("Trong luong xe: {0}", this.Weight);
            Console.WriteLine("Cong ty: {0}", this.Company);
        }
    }
}
