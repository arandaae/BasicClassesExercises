using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();

            car1.Make = "Toyota";
            car1.Model = "Camry";
            car1.Year = "2022";

            car1.NewCar();


        }
    }
}
