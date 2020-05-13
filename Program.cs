using System;

namespace methods
{
    class Program
    {
        
        public Decimal displayValue;
        public Decimal currentValue;

        public void Add(Decimal displayValue)
        {
            currentValue += displayValue;
        }

        public void Subtract(Decimal displayValue)
        {
            currentValue -= displayValue;
        }

        public void Multiply(Decimal displayValue)
        {
            currentValue *= displayValue;
        }

        public void Divide(Decimal displayValue)
        {
            currentValue /= displayValue;
        }

        public void SquareRoot(Decimal displayValue)
        {
            currentValue = (decimal)Math.Sqrt(Convert.ToDouble(displayValue));
        }
    }
}
