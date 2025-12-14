using DesignPatterns.Models;

namespace DesignPatterns.Infraestructure.Factory
{
    public abstract class CarFactory
    {
        public abstract Vehicle Create();
    }
}
