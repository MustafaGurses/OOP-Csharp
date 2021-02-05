using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examples.Inheritance
{
    public class Calculator : CalculatorMethods
    {
        public Calculator(float Number1, float Number2, string TransactionType)
        {
            Number1_ = Number1;
            Number2_ = Number2;
            TransactionType1_ = TransactionType;
        }
    }
}
