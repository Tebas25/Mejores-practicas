using DesignPatterns.Models;
using System.Collections.Generic;

namespace DesignPatterns.Infraestructure.Singletong
{
    public class MemoryCollection
    {
        private static MemoryCollection _memoryCollection;
        public ICollection<Vehicle> Vehicles { get; set; }
        public MemoryCollection() { 
            Vehicles = new List<Vehicle>();
        }

        public static MemoryCollection GetMemoryCollection()
        {
            if ( _memoryCollection == null )
            {
                _memoryCollection = new MemoryCollection();
            }
            return _memoryCollection;
        }
    }
}
