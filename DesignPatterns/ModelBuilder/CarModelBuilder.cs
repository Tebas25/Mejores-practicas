using DesignPatterns.Models;
using System;

namespace DesignPatterns.ModelBuilder
{
    public class CarModelBuilder
    {
        private string color;
        private string brand;
        private string model;
        private int year;

        public CarModelBuilder SetColor(string color)
        {
            this.color = color;
            return this;
        }

        public CarModelBuilder SetBrand(string brand)
        {
            this.brand = brand;
            return this;
        }

        public CarModelBuilder SetModel(string model)
        {
            this.model = model;
            return this;
        }

        public CarModelBuilder SetYear(int year)
        {
            this.year = year;
            return this;
        }

        public Vehicle Build()
        {
            return new Car(color, brand, model, year);
        }
    }
}
