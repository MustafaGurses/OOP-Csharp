using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples.Interface
{
    public class Calcs : ICalcs
    {
        private float number1;
        private float number2;
        private string TransactionType;
        public Calcs(float number1,float number2, string TransactionType)
        {
            this.number1 = number1;
            this.number2 = number2;
            this.TransactionType = TransactionType;
        }
        public float Calc()
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
                    return (float)(Math.Sqrt(number1 + number2));
                default:
                    return 0;
            }
        }
    }
}
