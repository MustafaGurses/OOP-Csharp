using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples.Inheritance
{
    public class AnimalsAndSounds
    {
        public const string Dog_Sound = "Hav hav";
        public const string Cat_Sound = "Miyav";
        public const string Cock_Sound = "ü ürü ü";
        public const string Bird_Sound = "cik cik";
        private string AnimalName;
        public string AnimalName1 { get => AnimalName; set => AnimalName = value; }
    }
}
