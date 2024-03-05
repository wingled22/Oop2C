using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsolePelayo2
{
    public class Animal
    {
        public int Legs { get; set; }
        public string? Skin { get; set; }
        public string? Teeth { get; set; }
        public string? Habitat { get; set; }
        public void WhatIsMyDiet()
        {
            if (Teeth == null)
                Console.WriteLine("No teeth data to process");
            else if (Teeth.ToLower() == "sharp")
                Console.WriteLine("You are Carnivore");
            else if (Teeth.ToLower() == "flat")
                Console.WriteLine("You are Herbivore");
            else if (Teeth.ToLower() == "both")
                Console.WriteLine("You are Omnivore");
            else
                Console.WriteLine("Cannot process the teeth data");
        }
    }

}