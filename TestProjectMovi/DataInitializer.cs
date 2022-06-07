using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectMovi
{
    internal class DataInitializer
    {
        public static List<Car> GetAllCars()
        {
            var cars = new List<Car> {
        new Car() {
          Id = "9f907bdf-f6de-425d-be5b-b4852eb77761",
            Model = "Tesla Model 3",
            Price = 1500000,
            type = "Electric",
            Brand = "Tesla"
        },
        new Car() {
          Id = "9f907bdf-f6de-425d-be5b-b4852eb77762",
            Model = "Versa",
            Price = 300000,
            type = "Sedan",
            Brand = "Nissan"
        }
      };

            return cars;
        }
    }
}
