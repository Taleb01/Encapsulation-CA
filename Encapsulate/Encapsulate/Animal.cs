﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
   public class Animal
    {
        public bool IsCarnivore { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }

        public Animal()
        {
        }

        public Animal(bool iscarnivore, int age, string species)

        {
           IsCarnivore= iscarnivore;
            Age = age;
            Species = species;
            
        }

        
    }
}
