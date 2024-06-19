using System;

namespace Trabalhob2
{
    public class Industrialized : Product
    {
        protected static readonly double PROFIT_LOW = 1.12;
        protected static readonly double PROFIT_MID = 1.105;
        protected static readonly double PROFIT_HIGH = 1.09;

        protected static readonly double IPI = 1.05;
        protected static readonly double ICMS = 1.12;

        protected int unity;

        public Industrialized(string name, double cost, int unity) : base(name, cost)
        {
            this.unity = unity;
        }
    
        protected override double calculatePrice()
        {
            if (unity <= 50)
            {
                return (cost * PROFIT_LOW) + calculateTransport();
            }
            else if (unity <= 200)
            {
                return (cost * PROFIT_MID) + calculateTransport();
            }
            else
            {
                return (cost * PROFIT_HIGH) + calculateTransport();
            }
        }

        protected override double calculateTransport()
        {
            if (unity <= 50)
            {
                return (0.35 * unity);
            }
            else if (unity <= 200)
            {
                return (0.30 * unity);
            }
            else
            {
                return (0.25 * unity);
            }
        }

        protected double calculateFinalPrice()
        {
            return calculatePrice() * ICMS * IPI;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public int Unity
        {
            get { return unity; }
            set { unity = value; }
        }

        public override string ToString()
        {
            return $"Industrialized product: Name={name}, Cost={cost:C}, Unity={unity}, Price={calculatePrice():C}, Final Price={calculateFinalPrice():C}";
        }
    }
}
