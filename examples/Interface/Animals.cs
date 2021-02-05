using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples.Interface
{
    public class Animals : IAnimals
    {
        private string AnimalName;
        public Animals(string AnimalName)
        {
            this.AnimalName = AnimalName;
        }
        public string GetAnimalSound()
        {
            switch (AnimalName.ToLower())
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
