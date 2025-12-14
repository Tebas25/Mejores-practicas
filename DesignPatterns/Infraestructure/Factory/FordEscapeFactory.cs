using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Infraestructure.Factory
{
    public class FordEscapeFactory : CarFactory
    {
        public override Vehicle Create()
        {
            return new ModelBuilder.CarModelBuilder()
                .SetBrand("Ford")
                .SetColor("red")
                .SetModel("Escape")
                .SetYear(2023)
                .Build();
        }
    }
}
