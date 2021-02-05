using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples.Encapsulation
{
    public class Animal
    {
        private string AnimalName;
        private string AnimalSound;
        public Animal(string AnimalName,string AnimalSound)
        {
            AnimalName_ = AnimalName;
            AnimalSound_ = AnimalSound;
        }
        public string AnimalName_ { get => AnimalName; set => AnimalName = value; }
        public string AnimalSound_ { get => AnimalSound; set => AnimalSound = value; }
    }
}
