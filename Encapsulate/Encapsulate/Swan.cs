﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulate
{
    public class Swan:Bird
    {
        private int levelOfRange; // need for create logic for get and set
        public int LevelOfRage { get; set; }

        public Swan() : base() { }
        public Swan(bool isCarnivore, int age,
            string species, int singingDb,
            int levelOfRage):
            base(isCarnivore,age,species,singingDb)
        {
            LevelOfRage = levelOfRage;
        }
        public override string Stats()
        {
            return base.Stats() + "\nOn a scale from 1 to:"+"10 how angry is it" + LevelOfRage;
        }
    }
}
