using DesignPatterns.Models;
using System;

namespace DesignPatterns.Infraestructure.Factory
{
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new ModelBuilder.CarModelBuilder()
                .SetBrand("Ford")
                .SetColor("red")
                .SetModel("Explorer")
                .SetYear(2024)
                .Build();
        }
    }
}
