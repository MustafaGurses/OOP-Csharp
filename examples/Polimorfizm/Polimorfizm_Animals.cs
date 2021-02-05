using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples.Polimorfizm
{
    public class Polimorfizm_Animals : Polimorfizm_Main
    {
        /*
         * This code was created on @kaynakkodum
         */
        private string AnimalName;
        public Polimorfizm_Animals(string AnimalName)
        {
            AnimalName1 = AnimalName;
        }

        public string AnimalName1 { get => AnimalName; set => AnimalName = value; }

        public override string GetAnimalSound()
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
