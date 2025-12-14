using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Car : Vehicle
    {
        public override int Tires { get => 4; }
        public int Year {  get; set; } //Se agregas la(s) nueva(s) propiedades que necesite car, pero no vehicle

        public Car(string color, string brand, string model, int year) : base(color, brand, model)
        {
            Year = year;
        }
    }
}
