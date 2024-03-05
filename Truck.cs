using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Truck:Vehicle
    {
        public string TypeBox { get; set; }
        public string payload { get; set; }
        public string boxDimensions { get; set; }

        public Truck()
        {
        }

        public Truck(string typeBox, string payload, string boxDimensions, string manufacturer, string model, double price, int year, string color, double weight, string company) : base(manufacturer, model, price, year, color, weight, company)
        {
            this.TypeBox = typeBox;
            this.payload = payload;
            this.boxDimensions = boxDimensions;
        }
        public virtual void Input()
        {
            base.Input();
            Console.Write("Nhap Loai thung xe: ");
            TypeBox = Console.ReadLine();
            Console.Write("Nhap tai trong xe: ");
            this.payload = Console.ReadLine();
            Console.Write("Nhap kich thuoc thung xe: ");
            this.boxDimensions = Console.ReadLine();

        }
        public virtual void Output()
        {
            base.Output();
            Console.WriteLine("Loai thung xe: {0}", TypeBox);
            Console.WriteLine("Tai trong xe: {0}", this.payload);
            Console.WriteLine("Kich thuoc thung xe: {0}", this.boxDimensions);
        }
    }

}
