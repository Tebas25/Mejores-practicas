using DesignPatterns.Models;
using System;

namespace DesignPatterns.Infraestructure.Factory
{
    public class FordMustangFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new ModelBuilder.CarModelBuilder()
                .SetBrand("Ford")
                .SetColor("red")
                .SetModel("Mustang")
                .SetYear(DateTime.Now.Year)
                .Build();
        }
    }
}
