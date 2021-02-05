using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples.Polimorfizm
{
    public class Polimorfizm_Calc : Polimorfizm_Main
    {
        private float number1;
        private float number2;
        private string TransactionType;
        public Polimorfizm_Calc(float Number1, float Number2,string TransactionType)
        {
            Number1_ = Number1;
            Number2_ = Number2;
            TransactionType1_ = TransactionType;
        }

        public float Number1_ { get => number1; set => number1 = value; }
        public float Number2_ { get => number2; set => number2 = value; }
        public string TransactionType1_ { get => TransactionType; set => TransactionType = value; }
        public override float Calc()
        {
            switch (TransactionType.ToLower())
            {
                case "çarp":
                    return (number1 * number2);
                case "böl":
                    return (number1 / number2);
                case "topla":
                    return (number1 + number2);
                case "çıkar":
                    return (number1 - number2);
                case "cos":
                    return (float)(Math.Cos(number1 + number2));
                case "sin":
                    return (float)(Math.Sin(number1 + number2));
                case "kare":
                    return (float)(Math.Sqrt(number1+number2));
                default:
                    return 0;
            }
        }
    }
}
