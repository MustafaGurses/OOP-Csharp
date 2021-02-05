using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples.Inheritance
{
    public class Animal : AnimalsAndSounds
    {
        public Animal(string AnimalName)
        {
            AnimalName1 = AnimalName;
        }
        public string GetAnimalSound()
        {
            switch (AnimalName1.ToLower())
            {
                case "köpek":
                    return "Köpekler 'hav hav' der\n";
                case "kedi":
                    return "Kediler 'miyav' der.\n";
                case "horoz":
                    return "Horozlar ' ü ürü ü ' diye öter.\n";
                case "kuş":
                    return "kuşlar 'cik cik' der.\n";
                default:
                    return "girilen hayvanı tanımıyorum\n";
            }
        }
    }
}
