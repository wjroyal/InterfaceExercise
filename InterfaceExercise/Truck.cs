﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }

        public double EngineSize { get; set; } = 6;
        public string Model { get; set; } = "F150";
        public string Make { get; set; } = "Ford";
        public int SeatCount { get; set; } = 4;
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; } 
        public bool HasFourWheelDrive { get; set; } = true;


        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {


                Console.WriteLine($"4 wheel driven{GetType().Name} now driving forward. . .");


            }
            else
            {
                Console.WriteLine($"{GetType().Name} ");
            }
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


