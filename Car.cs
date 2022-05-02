using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClassesExercise
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public void NewCar()
        {
            Console.WriteLine(Make);
            Console.WriteLine(Model);
            Console.WriteLine(Year);
        }



    }
}
