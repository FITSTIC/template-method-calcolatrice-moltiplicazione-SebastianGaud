namespace CalcolatriceTemplate
{
    public class CalcolatriceNormale : Calculator
    {
        public CalcolatriceNormale(double x, double y) : base(x, y)
        {
        }

        public override void MakeCalculus()
        {
            this.result = X * y;
        }
    }
}