using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    class Car:Vehicle
    {
        public int Seat { get; set; }
        public string Designs { get; set; }
        public string Interior { get; set; }

        public Car()
        {
        }

        public Car(int seat, string designs, string interior, string manufacturer, string model, double price, int year, string color, double weight, string company) : base(manufacturer,model,price,year,color,weight,company)
        {
            this.Seat = seat;
            this.Designs = designs;
            this.Interior = interior;
        }


        public override void Input()
        {
            base.Input();
            Console.Write("Nhap so ghe ngoi: ");
            this.Seat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap kieu dang: ");
            this.Designs = Console.ReadLine();
            Console.Write("Nhap noi that: ");
            this.Interior = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("So ghe ngoi: {0}", this.Seat);
            Console.WriteLine("Kieu dang: {0}", this.Designs);
            Console.WriteLine("Noi that: {0}", this.Interior);

        }
    }
}
