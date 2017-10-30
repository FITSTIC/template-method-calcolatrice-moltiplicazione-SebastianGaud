using System;

namespace CalcolatriceTemplate
{
    public class Calculator : ICalculator
    {
        protected double X { get; set; }
        protected double y { get; set; }
        protected double result;
        
        delegate void Reset();
        public bool Power { get; private set; }
        public Calculator(double x, double y)
        {
            this.X = x;
            this.y = y;
        }

        void ICalculator.WriteResult()
        {
            System.Console.WriteLine(result);
            ResetVariable();
            Power = false;
        }

        private void ResetVariable()
        {
            this.X = 0;
            this.y = 0;
        }

        public virtual void MakeCalculus(){

        }

    }
}