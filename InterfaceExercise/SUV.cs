using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {

        }

        public double EngineSize { get; set; } = 5.8;
        public string Model { get; set; } = "Rav4";
        public string Make { get; set; } = "Toyota";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Toyota";
        public string Motto { get; set; } = "Toyota for ya";
        public bool HasChangedGears { get; set; }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {


                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears. . .");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {


                Console.WriteLine($"{GetType().Name} is now in park . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park until we change gears. . .");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

    }

}


